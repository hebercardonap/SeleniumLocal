using AutomationFramework.Base;
using AutomationFramework.Extensions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Pages.v2
{
    public class BuildConfirmationPage : BasePage
    {
        private static By BY_THANK_YOU_MESSAGE = By.CssSelector("div[class~='form-confirmation-place-holder-block']");
        private static By BY_PRINT_LINK = By.XPath("//button[@title='Print Detailed Summary']");
        private static By BY_TOTAL_PRICE = By.XPath("//div[contains(@class,'total-price')]");
        private static By BY_ADDED_ACCESSORY = By.XPath("//div[contains(@class,'product border-bottom')]");
        private static By BY_ADDED_ACCESSORY_CONTAINER = By.CssSelector("div[class='added-products']");
        private static By BY_SHOPPING_TOOLS = By.XPath("//div[contains(@class,'layout__container')]//section[@id='shopping-tools']");
        private static By BY_GEM_SUMMARY_ACCESORY = By.CssSelector("div[class='quote-confirmation--build__summary-accessory-container'] div[class='quote-confirmation--build__summary-accessory']");
        private static By BY_BUILD_SUMMARY_TOGGLE = By.XPath("//div[@class='quote-confirmation--build__summary-toggle-icon']");
        private static By BY_GEM_BUILD_CONF_PAGE = By.CssSelector("header[class='quote-confirmation__header-container']");

        public BuildConfirmationPage(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public void WaitForBuildConfirmationPageToLoad()
        {
            DriverActions.waitForElementPresent(BY_THANK_YOU_MESSAGE);
        }

        public bool IsTotalPriceDisplayed()
        {
            return DriverActions.IsElementPresent(BY_TOTAL_PRICE);
        }

        public int GetAddedAccessoriesCount()
        {
            List<IWebElement> addedAccessories = Driver.FindElements(BY_ADDED_ACCESSORY).ToList();
            return addedAccessories.Count;
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

        public void WaitForGemConfirmationPageToLoad()
        {
            DriverActions.waitForElementVisibleAndEnabled(BY_GEM_BUILD_CONF_PAGE);
        }
    }
}
