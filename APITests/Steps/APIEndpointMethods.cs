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
                RestAPIHelper.SetUrl(string.Concat(UrlBuilder.getRangerLandingPageURL(), string.Format(EndpointString.DEALER_EXPERIENCE_ENDPOINT, year, dealerid)));
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.ACE))
            {
                RestAPIHelper.SetUrl(string.Concat(UrlBuilder.getAceLandingPageURL(), string.Format(EndpointString.DEALER_EXPERIENCE_ENDPOINT, year, dealerid)));
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.GEN))
            {
                RestAPIHelper.SetUrl(string.Concat(UrlBuilder.getGeneralLandingPageURL(), string.Format(EndpointString.DEALER_EXPERIENCE_ENDPOINT, year, dealerid)));
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.ATV))
            {
                RestAPIHelper.SetUrl(string.Concat(UrlBuilder.getSportsmanLandingPageURL(), string.Format(EndpointString.DEALER_EXPERIENCE_ENDPOINT, year, dealerid)));
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
            Assert.AreEqual(statusCode, (int)RestAPIHelper.GetResponse().StatusCode);
        }

        [Then(@"Response property values are as expected for (.*) brand")]
        public void ThenResponsePropertyValuesAreAsExpected(string brandName)
        {
            string url = string.Empty;
            if (stringEqualsIgnoreCase(brandName, Brand.RZR))
                url = UrlBuilder.getRzrLandingPageURL();
            else if (stringEqualsIgnoreCase(brandName, Brand.RAN))
                url = UrlBuilder.getRangerLandingPageURL();
            else if (stringEqualsIgnoreCase(brandName, Brand.ATV))
                url = UrlBuilder.getSportsmanLandingPageURL();
            else if (stringEqualsIgnoreCase(brandName, Brand.ACE))
                url = UrlBuilder.getAceLandingPageURL();
            else if (stringEqualsIgnoreCase(brandName, Brand.GEN))
                url = UrlBuilder.getGeneralLandingPageURL();
            else
                Assert.Fail("Brand {0} not suported", brandName);

            var deserialized = SimpleJson.SimpleJson.DeserializeObject<List<Variant>>(RestAPIHelper.GetResponse().Content);
            for (int i = 0; i < deserialized.Count; i++)
            {
                Assert.IsTrue(deserialized[i].OverviewPageURL.Contains(url));
                Assert.IsTrue(deserialized[i].WholegoodImageUrl.Contains(url));
                Assert.IsTrue(deserialized[i].ColorSwatchImageUrl.Contains(url));
                Assert.IsTrue(deserialized[i].ImagePath.Contains(url));
                Assert.IsTrue(deserialized[i].ColorThumbnailPath.Contains(url));
                Assert.IsTrue(deserialized[i].BuildURL.Contains(url));
            }
        }

    }
}
