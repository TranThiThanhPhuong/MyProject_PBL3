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
    public partial class Form_AddFood : Form
    {
        public Form_AddFood()
        {
            InitializeComponent();
            LoadNameCategory(comboBoxdanhmuc);
        }
        void LoadNameCategory(ComboBox cb)
        {
            cb.DataSource = CategoryBUS.Instance.GetAllCategory();
            cb.DisplayMember = "Name";
        }
        private void button1_Click(object sender, EventArgs e)
        {
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
            Food newFood = new Food(name, categoryID, price);
            if (FoodBUS.Instance.InsertFood(newFood))
            {
                //SplashScreenManager.ShowForm(typeof(WaitForm1));
                //LoadFoodToDataGridView();
                //SplashScreenManager.CloseForm();
                Log.WriteLog("add new Food: " + name);
                MessageBox.Show("Thêm món " + name + " thành công");
            }
            else
            {
                //SplashScreenManager.CloseForm();
                MessageBox.Show("Thêm món mới thất bại", "Lỗi");
            }
            this.Close();
        }

        private void Form_AddFood_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
