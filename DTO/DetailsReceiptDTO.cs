using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeBar.DTO
{
    class DetailsReceiptDTO
    {
        public DetailsReceiptDTO(string detailsReceiptID, string receiptID, string serviceID, int count, float total, bool detailsReceiptActive)
        {
            this.DetailsReceiptID = detailsReceiptID;
            this.ReceiptID = receiptID;
            this.ServiceID = serviceID;
            this.Count = count;
            this.Total = total;
            this.DetailsReceiptActive = detailsReceiptActive;
        }

        public DetailsReceiptDTO(DataRow row)
        {
            this.DetailsReceiptID = row["detailsReceiptID"].ToString();
            this.ReceiptID = row["receiptID"].ToString();
            this.ServiceID = row["serviceID"].ToString();
            this.Count = (int)row["count"];
            this.Total = (float)row["total"];
            this.DetailsReceiptActive = (bool)row["detailsReceiptActive"];
        }

        private string detailsReceiptID;
        private string receiptID;
        private string serviceID;
        private int count;
        private float total;
        private bool detailsReceiptActive;

        public string DetailsReceiptID { get => detailsReceiptID; set => detailsReceiptID = value; }
        public string ReceiptID { get => receiptID; set => receiptID = value; }
        public string ServiceID { get => serviceID; set => serviceID = value; }
        public int Count { get => count; set => count = value; }
        public float Total { get => total; set => total = value; }
        public bool DetailsReceiptActive { get => detailsReceiptActive; set => detailsReceiptActive = value; }
    }
}
