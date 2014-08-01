using System.Collections.Generic;
using System.Web.Mvc;

namespace Nop.Plugin.Shipping.UPS.Models
{
    public class UPSShippingModel
    {
        public UPSShippingModel()
        {
            CarrierServicesOffered = new List<string>();
            AvailableCarrierServices = new List<string>();
            AvailableCustomerClassifications = new List<SelectListItem>();
            AvailablePickupTypes = new List<SelectListItem>();
            AvailablePackagingTypes = new List<SelectListItem>();
        }
        public string Url { get; set; }

        public string AccessKey { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public decimal AdditionalHandlingCharge { get; set; }

        public bool InsurePackage { get; set; }

        public string CustomerClassification { get; set; }
        public IList<SelectListItem> AvailableCustomerClassifications { get; set; }

        public string PickupType { get; set; }
        public IList<SelectListItem> AvailablePickupTypes { get; set; }

        public string PackagingType { get; set; }
        public IList<SelectListItem> AvailablePackagingTypes { get; set; }
        
        public IList<string> CarrierServicesOffered { get; set; }
        public IList<string> AvailableCarrierServices { get; set; }
        public string[] CheckedCarrierServices { get; set; }

        public bool PassDimensions { get; set; }

        public int PackingPackageVolume { get; set; }

        public int PackingType { get; set; }
        public SelectList PackingTypeValues { get; set; }

        public bool Tracing { get; set; }
    }
}