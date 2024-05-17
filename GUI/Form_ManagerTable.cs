using BUS;
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
    public partial class Form_ManagerTable : Form
    {
        //string curTable;
        public Form_ManagerTable()
        {
            InitializeComponent();
            LoadTable();
        }
        private void LoadTable()
        {
            try
            {
                dgvban.DataSource = TableBUS.Instance.GetAllTable();
                dgvban.Columns[0].HeaderText = "Mã số";
                dgvban.Columns[0].ReadOnly = true;
                dgvban.Columns[1].HeaderText = "Tên bàn";
                dgvban.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Tạo kiểu cho ô dữ liệu
                dgvban.DefaultCellStyle.BackColor = Color.Pink;
                dgvban.DefaultCellStyle.ForeColor = Color.Black;

                // Tạo kiểu cho tiêu đề cột
                dgvban.ColumnHeadersDefaultCellStyle.BackColor = Color.DeepPink;
                dgvban.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                // Tạo kiểu cho dòng được chọn
                dgvban.DefaultCellStyle.SelectionBackColor = Color.HotPink;
                dgvban.DefaultCellStyle.SelectionForeColor = Color.White;

                // Căn giữa tiêu đề cột
                foreach (DataGridViewColumn column in dgvban.Columns)
                {
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            //SplashScreenManager.ShowForm(typeof(WaitForm1));
            int id = (int)dgvban.Rows[dgvban.CurrentCell.RowIndex].Cells[0].Value;
            string name = dgvban.Rows[dgvban.CurrentCell.RowIndex].Cells[1].Value.ToString();

            if (MessageBox.Show("Xóa " + name + "?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (TableBUS.Instance.DeleteTable(id))
                {
                    LoadTable();
                    //SplashScreenManager.CloseForm();
                    MessageBox.Show("Đã xóa " + name, "Thông báo");
                    Log.WriteLog("delete Table, ID = " + id);
                }
                else
                {
                    //SplashScreenManager.CloseForm();
                    MessageBox.Show("Không thể xóa bàn đang có người", "Lỗi");
                }
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Form_AddTable f = new Form_AddTable();
            f.ShowDialog();
            if (f.Table == -1)
                return;
            string table = "Bàn " + f.Table;

            bool tableExists = false;
            foreach (DataGridViewRow row in dgvban.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == table)
                {
                    tableExists = true;
                    break;
                }
            }

            if (tableExists)
            {
                MessageBox.Show("Tên bàn này đã tồn tại!");
            }
            else
            {
                if (TableBUS.Instance.InsertTable(table))
                {
                    //SplashScreenManager.ShowForm(typeof(WaitForm1));
                    LoadTable();
                    //SplashScreenManager.CloseForm();
                    MessageBox.Show("Thêm bàn mới thành công");
                    int tableID = (int)dgvban.Rows[dgvban.Rows.Count - 2].Cells[0].Value;
                    Log.WriteLog("add new Table, ID = " + tableID);
                }
                else
                {
                    MessageBox.Show("Thêm bàn mới thất bại!", "Lỗi");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvban_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridView view = sender as DataGridView;
            if (e.ColumnIndex == 1) // Kiểm tra nếu là cột "Tên bàn"
            {
                string newName = e.FormattedValue.ToString();
                if (string.IsNullOrEmpty(newName))
                {
                    MessageBox.Show("Tên bàn không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    view.CancelEdit();
                    return;
                }

                // Kiểm tra trùng tên bàn
                for (int i = 0; i < view.Rows.Count - 1; i++)
                {
                    if (i != e.RowIndex) // Bỏ qua dòng hiện tại
                    {
                        string existingName = view.Rows[i].Cells[1].Value.ToString();
                        if (newName.Equals(existingName))
                        {
                            MessageBox.Show("Tên bàn này đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            view.CancelEdit();
                            return;
                        }
                    }
                }

                // Đưa mã xử lý cập nhật dữ liệu vào đây
            }
        }

        private void dgvban_CellValidating_1(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridView view = sender as DataGridView;
            if (e.ColumnIndex == 1) // Kiểm tra nếu là cột "Tên bàn"
            {
                string newName = e.FormattedValue.ToString();
                if (string.IsNullOrEmpty(newName))
                {
                    MessageBox.Show("Tên bàn không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    view.CancelEdit();
                    return;
                }

                // Kiểm tra trùng tên bàn
                for (int i = 0; i < view.Rows.Count - 1; i++)
                {
                    if (i != e.RowIndex) // Bỏ qua dòng hiện tại
                    {
                        string existingName = view.Rows[i].Cells[1].Value.ToString();
                        if (newName.Equals(existingName))
                        {
                            MessageBox.Show("Tên bàn này đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            view.CancelEdit();
                            return;
                        }
                    }
                }

                // Đưa mã xử lý cập nhật dữ liệu vào đây
            }
        }
    }
}
