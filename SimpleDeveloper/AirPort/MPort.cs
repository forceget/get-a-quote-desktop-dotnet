using SimpleDeveloper.InAndOutModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Port
{
    public class MPort
    {
        public class Form
        {
            public string Id { get; set; }

            public string Name { get; set; }

            public string Code { get; set; }

            public string CountryName { get; set; }

            public string CountryCode { get; set; }

            public double? Latitude { get; set; }

            public double? Longitude { get; set; }

            public string CountryId { get; set; }

            public string CityId { get; set; }

            public string StateId { get; set; }
            public int? LocationTypeId { get; set; }
            public string ZipCode { get; set; }
            public string Address { get; set; }

        }

        public class FilterForm:MFilterBase 
        {
            public string Id { get; set; }
            public string CompanyId { get; set; }
            public string CountryCode { get; set; }
            public string Name { get; set; }
            public List<string> CountryCodes { get; set; }
            public string CountryId { get; set; }

        }

        public class Response
        {


            public string Id { get; set; }

            public string Name { get; set; }

            public string Code { get; set; }

            public string CountryName { get; set; }

            public string CountryCode { get; set; }

            public double? Latitude { get; set; }

            public double? Longitude { get; set; }

            public string CountryId { get; set; }

            public string CityId { get; set; }

            public string StateId { get; set; }

            //public RpLocation City { get; set; }
            //public RpLocation Country { get; set; }
            //public RpLocation State { get; set; }
            public int? LocationTypeId { get; set; }
            //public RpLocationType LocationType { get; set; }
            public string ZipCode { get; set; }
            public string Address { get; set; }

        }
    }
}
