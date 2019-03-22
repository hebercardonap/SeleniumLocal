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
    public class FooterModule : BasePage
    {
        private static By BY_FOOTER_STARTING_PRICE = By.XPath("//div[@class='cpq-footer__pricing-price']");
        private static By BY_FOOTER_PAYMENT_CALC = PolarisSeleniumAttribute.PolarisSeleniumSelector("footerCalculatorIcon");
        private static By BY_FOOTER_NEXT_BUTTON = PolarisSeleniumAttribute.PolarisSeleniumSelector("footerNextBtn");
        private static By BY_BUILD_SUMMARY_TOGGLE = By.XPath("//button[@class='btn-next cpq-footer__cta-button']");
        private static By BY_OPEN_BUILD_SUMMARY = By.CssSelector("button[class~='cpq-footer__cta-button']");
        private static By BY_NEXT_OPEN_BUILD_SUMMARY = PolarisSeleniumAttribute.PolarisSeleniumSelector("showBuildSummary");
        private static By BY_FOOTER_WIDGET_CONTAINER = By.CssSelector("div[id*='poll_container'] div[id*='poll']");
        private static By BY_FOOTER_WIDGET_CARET = By.CssSelector("a span[class*='widget_icon']");

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
            if (IsWidgetContainerDisplayed())
                DriverActions.clickElement(BY_FOOTER_WIDGET_CARET);

            DriverActions.waitForElementVisibleAndEnabled(BY_FOOTER_NEXT_BUTTON);
            DriverActions.clickElement(BY_FOOTER_NEXT_BUTTON);
        }

        public bool IsWidgetContainerDisplayed()
        {
            return DriverActions.IsElementPresent(BY_FOOTER_WIDGET_CONTAINER);
        }

        public void ClickFooterNextButtonOpenSummary()
        {
            if (DriverActions.IsElementPresent(BY_FOOTER_NEXT_BUTTON))
            {
                DriverActions.clickElement(BY_FOOTER_NEXT_BUTTON);
            }
            else
            {
                OpenBuildSummary();
            }
        }

        public void ClickFooterPaymentCalculator()
        {
            DriverActions.waitForElementVisibleAndEnabled(BY_FOOTER_PAYMENT_CALC);
            DriverActions.clickElement(BY_FOOTER_PAYMENT_CALC);
            DriverActions.waitForAjaxRequestToComplete();
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

        public void OpenBuildSummary()
        {
            DriverActions.waitForElementVisibleAndEnabled(BY_OPEN_BUILD_SUMMARY);
            DriverActions.clickElement(BY_OPEN_BUILD_SUMMARY);
        }

        public bool IsNextOpenBuildSummaryDisplayed()
        {
            return DriverActions.IsElementPresent(BY_NEXT_OPEN_BUILD_SUMMARY);
        }
    }
}
