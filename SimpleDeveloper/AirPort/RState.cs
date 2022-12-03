using City;
using Country;
using Forceget.Apilibrary;
using RestSharp;
using SimpleDeveloper.InAndOutModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace State
{
    public class RState : IState
    {

        public MState.Root MultipleGet(MState.FilterForm form)
        {
            MState.Root rb = new MState.Root();
            try
            {
                var request = new RestRequest(Method.POST);
                request.AddParameter("Sort.Column", form.Sort.Column);
                request.AddParameter("Take", form.Take);
                request.AddParameter("Sort.Type", form.Sort.Type);
                request.AddParameter("Offset", form.Offset);
                request.AddParameter("Search", form.Search);

                var response = RNetworkingOperation.Post<MState.Root>("https://localhost:44392/api/State/MultipleGet", request);

                return response;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
