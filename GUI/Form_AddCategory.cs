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
using BUS;

namespace GUI
{
    public partial class Form_AddCategory : Form
    {
        public int idcategory { get; set; }
        public System.Windows.Forms.TextBox TextBoxTen => txbten;
        public Form_AddCategory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txbten.Text;
            if (name == "")
            {
                MessageBox.Show("Tên danh mục không hợp lệ");
                return;
            }
            if (CategoryBUS.Instance.InsertCategory(name))
            {
                // SplashScreenManager.ShowForm(typeof(WaitForm1));
                //LoadFoodToDataGridView();
                //SplashScreenManager.CloseForm();
                MessageBox.Show("Thêm danh mục thành công");
                Log.WriteLog("add new Category: " + name);
                this.Close();
            }
            else
                MessageBox.Show("Thêm danh mục thất bại", "Lỗi");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
