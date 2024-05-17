using System;
using System.Data;
using System.Collections.Generic;
using System.Security.Cryptography;
using DTO;
using System.Security.Principal;
using System.Text;
 

using RestaurantManagementSystem;
namespace DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return AccountDAO.instance;
            }
        }

        //public object Passwordhash { get; private set; }

        public bool CheckLogin(Account account)
        {
            string newpassword = Passwordhash.HashPassword(account.Password);
            string query = "USP_Login @UserName , @Password";
            DataTable result = new DataTable();
            try
            {
                //result = DataProvider.Instance.ExecuteQuery(query, new object[] { account.UserName, hasPass });
                result = DataProvider.Instance.ExecuteQuery(query, new object[] { account.UserName, newpassword });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result.Rows.Count > 0;
           
            
        }

        public DataTable GetAllAcount()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("USP_GetAllAccount");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetAccountByUserName(string userName)
        {
            string query = "USP_GetAccountByUserName @UserName";
            try
            {
                return DataProvider.Instance.ExecuteQuery(query, new object[] { userName });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Insert(string userName, string displayName, int typeID)
        {
            string query = string.Format("USP_InsertAccount @UserName , @DisplayName , @TypeID");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { userName, displayName, typeID });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
        public bool Insert2(string userName, string displayName, int typeID)
        {
            string pw = "0";
            string password = Passwordhash.HashPassword(pw);
            string query = string.Format("insert into Account values(N'{0}', N'{1}', N'{2}', N'{3}')");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { userName, displayName, password, typeID });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
        public bool ResetPassword(string userName)
        {
            string query = string.Format("USP_ResetPassword @UserName");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }

        public bool Delete(string userName)
        {
            string query = string.Format("USP_DeleteAccount @UserName");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }

        public bool UpdateInformation(string userName, string displayName, string password, string newPass)
        {
            string newpass = Passwordhash.HashPassword(password);
            string query = "USP_UpdateAccount @UserName , @DisplayName , @Password , @NewPass";
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { userName, displayName, newpass, newPass });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
        //public bool UpdateInformation2(string userName, string displayName, string password, string newPass)
        //{
        //    string query = "insert into ";
        //    int result;
        //    try
        //    {
        //        result = DataProvider.Instance.ExecuteNonQuery(query,
        //            new object[] { userName, displayName, password, newPass });
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return result > 0;
        //}
        public DataTable SearchAccountByUserName(string userName)
        {

            string query = string.Format("USP_SearchAccountByUserName @UserName");

            DataTable table = new DataTable();
            try
            {
                return DataProvider.Instance.ExecuteQuery(query, new object[] { userName });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}