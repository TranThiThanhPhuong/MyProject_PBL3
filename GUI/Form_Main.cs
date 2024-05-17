using BUS;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class Form_Main : Form
    {
        private Button currentClickButton = new Button();
        public Form_Main()
        {
            InitializeComponent();
            currentClickButton = null;
            LoadTable();
            LoadCategory();
            LoadLookUpEditTable();
        }
        private void UpdateTableStatus(List<Table> tableList)
        {
            foreach (Table table in tableList)
            {
                // Kiểm tra xem bàn có mặt hàng nào không
                bool hasItems = CheckTableHasItems(table.ID); // Hàm CheckTableHasItems là hàm kiểm tra bàn có mặt hàng không

                // Cập nhật trạng thái của bàn
                table.Status = hasItems ? "Có người" : "Trống";
            }
        }

        // Hàm kiểm tra bàn có mặt hàng không
        private bool CheckTableHasItems(int tableID)
        {
            int billID = BillBUS.Instance.GetUnCheckBillIDByTableID(tableID);
            return billID != -1;
        }

        private void LoadTable()
        {
            flpBan.Controls.Clear();
            List<Table> tableList = TableBUS.Instance.GetTableList();

            foreach (Table item in tableList)
            {
                Button button = new Button() { Width = 95, Height = 95 };
                button.Text = item.Name + "\n" + item.Status;
                button.Click += btn_Click;
                button.Tag = item;
                // button.ImageList = imageList;

                switch (item.Status)
                {
                    case "Có người":
                        // button.ImageIndex = 0;
                        button.BackColor = Color.Pink;
                        break;
                    default:
                        button.BackColor = Color.DeepPink;
                        break;
                }
                flpBan.Controls.Add(button);
            }
            UpdateTableStatus(tableList);

        }
          void btn_Click(object sender, EventArgs e)
          {
            //Button clickedButton = sender as Button;
            //if (clickedButton != null && clickedButton.Tag != null && clickedButton.Tag is Table)
            //{
            //    Table table = clickedButton.Tag as Table;
            //    int tableID = table.ID;
            //    listViewHoaDon.Tag = clickedButton.Tag;
            //    ShowBill(tableID);
            //}
            int tableID = ((sender as Button).Tag as Table).ID;
            listViewHoaDon.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }
        private void comboBoxDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = comboBoxDanhMuc.SelectedItem as DataRowView;
            if (selectedRow != null)
            {
                int categoryId = Convert.ToInt32(selectedRow["ID"]); // Giả sử ID là tên cột chứa ID của danh mục
                DataTable foodData = FoodBUS.Instance.GetListFoodByCategoryID(categoryId);

                if (foodData.Rows.Count > 0)
                {
                    comboBoxMatHang.DataSource = foodData;
                    comboBoxMatHang.DisplayMember = "Name";
                }
                else
                {
                    comboBoxMatHang.DataSource = null; // Xóa dữ liệu hiện có
                }
                GetListFoodByCategory(categoryId);
            }
        }
        private void LoadCategory()
        {
            comboBoxDanhMuc.DataSource = CategoryBUS.Instance.GetAllCategory();
            comboBoxDanhMuc.DisplayMember = "Name";
            //comboBoxDanhMuc.ValueMember = "ID";
        }

        private void LoadLookUpEditTable()
        {
            comboBoxchuyenban.DataSource = TableBUS.Instance.GetTableList();
            comboBoxchuyenban.DisplayMember = "Name";
           // comboBoxchuyenban.ValueMember = "ID";
        }

        private void GetListFoodByCategory(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            comboBoxMatHang.DataSource = listFood;
            comboBoxMatHang.DisplayMember = "Name";
        }
        private void ShowBill(int tableID)
        {
            listViewHoaDon.Items.Clear();
            List<TempBill> listTempBill = new List<TempBill>();
            try
            {
                listTempBill = TempBillBUS.Instance.GetListTempBillByTableID(tableID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            int totalPrice = 0;
            foreach (TempBill item in listTempBill)
            {
                ListViewItem lsvItem = new ListViewItem(item.Food.ToString());
                lsvItem.SubItems.Add(item.AmountFood.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.Total.ToString());

                totalPrice += item.Total;
                listViewHoaDon.Items.Add(lsvItem);
            }

            CultureInfo culture = new CultureInfo("vi-VN");
            // Thread.CurrentThread.CurrentCulture = culture;
            texboxtien.Text = totalPrice.ToString("c", culture);
        }
        private void comboBoxMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Food selectedFood = comboBoxMatHang.SelectedItem as Food;
            //if (selectedFood != null)
            //{
            //    int foodID = selectedFood.ID;
            //    string foodName = selectedFood.Name;
            //    MessageBox.Show($"Mã món hàng: {foodID}, Tên món hàng: {foodName}");
            //}
            //else
            //{
            //    MessageBox.Show("Không lấy được dữ liệu từ combobox");
            //}
        }
        private void btnthemmon_Click(object sender, EventArgs e)
        {
            Table table = listViewHoaDon.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn");
                return;
            }

            if (numericUpDownsoluongmon.Value == 0)
            {
                MessageBox.Show("Hãy chọn số lượng món");
                return;
            }
            int amount = (int)numericUpDownsoluongmon.Value;
            Food selectedFood = comboBoxMatHang.SelectedItem as Food;

            // Kiểm tra xem đã lấy được đối tượng Food hay không
            if (selectedFood == null)
            {
                MessageBox.Show("Hãy chọn món");
                return;
            }

            // Lấy ID của món hàng được chọn
            int foodID = selectedFood.ID;
            int billID = BillBUS.Instance.GetUnCheckBillIDByTableID(table.ID);
            try
            {
                if (billID == -1)
                {
                    BillBUS.Instance.InsertBill(table.ID);
                    BillInfoBUS.Instance.InsertBillInfo(BillBUS.Instance.GetMaxBillID(), foodID, amount);
                }
                else
                {
                    BillInfoBUS.Instance.InsertBillInfo(billID, foodID, amount);
                }

                // Hiển thị hóa đơn và cập nhật lại giao diện
                ShowBill(table.ID);
                LoadTable();
                LoadLookUpEditTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnchuyenban_Click(object sender, EventArgs e)
        {
            Table currentTable = listViewHoaDon.Tag as Table;
            if (currentTable == null)
            {
                MessageBox.Show("Vui lòng chọn bàn cần chuyển.");
                return;
            }

            if (comboBoxchuyenban.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn bàn muốn chuyển đến.");
                return;
            }

            Table targetTable = comboBoxchuyenban.SelectedItem as Table;
            int currentTableID = currentTable.ID;
            int targetTableID = targetTable.ID;

            DialogResult result = MessageBox.Show($"Bạn có thật sự muốn chuyển {currentTable.Name} sang {targetTable.Name}?",
                                                  "Xác nhận chuyển bàn", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                try
                {
                    Log.WriteLog($"Chuyển {currentTable.Name} sang {targetTable.Name}");
                    TableBUS.Instance.SwitchTable(currentTableID, targetTableID);
                    LoadTable();
                    LoadLookUpEditTable();
                    foreach (Button button in flpBan.Controls)
                    {
                        if ((button.Tag as Table).ID == targetTableID)
                        {
                            listViewHoaDon.Tag = button.Tag;
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi chuyển bàn: {ex.Message}");
                }
            }
        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            Table table = listViewHoaDon.Tag as Table;
            if (table == null)
                return;

            int billID = -1;
            try
            {
                billID = BillBUS.Instance.GetUnCheckBillIDByTableID(table.ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

            int discount = (int)numericUpDowngiamgia.Value;
            double totalPrice = Convert.ToDouble(texboxtien.Text.Split(',')[0]) * 1000;
            double finalPrice = totalPrice - (totalPrice / 100) * discount;
            int amount = (int)numericUpDownsoluongmon.Value;
            
            if (billID != -1)
            {
                if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho {0}?", table.Name),
                    "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    // Print bill
                    List<TempBill> lstTempBill = new List<TempBill>();

                    try
                    {
                        lstTempBill = TempBillBUS.Instance.GetListTempBillByTableID(table.ID);
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex);
                    }
                    BillBUS.Instance.CheckOut(billID, discount, (int)finalPrice);
                    ShowBill(table.ID);
                    LoadTable();
                    LoadLookUpEditTable();

                    Log.WriteLog("check new Bill, ID = " + billID + ", Total price = " + finalPrice);
                    //Form_HoaDon form_HoaDon = new Form_HoaDon(table.ID,billID, discount, (int)finalPrice);
                    Form_HoaDon form_HoaDon = new Form_HoaDon(lstTempBill, table.ID,billID, discount, (int)finalPrice, (int)totalPrice);
                    form_HoaDon.billID = billID;
                    form_HoaDon.discount = discount;
                    form_HoaDon.totalprice = (int)finalPrice;
                    form_HoaDon.tableID = table.ID;
                    form_HoaDon.tong = (int)totalPrice;
                    this.Hide();
                    form_HoaDon.ShowDialog();
                    this.Show();
                }

            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
