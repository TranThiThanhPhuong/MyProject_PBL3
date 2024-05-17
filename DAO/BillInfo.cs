using System.Collections.Generic;
using System.Data;

using DTO;

namespace DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillInfoDAO();
                return BillInfoDAO.instance;
            }
        }

        private BillInfoDAO() { }
        public List<BillInfo2> GetListBillInfoByBillID(int id)
        {
            List<BillInfo2> list = new List<BillInfo2>();

            string query = "USP_GetListBillByBillID  @BillID " ;

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id});

            foreach (DataRow item in data.Rows)
            {
                BillInfo2 food = new BillInfo2(item);
                list.Add(food);
            }

            return list;
        }
        public void InsertBillInfo(int billID, int foodID, int amount)
        {
            string query = "USP_InsertBillInfo @BillID , @FoodID , @Amount";
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { billID, foodID, amount });
            }
            catch { }
        }

        public void DeleteBillInfoByBillID(int billID)
        {
            string query = string.Format("USP_DeleteBillInfoByBillID @BillID");
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { billID });
            }
            catch { }
        }
    }
}