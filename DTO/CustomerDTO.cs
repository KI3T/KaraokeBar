using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeBar.DTO
{
    public class CustomerDTO
    {
        public CustomerDTO(string customerID, string customerName, string staffPhone, bool customerActive)
        {
            this.CustomerID = customerID;
            this.CustomerName = customerName;
            this.StaffPhone = staffPhone;
            this.CustomerActive = customerActive;
        }

        public CustomerDTO(DataRow row)
        {
            this.CustomerID = row["customerID"].ToString();
            this.CustomerName = row["customerName"].ToString();
            this.StaffPhone = row["staffPhone"].ToString();
            this.CustomerActive = (bool)row["customerActive"];
        }

        private string customerID;
        private string customerName;
        private string staffPhone;
        private bool customerActive;

        public string CustomerID { get => customerID; set => customerID = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public string StaffPhone { get => staffPhone; set => staffPhone = value; }
        public bool CustomerActive { get => customerActive; set => customerActive = value; }
    }
}
