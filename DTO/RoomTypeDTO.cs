using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeBar.DTO
{
    public class RoomTypeDTO
    {
        public RoomTypeDTO(string roomTypeID, string roomTypeName, float roomTypePrice, bool roomTypeActive)
        {
            this.RoomTypeID = roomTypeID;
            this.RoomTypeName = roomTypeName;
            this.RoomTypePrice = roomTypePrice;
            this.RoomTypeActive = roomTypeActive;
        }

        public RoomTypeDTO(DataRow row)
        {
            this.RoomTypeID = row["roomTypeID"].ToString();
            this.RoomTypeName = row["roomTypeName"].ToString();
            this.RoomTypePrice = (float)row["roomTypePrice"];
            this.RoomTypeActive = (bool)row["roomTypeActive"];
        }

        private string roomTypeID;
        private string roomTypeName;
        private float roomTypePrice;
        private bool roomTypeActive;

        public string RoomTypeID { get => roomTypeID; set => roomTypeID = value; }
        public string RoomTypeName { get => roomTypeName; set => roomTypeName = value; }
        public float RoomTypePrice { get => roomTypePrice; set => roomTypePrice = value; }
        public bool RoomTypeActive { get => roomTypeActive; set => roomTypeActive = value; }
    }
}
