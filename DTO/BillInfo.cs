using System.Data;

namespace DTO
{
    public class BillInfo
    {
        public int ID { get; set; }
        public int BillID { get; set; }
        public int FoodID { get; set; }
        public int Amount { get; set; }

        public int Discount { get; set; }
        public int totalPrice { get; set; }

        public BillInfo(int id, int billID, int foodID, int amount)// int discount, int totalPrice)
        {
            this.ID = id;
            this.BillID = billID;
            this.FoodID = foodID;
            this.Amount = amount;
            //this.Discount = discount;
            //this.totalPrice = totalPrice;
        }

        public BillInfo(DataRow row)
        {
            this.ID = (int)row["id"];
            this.BillID = (int)row["billID"];
            this.FoodID = (int)row["foodID"];
            this.Amount = (int)row["amount"];
            //this.Discount = (int)row["discount"];
            //this.totalPrice = (int)row["totalPrice"];
        }
    }
}