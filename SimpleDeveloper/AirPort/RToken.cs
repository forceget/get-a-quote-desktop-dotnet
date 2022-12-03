using Forceget.Apilibrary;
using RestSharp;
using System;

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
