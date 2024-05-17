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
    public partial class Form_ManagerAdmin : Form
    {
        public Form_ManagerAdmin(Account loginAccount)
        {
            InitializeComponent();
            this.LoginAccount = loginAccount;
        }
        private Account loginAccount;
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value;  }
        }
        private void Form_ManagerAdmin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //groupBox1.Visible = false;
        }
        private Form CheckFormExist(Type fType)
        {
            foreach (Form f in MdiChildren)
            {
                if (f.GetType() == fType)
                    return f;
            }
            return null;
        }
        private void ptbadmin_Click(object sender, EventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(Form_ManagerAccount));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Form_ManagerAccount f = new Form_ManagerAccount(loginAccount);
                //f.MdiParent = this;
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }

        private void ptbstaff_Click(object sender, EventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(Form_Account));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Form_Account f = new Form_Account();
                f.LoginUserName = loginAccount.UserName;
                //f.MdiParent = this;
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }

        private void ptboder_Click(object sender, EventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(Form_Main));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Form_Main f = new Form_Main();
                //f.MdiParent = this;
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }

        private void ptbcategory_Click(object sender, EventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(Form_ManagerCategory));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Form_ManagerCategory f = new Form_ManagerCategory();
                //f.MdiParent = this;
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }

        private void ptbfood_Click(object sender, EventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(Form_ManagerFood));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Form_ManagerFood f = new Form_ManagerFood();
                //f.MdiParent = this;
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }

        private void ptbtable_Click(object sender, EventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(Form_ManagerTable));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Form_ManagerTable f = new Form_ManagerTable();
                //f.MdiParent = this;
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }

        private void ptbdoanhthu_Click(object sender, EventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(Form_Bill));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Form_Bill f = new Form_Bill();
                //f.MdiParent = this;
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }

        private void ptbthongke_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
