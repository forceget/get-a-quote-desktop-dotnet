using AutomaticPricing;
using SimpleDeveloper.InAndOutModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticPricing
{
    public class MAutomaticPricing
    {
        public class Form
        {
            public string Id { get; set; }
            public string CompanyId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string CompanyName { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public string FromType { get; set; }
            public string ToType { get; set; }
            public string FromLocationId { get; set; }
            public string ToLocationId { get; set; }
            public string FromLocationCountryId { get; set; }
            public string ToLocationCountryId { get; set; }
            public string ProductAmount { get; set; }
            public int ShipmentLoadType { get; set; } 
            public DateTime? ProductReadyDate { get; set; }
            public List<FAutomaticPricingPackage> Packages { get; set; }
            public List<FAutomaticPricingContainer> Containers { get; set; }
            public int HazardousGoods { get; set; }
            public string AffilatePartnerId { get; set; }
            public int Insurance { get; set; }
            public int CustomsClearance { get; set; }

        }
        public class FAutomaticPricingPackage
        {
            public string PackageTypeId { get; set; }
            public string TotalUnit { get; set; }
            public string Length { get; set; }
            public string Width { get; set; }
            public string Height { get; set; }
            public string Weight { get; set; }
            public string MetricType { get; set; }
        }
        public class FAutomaticPricingContainer
        {
            public string TotalUnit { get; set; }
            public string Size { get; set; }

        }

        public class FAutomaticPricingContain
        {
            public string Item { get; set; }
        }
        public class FilterForm:MFilterBase 
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string CompanyName { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public string TransportationMethod { get; set; }
            public string Averageamounth { get; set; }
            public string FromType { get; set; }
            public string ToType { get; set; }
            public string FromLocationId { get; set; }
            public string ToLocationId { get; set; }
            public string FromLocationCountryId { get; set; }
            public string ToLocationCountryId { get; set; }
            public string FromLocationCityId { get; set; }
            public string FromLocationAddress { get; set; }
            public string ToLocationCityId { get; set; }
            public string FromLocationStateId { get; set; }
            public string ToLocationStateId { get; set; }
            public string ShipmentTypeId { get; set; }
            public decimal? ProductAmount { get; set; }


        }

        public class Response
        {
            public Root Data { get; set; }
            public int Status { get; set; } = 200;
            public List<string> StatusTexts { get; set; } = new List<string>();
            public dynamic Total { get; set; }
            public long Count { get; set; } = 0;

        }
        #region Root
        public class Item
        {
            public object id { get; set; }
            public object companyId { get; set; }
            public object firstName { get; set; }
            public object lastName { get; set; }
            public object companyName { get; set; }
            public object email { get; set; }
            public object phoneNumber { get; set; }
            public object transportationMethod { get; set; }
            public object monthlyAverageShipment { get; set; }
            public object fromType { get; set; }
            public object toType { get; set; }
            public object fromLocationId { get; set; }
            public object toLocationId { get; set; }
            public object fromLocationCountryId { get; set; }
            public object toLocationCountryId { get; set; }
            public object fromLocationCityId { get; set; }
            public object toLocationCityId { get; set; }
            public object fromLocationStateId { get; set; }
            public object toLocationStateId { get; set; }
            public object shipmentTypeId { get; set; }
            public object shipmentType { get; set; }
            public object containerType { get; set; }
            public object containerNumber { get; set; }
            public object packages { get; set; }
            public object chargableWeight { get; set; }
            public object totalPrice { get; set; }
            public string offerId { get; set; }
            public int productAmount { get; set; }
            public object fromLocationAddress { get; set; }
            public DateTime productReadyDate { get; set; }
            public int insurance { get; set; }
            public int customsClearance { get; set; }
            public int shipmentLoadType { get; set; }
            public int isFreightos { get; set; }
            public object freightosNumber { get; set; }
        }

        public class Root
        {
            public int status { get; set; }
            public string statusText { get; set; }
            public List<object> statusTexts { get; set; }
            public Item item { get; set; }
            public object total { get; set; }
            public int count { get; set; }
        }


        #endregion
    }
}
