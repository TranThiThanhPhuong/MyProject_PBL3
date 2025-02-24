﻿using System;
using System.Data;

using DTO;

namespace DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillDAO();
                return BillDAO.instance;
            }
        }

        private BillDAO() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tableID"></param>
        /// <returns>Bill ID, if Bill ID is null, this function will return -1</returns>
        public int GetUnCheckBillIDByTableID(int tableID)
        {
            DataTable table;
            try
            {
                table = DataProvider.Instance.ExecuteQuery("GetUnCheckBillIDByTableID @TableID", new object[] { tableID });
            }
            catch (Exception ex)
            {
                throw ex;
            }

            if (table.Rows.Count > 0)
            {
                Bill bill = new Bill(table.Rows[0]);
                return bill.ID;
            }
            return -1;
        }
        public DataTable GetUnCheckBillIDByTableID2(int ID)
        {
            try
                {
                  return DataProvider.Instance.ExecuteQuery("GetUnCheckBillIDByTableID2 @ID", new object[] { ID });

                }
            catch (Exception ex)
                {
                throw ex;
                }
        }
        public void InsertBill(int tableID)
        {
            try
            {
                DataProvider.Instance.ExecuteNonQuery("USP_InsertBill @TableID", new object[] { tableID });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetMaxBillID()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("USP_GetMaxBillID");
            }
            catch
            {
                return 1;
            }
        }

        public void CheckOut(int billID, int discount, int totalPrice)
        {
            string query = "USP_CheckOut @ID , @Discount , @TotalPrice";
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { billID, discount, totalPrice });
            }
            catch { }
        }

        public DataTable GetListBillByDate(DateTime fromDate, DateTime toDate)
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("USP_GetListBillByDay @fromDate , @toDate",
                    new object[] { fromDate, toDate });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteBill(int id)
        {
            string query = string.Format("USP_DeleteBill @ID");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
    }
}
