using AutomaticPricing;
using SimpleDeveloper.InAndOutModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AutomaticPricing.MAutomaticPricing;

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
            public string ProductReadyDate { get; set; }
            public List<FAutomaticPricingPackage> Packages { get; set; }
            public List<FAutomaticPricingContainer> Containers { get; set; }
            public string AffilatePartnerId { get; set; }

            public int HazardousGoods { get; set; }
            public int ShipmentLoadType { get; set; }
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
            public List<Pricing> pricings { get; set; }
            public string offerId { get; set; }
            public string redirectUrl { get; set; }
        }

        public class Pricing
        {
            public int id { get; set; }
            public int speedType { get; set; }
            public int isSelected { get; set; }
            public string startLocationId { get; set; }
            public string startLocationName { get; set; }
            public object startLocationAddress { get; set; }
            public string startLocationCode { get; set; }
            public string endLocationId { get; set; }
            public string endLocationName { get; set; }
            public string endLocationAddress { get; set; }
            public string endLocationCode { get; set; }
            public string fromPortId { get; set; }
            public string fromPortName { get; set; }
            public string fromPortCode { get; set; }
            public string toPortId { get; set; }
            public string toPortName { get; set; }
            public string toPortCode { get; set; }
            public string fromAirportId { get; set; }
            public string fromAirportName { get; set; }
            public string fromAirportCode { get; set; }
            public string toAirportId { get; set; }
            public string toAirportName { get; set; }
            public string toAirportCode { get; set; }
            public double totalPrice { get; set; }
            public int transitTime { get; set; }
            public string shipmentTypeId { get; set; }
            public string shipmentTypeName { get; set; }
            public string transportationTypeId { get; set; }
            public string transportationTypeName { get; set; }
            public string incotermId { get; set; }
            public string incotermName { get; set; }
            public List<PricingCostItem> pricingCostItems { get; set; }
        }

        public class PricingCostItem
        {
            public int id { get; set; }
            public int offerPricingId { get; set; }
            public double quantity { get; set; }
            public double unitPrice { get; set; }
            public double totalPrice { get; set; }
            public string costTypeName { get; set; }
            public string costItemName { get; set; }
            public string description { get; set; }
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
