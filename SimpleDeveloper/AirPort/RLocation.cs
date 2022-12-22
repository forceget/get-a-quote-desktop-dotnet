using City;
using Forceget.Apilibrary;
using RestSharp;
using SimpleDeveloper.InAndOutModel;
using State;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Location
{
    public class RLocation : ILocation
    {

        public MLocation.Root MultipleGet(MLocation.FilterForm form)
        {
            MLocation.Root rb = new MLocation.Root();
            try
            {
                var request = new RestRequest(Method.POST);
                request.AddParameter("Sort.Column", form.Sort.Column);
                request.AddParameter("Take", form.Take);
                request.AddParameter("Sort.Type", form.Sort.Type);
                request.AddParameter("Offset", form.Offset);
                foreach (var item in form.LocationType)
                {
                    request.AddParameter("LocationTypes", item);
                }
                request.AddParameter("Search", form.Search);

                var response = RNetworkingOperation.Post<MLocation.Root>("https://localhost:44392/api/Location/Search", request);

                return response;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
