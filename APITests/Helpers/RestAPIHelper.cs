using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITests.Helpers
{
    public static class RestAPIHelper
    {
        public static RestClient client;
        public static RestRequest restRequest;
        public static string baseUrl = "http://rzr-qa.polarisindcms.com/";

        public static RestClient SetUrl(string endpoint)
        {
            return client = new RestClient(endpoint);
        }

        public static RestRequest CreateGetRequest()
        {
            restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("Postman-Token", "e2dfeeaa-51a3-45e0-ab5c-69c4199a503e");
            restRequest.AddHeader("Cache-Control", "no-cache");
            return restRequest;
        }

        public static IRestResponse GetResponse()
        {
            return client.Execute(restRequest);
        }
    }
}
