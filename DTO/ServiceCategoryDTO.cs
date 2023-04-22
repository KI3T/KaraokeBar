using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeBar.DTO
{
    class ServiceCategoryDTO
    {
        public ServiceCategoryDTO(string serviceCategoryID, string serviceCategoryName, bool serviceCategoryActive)
        {
            this.ServiceCategoryID = serviceCategoryID;
            this.ServiceCategoryName = serviceCategoryName;
            this.ServiceCategoryActive = serviceCategoryActive;
        }

        public ServiceCategoryDTO(DataRow row)
        {
            this.ServiceCategoryID = row["serviceCategoryID"].ToString();
            this.ServiceCategoryName = row["serviceCategoryName"].ToString();
            this.ServiceCategoryActive = (bool)row["serviceCategoryActive"];
        }

        private string serviceCategoryID;
        private string serviceCategoryName;
        private bool serviceCategoryActive;

        public string ServiceCategoryID { get => serviceCategoryID; set => serviceCategoryID = value; }
        public string ServiceCategoryName { get => serviceCategoryName; set => serviceCategoryName = value; }
        public bool ServiceCategoryActive { get => serviceCategoryActive; set => serviceCategoryActive = value; }
    }
}
