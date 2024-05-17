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
using BUS;


namespace GUI
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }
        public bool CheckType(int type)
        {
            if (type == 1)
            {
                return true;
            }
            return false;
        }
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            //SplashScreenManager.ShowForm(typeof(WaitForm1));

            Account account = new Account(txbtendangnhap.Text, txbmatkhau.Text);
            try
            {
                if (AccountBUS.Instance.CheckLogin(account))
                {
                    Log.WriteLog("----------" + account.UserName + " log in ----------");

                    Account acc = AccountBUS.Instance.GetAccountByUserName(account.UserName);
                    if (CheckType(acc.TypeID))
                    {
                        Form_ManagerAdmin form = new Form_ManagerAdmin(acc);
                        this.Hide();
                        //form.Show();
                        form.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        Form_ManagerUser form1 = new Form_ManagerUser(acc);
                        this.Hide();
                        form1.ShowDialog();
                        this.Show();
                    }
                }
                else
                {
                    //SplashScreenManager.CloseForm();
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đóng phần mềm", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void txbtendangnhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txbmatkhau.UseSystemPasswordChar = false;
            }
            else
            {
                txbmatkhau.UseSystemPasswordChar = true;
            }
        }
    }
}
