using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeBar.DTO
{
    class StaffDTO
    {
        public StaffDTO(string staffID, byte[] staffAvatar, string staffName, DateTime staffBirthday,
                            string staffSex, string staffPhone, string staffCCCD, string staffAddress,
                            string staffPosition, bool staffActive)
        {
            this.StaffID = staffID;
            this.staffAvatar = staffAvatar;
            this.StaffName = staffName;
            this.StaffBirthday = staffBirthday;
            this.StaffSex = staffSex;
            this.StaffPhone = staffPhone;
            this.StaffCCCD = staffCCCD;
            this.StaffAddress = staffAddress;
            this.StaffPosition = staffPosition;
            this.StaffActive = staffActive;
        }

        public StaffDTO(DataRow row)
        {
            this.StaffID = row["staffID"].ToString();
            this.StaffAvatar = row.Field<byte[]>("staffAvatar");
            this.StaffName = row["staffName"].ToString();
            this.StaffBirthday = (DateTime)row["staffBirthday"];
            this.StaffSex = row["staffSex"].ToString();
            this.StaffPhone = row["staffPhone"].ToString();
            this.StaffCCCD = row["staffCCCD"].ToString();
            this.StaffAddress = row["staffAddress"].ToString();
            this.StaffPosition = row["staffPosition"].ToString();
            this.StaffActive = (bool)row["staffActive"];
        }

        private string staffID;
        private byte[] staffAvatar;
        private string staffName;
        private DateTime staffBirthday;
        private string staffSex;
        private string staffPhone;
        private string staffCCCD;
        private string staffAddress;
        private string staffPosition;
        private bool staffActive;

        public string StaffID { get => staffID; set => staffID = value; }
        public byte[] StaffAvatar { get => staffAvatar; set => staffAvatar = value; }
        public string StaffName { get => staffName; set => staffName = value; }
        public DateTime StaffBirthday { get => staffBirthday; set => staffBirthday = value; }
        public string StaffSex { get => staffSex; set => staffSex = value; }
        public string StaffPhone { get => staffPhone; set => staffPhone = value; }
        public string StaffCCCD { get => staffCCCD; set => staffCCCD = value; }
        public string StaffAddress { get => staffAddress; set => staffAddress = value; }
        public string StaffPosition { get => staffPosition; set => staffPosition = value; }
        public bool StaffActive { get => staffActive; set => staffActive = value; }
    }
}
