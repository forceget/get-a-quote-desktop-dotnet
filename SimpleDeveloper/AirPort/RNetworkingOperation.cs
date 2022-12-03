using RestSharp;
using Token;

namespace Forceget.Apilibrary
{
    public static class RNetworkingOperation
    {
        public static T Post<T>(string url, IRestRequest request)
        {
            var client = new RestClient(url);
            request.AddHeader("accept", "*/*");
            request.AlwaysMultipartFormData = true;

            if (!string.IsNullOrEmpty(RToken.Token))
            {
                request.AddHeader("Authorization", "Bearer " + RToken.Token);
            }

            var result = client.Execute<T>(request);
            return result.Data;
        }
    }
}
