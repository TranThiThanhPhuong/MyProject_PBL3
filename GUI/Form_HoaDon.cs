using BUS;
using DAO;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI
{
    public partial class Form_HoaDon : Form
    {
        public int billID;
        public int discount;
        public int totalprice;
        public int tableID;
        public int amount;
        public int foodid;
        public int foodprice;
        public int tong;
        public Form_HoaDon(List<TempBill> tempBills, int tableid, int BillID, int discount, int totalprice, int tong)
        {
            InitializeComponent();
            listView1.Items.Clear();
            Rtbbillid.Text = BillID.ToString();
            Rtbdis.Text = discount.ToString();
            Rtbttpice.Text = totalprice.ToString();
            Rtbtong.Text = tong.ToString();
            Rtbban.Text = tableid.ToString();
            listView1.View = View.Details;
            listView1.Columns.Add("Món");
            listView1.Columns.Add("Số lượng");
            listView1.Columns.Add("Giá");
            listView1.Columns.Add("Thành tiền");
            listView1.Font = new Font("Arial", 12, FontStyle.Regular);
            listView1.ForeColor = Color.Black; // Màu chữ
            listView1.BackColor = Color.White;
            listView1.Columns[0].Width = 150; // Cột Food có chiều rộng là 200
            listView1.Columns[1].Width = 85; 
            listView1.Columns[2].Width = 85; // Cột Food có chiều rộng là 200
            listView1.Columns[3].Width = 110;
            foreach (TempBill item in tempBills)
            {
                ListViewItem lsvItem = new ListViewItem(item.Food.ToString());
                lsvItem.SubItems.Add(item.AmountFood.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.Total.ToString());
                listView1.Items.Add(lsvItem);
            }
        }
        private void btninBIll_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thành công");
            this.Close();
        }
    }
}
        