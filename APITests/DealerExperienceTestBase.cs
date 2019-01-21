using APITests.Contracts;
using APITests.Endpoints;
using APITests.Helpers;
using AutomationFramework.Base;
using AutomationFramework.UrlBuilderSites;
using AutomationFramework.Utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITests
{
    public class DealerExperienceTestBase : ApiBasePage
    {
        public void SetDealerExperienceBrandUrl(string brandName, string year, string dealerid)
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

        public void CreateGetRequest()
        {
            RestAPIHelper.CreateGetRequest();
        }

        public int GetResponseStatusCode()
        {
            return (int)RestAPIHelper.GetResponse().StatusCode;
        }

        public void ResponsePropertyValuesAsExpected(string brand)
        {
            string url = string.Empty;
            if (stringEqualsIgnoreCase(brand, Brand.RZR))
                url = UrlBuilder.getRzrLandingPageURL();
            else if (stringEqualsIgnoreCase(brand, Brand.RAN))
                url = UrlBuilder.getRangerLandingPageURL();
            else if (stringEqualsIgnoreCase(brand, Brand.ATV))
                url = UrlBuilder.getSportsmanLandingPageURL();
            else if (stringEqualsIgnoreCase(brand, Brand.ACE))
                url = UrlBuilder.getAceLandingPageURL();
            else if (stringEqualsIgnoreCase(brand, Brand.GEN))
                url = UrlBuilder.getGeneralLandingPageURL();
            else
                Assert.Fail("Brand {0} not suported", brand);

            var deserialized = SimpleJson.SimpleJson.DeserializeObject<List<Variant>>(RestAPIHelper.GetResponse().Content);
            for (int i = 0; i < deserialized.Count; i++)
            {
                //Assert.IsTrue(deserialized[i].OverviewPageURL.Contains(url)); Removing this validation as Reflect is not using this for now
                Assert.IsTrue(deserialized[i].BuildURL.Contains(url));
            }
        }
    }
}
