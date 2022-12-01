using Port;
using RestSharp;
using SimpleDeveloper.InAndOutModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Country
{
    public class RCountry : ICountry
    {

        public ResponseBase<List<MCountry.Root>> MultipleGet(MCountry.FilterForm form)
        {
            ResponseBase<List<MCountry.Root>> rb = new ResponseBase<List<MCountry.Root>>();
            try
            {
                var client = new RestClient("https://localhost:44392/api/Country/MultipleGet");
                var request = new RestRequest(Method.POST);
                request.AddHeader("Authorization", "Bearer " + "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiJiNDhjMjk0ZS01ODdjLTQ2YjUtOTk5ZC00NjQ3MDgwY2YzM2EiLCJqdGkiOiIyMWM3YWE3Mi00ZGQ0LTRkYTMtYTExOS1lMzJjNzAyYzc4MzAiLCJuYmYiOjE2Njg4NDk5NDIsImV4cCI6MTY3MTQ0MTk0MiwiaXNzIjoiaHR0cHM6Ly9mb3JjZWdldC5jb20vIiwiYXVkIjoiZGV2In0.wb5OGXbVHy6m2038VUaCtcAnWwjS4ftT2eD89VuOxLU");
                request.AddParameter("Sort.Column", form.Sort.Column);
                request.AddParameter("Take", form.Take);
                request.AddParameter("Sort.Type", form.Sort.Type);
                request.AddParameter("Offset", form.Offset);
                request.AddParameter("Search", form.Search);

                var response = client.Execute<MCountry.Root>(request);
                var data = response.Data.item.Select(x => x.name).ToList();
                rb.Item = data.ToList();

                return rb;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
