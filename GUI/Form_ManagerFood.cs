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

namespace GUI
{
    public partial class Form_ManagerFood : Form
    {
        Food curFood;
        public Form_ManagerFood()
        {
            //SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            //btnRemove.Enabled = false;
            //btnSearch.Enabled = false;
            LoadFoodToDataGridView();
            LoadNameCategory(comboBoxdanhmuc);
            AddFoodBinding();
            //SplashScreenManager.CloseForm();
        }
        private void LoadFoodToDataGridView()
        {

            try
            {
                dgvThucAn.DataSource = FoodBUS.Instance.GetAllFood();
                dgvThucAn.Columns[0].HeaderText = "Mã";
                dgvThucAn.Columns[1].HeaderText = "Tên";
                dgvThucAn.Columns[2].HeaderText = "Mã danh mục";
                dgvThucAn.Columns[3].HeaderText = "Đơn giá";
                dgvThucAn.Columns[0].ReadOnly = true;
                // dgvThucAn.Columns[2].DataPropertyName = "CategoryName";
                dgvThucAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Tạo kiểu cho ô dữ liệu
                dgvThucAn.DefaultCellStyle.BackColor = Color.Pink;
                dgvThucAn.DefaultCellStyle.ForeColor = Color.Black;

                // Tạo kiểu cho tiêu đề cột
                dgvThucAn.ColumnHeadersDefaultCellStyle.BackColor = Color.DeepPink;
                dgvThucAn.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                // Tạo kiểu cho dòng được chọn
                dgvThucAn.DefaultCellStyle.SelectionBackColor = Color.HotPink;
                dgvThucAn.DefaultCellStyle.SelectionForeColor = Color.White;

                // Căn giữa tiêu đề cột
                foreach (DataGridViewColumn column in dgvThucAn.Columns)
                {
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void dgvThucAn_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;

            if (dataGridView.CurrentRow == null)
                return;

            int rowIndex = dataGridView.CurrentRow.Index;

            DataGridViewCellCollection cells = dataGridView.Rows[rowIndex].Cells;

            object categoryID = cells[2].Value;
            if (categoryID == null || categoryID == DBNull.Value)
                return;

            int selectedIndex = -1;
            for (int i = 0; i < comboBoxdanhmuc.Items.Count; i++)
            {
                if (comboBoxdanhmuc.Items[i] is Category)
                {
                    Category category = comboBoxdanhmuc.Items[i] as Category;
                    if (category.ID == (int)categoryID)
                    {
                        selectedIndex = i;
                        break;
                    }
                }
            }

            if (selectedIndex != -1)
            {
                comboBoxdanhmuc.SelectedIndex = selectedIndex;
            }

            // Initialize curFood object
            int foodID = (int)dataGridView.Rows[rowIndex].Cells[0].Value;
            string foodName = dataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            int foodCategoryID = (int)dataGridView.Rows[rowIndex].Cells[2].Value;
            int foodPrice = (int)dataGridView.Rows[rowIndex].Cells[3].Value;

            curFood = new Food(foodID, foodName, foodCategoryID, foodPrice);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int id = (int)dgvThucAn.Rows[dgvThucAn.CurrentCell.RowIndex].Cells[0].Value;
            string name = dgvThucAn.Rows[dgvThucAn.CurrentCell.RowIndex].Cells[1].Value.ToString();

            if (MessageBox.Show("Xóa " + name + "?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (FoodBUS.Instance.DeleteFood(id))
                {
                    LoadFoodToDataGridView();
                    MessageBox.Show("Đã xóa " + name, "Thông báo");
                    Log.WriteLog("delete Food: " + name);
                }
                else
                    MessageBox.Show("Không thể xóa món hiện hành", "Lỗi");
            }
            AddFoodBinding();

        }

        private void txbtimkiem_TextChanged(object sender, EventArgs e)
        {
            if (txbtimkiem.Text != "")
                btntimkiem.Enabled = true;
            else
                btntimkiem.Enabled = false;
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                // SplashScreenManager.ShowForm(typeof(WaitForm1));
                dgvThucAn.DataSource = FoodBUS.Instance.SearchFoodByName(txbtimkiem.Text);
                //SplashScreenManager.CloseForm();
            }
            catch (Exception ex)
            {
                //SplashScreenManager.CloseForm();
                MessageBox.Show("Error: " + ex);
            }
            AddFoodBinding();
        }
        private void AddFood()
        {
            string name = txbten.Text;
            if (name == "")
            {
                MessageBox.Show("Tên món không hợp lệ");
                return;
            }
            string categoryID = comboBoxdanhmuc.Text;
            if (categoryID == "")
            {
                MessageBox.Show("Hãy chọn danh mục");
                return;
            }
            string priceTemp = txbgia.Text;
            if (priceTemp == "")
            {
                MessageBox.Show("Đơn giá không được bỏ trống");
                return;
            }
            int price = int.Parse(priceTemp);
            if (price <= 0 || price > 10000000)
            {
                MessageBox.Show("Đơn giá không hợp lệ");
                return;
            }

            Food newFood = new Food(name, int.Parse(categoryID), price);
            if (FoodBUS.Instance.InsertFood(newFood))
            {
                //SplashScreenManager.ShowForm(typeof(WaitForm1));
                LoadFoodToDataGridView();
                //SplashScreenManager.CloseForm();
                Log.WriteLog("add new Food: " + name);
                MessageBox.Show("Thêm món " + name + "thành công");
            }
            else
            {
                //SplashScreenManager.CloseForm();
                MessageBox.Show("Thêm món mới thất bại", "Lỗi");
            }

        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            Form_AddFood form_AddFood = new Form_AddFood();
            form_AddFood.ShowDialog();
            LoadFoodToDataGridView();
            AddFoodBinding();
            
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string id = txbma.Text;
            if (id == "") // id = "" when data is not inserted into database
            {
                //AddFood();
                LoadFoodToDataGridView();
                return;
            }

            string name = txbten.Text;
            if (name == "")
            {
                MessageBox.Show("Tên món không hợp lệ");
                return;
            }

            string categoryname = comboBoxdanhmuc.Text;
            if (categoryname == "")
            {
                MessageBox.Show("Hãy chọn danh mục");
                return;
            }
            string priceTemp = txbgia.Text;
            if (priceTemp == "")
            {
                MessageBox.Show("Đơn giá không được bỏ trống");
                return;
            }
            int price = int.Parse(priceTemp);
            if (price <= 0 || price > 10000000)
            {
                MessageBox.Show("Đơn giá không hợp lệ");
                return;
            }
            int categoryID = CategoryBUS.Instance.GetCategoryIdByName(categoryname);
            if (categoryID == -1)
            {
                MessageBox.Show("Không tìm thấy danh mục");
                return;
            }
            string idfood = txbma.Text;
            Food newFood = new Food(int.Parse(idfood), name, categoryID, price);
            if (FoodBUS.Instance.UpdateFood(newFood))
            {
                LoadFoodToDataGridView();
                // SplashScreenManager.CloseForm();
                Log.WriteLog("update Food: Name: " + curFood.Name + " -> " + name
                              + ", Category ID: " + curFood.CategoryID + " -> " + categoryID
                              + ", Price: " + curFood.Price + " -> " + price);
            }
            else
            {
                //SplashScreenManager.CloseForm();
                MessageBox.Show("Sửa thông tin món thất bại\n Không thể thay đổi thông tin món hiện hành", "Lỗi");
            }
            AddFoodBinding();
        }
        void AddFoodBinding()
        {
            if (txbten.DataBindings.Count == 0)
            {
                // Nếu chưa có binding, thêm binding mới cho TextBox tên danh mục
                txbten.DataBindings.Add(new Binding("Text", dgvThucAn.DataSource, "Name"));
            }
            else
            {
                // Nếu đã có binding, xóa binding cũ và thêm binding mới
                txbten.DataBindings.Clear();
                txbten.DataBindings.Add(new Binding("Text", dgvThucAn.DataSource, "Name"));
            }

            // Tương tự, kiểm tra và thêm binding cho TextBox mã danh mục (ID)
            if (txbma.DataBindings.Count == 0)
            {
                txbma.DataBindings.Add(new Binding("Text", dgvThucAn.DataSource, "ID"));
            }
            else
            {
                txbma.DataBindings.Clear();
                txbma.DataBindings.Add(new Binding("Text", dgvThucAn.DataSource, "ID"));
            }
            if (txbgia.DataBindings.Count == 0)
            {
                txbgia.DataBindings.Add(new Binding("Text", dgvThucAn.DataSource, "Price"));
            }
            else
            {
                txbgia.DataBindings.Clear();
                txbgia.DataBindings.Add(new Binding("Text", dgvThucAn.DataSource, "Price"));

            }
            comboBoxdanhmuc.DataSource = CategoryBUS.Instance.GetAllCategory();
            comboBoxdanhmuc.DisplayMember = "Name";
            comboBoxdanhmuc.ValueMember = "ID";
            // Bind SelectedValue của ComboBox với CategoryID của dòng được chọn trong DataGridView
            comboBoxdanhmuc.DataBindings.Clear();
            comboBoxdanhmuc.DataBindings.Add("SelectedValue", dgvThucAn.DataSource, "CategoryID");
        }
        void LoadNameCategory(ComboBox cb)
        {
            cb.DataSource = CategoryBUS.Instance.GetAllCategory();
            cb.DisplayMember = "Name";
        }

        private void txbma_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvThucAn.SelectedCells.Count > 0)
                {
                    int id = (int)dgvThucAn.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;

                    Category cateogory = CategoryDAO.Instance.GetCategoryByID(id);

                    comboBoxdanhmuc.SelectedItem = cateogory;

                    int index = -1;
                    int i = 0;
                    foreach (Category item in comboBoxdanhmuc.Items)
                    {
                        if (item.ID == cateogory.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }

                    comboBoxdanhmuc.SelectedIndex = index;
                }
            }
            catch { }

        }

