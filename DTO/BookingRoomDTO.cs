using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeBar.DTO
{
    class BookingRoomDTO
    {
        public BookingRoomDTO(string bookingRoomID, string roomID, string customerName, string customerPhone,
                                DateTime bookingTime, string note, string staffID, int bookingStatus,
                                bool bookingRoomActive)
        {
            this.RoomID = roomID;
            this.RoomName = RoomName;
            this.CustomerNam = customerNam;
            this.CustomerPhone = customerPhone;
            this.BookingTime = bookingTime;
            this.Note = note;
            this.StaffID = staffID;
            this.BookingStatus = bookingStatus;
            this.BookingRoomActive = bookingRoomActive;
        }

        public BookingRoomDTO(DataRow row)
        {
            this.RoomID = row["roomID"].ToString();
            this.RoomName = row["roomName"].ToString();
            this.customerNam = row["customerNam"].ToString();
            this.CustomerPhone = row["customerPhone"].ToString();
            this.BookingTime = (DateTime)row["bookingTime"];
            this.Note = row["note"].ToString();
            this.StaffID = row["staffID"].ToString();
            this.BookingStatus = (int)row["bookingStatus"];
            this.BookingRoomActive = (bool)row["bookingRoomActive"];
        }

        private string roomID;
        private string roomName;
        private string customerNam;
        private string customerPhone;
        private DateTime bookingTime;
        private string note;
        private string staffID;
        private int bookingStatus;
        private bool bookingRoomActive;

        public string RoomID { get => roomID; set => roomID = value; }
        public string RoomName { get => roomName; set => roomName = value; }
        public string CustomerNam { get => customerNam; set => customerNam = value; }
        public string CustomerPhone { get => customerPhone; set => customerPhone = value; }
        public DateTime BookingTime { get => bookingTime; set => bookingTime = value; }
        public string Note { get => note; set => note = value; }
        public string StaffID { get => staffID; set => staffID = value; }
        public int BookingStatus { get => bookingStatus; set => bookingStatus = value; }
        public bool BookingRoomActive { get => bookingRoomActive; set => bookingRoomActive = value; }
    }
}
