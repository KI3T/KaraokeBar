using KaraokeBar.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeBar.DAO
{
    public class RoomDAO
    {
        private static RoomDAO instance;

        public static RoomDAO Instance
        {
            get { if (instance == null) instance = new RoomDAO(); return RoomDAO.instance; }
            private set { RoomDAO.instance = value; }
        }

        public static int RoomWidth = 145;
        public static int RoomHeight = 145;

        private RoomDAO() { }

        public List<RoomDTO> LoadRoomList()
        {
            List<RoomDTO> roomList = new List<RoomDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetRoomList");

            foreach (DataRow item in data.Rows)
            {
                RoomDTO room = new RoomDTO(item);
                roomList.Add(room);
            }

            return roomList;
        }
    }
}
