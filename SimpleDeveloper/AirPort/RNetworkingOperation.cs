using RestSharp;
using Token;

namespace Forceget.Apilibrary
{
    public static class RNetworkingOperation
    {
        public static T Post<T>(string url, IRestRequest request)
        {
            var client = new RestClient(url);
            request.Method = Method.POST;
            request.AddHeader("accept", "*/*");
            request.AlwaysMultipartFormData = true;

            if (!string.IsNullOrEmpty(RToken.Token))
            {
                request.AddHeader("Authorization", "Bearer " + RToken.Token);
            }

            var result = client.Execute<T>(request);
            return result.Data;
        }

        public static T Get<T>(string url, IRestRequest request)
        {
            var client = new RestClient(url);
            request.Method = Method.GET;
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
