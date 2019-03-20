using AutomationFramework.Base;
using AutomationFramework.Extensions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Pages.v3
{
    public class ConfirmationPage : BasePage
    {
        private static By BY_CONFIRMATION_MSG_CONTAINER = By.CssSelector("div[class~='form-confirmation-place-holder-block']");
        private static By BY_BUILD_SUMMARY_CONFIRMATION_HEADER = By.XPath("//*[contains(@class, 'form-confirmation-build-summary-header')]");
        private static By BY_BUILD_TOTAL_PRICE = By.XPath("//*[contains(@class, 'total-price')]");
        private static By BY_SUMMARY_ADDED_ACCESSORY = By.CssSelector("div[class~='product-name']");
        private static By BY_WHOLEGOOD_MODEL_ID = By.XPath("//div[@class='text-align-right pull-right font-size-sm split-right']");
        private static By BY_SUMMARY_PRINT_BUTTON = By.CssSelector("button[class~='summary-print']");
        private static By BY_ADDED_PACKAGES_CONTAINER = By.CssSelector("div[class='added-packages']");
        private static By BY_ADDED_PKG_TITLES = By.CssSelector("div[class='added-packages'] div[class='product-name-group']");
        private static By BY_PACKAGE_SUBPRODUCT_NAMES = By.CssSelector("div[class='added-packages'] div[class~='product-name']");
        private static By BY_OPTIONS_ACCESSORIES_SECTION = By.CssSelector("div[class~='added-accessories']");
        private static By BY_CONFIRMATION_MODEL_NAME = By.CssSelector("div div div[class~='border-bottom-sm'] h4");
        private static By BY_KIT_PACKAGE_ICON_ARROW = By.CssSelector("span[class~='product-name-group-icon']");
        private static By BY_GEM_SUMMARY_ACCESORY = By.CssSelector("div[class='quote-confirmation--build__summary-accessory-container'] div[class='quote-confirmation--build__summary-accessory']");
        private static By BY_BUILD_SUMMARY_TOGGLE = By.XPath("//div[@class='quote-confirmation--build__summary-toggle-icon']");

        public ConfirmationPage(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public void WaitUntilConfirmationPageLoads()
        {
            WebDriverExtensions.WaitForPageLoaded(Driver);
            DriverActions.waitForElementPresent(BY_CONFIRMATION_MSG_CONTAINER);
        }

        public bool IsBuildSummaryHeaderDisplayed()
        {
            return DriverActions.IsElementPresent(BY_BUILD_SUMMARY_CONFIRMATION_HEADER);
        }

        public int AccessoryAddedCount()
        {
            List<IWebElement> accessories = Driver.FindElements(BY_SUMMARY_ADDED_ACCESSORY).ToList();
            return accessories.Count;
        }

        public string GetQuoteModelId()
        {
            string modelId = Driver.FindElement(BY_WHOLEGOOD_MODEL_ID).GetAttribute("innerHTML");
            string model = modelId.Substring(modelId.LastIndexOf(":") + 1);
            return model.Trim();
        }

        public bool IsSummaryPrintLinkDisplayed()
        {
            return DriverActions.IsElementPresent(BY_SUMMARY_PRINT_BUTTON);
        }

        public List<string> GetConfirmationPackageSubproductsNames()
        {
            List<string> subproducts = new List<string>();
            List<IWebElement> subproductsElements = Driver.FindElements(BY_PACKAGE_SUBPRODUCT_NAMES).ToList();

            foreach (var item in subproductsElements)
            {
                subproducts.Add(item.Text);
            }

            return subproducts;
        }

        public void ClickKitPackageDropdownArrow()
        {
            List<IWebElement> kitPackageArrows = Driver.FindElements(BY_KIT_PACKAGE_ICON_ARROW).ToList();
            foreach (var item in kitPackageArrows)
            {
                DriverActions.clickElement(item);
            }
        }

        public bool IsProductDescPresentBuildConfirmation(string productDesc)
        {
            bool isFound = false;
            List<IWebElement> summaryProductIds = Driver.FindElements(BY_PACKAGE_SUBPRODUCT_NAMES).ToList();

            foreach (var item in summaryProductIds)
            {
                string description = item.Text;

                if (description.Length > 0 && stringContainsIgnoreCase(description, productDesc))
                {
                    isFound = true;
                    break;
                }
                else
                    isFound = false;
            }
            return isFound;
        }

        public bool IsPackagePresentConfirmation(string package)
        {
            bool isFound = false;
            List<IWebElement> summaryProductIds = Driver.FindElements(BY_ADDED_PKG_TITLES).ToList();

            foreach (var item in summaryProductIds)
            {
                string description = item.Text;

                if (description.Length > 0 && stringContainsIgnoreCase(description, package))
                {
                    isFound = true;
                    break;
                }
                else
                    isFound = false;
            }
            return isFound;
        }

        public bool IsOptionsSectionDisplayed()
        {
            return DriverActions.IsElementPresent(BY_OPTIONS_ACCESSORIES_SECTION);
        }

        public string GetConfirmationModelName()
        {
            return Driver.FindElement(BY_CONFIRMATION_MODEL_NAME).Text;
        }

        public int GetGemAddedAccessoriesCount()
        {
            List<IWebElement> addedAccessories = Driver.FindElements(BY_GEM_SUMMARY_ACCESORY).ToList();
            return addedAccessories.Count;
        }

        public void ClickBuildSummaryToggleCaret()
        {
            DriverActions.clickElement(BY_BUILD_SUMMARY_TOGGLE);
        }
    }
}
