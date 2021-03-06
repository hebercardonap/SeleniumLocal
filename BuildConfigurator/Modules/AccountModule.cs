﻿using AutomationFramework.Base;
using AutomationFramework.Extensions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BuildConfigurator.Modules
{
    public class AccountModule : BasePage
    {
        private static By BY_ACCT_MODAL_CONTAINER = By.XPath("//div[@class='modal__content account-modal']");
        private static By BY_ACCT_MODAL_CLOSE_ICON = By.XPath("//i[@class='icon icon__close-circle']");
        private static By BY_ACCT_MODAL_ORDERS = By.CssSelector("ul[class='account-modal__navigation']>li:nth-child(1)>a");
        private static By BY_ACCT_MODAL_SAVED_VEHICLES = By.CssSelector("ul[class='account-modal__navigation']>li:nth-child(2)>a");
        private static By BY_ACCT_MODAL_ADDRESSES = By.CssSelector("ul[class='account-modal__navigation']>li:nth-child(3)>a");
        private static By BY_ACCT_MODAL_ACCT_INFO = By.CssSelector("ul[class='account-modal__navigation']>li:nth-child(4)>a");
        private static By BY_ACCT_MODAL_LOG_OUT = By.CssSelector("ul[class='account-modal__navigation']>li:nth-child(5)>a");
        private static By BY_DROPDOWN_ACCT_ICON = By.XPath("//*[@class='dropdown-account__icon']");
        private static By BY_ACCT_LOGIN_LINK = By.XPath("//a[contains(@class,'link-item--log-in')]");
        private static By BY_ACCT_LOGGED_IN_ICON = By.XPath("//*[@class='icon icon__account']");
        private static By BY_SAVE_MODAL_BODY = By.XPath("//div[@class='modal__body']");

        public AccountModule(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public bool IsAccountModalDisplayed()
        {
            return DriverActions.IsElementPresent(BY_ACCT_MODAL_CONTAINER);
        }

        public void ClickAcctModalCloseIcon()
        {
            DriverActions.clickElement(BY_ACCT_MODAL_CLOSE_ICON);
        }

        public void ClickAcctModalOrders()
        {
            DriverActions.clickElement(BY_ACCT_MODAL_ORDERS);
        }

        public void ClickAcctModalSavedVehicles()
        {
            DriverActions.clickElement(BY_ACCT_MODAL_SAVED_VEHICLES);
            Driver.WaitForPageLoaded();
            WaitForSaveModalBodyToLoad();
        }

        public void ClickAcctModalAddresses()
        {
            DriverActions.clickElement(BY_ACCT_MODAL_ADDRESSES);
        }

        public void ClickAcctModalAcctInfo()
        {
            DriverActions.clickElement(BY_ACCT_MODAL_ACCT_INFO);
        }

        public void ClickAcctModalLogOut()
        {
            DriverActions.clickElement(BY_ACCT_MODAL_LOG_OUT);
        }

        public void ClickDropDownAcctIcon()
        {
            DriverActions.clickElement(BY_DROPDOWN_ACCT_ICON);
        }

        public bool IsUserLoggedOut()
        {
            DriverActions.waitForElementVisibleAndEnabled(BY_DROPDOWN_ACCT_ICON);
            ClickDropDownAcctIcon();
            DriverActions.waitForElementVisibleAndEnabled(BY_ACCT_LOGIN_LINK);
            return DriverActions.IsElementPresent(BY_ACCT_LOGIN_LINK);
        }

        public void ClickAcctLoggedInIcon()
        {
            DriverActions.waitForAjaxRequestToComplete();
            WebDriverExtensions.WaitForPageLoaded(Driver);
            DriverActions.WaitForCanvassToComplete();
            DriverActions.waitForElementVisibleAndEnabled(BY_ACCT_LOGGED_IN_ICON);
            DriverActions.clickElement(BY_ACCT_LOGGED_IN_ICON);
        }

        public void WaitForSaveModalBodyToLoad()
        {
            DriverActions.waitForElementVisibleAndEnabled(BY_SAVE_MODAL_BODY);
        }
    }
}
