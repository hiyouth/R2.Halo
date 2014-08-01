using System;
using System.Text;
using System.Web.Mvc;
using Nop.Core;
using Nop.Plugin.Shipping.UPS.Domain;
using Nop.Plugin.Shipping.UPS.Models;

namespace Nop.Plugin.Shipping.UPS.Controllers
{
    //[AdminAuthorize]
    public class ShippingUPSController :Controller
    {
        //private readonly UPSSettings _upsSettings;
        //private readonly ISettingService _settingService;

        public ShippingUPSController()
        {

        }

        //public ShippingUPSController(UPSSettings upsSettings, ISettingService settingService)
        //{
        //    this._upsSettings = upsSettings;
        //    this._settingService = settingService;
        //}

        //[ChildActionOnly]
        public ActionResult Configure()
        {
            var model = new UPSShippingModel();
            //model.Url = _upsSettings.Url;
            //model.AccessKey = _upsSettings.AccessKey;
            //model.Username = _upsSettings.Username;
            //model.Password = _upsSettings.Password;
            //model.AdditionalHandlingCharge = _upsSettings.AdditionalHandlingCharge;
            //model.InsurePackage = _upsSettings.InsurePackage;
            //model.PackingPackageVolume = _upsSettings.PackingPackageVolume;
            //model.PackingType = Convert.ToInt32(_upsSettings.PackingType);
            //model.PackingTypeValues = _upsSettings.PackingType.ToSelectList();
            //model.PassDimensions = _upsSettings.PassDimensions;

            //foreach (UPSCustomerClassification customerClassification in Enum.GetValues(typeof(UPSCustomerClassification)))
            //{
            //    model.AvailableCustomerClassifications.Add(new SelectListItem()
            //        {
            //            Text = CommonHelper.ConvertEnum(customerClassification.ToString()),
            //            Value = customerClassification.ToString(),
            //            Selected = customerClassification == _upsSettings.CustomerClassification
            //        });
            //}
            //foreach (UPSPickupType pickupType in Enum.GetValues(typeof(UPSPickupType)))
            //{
            //    model.AvailablePickupTypes.Add(new SelectListItem()
            //    {
            //        Text = CommonHelper.ConvertEnum(pickupType.ToString()),
            //        Value = pickupType.ToString(),
            //        Selected = pickupType == _upsSettings.PickupType
            //    });
            //}
            //foreach (UPSPackagingType packagingType in Enum.GetValues(typeof(UPSPackagingType)))
            //{
            //    model.AvailablePackagingTypes.Add(new SelectListItem()
            //    {
            //        Text = CommonHelper.ConvertEnum(packagingType.ToString()),
            //        Value = packagingType.ToString(),
            //        Selected = packagingType == _upsSettings.PackagingType
            //    });
            //}

            //var services = new UPSServices();
            //// Load Domestic service names
            //string carrierServicesOfferedDomestic = _upsSettings.CarrierServicesOffered;
            //foreach (string service in services.Services)
            //    model.AvailableCarrierServices.Add(service);

            //if (!String.IsNullOrEmpty(carrierServicesOfferedDomestic))
            //    foreach (string service in services.Services)
            //    {
            //        string serviceId = UPSServices.GetServiceId(service);
            //        if (!String.IsNullOrEmpty(serviceId) && !String.IsNullOrEmpty(carrierServicesOfferedDomestic))
            //        {
            //            // Add delimiters [] so that single digit IDs aren't found in multi-digit IDs
            //            if (carrierServicesOfferedDomestic.Contains(String.Format("[{0}]", serviceId)))
            //                model.CarrierServicesOffered.Add(service);
            //        }
            //    }

            return View("Nop.Plugin.Shipping.UPS.Views.ShippingUPS.Configure", model);
        }
    }
}
