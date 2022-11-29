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

            public string Name { get; set; }

            public string CountryId { get; set; }

            public string CityId { get; set; }

            public string StateId { get; set; }

            public string CountryName { get; set; }

            public string CountryCode { get; set; }

            public string CityName { get; set; }

            public string Type { get; set; }

            public string Code { get; set; }

            public double? Latitude { get; set; }

            public double? Longitude { get; set; }
            public int? LocationTypeId { get; set; }
            public string ZipCode { get; set; }
            public string Address { get; set; }

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


            public string Id { get; set; }

            public string Name { get; set; }

            public string CountryId { get; set; }

            public string CityId { get; set; }

            public string StateId { get; set; }

            public string CountryName { get; set; }

            public string CountryCode { get; set; }

            public string CityName { get; set; }

            public string Type { get; set; }

            public string Code { get; set; }

            public double? Latitude { get; set; }

            public double? Longitude { get; set; }

            //public RpLocation Country { get; set; }
            //public RpLocation State { get; set; }
            //public RpLocation City { get; set; }
            public int? LocationTypeId { get; set; }
            //public RpLocationType LocationType { get; set; }
            public string ZipCode { get; set; }
            public string Address { get; set; }

        }
    }
}
