using Newtonsoft.Json;
using RestSharp;
using RestSharp.Serialization.Json;
using SimpleDeveloper.InAndOutModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading;

namespace AirPort
{
    public class RAirPort : IAirPort
    {

        public MAirPort.Root MultipleGet(MAirPort.FilterForm form)
        {
            MAirPort.Root rb = new MAirPort.Root();
            try
            {
                var client = new RestClient("https://localhost:44392/api/AirPort/MultipleGet");
                var request = new RestRequest(Method.POST);
                request.AddHeader("Authorization", "Bearer " + "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiJiNDhjMjk0ZS01ODdjLTQ2YjUtOTk5ZC00NjQ3MDgwY2YzM2EiLCJqdGkiOiIyMWM3YWE3Mi00ZGQ0LTRkYTMtYTExOS1lMzJjNzAyYzc4MzAiLCJuYmYiOjE2Njg4NDk5NDIsImV4cCI6MTY3MTQ0MTk0MiwiaXNzIjoiaHR0cHM6Ly9mb3JjZWdldC5jb20vIiwiYXVkIjoiZGV2In0.wb5OGXbVHy6m2038VUaCtcAnWwjS4ftT2eD89VuOxLU");
                request.AddParameter("Sort.Column", form.Sort.Column);
                request.AddParameter("Take", form.Take);
                request.AddParameter("Sort.Type", form.Sort.Type);
                request.AddParameter("Offset", form.Offset);
                request.AddParameter("Search", form.Search);

                var response = client.Execute<MAirPort.Root>(request);
                
                rb = response.Data;

                return rb;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
