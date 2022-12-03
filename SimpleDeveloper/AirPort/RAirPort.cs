using Forceget.Apilibrary;
using RestSharp;
using System;

namespace AirPort
{
    public class RAirPort : IAirPort
    {

        public MAirPort.Root MultipleGet(MAirPort.FilterForm form)
        {
            MAirPort.Root rb = new MAirPort.Root();
            try
            {
                var request = new RestRequest(Method.POST);
                request.AddParameter("Sort.Column", form.Sort.Column);
                request.AddParameter("Take", form.Take);
                request.AddParameter("Sort.Type", form.Sort.Type);
                request.AddParameter("Offset", form.Offset);
                request.AddParameter("Search", form.Search);

                var response = RNetworkingOperation.Post<MAirPort.Root>("https://localhost:44392/api/AirPort/MultipleGet", request);

                return response;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
