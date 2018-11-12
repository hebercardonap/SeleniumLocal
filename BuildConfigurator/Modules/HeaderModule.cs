using AutomationFramework.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Pages
{
    public class HeaderModule : BasePage
    {
        public HeaderModule(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        private static By BY_HEADER_CLOSE_ICON = By.XPath("//a[contains(@class,'cpq-header__select-close')]");
        private static By BY_HEADER_TITLE = By.XPath("//div[contains(@class,'title')]");
        private static By BY_NAVIGATION_BAR_CPQ_HEADER = By.XPath("//div[@id='cpq-header']");
        //TODO: Update with save icon selector
        private static By BY_SAVE_HEADER_ICON = By.XPath("");
        //TODO: Update with email icon selector
        private static By BY_EMAIL_HEADER_ICON = By.XPath("");


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
    }
}
