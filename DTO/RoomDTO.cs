using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeBar.DTO
{
    public class RoomDTO
    {
        public RoomDTO(string roomID, string roomName, int roomStatus, string roomTypeID, bool roomActive)
        {
            this.RoomID = roomID;
            this.RoomName = roomName;
            this.RoomStatus = roomStatus;
            this.RoomTypeID = roomTypeID;
            this.RoomActive = roomActive;
        }

        public RoomDTO(DataRow row)
        {
            this.RoomID = row["roomID"].ToString();
            this.RoomName = row["roomName"].ToString();
            this.RoomStatus = (int)row["roomStatus"];
            this.RoomTypeID = row["roomTypeID"].ToString();
            this.RoomActive = (bool)row["roomActive"];
        }

        private string roomID;
        private string roomName;
        private int roomStatus;
        private string roomTypeID;
        private bool roomActive;

        public string RoomID { get { return roomID; } set { roomID = value; } }
        public string RoomName { get { return roomName; } set { roomName = value; } }
        public int RoomStatus { get { return roomStatus; } set { roomStatus = value; } }
        public string RoomTypeID { get { return roomTypeID; } set { roomTypeID = value; } }
        public bool RoomActive { get { return roomActive; } set { roomActive = value; } }
    }
}
