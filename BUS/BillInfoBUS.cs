using System;
using System.Collections.Generic;

using DAO;
using DTO;

namespace BUS
{
    public class BillInfoBUS
    {
        private static BillInfoBUS instance;

        public static BillInfoBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillInfoBUS();
                return BillInfoBUS.instance;
            }
        }
        public List<BillInfo2> GetListBillInfoByBillID(int id)
        {
            try
            {
                return BillInfoDAO.Instance.GetListBillInfoByBillID(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        private BillInfoBUS() { }
        
        public void InsertBillInfo(int billID, int foodID, int amount)
        {
            try
            {
                BillInfoDAO.Instance.InsertBillInfo(billID, foodID, amount);
            }
            catch { }
        }

        public void DeleteBillInfoByBillID(int billID)
        {
            try
            {
                BillInfoDAO.Instance.DeleteBillInfoByBillID(billID);
            }
            catch { }
        }
    }
}