using BUS;
using DTO;
using System;
using System.Drawing;
using System.Security.Principal;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form_Account : Form
    {
        private string loginUserName;
        Account Account1;
        
        public string LoginUserName
        {
            get { return loginUserName; }
            set { loginUserName = value; }
        }

        public Form_Account()
        {
            InitializeComponent();
            LoadDanhSachNhanVien();
            //comboBoxtaikhoan.DataSource = AccountTypeBUS.Instance.GetAllAccountType();
            AddFoodBinding();
        }
        void LoadDanhSachNhanVien()
        {
            dgvAccount.DataSource = AccountBUS.Instance.GetAllAcount();
            dgvAccount.Columns[0].HeaderText = "Tên đăng nhập";
            dgvAccount.Columns[1].HeaderText = "Tên hiện thị";
            dgvAccount.Columns[2].HeaderText = "Mã loại tài khoản";
            dgvAccount.Columns[3].HeaderText = "Mật khẩu";
            dgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn column in dgvAccount.Columns)
            {
                column.FillWeight = 1;
            }
            // Tạo kiểu cho ô dữ liệu
            dgvAccount.DefaultCellStyle.BackColor = Color.Pink;
            dgvAccount.DefaultCellStyle.ForeColor = Color.Black;

            // Tạo kiểu cho tiêu đề cột
            dgvAccount.ColumnHeadersDefaultCellStyle.BackColor = Color.DeepPink;
            dgvAccount.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // Tạo kiểu cho dòng được chọn
            dgvAccount.DefaultCellStyle.SelectionBackColor = Color.HotPink;
            dgvAccount.DefaultCellStyle.SelectionForeColor = Color.White;

            // Căn giữa tiêu đề cột
            foreach (DataGridViewColumn column in dgvAccount.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        void AddFoodBinding()
        {
            if (txbtendangnhap.DataBindings.Count == 0)
            {
                // Nếu chưa có binding, thêm binding mới cho TextBox tên danh mục
                txbtendangnhap.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "UserName"));
            }
            else
            {
                // Nếu đã có binding, xóa binding cũ và thêm binding mới
                txbtendangnhap.DataBindings.Clear();
                txbtendangnhap.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "UserName"));
            }

            // Tương tự, kiểm tra và thêm binding cho TextBox mã danh mục (ID)
            if (txbtenhienthi.DataBindings.Count == 0)
            {
                txbtenhienthi.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "DisplayName"));
            }
            else
            {
                txbtenhienthi.DataBindings.Clear();
                txbtenhienthi.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "DisplayName"));
            }
            //dgvAccount.DataSourceChanged += (s, e) =>
            {
                comboBoxtaikhoan.DataSource = AccountTypeBUS.Instance.GetAllAccountType();
                comboBoxtaikhoan.DisplayMember = "TypeName";
                //comboBoxtaikhoan.ValueMember = "ID";
                comboBoxtaikhoan.DataBindings.Clear();
                comboBoxtaikhoan.DataBindings.Add("Text", dgvAccount.DataSource, "TypeID");
               // dgvAccount.SelectionChanged += dgvAccount_SelectionChanged;
            };
            
        }
        private bool CheckCharacter(string str)
        {
            string correctString = "1234567890 QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm";
            foreach (char character1 in str)
            {
                bool isCorrect = false;
                foreach (char character2 in correctString)
                {
                    if (character1 == character2)
                        isCorrect = true;
                }
                if (isCorrect == false)
                    return false;
            }
            return true;
        }


        private void dgvAccount_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;
            if (dataGridView.CurrentRow == null)
                return;

            int rowIndex = dataGridView.CurrentRow.Index;
            DataGridViewCellCollection cells = dataGridView.Rows[rowIndex].Cells;

            if (cells[2].Value == null || cells[2].Value == DBNull.Value)
                return;

            int accountType;
            if (int.TryParse(cells[2].Value.ToString(), out accountType))
            {
                for (int i = 0; i < comboBoxtaikhoan.Items.Count; i++)
                {
                    if (comboBoxtaikhoan.Items[i] is AccountType accountType1 && accountType1.ID == accountType)
                    {
                        comboBoxtaikhoan.SelectedIndex = i;
                        break;
                    }
                }
            }

            // Initialize curFood object                                   
            string tendangnhap = cells[0].Value?.ToString() ?? "";
            string tenhienthi = cells[1].Value?.ToString() ?? "";
            Account1 = new Account(tendangnhap, tenhienthi, accountType);
        }

        //private void comboBoxtaikhoan_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    //comboBoxtaikhoan.DataSource = AccountTypeBUS.Instance.GetAllAccountType();
        //}

        ////private void btnsua_Click(object sender, EventArgs e)
        ////{
        ////    string userName = txbtendangnhap.Text;
        ////    if (MessageBox.Show("Đặt lại mật khẩu cho tài khoản " + userName + "?", "Xác nhận", MessageBoxButtons.YesNo)
        ////        == DialogResult.Yes)
        ////    {
        ////        if (AccountBUS.Instance.ResetPassword(userName))
        ////        {
        ////            LoadDanhSachNhanVien();
        ////            MessageBox.Show("Đặt lại mật khẩu thành công\n Mật khẩu mặc định là '0'");
        ////            Log.WriteLog("set password for Account: " + userName);
        ////        }
        ////        else
        ////            MessageBox.Show("Đặt lại mật khẩu thất bại", "Lỗi");

        ////    }
        ////    AddFoodBinding();
        ////}

        //private void btnxoa_Click(object sender, EventArgs e)
        //{
        //    string userName = txbtendangnhap.Text;
        //    if (loginUserName.Equals(userName))
        //    {
        //        MessageBox.Show("Không thể xóa tài khoản hiện hành!!!");
        //        return;
        //    }

        //    if (MessageBox.Show("Xóa " + userName + "?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
        //    {
        //        if (AccountBUS.Instance.Delete(userName))
        //        {
        //            LoadDanhSachNhanVien();
        //            MessageBox.Show("Xóa tài khoản thành công");
        //            Log.WriteLog("delete Account: " + userName);
        //        }
        //        else
        //            MessageBox.Show("Xóa tài khoản thất bại", "Lỗi");
        //    }
        //    AddFoodBinding();
        //}
        //private void txbtimkiem_TextChanged(object sender, EventArgs e)
        //{
        //    if (txbtimkiem.Text != "") { }
        //        //btnSearch.Enabled = true;
        //    else { }
        //        //btnSearch.Enabled = false;
        //}

        //private void btntimkiem_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        //SplashScreenManager.ShowForm(typeof(WaitForm1));
        //        dgvAccount.DataSource = AccountBUS.Instance.SearchAccountByUserName(txbtimkiem.Text);
        //        //SplashScreenManager.CloseForm();
        //    }
        //    catch (Exception ex)
        //    {
        //       // SplashScreenManager.CloseForm();
        //        MessageBox.Show("Error: " + ex);
        //    }
        //    AddFoodBinding();
        //}

        //private void btntailai_Click(object sender, EventArgs e)
        //{
        //    txbtendangnhap.Text = "";
        //    txbtenhienthi.Text = "";
        //    comboBoxtaikhoan.Text = "";
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txbtimkiem.Text != "") { }
            //btnSearch.Enabled = true;
            else { }
            //btnSearch.Enabled = false;
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            string userName = txbtendangnhap.Text.Trim();
            if (string.IsNullOrWhiteSpace(userName) || CheckCharacter(userName) == false)
            {
                MessageBox.Show("Tên tài khoản không hợp lệ");
                return;
            }

            // Kiểm tra xem tên tài khoản đã tồn tại chưa
            bool isUserNameExist = AccountBUS.Instance.CheckUserNameExists(userName);
            if (isUserNameExist)
            {
                MessageBox.Show("Tên tài khoản này đã được sử dụng!");
                return;
            }

            string displayName = txbtenhienthi.Text.Trim();
            if (string.IsNullOrWhiteSpace(displayName))
            {
                MessageBox.Show("Tên hiển thị không hợp lệ");
                return;
            }
            string accoutType = comboBoxtaikhoan.Text;
            int account = int.Parse(accoutType);
            if (account == -1)
            {
                MessageBox.Show("Hãy chọn loại tài khoản");
                return;
            }

            if (AccountBUS.Instance.Insert(userName, displayName, account))
            {
                LoadDanhSachNhanVien();
                MessageBox.Show("Thêm tài khoản mới thành công\nMật khẩu mặc định là '0'\nHãy đổi mật khẩu để bảo mật tài khoản", "Thông báo");
                Log.WriteLog("add new Account: " + userName);
            }
            else
            {
                MessageBox.Show("Thêm tài khoản mới thất bại", "Lỗi");
            }
            AddFoodBinding();
        }

        private void tbnsua_Click(object sender, EventArgs e)
        {
            string userName = txbtendangnhap.Text;
            if (MessageBox.Show("Đặt lại mật khẩu cho tài khoản " + userName + "?", "Xác nhận", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                if (AccountBUS.Instance.ResetPassword(userName))
                {
                    LoadDanhSachNhanVien();
                    MessageBox.Show("Đặt lại mật khẩu thành công\n Mật khẩu mặc định là '0'");
                    Log.WriteLog("set password for Account: " + userName);
                }
                else
                    MessageBox.Show("Đặt lại mật khẩu thất bại", "Lỗi");

            }
            AddFoodBinding();
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            string userName = txbtendangnhap.Text;
            if (loginUserName.Equals(userName))
            {
                MessageBox.Show("Không thể xóa tài khoản hiện hành!!!");
                return;
            }

            if (MessageBox.Show("Xóa " + userName + "?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (AccountBUS.Instance.Delete(userName))
                {
                    LoadDanhSachNhanVien();
                    MessageBox.Show("Xóa tài khoản thành công");
                    Log.WriteLog("delete Account: " + userName);
                }
                else
                    MessageBox.Show("Xóa tài khoản thất bại", "Lỗi");
            }
            AddFoodBinding();
        }

        private void btntimkiem_Click_1(object sender, EventArgs e)
        {
            try
            {
                //SplashScreenManager.ShowForm(typeof(WaitForm1));
                dgvAccount.DataSource = AccountBUS.Instance.SearchAccountByUserName(txbtimkiem.Text);
                //SplashScreenManager.CloseForm();
            }
            catch (Exception ex)
            {
                // SplashScreenManager.CloseForm();
                MessageBox.Show("Error: " + ex);
            }
            AddFoodBinding();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txbtendangnhap.Text = "";
            txbtenhienthi.Text = "";
            comboBoxtaikhoan.Text = "";
        }

        private void dgvAccount_SelectionChanged_1(object sender, EventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;
            if (dataGridView.CurrentRow == null)
                return;

            int rowIndex = dataGridView.CurrentRow.Index;
            DataGridViewCellCollection cells = dataGridView.Rows[rowIndex].Cells;

            if (cells[2].Value == null || cells[2].Value == DBNull.Value)
                return;

            int accountType;
            if (int.TryParse(cells[2].Value.ToString(), out accountType))
            {
                for (int i = 0; i < comboBoxtaikhoan.Items.Count; i++)
                {
                    if (comboBoxtaikhoan.Items[i] is AccountType accountType1 && accountType1.ID == accountType)
                    {
                        comboBoxtaikhoan.SelectedIndex = i;
                        break;
                    }
                }
            }

            // Initialize curFood object                                   
            string tendangnhap = cells[0].Value?.ToString() ?? "";
            string tenhienthi = cells[1].Value?.ToString() ?? "";
            Account1 = new Account(tendangnhap, tenhienthi, accountType);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
