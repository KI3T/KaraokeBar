using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeBar.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; }
            private set { AccountDAO.instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string accountUserName, string accountPassword)
        {
            string query = "USP_Login @accountUserName , @accountPassword";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {accountUserName, accountPassword});

            return result.Rows.Count > 0;
        }

        public string GetAccountPermission(string accountUserName)
        {
            string query = "USP_GetAccountPermission @accountUserName";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { accountUserName });

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                return row["AccountPermission"].ToString();
            }

            return null;
        }

    }
}
