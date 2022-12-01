using AirPort;
using City;
using Country;
using Location;
using SimpleDeveloper.InAndOutModel;
using State;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPort
{
    public class MAirPort
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
            public string Id { get; set; }
            public string CompanyId { get; set; }
            public string CountryCode { get; set; }
            public string CountryId { get; set; }
            public string StateId { get; set; }
            public string Name { get; set; }

            public List<string> Types { get; set; }

            public List<string> CountryCodes { get; set; }

        }

        public class Response
        {
            public List<string> Data { get; set; }
            public int Status { get; set; } = 200;
            public List<string> StatusTexts { get; set; } = new List<string>();
            public dynamic Total { get; set; }

            public long Count { get; set; } = 0;

        }
        
        #region root
        public class City
        {
            public string id { get; set; }
            public object companyId { get; set; }
            public object amazonWarehouseId { get; set; }
            public object stateId { get; set; }
            public object countryId { get; set; }
            public object companyInfo { get; set; }
            public object cityId { get; set; }
            public object zipCode { get; set; }
            public object description { get; set; }
            public string name { get; set; }
            public object contactPersonName { get; set; }
            public object contactPersonMobile { get; set; }
            public object contactPersonMail { get; set; }
            public object address { get; set; }
            public object company { get; set; }
            public object receivingHours { get; set; }
            public object address2 { get; set; }
            public int isDeleted { get; set; }
            public object created_time { get; set; }
            public object latitude { get; set; }
            public object longitude { get; set; }
            public object locationTypeId { get; set; }
            public object locationType { get; set; }
            public object city { get; set; }
            public object country { get; set; }
            public object state { get; set; }
            public object isAmazon { get; set; }
            public int isForcegetWarehouseLocation { get; set; }
            public object type { get; set; }
            public object code { get; set; }
            public object iso3 { get; set; }
            public object flag { get; set; }
        }

        public class Country
        {
            public string id { get; set; }
            public object companyId { get; set; }
            public object amazonWarehouseId { get; set; }
            public object stateId { get; set; }
            public object countryId { get; set; }
            public object companyInfo { get; set; }
            public object cityId { get; set; }
            public object zipCode { get; set; }
            public object description { get; set; }
            public string name { get; set; }
            public object contactPersonName { get; set; }
            public object contactPersonMobile { get; set; }
            public object contactPersonMail { get; set; }
            public object address { get; set; }
            public object company { get; set; }
            public object receivingHours { get; set; }
            public object address2 { get; set; }
            public int isDeleted { get; set; }
            public object created_time { get; set; }
            public object latitude { get; set; }
            public object longitude { get; set; }
            public object locationTypeId { get; set; }
            public object locationType { get; set; }
            public object city { get; set; }
            public object country { get; set; }
            public object state { get; set; }
            public object isAmazon { get; set; }
            public int isForcegetWarehouseLocation { get; set; }
            public object type { get; set; }
            public string code { get; set; }
            public string iso3 { get; set; }
            public string flag { get; set; }
        }

        public class Item
        {
            public string id { get; set; }
            public string name { get; set; }
            public string countryId { get; set; }
            public string cityId { get; set; }
            public object stateId { get; set; }
            public object countryName { get; set; }
            public object countryCode { get; set; }
            public object cityName { get; set; }
            public string type { get; set; }
            public string code { get; set; }
            public object latitude { get; set; }
            public object longitude { get; set; }
            public Country country { get; set; }
            public State state { get; set; }
            public City city { get; set; }
            public int locationTypeId { get; set; }
            public LocationType locationType { get; set; }
            public object zipCode { get; set; }
            public string address { get; set; }
        }

        public class LocationType
        {
            public int id { get; set; }
            public string name { get; set; }
            public object detail { get; set; }
        }

        public class Root
        {
            public int status { get; set; }
            public object statusText { get; set; }
            public List<object> statusTexts { get; set; }
            public List<Item> item { get; set; }
            public object total { get; set; }
            public int count { get; set; }
        }

        public class State
        {
            public object id { get; set; }
            public object companyId { get; set; }
            public object amazonWarehouseId { get; set; }
            public object stateId { get; set; }
            public object countryId { get; set; }
            public object companyInfo { get; set; }
            public object cityId { get; set; }
            public object zipCode { get; set; }
            public object description { get; set; }
            public object name { get; set; }
            public object contactPersonName { get; set; }
            public object contactPersonMobile { get; set; }
            public object contactPersonMail { get; set; }
            public object address { get; set; }
            public object company { get; set; }
            public object receivingHours { get; set; }
            public object address2 { get; set; }
            public int isDeleted { get; set; }
            public object created_time { get; set; }
            public object latitude { get; set; }
            public object longitude { get; set; }
            public object locationTypeId { get; set; }
            public object locationType { get; set; }
            public object city { get; set; }
            public object country { get; set; }
            public object state { get; set; }
            public object isAmazon { get; set; }
            public int isForcegetWarehouseLocation { get; set; }
            public object type { get; set; }
            public object code { get; set; }
            public object iso3 { get; set; }
            public object flag { get; set; }
        }
        #endregion
    }
}
