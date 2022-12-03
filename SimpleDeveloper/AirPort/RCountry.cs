using AirPort;
using Forceget.Apilibrary;
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

        public MCountry.Root MultipleGet(MCountry.FilterForm form)
        {
            MCountry.Root rb = new MCountry.Root();
            try
            {
                var request = new RestRequest(Method.POST);
                request.AddParameter("Sort.Column", form.Sort.Column);
                request.AddParameter("Take", form.Take);
                request.AddParameter("Sort.Type", form.Sort.Type);
                request.AddParameter("Offset", form.Offset);
                request.AddParameter("Search", form.Search);

                var response = RNetworkingOperation.Post<MCountry.Root>("https://localhost:44392/api/Country/MultipleGet", request);

                return response;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
