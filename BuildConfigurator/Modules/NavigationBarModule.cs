using AutomationFramework.Base;
using AutomationFramework.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Modules
{
    public class NavigationBarModule : BasePage
    {
        private static By BY_NAVIGATION_BAR = By.XPath("//section[@class='cpq-title-nav']");
        private static By BY_NAV_ACCESSORIES = PolarisSeleniumAttribute.PolarisSeleniumSelector("Accessories");
        private static By BY_NAV_COLOR = PolarisSeleniumAttribute.PolarisSeleniumSelector("Color");
        private static By BY_NAV_TRIM= PolarisSeleniumAttribute.PolarisSeleniumSelector("Trim");
        private static By BY_NAV_MODELS = PolarisSeleniumAttribute.PolarisSeleniumSelector("Models");
        private static By BY_NAV_PACKAGES = PolarisSeleniumAttribute.PolarisSeleniumSelector("Packages");
        public NavigationBarModule(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public void WaitForNavigationBarToLoad()
        {
            DriverActions.waitForElementVisibleAndEnabled(BY_NAVIGATION_BAR);
        }

        public void ClickAccessoriesNavigation()
        {
            DriverActions.clickElement(BY_NAV_ACCESSORIES);
        }

        public void ClickPackagesNavigation()
        {
            DriverActions.clickElement(BY_NAV_PACKAGES);
        }

        public void ClickColorNavigation()
        {
            DriverActions.clickElement(BY_NAV_COLOR);
        }

        public void ClickTrimNavigation()
        {
            DriverActions.clickElement(BY_NAV_TRIM);
        }

        public void ClickModelsNavigation()
        {
            DriverActions.clickElement(BY_NAV_MODELS);
        }
    }
}
