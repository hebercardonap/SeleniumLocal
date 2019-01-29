using AutomationFramework.Helpers;
using AutomationFramework.UrlBuilderSites;
using AutomationFramework.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.ApiUtils.EndpointBuilder
{
    public static class CPQEndpointBuilder
    {
        public static string DEALER_EXPERIENCE_ENDPOINT = "api/dealer-configurator/getAllModels?year={0}&dealerid={1}";

        public static string GetDealerExpModelsEnpointByBrandYear(string brand, string year, string dealerid)
        {
            string enpointString = string.Empty;

            if (StringCompare.stringEqualsIgnoreCase(brand, Brand.RZR))
            {
                enpointString = string.Concat(UrlBuilder.getRzrLandingPageURL(), string.Format(DEALER_EXPERIENCE_ENDPOINT, year, dealerid));
            }
            else if (StringCompare.stringEqualsIgnoreCase(brand, Brand.RAN))
            {
                enpointString = string.Concat(UrlBuilder.getRangerLandingPageURL(), string.Format(DEALER_EXPERIENCE_ENDPOINT, year, dealerid));
            }
            else if (StringCompare.stringEqualsIgnoreCase(brand, Brand.ATV))
            {
                enpointString = string.Concat(UrlBuilder.getSportsmanLandingPageURL(), string.Format(DEALER_EXPERIENCE_ENDPOINT, year, dealerid));
            }
            else if (StringCompare.stringEqualsIgnoreCase(brand, Brand.ACE))
            {
                enpointString = string.Concat(UrlBuilder.getAceLandingPageURL(), string.Format(DEALER_EXPERIENCE_ENDPOINT, year, dealerid));
            }
            else if (StringCompare.stringEqualsIgnoreCase(brand, Brand.GEN))
            {
                enpointString = string.Concat(UrlBuilder.getGeneralLandingPageURL(), string.Format(DEALER_EXPERIENCE_ENDPOINT, year, dealerid));
            }
            else if (StringCompare.stringEqualsIgnoreCase(brand, Brand.IND))
            {
                enpointString = string.Concat(UrlBuilder.getIndianLandingPageURL(), string.Format(DEALER_EXPERIENCE_ENDPOINT, year, dealerid));
            }
            else if (StringCompare.stringEqualsIgnoreCase(brand, Brand.SLG))
            {
                enpointString = string.Concat(UrlBuilder.getSlgLandingPageURL(), string.Format(DEALER_EXPERIENCE_ENDPOINT, year, dealerid));
            }
            else if (StringCompare.stringEqualsIgnoreCase(brand, Brand.SNO))
            {
                enpointString = string.Concat(UrlBuilder.getSnoLandingPageURL(), string.Format(DEALER_EXPERIENCE_ENDPOINT, year, dealerid));
            }
            else if (StringCompare.stringEqualsIgnoreCase(brand, Brand.GEM))
            {
                enpointString = string.Concat(UrlBuilder.getGemLandingPageURL(), string.Format(DEALER_EXPERIENCE_ENDPOINT, year, dealerid));
            }

            return enpointString;
        }
    }
}
