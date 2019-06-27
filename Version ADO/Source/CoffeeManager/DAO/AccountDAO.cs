using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; }
            private set { AccountDAO.instance = value; }
        }
        private AccountDAO() { }

        public bool CheckAccountExits(string userName)
        {
            string query = "exec USP_CheckAccountExits @userName";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName });
            if (result.Rows.Count > 0)
                return false;
            else
                return true;
        }
        public bool Login(string userName, string passWord)
        {
            //byte[] temp = ASCIIEncoding.ASCII.GetBytes(passWord);
            //byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            //string hasPass = "";
            //foreach(byte item in hasData)
            //{
            //hasPass += item;
            //}
            //var list = hasData.ToString();
            //list.Reverse();

            //1962026656160185351301320480154111117132155

            string query = "EXEC USP_Login @userName , @passWord";

            //DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, hasPass /*list*/});

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord /*list*/});

            return result.Rows.Count > 0;
        }

        public bool UpdateAccount(string userName, string displayName, string pass, string newPass)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC USP_UpdateAccount @userName , @displayName , @password , @newPassword ", new object[] { userName, displayName, pass, newPass });
            return result > 0;
        }

        public Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from account where userName = '" + userName + "'");
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }

        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT UserName,DisplayName,Type FROM dbo.Account");
        }

        public bool InsertAccount(string userName, string displayName, int type)
        {
            //string query = string.Format("INSERT dbo.Account ( UserName, DisplayName, Type, passWord)values (N'{0}', N'{1}', {2} , N'{3}')", userName, displayName, type, 1962026656160185351301320480154111117132155);
            string query = string.Format("INSERT dbo.Account ( UserName, DisplayName, Type)values (N'{0}', N'{1}', {2})", userName, displayName, type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateAccount(string userName, string displayName, int type)
        {
            string query = string.Format("UPDATE dbo.Account SET DisplayName = N'{1}' , Type = {2} WHERE UserName = N'{0}'", userName, displayName, type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteAccount(string userName)
        {
            string query = string.Format("DELETE Account where UserName = N'{0}'", userName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool ResetPassword(string userName)
        {
            //string query = string.Format("UPDATE Account SET PassWord = N'1962026656160185351301320480154111117132155' where UserName = N'{0}'", userName);
            string query = string.Format("UPDATE Account SET PassWord = N'0' where UserName = N'{0}'", userName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
