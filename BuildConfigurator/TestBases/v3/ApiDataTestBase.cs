using AutomationFramework.ApiUtils.ApiDataProvider;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.TestBases.v3
{
    public class ApiDataTestBase : ApiDataProvider
    {
        Random rnd = new Random();
        public string GetRandomModelColorFromApi(string brand, string year, string dealerid)
        {
            var allModels = GetAllModelsColorApiResponse(brand, year, dealerid);
            Assert.IsNotNull(allModels, "ModelColors collection is empty");
            return allModels[rnd.Next(0, allModels.Count)];
        }

        public List<string> GetAllModelsColorsFromApi(string brand, string year, string dealerid)
        {
            List<string> allModelColors = GetModelsColorByBrandYear(brand, year, dealerid);
            Assert.IsNotNull(allModelColors, "ModelColors collection is empty");

            return allModelColors;
        }

        public List<string> GetOneModelsColorsEachCategoryFromApi(string brand, string year, string dealerid)
        {
            List<string> allModelColors = GetOneModelColorFromEachCategoryApi(brand, year, dealerid);
            Assert.IsNotNull(allModelColors, "ModelColors collection is empty");

            return allModelColors;
        }

        public string GetBuildUrlFromApi(string brand, string year, string dealerid)
        {
            string buildUrls = GetAllBuildUrls(brand, year, dealerid);
            string buildUrlsString = string.Empty;
            return buildUrls;
        }
    }
}
