using APITests.Contracts;
using APITests.Endpoints;
using APITests.Helpers;
using AutomationFramework.Base;
using AutomationFramework.UrlBuilderSites;
using AutomationFramework.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace APITests.Steps
{
    [Binding]
    public class APIEndpointMethods : BasePage
    {
        [Given(@"I have DEX (.*) endpoint with year (.*) and dealer (.*)")]
        public void GivenIHaveEndpoint(string brandName, string year, string dealerid)
        {
            if (stringEqualsIgnoreCase(brandName, Brand.RZR))
            {
                RestAPIHelper.SetUrl(string.Concat(UrlBuilder.getRzrLandingPageURL(), string.Format(EndpointString.DEALER_EXPERIENCE_ENDPOINT, year, dealerid)));
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.RAN))
            {
                RestAPIHelper.SetUrl(Path.Combine(UrlBuilder.getRangerLandingPageURL(), string.Format(EndpointString.DEALER_EXPERIENCE_ENDPOINT, year, dealerid)));
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.ACE))
            {
                RestAPIHelper.SetUrl(Path.Combine(UrlBuilder.getAceLandingPageURL(), string.Format(EndpointString.DEALER_EXPERIENCE_ENDPOINT, year, dealerid)));
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.GEN))
            {
                RestAPIHelper.SetUrl(Path.Combine(UrlBuilder.getGeneralLandingPageURL(), string.Format(EndpointString.DEALER_EXPERIENCE_ENDPOINT, year, dealerid)));
            }
            else
            {
                Assert.Fail("Specified brand {0} not found", brandName);
            }
            
        }

        [When(@"I call GET method")]
        public void WhenICallGETMethod()
        {
            RestAPIHelper.CreateGetRequest();
        }

        [Then(@"API response code is (.*)")]
        [When(@"API response code is (.*)")]
        public void ThenAPIResponseIsAsExpected(int statusCode)
        {
            Assert.AreEqual((int)RestAPIHelper.GetResponse().StatusCode, statusCode);
        }

        [Then(@"Response property values are as expected")]
        public void ThenResponsePropertyValuesAreAsExpected()
        {
            var deserialized = SimpleJson.SimpleJson.DeserializeObject<List<Variant>>(RestAPIHelper.GetResponse().Content);
            for (int i = 0; i < deserialized.Count; i++)
            {
                Assert.IsTrue(deserialized[i].OverviewPageURL.Contains(UrlBuilder.getRzrLandingPageURL()));
                Assert.IsTrue(deserialized[i].WholegoodImageUrl.Contains(UrlBuilder.getRzrLandingPageURL()));
                Assert.IsTrue(deserialized[i].ColorSwatchImageUrl.Contains(UrlBuilder.getRzrLandingPageURL()));
                Assert.IsTrue(deserialized[i].ImagePath.Contains(UrlBuilder.getRzrLandingPageURL()));
                Assert.IsTrue(deserialized[i].ColorThumbnailPath.Contains(UrlBuilder.getRzrLandingPageURL()));
                Assert.IsTrue(deserialized[i].BuildURL.Contains(UrlBuilder.getRzrLandingPageURL()));
            }
        }

        private dynamic test(string jsonString)
        {
            var myObj = (dynamic)JsonConvert.DeserializeObject(jsonString);
            return myObj;
        }

    }
}
