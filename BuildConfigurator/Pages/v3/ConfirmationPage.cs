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
        private static By BY_SUMMARY_ADDED_ACCESSORY = By.XPath("//*[contains(@class, 'split-50')]");
        private static By BY_WHOLEGOOD_MODEL_ID = By.XPath("//div[@class='text-align-right pull-right font-size-sm split-right']");
        private static By BY_SUMMARY_PRINT_BUTTON = By.CssSelector("button[class~='summary-print']");

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
    }
}
