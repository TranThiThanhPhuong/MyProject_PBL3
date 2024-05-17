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
    public partial class Form_AddTable : Form
    {
        public int Table { get; set; }
        public Form_AddTable()
        {
            InitializeComponent();
        }

        private void Form_AddTable_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBox1.Text == "")
                Table = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Hãy nhập dữ liệu!!");
                return;
            }

            int temp;
            if (int.TryParse(textBox1.Text, out temp) == false)
            {
                MessageBox.Show("Dữ liệu không hợp lệ!!");
                textBox1.Focus();
                return;
            }
            else
            {
                Table = temp;
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
