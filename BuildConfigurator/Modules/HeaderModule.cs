using AutomationFramework.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Modules
{
    public class HeaderModule : BasePage
    {
        public HeaderModule(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        private static By BY_HEADER_CLOSE_ICON = By.XPath("//a[@class='cpq-header__icon-close']//i[@class='icon icon__close-circle']");
        private static By BY_HEADER_TITLE = By.XPath("//div[contains(@class,'title')]");
        private static By BY_NAVIGATION_BAR_CPQ_HEADER = By.XPath("//div[@id='cpq-header']");
        private static By BY_SAVE_HEADER_ICON = By.XPath("//i[@class='icon icon__save']");
        private static By BY_EMAIL_HEADER_ICON = By.XPath("//i[@class='icon icon__email']");
        private static By BY_SIGN_IN_HEADER_ICON = By.XPath("//a[@class='cpq-header__identity-signin']");
        private static By BY_ACCOUNT_ICON = By.XPath("//i[@class='icon icon__account']");


        public void ClickHeaderCloseIcon()
        {
            DriverActions.clickElement(BY_HEADER_CLOSE_ICON);
        }

        public void WaitForHeaderToBeDisplayed()
        {
            DriverActions.waitForElementPresent(BY_HEADER_TITLE);
        }

        public bool IsNavigationBarBrandNameDisplayed()
        {
            return DriverActions.IsElementPresent(BY_NAVIGATION_BAR_CPQ_HEADER);
        }

        public string GetHeaderBrandName()
        {
            return Driver.FindElement(BY_NAVIGATION_BAR_CPQ_HEADER).Text;
        }

        public void WaitForCloseIconToBeEnabled()
        {
            DriverActions.waitForElementVisibleAndEnabled(BY_HEADER_CLOSE_ICON);
        }

        public bool IsSaveHeaderIconDisplayed()
        {
            return DriverActions.IsElementPresent(BY_SAVE_HEADER_ICON);
        }

        public bool IsEmailHeaderIconDisplayed()
        {
            return DriverActions.IsElementPresent(BY_EMAIL_HEADER_ICON);
        }

        public void ClickSaveHeaderIcon()
        {
            DriverActions.clickElement(BY_SAVE_HEADER_ICON);
        }

        public void ClickEmailHeaderIcon()
        {
            DriverActions.clickElement(BY_EMAIL_HEADER_ICON);
        }

        public bool IsHeaderSignInIconDisplayed()
        {
            return DriverActions.IsElementPresent(BY_SIGN_IN_HEADER_ICON);
        }

        public void ClickSignInHeaderIcon()
        {
            DriverActions.clickElement(BY_SIGN_IN_HEADER_ICON);
        }

        public void ClickAccountHeaderIcon()
        {
            DriverActions.clickElement(BY_ACCOUNT_ICON);
        }

        public bool IsAccountHeaderIconDisplayed()
        {
            return DriverActions.IsElementPresent(BY_ACCOUNT_ICON);
        }
    }
}
