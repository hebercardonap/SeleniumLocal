using AutomationFramework.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Modules
{
    public class FooterModule : BasePage
    {
        private static By BY_FOOTER_STARTING_PRICE = By.XPath("");
        private static By BY_FOOTER_PAYMENT_CALC = By.XPath("");
        private static By BY_FOOTER_NEXT_BUTTON = By.XPath("");
        private static By BY_BUILD_SUMMARY_TOGGLE = By.XPath("");


        public FooterModule(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public bool IsStartingPriceDisplayed()
        {
            return DriverActions.IsElementPresent(BY_FOOTER_STARTING_PRICE);
        }

        public bool IsPaymentCalculatorDisplayed()
        {
            return DriverActions.IsElementPresent(BY_FOOTER_PAYMENT_CALC);
        }

        public bool IsNextButtonDisplayed()
        {
            return DriverActions.IsElementPresent(BY_FOOTER_NEXT_BUTTON);
        }

        public void ClickFooterNextButton()
        {
            DriverActions.waitForElementVisibleAndEnabled(BY_FOOTER_NEXT_BUTTON);
            DriverActions.clickElement(BY_FOOTER_NEXT_BUTTON);
        }

        public void ClickFooterPaymentCalculator()
        {
            DriverActions.waitForElementVisibleAndEnabled(BY_FOOTER_PAYMENT_CALC);
            DriverActions.clickElement(BY_FOOTER_PAYMENT_CALC);
        }

        public void ClickFooterStartingPrice()
        {
            DriverActions.waitForElementVisibleAndEnabled(BY_FOOTER_STARTING_PRICE);
            DriverActions.clickElement(BY_FOOTER_STARTING_PRICE);
        }

        public bool IsBuildSummaryToggleDisplayed()
        {
            return DriverActions.IsElementPresent(BY_BUILD_SUMMARY_TOGGLE);
        }

        public void ClickFooterBuildSummaryToggle()
        {
            DriverActions.waitForElementVisibleAndEnabled(BY_BUILD_SUMMARY_TOGGLE);
            DriverActions.clickElement(BY_BUILD_SUMMARY_TOGGLE);
        }
    }
}
