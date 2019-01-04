using AutomationFramework.Base;
using AutomationFramework.Extensions;
using AutomationFramework.Utils;
using BuildConfigurator.Modules;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Pages
{
    public class PackagesPage : BasePage
    {
        private static By BY_INTERIOR_LINK = PolarisSeleniumAttribute.PolarisSeleniumSelector("viewInteriorLink");
        private static By BY_EXTERIOR_LINK = PolarisSeleniumAttribute.PolarisSeleniumSelector("viewExteriorLink");
        private static By BY_PACKAGE_CATEGORY_CONTAINER = PolarisSeleniumAttribute.PolarisSeleniumSelector("buildAccessoriesCategory");
        public HeaderModule HeaderModule { get { return new HeaderModule(_parallelConfig); } }

        public CalculatorModule CalculatorModule { get { return new CalculatorModule(_parallelConfig); } }

        public FooterModule FooterModule { get { return new FooterModule(_parallelConfig); } }
        public PackagesPage(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public bool IsExteriorLinkDisplayed()
        {
            return DriverActions.IsElementPresent(BY_EXTERIOR_LINK);
        }

        public bool IsInteriorLinkDisplayed()
        {
            return DriverActions.IsElementPresent(BY_INTERIOR_LINK);
        }

        public void WaitForPackagesPageToLoad()
        {
            WebDriverExtensions.WaitForPageLoaded(Driver);
            DriverActions.waitForElementVisibleAndEnabled(BY_PACKAGE_CATEGORY_CONTAINER);
        }
    }
}
