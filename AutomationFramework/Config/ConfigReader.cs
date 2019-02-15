using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;
using AutomationFramework.Base;

namespace AutomationFramework.Config
{
    public class ConfigReader
    {
        private static string ENVIRONMENT = "Environment";
        private static string BROWSER_LOCALE = "locale";
        private static string RETRY_COUNT = "retryCount";
        private static string CONFIG_URL_TEMPLATE = "URL/{0}";


        public static void setFrameworkSettings()
        {
            Settings.Environment = ConfigurationManager.AppSettings[ENVIRONMENT].ToString() ?? "QA";
            Settings.IsLog = ConfigurationManager.AppSettings["isLog"].ToString() ?? "Y";
            Settings.LogPath = ConfigurationManager.AppSettings["logPath"].ToString();
            Settings.BrowserType = (BrowserType)Enum.Parse(typeof(BrowserType), ConfigurationManager.AppSettings["browser"]);
            Settings.Browser = ConfigurationManager.AppSettings["browser"];
            Settings.RetryCount = Convert.ToInt32(ConfigurationManager.AppSettings["retryCount"]);
        }
        public static string getEnvironment()
        {
            return ConfigurationManager.AppSettings[ENVIRONMENT].ToString() ?? "QA";
        }
        
        public static string getBrowserLocale()
        {
            return ConfigurationManager.AppSettings[BROWSER_LOCALE].ToString() ?? "en-us";
        }

        public static string getBaseUrl(string brand)
        {
            string url = string.Empty;
            var confManagerSettings = ConfigurationManager.GetSection(string.Format(CONFIG_URL_TEMPLATE, getEnvironment())) as NameValueCollection;
            return confManagerSettings[brand].ToString();
        }
    }
}
