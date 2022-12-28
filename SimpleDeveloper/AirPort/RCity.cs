using AirPort;
using Country;
using Forceget.Apilibrary;
using RestSharp;
using SimpleDeveloper.InAndOutModel;
using State;
using System;
using System.Collections.Generic;
using System.Linq;

namespace City
{
    public class RCity 
    {

        public MCity.Root MultipleGet(MCity.FilterForm form)
        {
            MCity.Root rb = new MCity.Root();
            try
            {
                var request = new RestRequest(Method.POST);
                request.AddParameter("Sort.Column", form.Sort.Column);
                request.AddParameter("Take", form.Take);
                request.AddParameter("Sort.Type", form.Sort.Type);
                request.AddParameter("Offset", form.Offset);
                request.AddParameter("Search", form.Search);

                var response = RNetworkingOperation.Post<MCity.Root>(form.url + "/api/City/MultipleGet", request);

                return response;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
