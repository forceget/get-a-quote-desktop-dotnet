using Forceget.Apilibrary;
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
using Parameter = RestSharp.Parameter;

namespace Token
{
    public class RToken
    {
        public static string Token { get; set; }

        public static MToken.Root Login(MToken.FilterForm form)
        {
            MToken.Root rb = new MToken.Root();
            try
            {
                var request = new RestRequest(Method.POST);
                request.AddParameter("Email", form.Email);
                request.AddParameter("Password", form.PasswordHash);

                var response = RNetworkingOperation.Post<MToken.Root>("https://localhost:44392/api/User/Token", request);
                Token = response.item.token;
                rb = response;
                return rb;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
