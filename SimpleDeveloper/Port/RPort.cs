using Nest;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

namespace Port
{
    public class RPort : IPort
    {
        public ResponseBase<MPort.Response> Add(MPort form, string currentUserId)
        {
            throw new NotImplementedException();
        }

        public ResponseBase<string> Delete(string id, string currentUserId)
        {
            throw new NotImplementedException();
        }
        public ResponseBase<string> Delete(MPort.FilterForm form, string currentUserId)
        {
            throw new NotImplementedException();
        }

        public ResponseBase<List<MPort.Response>> MultipleGet(MPort.FilterForm form)
        {
            ResponseBase<List<MPort.Response>> rb = new ResponseBase<List<MPort.Response>>();
            try
            {
                form.Search = form.Search?.ToLower();

                var client = new RestClient("https://localhost:44392/api/Port/MultipleGet");
                var request = new RestRequest(Method.POST);
                request.AddHeader("Authorization", "Bearer " + "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiJiNDhjMjk0ZS01ODdjLTQ2YjUtOTk5ZC00NjQ3MDgwY2YzM2EiLCJqdGkiOiIyMWM3YWE3Mi00ZGQ0LTRkYTMtYTExOS1lMzJjNzAyYzc4MzAiLCJuYmYiOjE2Njg4NDk5NDIsImV4cCI6MTY3MTQ0MTk0MiwiaXNzIjoiaHR0cHM6Ly9mb3JjZWdldC5jb20vIiwiYXVkIjoiZGV2In0.wb5OGXbVHy6m2038VUaCtcAnWwjS4ftT2eD89VuOxLU");
                request.AddParameter("Sort.Column", form.Sort.Column);
                request.AddParameter("Take", form.Take);
                request.AddParameter("Sort.Type", form.Sort.Type);
                request.AddParameter("Offset", form.Offset);

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

        public ResponseBase<MPort.Response> SingleGet(string id, string currentUserId)
        {
            throw new NotImplementedException();
        }

        public ResponseBase<MPort.Response> Update(MPort form, string currentUserId)
        {
            throw new NotImplementedException();
        }
    }
}
