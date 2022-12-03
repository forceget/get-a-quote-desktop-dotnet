using AirPort;
using Forceget.Apilibrary;
using RestSharp;
using SimpleDeveloper.InAndOutModel;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

namespace Port
{
    public class RPort : IPort
    {

        public MPort.Root MultipleGet(MPort.FilterForm form)
        {
            MPort.Root rb = new MPort.Root();
            try
            {
                var request = new RestRequest(Method.POST);
                request.AddParameter("Sort.Column", form.Sort.Column);
                request.AddParameter("Take", form.Take);
                request.AddParameter("Sort.Type", form.Sort.Type);
                request.AddParameter("Offset", form.Offset);
                request.AddParameter("Search", form.Search);


                var response = RNetworkingOperation.Post<MPort.Root>("https://localhost:44392/api/Port/MultipleGet", request);

                return response;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
