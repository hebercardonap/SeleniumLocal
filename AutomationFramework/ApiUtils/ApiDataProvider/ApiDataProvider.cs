using AutomationFramework.ApiUtils.Contracts;
using AutomationFramework.ApiUtils.EndpointBuilder;
using AutomationFramework.ApiUtils.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationFramework.ApiUtils.ApiDataProvider
{
    public class ApiDataProvider
    {
        private static readonly int API_SUCCESS_RESPONSE_CODE = 200;
        RestAPIHelper RestAPIHelper = new RestAPIHelper();

        public List<string> GetModelsColorByBrandYear(string brand, string year, string dealerid)
        {
            List<string> models = new List<string>();
            List<string> seoNames = GetAllModelsColorApiResponse(brand, year, dealerid);
            int modelsCount = seoNames.Count;
            if (modelsCount > 0)
            {
                for (int i = 0; i < modelsCount; i++)
                {
                    string partial = seoNames[i].Remove(seoNames[i].Length - 1);
                    string modelColorString = partial.Substring(partial.LastIndexOf("/") + 1);
                    models.Add(modelColorString);
                }
            }
            return models;
        }

        private List<string> GetAllModelsColorApiResponse(string brand, string year, string dealerid)
        {
            List<string> modelsSeoName = new List<string>();
            RestAPIHelper.SetUrl(CPQEndpointBuilder.GetDealerExpModelsEnpointByBrandYear(brand, year, dealerid));
            RestAPIHelper.CreateGetRequest();

            if (GetResponseStatusCode() == API_SUCCESS_RESPONSE_CODE)
            {
                var deserialized = SimpleJson.SimpleJson.DeserializeObject<List<Variant>>(RestAPIHelper.GetResponse().Content);

                for (int i = 0; i < deserialized.Count; i++)
                {
                    modelsSeoName.Add(deserialized[i].OverviewPageURL);
                }
            }

            return modelsSeoName;
        }

        private int GetResponseStatusCode()
        {
            int count = 0;
            int statusCode = (int)RestAPIHelper.GetResponse().StatusCode;
            while (statusCode == 0)
            {
                statusCode = (int)RestAPIHelper.GetResponse().StatusCode;
                Thread.Sleep(500);
                count++;

                if (count == 5)
                {
                    break;
                }
            }
            return statusCode;
        }
    }
}
