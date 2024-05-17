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
    public partial class Form_ManagerUser : Form
    {
        public Form_ManagerUser(Account loginAccount)
        {
            InitializeComponent();
            this.LoginAccount = loginAccount;
        }
        private Account loginAccount;
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
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
        private Form CheckFormExist(Type fType)
        {
            foreach (Form f in MdiChildren)
            {
                if (f.GetType() == fType)
                    return f;
            }
            return null;
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
