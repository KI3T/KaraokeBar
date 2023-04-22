using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeBar.DTO
{
    public class ReceiptDTO
    {
        public ReceiptDTO(string receiptID, string staffID, string customerName, string customerPhone,
                            string roomID, DateTime checkInTime, DateTime checkOutTime, string note,
                            bool receiptStatus, bool receiptActive)
        {
            this.ReceiptID = receiptID;
            this.StaffID = staffID;
            this.CustomerName = customerName;
            this.CustomerPhone = customerPhone;
            this.RoomID = roomID;
            this.CheckInTime = checkInTime;
            this.CheckOutTime = checkOutTime;
            this.Note = note;
            this.ReceiptStatus = receiptStatus;
            this.ReceiptActive = receiptActive;
        }

        public ReceiptDTO(DataRow row)
        {
            this.ReceiptID = row["receiptID"].ToString();
            this.StaffID = row["staffID"].ToString();
            this.CustomerName = row["customerName"].ToString();
            this.CustomerPhone = row["customerPhone"].ToString();
            this.RoomID = row["roomID"].ToString();
            this.CheckInTime = (DateTime)row["checkInTime"];
            this.CheckOutTime = (DateTime)row["checkOutTime"];
            this.Note = row["note"].ToString();
            this.ReceiptStatus = (bool)row["receiptStatus"];
            this.ReceiptActive = (bool)row["receiptActive"];
        }

        private string receiptID;
        private string staffID;
        private string customerName;
        private string customerPhone;
        private string roomID;
        private DateTime checkInTime;
        private DateTime checkOutTime;
        private string note;
        private bool receiptStatus;
        private bool receiptActive;

        public string ReceiptID { get => receiptID; set => receiptID = value; }
        public string StaffID { get => staffID; set => staffID = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public string CustomerPhone { get => customerPhone; set => customerPhone = value; }
        public string RoomID { get => roomID; set => roomID = value; }
        public DateTime CheckInTime { get => checkInTime; set => checkInTime = value; }
        public DateTime CheckOutTime { get => checkOutTime; set => checkOutTime = value; }
        public string Note { get => note; set => note = value; }
        public bool ReceiptStatus { get => receiptStatus; set => receiptStatus = value; }
        public bool ReceiptActive { get => receiptActive; set => receiptActive = value; }
    }
}
