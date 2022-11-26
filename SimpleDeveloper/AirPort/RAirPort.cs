using RestSharp;
using SimpleDeveloper.InAndOutModel;
using System;
using System.Collections.Generic;

namespace AirPort
{
    public class RAirPort : IAirPort
    {

        public ResponseBase<List<MAirPort.Response>> MultipleGet(MAirPort.FilterForm form)
        {
            ResponseBase<List<MAirPort.Response>> rb = new ResponseBase<List<MAirPort.Response>>();
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

                IRestResponse response = client.Execute(request);
                var data = response.Content;
                rb.Item = data;

                return rb;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
