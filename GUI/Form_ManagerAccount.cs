using BUS;
using DTO;
using RestaurantManagementSystem;
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
    public partial class Form_ManagerAccount : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }
        void ChangeAccount(Account acc)
        {
            txbtendangnhap.Text = acc.UserName;
            txbtenhienthi.Text = acc.DisplayName;
        }
        public Form_ManagerAccount(Account acc)
        {
           // this.IsMdiContainer = true;
            InitializeComponent();
            LoginAccount = acc;
        }
        private void UpdateAccount()
        {
            string displayName = txbtenhienthi.Text;
            string password = txbmatkhau.Text;
            string newPass = txbmatkhaumoi.Text;
            string retypePass = txbnhaplaimk.Text;
            string userName = txbtendangnhap.Text;
            string newpass2 = Passwordhash.HashPassword(newPass);
            if (!string.Equals(newPass.Trim(), retypePass.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Mật khẩu nhập lại không đúng");
            }
            else
            {
                // SplashScreenManager.ShowForm(typeof(WaitForm1));
                if (AccountBUS.Instance.UpdateInformation(userName, displayName, password, newpass2))
                {
                    // SplashScreenManager.CloseForm();
                    MessageBox.Show("Cập nhật thành công");
                    Log.WriteLog("change account's information");
                }
                else
                {
                    // SplashScreenManager.CloseForm();
                    MessageBox.Show("Vui lòng điền đúng mật khẩu");
                }
            }
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            UpdateAccount();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbmatkhaumoi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
