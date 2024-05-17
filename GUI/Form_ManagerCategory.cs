using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI
{
    public partial class Form_ManagerCategory : Form
    {
        string curName;

        public Form_ManagerCategory()
        {
            InitializeComponent();
            LoadFoodToDataGridView();
            AddFoodBinding();
        }
        private void LoadFoodToDataGridView()
        {

            try
            {
                dgvThucAn.DataSource = CategoryBUS.Instance.GetAllCategory();
                dgvThucAn.Columns[0].HeaderText = "Mã";
                dgvThucAn.Columns[1].HeaderText = "Tên";
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
            if (dgvThucAn.CurrentRow != null)
            {
                // Lấy thông tin của hàng được chọn
                //string id = dgvThucAn.CurrentRow.Cells["IdColumn"].Value.ToString();
                string name = dgvThucAn.CurrentRow.Cells["Name"].Value.ToString();

                // Hiển thị thông tin của hàng trong các ô textbox
                txbten.Text = name;
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int id = (int)dgvThucAn.Rows[dgvThucAn.CurrentCell.RowIndex].Cells[0].Value;
            string name = dgvThucAn.Rows[dgvThucAn.CurrentCell.RowIndex].Cells[1].Value.ToString();

            if (MessageBox.Show("Xóa " + name + "?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (CategoryBUS.Instance.DeteleCategory(id))
                {
                    LoadFoodToDataGridView();
                    MessageBox.Show("Đã xóa " + name, "Thông báo");
                    Log.WriteLog("delete Food: " + name);
                }
                else
                    MessageBox.Show("Không thể xóa danh mục hiện hành", "Lỗi");
            }
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
                MessageBox.Show("Tên danh mục không hợp lệ");
                return;
            }
            if (CategoryBUS.Instance.UpdateCategory(int.Parse(id), name))
            {
                //SplashScreenManager.ShowForm(typeof(WaitForm1));
                LoadFoodToDataGridView();
               // SplashScreenManager.CloseForm();
                Log.WriteLog("update Category: " + curName + " -> " + name);
            }
            else
                MessageBox.Show("Sửa danh mục thất bại", "Lỗi");
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
                dgvThucAn.DataSource = CategoryBUS.Instance.SearchCategoryByName(txbtimkiem.Text);
                AddFoodBinding();
                //SplashScreenManager.CloseForm();
            }
            catch (Exception ex)
            {
                //SplashScreenManager.CloseForm();
                MessageBox.Show("Error: " + ex);
            }
            AddFoodBinding();
        }
        //private void AddFood()
        //{
        //    string name = txbten.Text;
        //    if (name == "")
        //    {
        //        MessageBox.Show("Tên danh mục không hợp lệ");
        //        return;
        //    }
        //    if (CategoryBUS.Instance.InsertCategory(name))
        //    {
        //        // SplashScreenManager.ShowForm(typeof(WaitForm1));
        //        LoadFoodToDataGridView();
        //        //SplashScreenManager.CloseForm();
        //        Log.WriteLog("add new Category: " + name);
        //    }
        //    else
        //        MessageBox.Show("Thêm danh mục thất bại", "Lỗi");

        //}

        private void btnthem_Click(object sender, EventArgs e)
        {
            Form_AddCategory form_AddCategory = new Form_AddCategory();
            form_AddCategory.ShowDialog();
            LoadFoodToDataGridView();
            AddFoodBinding();
            //if (form_AddCategory.idcategory == -1)
            //    return;
            //string nameC = form_AddCategory.TextBoxTen.Text; // Lấy tên danh mục từ form_AddCategory

            //bool namecategory = false;
            //foreach (DataGridViewRow row in dgvThucAn.Rows)
            //{
            //    if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == nameC) // So sánh tên danh mục với các tên danh mục hiện có
            //    {
            //        namecategory = true;
            //        break;
            //    }
            //}

            //if (namecategory)
            //{
            //    MessageBox.Show("Tên danh mục này đã tồn tại!");
            //}
            //else
            //{
            //    if (CategoryBUS.Instance.InsertCategory(nameC))
            //    {
            //        LoadFoodToDataGridView();
            //        MessageBox.Show("Thêm danh mục mới thành công");
            //        Log.WriteLog("add new Category: " + nameC);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Thêm danh mục mới thất bại!", "Lỗi");
            //    }
            //}
            //string name = txbten.Text;
            //if (name == "")
            //{
            //    MessageBox.Show("Tên danh mục không hợp lệ");
            //    return;
            //}
            //if (CategoryBUS.Instance.InsertCategory(name))
            //{
            //    // SplashScreenManager.ShowForm(typeof(WaitForm1));
            //    LoadFoodToDataGridView();
            //    //SplashScreenManager.CloseForm();
            //    Log.WriteLog("add new Category: " + name);
            //}
            //else
            //    MessageBox.Show("Thêm danh mục thất bại", "Lỗi");
        }

        private void btntailai_Click(object sender, EventArgs e)
        {
            LoadFoodToDataGridView();
            AddFoodBinding();
        }
        void AddFoodBinding()
        {
            // Kiểm tra xem TextBox đã được binding với thuộc tính nào chưa
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
        }

        private void txbten_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvThucAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
