﻿using Location;
using SimpleDeveloper.InAndOutModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Location
{
    public class MLocation
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
            public string CompanyId { get; set; }
            public string StateId { get; set; }
            public string CityId { get; set; }
            public bool? IsCompanyOnly { get; set; } = false;
            public string Id { get; set; }
            public string Name { get; set; }
            public int LocationTypes { get; set; }
            public string CountryId { get; set; }
            public string CountryName { get; set; }
            public string CountryCode { get; set; }
            public string StateCode { get; set; }


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
