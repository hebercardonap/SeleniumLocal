using AutomationFramework.Config;
using AutomationFramework.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.UrlBuilderSites
{
    public class UrlBuilder : ConfigReader
    {
        private static string BUILD_MODEL_URL_PART = "/build-model/";
        private static string BUILD_CATEGORY_URL_PART = "/build-category/";
        private static string NUMBER_SIGN = "#";
        private static string SLASH = "/";

        public static string getRzrLandingPageURL()
        {
            return string.Concat(getBaseUrl(Brand.RZR), getBrowserLocale(), SLASH);
        }

        public static string getSnoLandingPageURL()
        {
            return string.Concat(getBaseUrl(Brand.SNO), getBrowserLocale(), SLASH);
        }

        public static string getIndianLandingPageURL()
        {
            return string.Concat(getBaseUrl(Brand.IND), getBrowserLocale(), SLASH);
        }

        public static string getMilitaryLandingPageURL()
        {
            return string.Concat(getBaseUrl(Brand.MIL), getBrowserLocale(), SLASH);
        }

        public static string getSlgLandingPageURL()
        {
            return string.Concat(getBaseUrl(Brand.SLG), getBrowserLocale(), SLASH);
        }

        public static string getGemLandingPageURL()
        {
            return string.Concat(getBaseUrl(Brand.GEM), getBrowserLocale(), SLASH);
        }

        public static string getCommercialLandingPageURL()
        {
            return string.Concat(getBaseUrl(Brand.CMV), getBrowserLocale(), SLASH);
        }

        public static string getSportsmanLandingPageURL()
        {
            return string.Concat(getBaseUrl(Brand.ATV), getBrowserLocale(), SLASH);
        }

        public static string getAceLandingPageURL()
        {
            return string.Concat(getBaseUrl(Brand.ACE), getBrowserLocale(), SLASH);
        }

        public static string getRangerLandingPageURL()
        {
            return string.Concat(getBaseUrl(Brand.RAN), getBrowserLocale(), SLASH);
        }

        public static string getGeneralLandingPageURL()
        {
            return string.Concat(getBaseUrl(Brand.GEN), getBrowserLocale(), SLASH);
        }

        public static string getRzrBuildModelUrl()
        {
            return string.Concat(getBaseUrl(Brand.RZR), getBrowserLocale(), BUILD_MODEL_URL_PART);
        }

        public static string getIndianBuildModelUrl()
        {
            return string.Concat(getBaseUrl(Brand.IND), getBrowserLocale(), BUILD_MODEL_URL_PART);
        }

        public static string getGemBuildModelUrl()
        {
            return string.Concat(getBaseUrl(Brand.GEM), getBrowserLocale(), BUILD_MODEL_URL_PART);
        }

        public static string getSportsmanBuildModelUrl()
        {
            return string.Concat(getBaseUrl(Brand.ATV), getBrowserLocale(), BUILD_MODEL_URL_PART);
        }

        public static string getAceBuildModelUrl()
        {
            return string.Concat(getBaseUrl(Brand.ACE), getBrowserLocale(), BUILD_MODEL_URL_PART);
        }

        public static string getGeneralBuildModelUrl()
        {
            return string.Concat(getBaseUrl(Brand.GEN), getBrowserLocale(), BUILD_MODEL_URL_PART);
        }

        public static string getRangerBuildModelUrl()
        {
            return string.Concat(getBaseUrl(Brand.RAN), getBrowserLocale(), BUILD_MODEL_URL_PART);
        }

        public static string getSlingshotBuildModelUrl()
        {
            return string.Concat(getBaseUrl(Brand.SLG), getBrowserLocale(), BUILD_MODEL_URL_PART);
        }

        public static string getIndianBuildCategoryUrl()
        {
            return string.Concat(getBaseUrl(Brand.IND), getBrowserLocale(), BUILD_CATEGORY_URL_PART);
        }

        public static string getSnowBuildModelUrl()
        {
            return string.Concat(getBaseUrl(Brand.SNO), getBrowserLocale(), BUILD_MODEL_URL_PART);
        }

        public static string GetRangerBrandHomePage()
        {
            return string.Concat(getBaseUrl(Brand.RAN), getBrowserLocale(), "/");
        }

        public static string GetBuildCategoryUrl(string brand)
        {
            return string.Concat(getBaseUrl(brand), getBrowserLocale(), BUILD_CATEGORY_URL_PART);
        }
    }
}
