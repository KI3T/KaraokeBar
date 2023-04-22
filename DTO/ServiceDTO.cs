using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeBar.DTO
{
    public class ServiceDTO
    {
        public ServiceDTO(string serviceID, byte[] serviceImage, string serviceName, string serviceCategoryID,
                            string descriptionn, string unit, int price, int quantity,
                            DateTime expiryDate, bool serviceActive)
        {
            this.ServiceID = serviceID;
            this.ServiceImage = serviceImage;
            this.ServiceName = serviceName;
            this.ServiceCategoryID = serviceCategoryID;
            this.Descriptionn = descriptionn;
            this.Unit = unit;
            this.Price = price;
            this.Quantity = quantity;
            this.ExpiryDate = expiryDate;
            this.ServiceActive = serviceActive;
        }

        public ServiceDTO(DataRow row)
        {
            this.ServiceID = row["serviceID"].ToString();
            this.ServiceImage = row.Field<byte[]>("serviceImage");
            this.ServiceName = row["serviceName"].ToString();
            this.ServiceCategoryID = row["serviceCategoryID"].ToString();
            this.Descriptionn = row["descriptionn"].ToString();
            this.Unit = row["unit"].ToString();
            this.Price = (int)row["price"];
            this.Quantity = (int)row["quantity"];
            this.ExpiryDate = (DateTime)row["expiryDate"];
            this.ServiceActive = (bool)row["serviceActive"];
        }

        private string serviceID;
        private byte[] serviceImage;
        private string serviceName;
        private string serviceCategoryID;
        private string descriptionn;
        private string unit;
        private int price;
        private int quantity;
        private DateTime expiryDate;
        private bool serviceActive;

        public string ServiceID { get => serviceID; set => serviceID = value; }
        public byte[] ServiceImage { get => serviceImage; set => serviceImage = value; }
        public string ServiceName { get => serviceName; set => serviceName = value; }
        public string ServiceCategoryID { get => serviceCategoryID; set => serviceCategoryID = value; }
        public string Descriptionn { get => descriptionn; set => descriptionn = value; }
        public string Unit { get => unit; set => unit = value; }
        public int Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public DateTime ExpiryDate { get => expiryDate; set => expiryDate = value; }
        public bool ServiceActive { get => serviceActive; set => serviceActive = value; }
    }
}
