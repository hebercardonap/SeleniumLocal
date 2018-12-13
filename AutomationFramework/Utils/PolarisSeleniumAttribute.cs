using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Utils
{
    public class PolarisSeleniumAttribute
    {
        private static string SELENIUM_ATTRIBUTE = "data-slnm-attr";
        private static By selector;

        public static By PolarisSeleniumSelector(string attributeValue)
        {
            selector = By.XPath(String.Format("//*[@{0} = '{1}']", SELENIUM_ATTRIBUTE, attributeValue));
            return selector;
        }
    }
}
