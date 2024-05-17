using BUS;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class Form_Bill : Form
    {
        public Form_Bill()//List<TempBill> tempBills, int tableid, int BillID, int discount, int totalprice, int tong)
        {
            InitializeComponent();
        }
        //private void fBill_Load(object sender, EventArgs e)
        //{
        //    DateTime today = DateTime.Now;
        //    dateTimePickerfromdate.Value = new DateTime(today.Year, today.Month, 1);
        //    dateTimePickertodate.Value = dateTimePickerfromdate.Value.AddMonths(1).AddDays(-1);
        //    //btnxoa.Enabled = false;
        //}
        void LoadListBillByDate(DateTime fromDate, DateTime toDate)
        {
            try
            {
                dgvHoaDon.DataSource = BillBUS.Instance.GetListBillByDate(fromDate, toDate);
                dgvHoaDon.Columns[0].HeaderText = "Mã hóa đơn";
                dgvHoaDon.Columns[1].HeaderText = "Tên bàn";
                dgvHoaDon.Columns[2].HeaderText = "Ngày vào";
                dgvHoaDon.Columns[3].HeaderText = "Giảm giá";
                dgvHoaDon.Columns[4].HeaderText = "Tổng tiền";
                dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvHoaDon.DefaultCellStyle.BackColor = Color.Pink;
                dgvHoaDon.DefaultCellStyle.ForeColor = Color.Black;

                // Tạo kiểu cho tiêu đề cột
                dgvHoaDon.ColumnHeadersDefaultCellStyle.BackColor = Color.DeepPink;
                dgvHoaDon.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                // Tạo kiểu cho dòng được chọn
                dgvHoaDon.DefaultCellStyle.SelectionBackColor = Color.HotPink;
                dgvHoaDon.DefaultCellStyle.SelectionForeColor = Color.White;

                // Căn giữa tiêu đề cột
                foreach (DataGridViewColumn column in dgvHoaDon.Columns)
                {
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void btntailai_Click(object sender, EventArgs e)
        {
            LoadListBillByDate((DateTime)dateTimePickerfromdate.Value, (DateTime)dateTimePickertodate.Value);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedCells.Count > 0)
            {
                int rowIndex = dgvHoaDon.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvHoaDon.Rows[rowIndex];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);

                if (MessageBox.Show("Xóa hóa đơn " + id + "?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        BillInfoBUS.Instance.DeleteBillInfoByBillID(id);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex);
                    }

                    if (BillBUS.Instance.DeleteBill(id))
                    {
                        btntailai_Click(sender, e);
                        MessageBox.Show("Xóa hóa đơn thành công", "Thông báo");
                        Log.WriteLog("delete Bill, ID = " + id);
                    }
                    else
                        MessageBox.Show("Không thể xóa hóa đơn", "Lỗi");
                }
            }
            //btnxoa.Enabled = false;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Bill_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            dateTimePickerfromdate.Value = dateTimePickertodate.Value.AddDays(-6);
            //dateTimePickertodate.Value = dateTimePickerfromdate.Value.AddMonths(1).AddDays(-1);
            dateTimePickertodate.Value = new DateTime(today.Year, today.Month, today.Day);
        }
        private void LoadListFoodByBillID(int id)
        {
            //listView1.View = View.Details;
            //listView1.Columns.Add("Món");
            //listView1.Columns.Add("Số lượng");
            //listView1.Columns.Add("Giá");
            //listView1.Columns.Add("Thành tiền");
            //listView1.Font = new Font("Arial", 12, FontStyle.Regular);
            //listView1.ForeColor = Color.Black; // Màu chữ
            //listView1.BackColor = Color.White;
            //listView1.Columns[0].Width = 150; // Cột Food có chiều rộng là 200
            //listView1.Columns[1].Width = 85;
            //listView1.Columns[2].Width = 85; // Cột Food có chiều rộng là 200
            //listView1.Columns[3].Width = 110;
            //foreach (TempBill item in tempBills)
            //{
            //    ListViewItem lsvItem = new ListViewItem(item.Food.ToString());
            //    lsvItem.SubItems.Add(item.AmountFood.ToString());
            //    lsvItem.SubItems.Add(item.Price.ToString());
            //    lsvItem.SubItems.Add(item.Total.ToString());
            //    listView1.Items.Add(lsvItem);
            //}
            //BillBUS.Instance.GetUnCheckBillIDByTableID(id);
            List<BillInfo2> billInfos = BillInfoBUS.Instance.GetListBillInfoByBillID(id);
            dgvMonAn.DataSource = billInfos;
            dgvMonAn.Columns[0].HeaderText = "Món ăn";
            dgvMonAn.Columns[1].HeaderText = "Số lượng";
            dgvMonAn.Columns[2].HeaderText = "Giá";
            dgvMonAn.Columns[3].HeaderText = "Thành tiền";
            dgvMonAn.DefaultCellStyle.BackColor = Color.Pink;
            dgvMonAn.DefaultCellStyle.ForeColor = Color.Black;

            // Tạo kiểu cho tiêu đề cột
            dgvMonAn.ColumnHeadersDefaultCellStyle.BackColor = Color.DeepPink;
            dgvMonAn.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // Tạo kiểu cho dòng được chọn
            dgvMonAn.DefaultCellStyle.SelectionBackColor = Color.HotPink;
            dgvMonAn.DefaultCellStyle.SelectionForeColor = Color.White;

            //Căn giữa tiêu đề cột
            foreach (DataGridViewColumn column in dgvMonAn.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int rowIndex = e.RowIndex;

            //// Kiểm tra nếu chỉ mục hàng hợp lệ và không phải hàng tiêu đề
            //if (rowIndex >= 0 && rowIndex < dgvHoaDon.Rows.Count - 1)
            //{
            //    // Lấy giá trị của cột "Mã hóa đơn" ở hàng được chọn
            //    int selectedBillID = Convert.ToInt32(dgvHoaDon.Rows[rowIndex].Cells[0].Value);

            //    // Gọi hàm để lấy danh sách chi tiết hóa đơn dựa trên mã hóa đơn đã chọn
            //    List<BillInfo2> billInfos = BillInfoBUS.Instance.GetListBillInfoByBillID(selectedBillID);

            //    // Cập nhật dgvMonAn với danh sách chi tiết hóa đơn mới
            //    dgvMonAn.DataSource = billInfos;
            //    dgvMonAn.Columns[0].HeaderText = "Món ăn";
            //    dgvMonAn.Columns[1].HeaderText = "Số lượng";
            //    dgvMonAn.Columns[2].HeaderText = "Giá";
            //    dgvMonAn.Columns[3].HeaderText = "Thành tiền";
            //}
        }


    }
}
