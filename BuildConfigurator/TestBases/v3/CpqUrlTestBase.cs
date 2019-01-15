using AutomationFramework.Base;
using AutomationFramework.UrlBuilderSites;
using AutomationFramework.Utils;
using BuildConfigurator.Pages.v3;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.TestBases
{
    public class CpqUrlTestBase : BasePage
    {
        private static string BUILD_TRIM_URL_PART = "/build-trim/";
        private static string BUILD_COLOR_URL_PART = "/build-color/";
        private static string BUILD_PACKAGE_PAGE = "/build-package/";
        private static string BUILD_URL_PART = "/build/";
        private static string SLASH = "/";
        private static string TEST_DEALER_PART_ID = "?dealerid=02040900";

        public CpqUrlTestBase(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        /// <summary>
        /// To navigate to models page by brand
        /// </summary>
        /// <param name="brandName"></param>
        public void NavigateToModelsPage(string brandName)
        {
            if (stringEqualsIgnoreCase(brandName, Brand.RAN))
            {
                GoToUrl(UrlBuilder.getRangerBuildModelUrl());
                _parallelConfig.CurrentPage = new ModelsPage(_parallelConfig);
            }
            else
                Assert.Fail("Brand {0} not supported", brandName);
        }

        /// <summary>
        /// To navigate to trims page for specific brand/model
        /// </summary>
        /// <param name="brand">RZR, RAN, ...</param>
        /// <param name="model">rzr-570, ranger-500, ...</param>
        public void NavigateToTrimsPage(string brand, string model)
        {
            if (stringEqualsIgnoreCase(Brand.RAN, brand))
            {
                string url = string.Concat(UrlBuilder.GetRangerBrandHomePage(), model, BUILD_TRIM_URL_PART);
                GoToUrl(url);
            }
            else
                Assert.Fail("Band {0} or model {1} is not supported", brand, model);
        }

        /// <summary>
        /// To navigate to colors page for specific brand/model
        /// </summary>
        /// <param name="brand">RZR, RAN, ...</param>
        /// <param name="model">rzr-570, ranger-500, ...</param>
        public void NavigateToColorsPage(string brand, string model)
        {
            if (stringEqualsIgnoreCase(Brand.RAN, brand))
            {
                string url = string.Concat(UrlBuilder.GetRangerBrandHomePage(), model, BUILD_COLOR_URL_PART);
                GoToUrl(url);
            }
            else
                Assert.Fail("Band {0} or model {1} is not supported", brand, model);
        }

        /// <summary>
        /// To navigate to packages page for specific brand/model
        /// </summary>
        /// <param name="brand">RZR, RAN, ...</param>
        /// <param name="model">rzr-570, ranger-500, ...</param>
        public void NavigateToPackagesPage(string brand, string model)
        {
            if (stringEqualsIgnoreCase(Brand.RAN, brand))
            {
                string url = string.Concat(UrlBuilder.GetRangerBrandHomePage(), model, BUILD_PACKAGE_PAGE);
                GoToUrl(url);
            }
            else
                Assert.Fail("Band {0} or model {1} is not supported", brand, model);
        }

        /// <summary>
        /// To navigate to Accessories page for specific brand/model
        /// </summary>
        /// <param name="brand">RZR, RAN, ...</param>
        /// <param name="model">rzr-570, ranger-500, ...</param>
        public void NavigateToAccessoriesPage(string brand, string model)
        {
            if (stringEqualsIgnoreCase(brand, Brand.IND))
            {
                string buildUrl = string.Concat(UrlBuilder.getIndianLandingPageURL(), model, BUILD_URL_PART);
                GoToUrl(buildUrl);
            }
            else if (stringEqualsIgnoreCase(brand, Brand.ATV))
            {
                string buildUrl = string.Concat(UrlBuilder.getSportsmanLandingPageURL(), model, BUILD_URL_PART);
                GoToUrl(buildUrl);
            }
            else if (stringEqualsIgnoreCase(brand, Brand.SLG))
            {
                string buildUrl = string.Concat(UrlBuilder.getSlgLandingPageURL(), model, BUILD_URL_PART);
                GoToUrl(buildUrl);
            }
            else if (stringEqualsIgnoreCase(brand, Brand.GEN))
            {
                string buildUrl = string.Concat(UrlBuilder.getGeneralLandingPageURL(), model, BUILD_URL_PART);
                GoToUrl(buildUrl);
            }
            else if (stringEqualsIgnoreCase(brand, Brand.ACE))
            {
                string buildUrl = string.Concat(UrlBuilder.getAceLandingPageURL(), model, BUILD_URL_PART);
                GoToUrl(buildUrl);
            }
            else if (stringEqualsIgnoreCase(brand, Brand.RZR))
            {
                string buildUrl = string.Concat(UrlBuilder.getRzrLandingPageURL(), model, BUILD_URL_PART);
                GoToUrl(buildUrl);
            }
            else if (stringEqualsIgnoreCase(brand, Brand.SNO))
            {
                string buildUrl = string.Concat(UrlBuilder.getSnoLandingPageURL(), model, BUILD_URL_PART);
                GoToUrl(buildUrl);
            }
            else if (stringEqualsIgnoreCase(brand, Brand.RAN))
            {
                string buildUrl = string.Concat(UrlBuilder.getRangerLandingPageURL(), model, BUILD_URL_PART);
                GoToUrl(buildUrl);
            }
            else if (stringEqualsIgnoreCase(brand, Brand.GEM))
            {
                string buildUrl = string.Concat(UrlBuilder.getGemLandingPageURL(), model, BUILD_URL_PART);
                GoToUrl(buildUrl);
            }
            else
                Assert.Fail("Brand {0} not supported", brand);
        }

        public void NavigateToBrandDealerExpUrl(string brand, string model)
        {
            if (stringEqualsIgnoreCase(brand, Brand.RAN))
            {
                string url = string.Concat(UrlBuilder.getRangerLandingPageURL(), model, BUILD_URL_PART, TEST_DEALER_PART_ID);
                GoToUrl(url);
            }
            else if (stringEqualsIgnoreCase(brand, Brand.RZR))
            {
                string url = string.Concat(UrlBuilder.getRzrLandingPageURL(), model, BUILD_URL_PART, TEST_DEALER_PART_ID);
                GoToUrl(url);
            }
            else
                Assert.Fail("Brand {0} not supported", brand);
        }

    }
}
