using RestSharp;

namespace AutomationFramework.ApiUtils.Helpers
{
    public class RestAPIHelper
    {
        public RestClient client;
        public RestRequest restRequest;

        public RestClient SetUrl(string endpoint)
        {
            return client = new RestClient(endpoint);
        }

        public RestRequest CreateGetRequest()
        {
            restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("Postman-Token", "e2dfeeaa-51a3-45e0-ab5c-69c4199a503e");
            restRequest.AddHeader("Cache-Control", "no-cache");
            restRequest.AddHeader("Referer", "http://polaris-cpq-test.com/");
            return restRequest;
        }

        public IRestResponse GetResponse()
        {
            return client.Execute(restRequest);
        }
    }
}
