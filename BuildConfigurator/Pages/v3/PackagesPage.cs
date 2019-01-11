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
        private static By BY_ACCESSORIES_PACKAGES = PolarisSeleniumAttribute.PolarisSeleniumSelector("buildAccessoryProduct");
        private static By BY_CHILD_ADD_BUTTON = By.XPath(".//button[@data-slnm-attr='productCTA']");
        private static By BY_WHOLEGOOD_MODEL_ID = By.XPath("//div[@class='summary-vehicle-modelId']");

        private static Random rnd = new Random();
        public HeaderModule HeaderModule { get { return new HeaderModule(_parallelConfig); } }

        public CalculatorModule CalculatorModule { get { return new CalculatorModule(_parallelConfig); } }

        public FooterModule FooterModule { get { return new FooterModule(_parallelConfig); } }

        public Toolbar Toolbar { get { return new Toolbar(_parallelConfig); } }


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

        public void AddRandomAvailablePackage()
        {
            List<IWebElement> packages = Driver.FindElements(BY_ACCESSORIES_PACKAGES).ToList();
            IWebElement addButton = packages[rnd.Next(0, packages.Count)].FindElement(BY_CHILD_ADD_BUTTON);
            DriverActions.clickElement(addButton);
        }

        public string GetWholegoodModelId()
        {
            string model = Driver.FindElement(BY_WHOLEGOOD_MODEL_ID).GetAttribute("innerHTML").Trim();
            return model;
        }
    }
}
