using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeBar.DTO
{
    public class AccountDTO
    {
        public AccountDTO(string accountID, string accountUserName, string accountPassword, string accountPermission, string staffID, bool accountActive)
        {
            this.AccountID = accountID;
            this.AccountUserName = accountUserName;
            this.AccountPassword = accountPassword;
            this.AccountPermission = accountPermission;
            this.StaffID = staffID;
            this.AccountActive = accountActive;
        }

        public AccountDTO(DataRow row)
        {
            this.AccountID = row["accountID"].ToString();
            this.AccountUserName = row["accountUserName"].ToString();
            this.AccountPassword = row["accountPassword"].ToString();
            this.AccountPermission = row["accountPermission"].ToString();
            this.StaffID = row["staffID"].ToString();
            this.AccountActive = (bool)row["accountActive"];
        }

        private string accountID;
        private string accountUserName;
        private string accountPassword;
        private string accountPermission;
        private string staffID;
        private bool accountActive;

        public string AccountID { get => accountID; set => accountID = value; }
        public string AccountUserName { get => accountUserName; set => accountUserName = value; }
        public string AccountPassword { get => accountPassword; set => accountPassword = value; }
        public string AccountPermission { get => accountPermission; set => accountPermission = value; }
        public string StaffID { get => staffID; set => staffID = value; }
        public bool AccountActive { get => accountActive; set => accountActive = value; }
    }
}