        private void btntailai_Click(object sender, EventArgs e)
        {
            LoadFoodToDataGridView();
            AddFoodBinding();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //private void dgvThucAn_Resize(object sender, EventArgs e)
        //{
        //    dgvThucAn.Size = new Size(this.ClientSize.Width - dgvThucAn.Location.X * 2, this.ClientSize.Height - dgvThucAn.Location.Y * 2);
        //}

        //private void dgvThucAn_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        //{
        //    DataGridView dataGridView = sender as DataGridView;

        //    if (dataGridView.Rows[e.RowIndex].IsNewRow)
        //        AddFood(dataGridView, e.RowIndex);
        //    else
        //        UpdateFood(dataGridView, e.RowIndex);
        //}
        //private void AddFood(DataGridView dataGridView, int rowIndex)
        //{
        //    string name = dataGridView.Rows[rowIndex].Cells[1].Value?.ToString();
        //    if (string.IsNullOrEmpty(name))
        //    {
        //        MessageBox.Show("Tên món không hợp lệ");
        //        return;
        //    }

        //    string categoryID = dataGridView.Rows[rowIndex].Cells[2].Value?.ToString();
        //    if (string.IsNullOrEmpty(categoryID))
        //    {
        //        MessageBox.Show("Hãy chọn danh mục");
        //        return;
        //    }

        //    string priceTemp = dataGridView.Rows[rowIndex].Cells[3].Value?.ToString();
        //    if (string.IsNullOrEmpty(priceTemp))
        //    {
        //        MessageBox.Show("Đơn giá không được bỏ trống");
        //        return;
        //    }
        //    if (!int.TryParse(priceTemp, out int price) || price <= 0 || price > 10000000)
        //    {
        //        MessageBox.Show("Đơn giá không hợp lệ");
        //        return;
        //    }

        //    Food newFood = new Food(name, int.Parse(categoryID), price);
        //    if (FoodBUS.Instance.InsertFood(newFood))
        //    {
        //        // SplashScreenManager.ShowForm(typeof(WaitForm1));
        //        LoadFoodToDataGridView();
        //        //SplashScreenManager.CloseForm();
        //        Log.WriteLog("add new Food: " + name);
        //    }
        //    else
        //    {
        //        //SplashScreenManager.CloseForm();
        //        MessageBox.Show("Thêm món mới thất bại", "Lỗi");
        //    }

        //}
        //private void UpdateFood(DataGridView dataGridView, int rowIndex)
        //{
        //    string id = dataGridView.Rows[rowIndex].Cells[0].Value?.ToString();
        //    if (string.IsNullOrEmpty(id)) // id = null when data is not inserted into database
        //    {
        //        AddFood(dataGridView, rowIndex);
        //        return;
        //    }

        //    string name = dataGridView.Rows[rowIndex].Cells[1].Value?.ToString();
        //    if (string.IsNullOrEmpty(name))
        //    {
        //        MessageBox.Show("Tên món không hợp lệ");
        //        return;
        //    }

        //    string categoryID = dataGridView.Rows[rowIndex].Cells[2].Value?.ToString();
        //    if (string.IsNullOrEmpty(categoryID))
        //    {
        //        MessageBox.Show("Hãy chọn danh mục");
        //        return;
        //    }

        //    string priceTemp = dataGridView.Rows[rowIndex].Cells[3].Value?.ToString();
        //    if (string.IsNullOrEmpty(priceTemp))
        //    {
        //        MessageBox.Show("Đơn giá không được bỏ trống");
        //        return;
        //    }
        //    if (!int.TryParse(priceTemp, out int price) || price <= 0 || price > 1000000)
        //    {
        //        MessageBox.Show("Đơn giá không hợp lệ");
        //        return;
        //    }

        //    // SplashScreenManager.ShowForm(typeof(WaitForm1));
        //    Food food = new Food(int.Parse(id), name, int.Parse(categoryID), price);
        //    if (FoodBUS.Instance.UpdateFood(food))
        //    {
        //        LoadFoodToDataGridView();
        //        //SplashScreenManager.CloseForm();
        //        Log.WriteLog("update Food: Name: " + curFood.Name + " -> " + name
        //                      + ", Category ID: " + curFood.CategoryID + " -> " + categoryID
        //                      + ", Price: " + curFood.Price + " -> " + price);
        //    }
        //    else
        //    {
        //       // SplashScreenManager.CloseForm();
        //        MessageBox.Show("Sửa thông tin món thất bại\n Không thể thay đổi thông tin món hiện hành", "Lỗi");
        //    }
        //}


    }
}
