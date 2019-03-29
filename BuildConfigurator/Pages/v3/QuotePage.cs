﻿using AutomationFramework.Base;
using AutomationFramework.DataProvider;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Pages.v3
{
    public class QuotePage : BasePage
    {
        private static By BY_FIRST_NAME_FIELD = By.CssSelector("div[data-form-mapping='FirstName'] input");
        private static By BY_LAST_NAME_FIELD = By.CssSelector("div[data-form-mapping='LastName'] input");
        private static By BY_EMAIL_FIELD = By.CssSelector("div[data-form-mapping='Email'] input");
        private static By BY_PHONE_FIELD = By.CssSelector("div[data-form-mapping='Phone'] input");
        private static By BY_POSTAL_CODE_FIELD = By.XPath("//input[contains(@class, 'FormTextbox__Input d')]");
        private static By BY_GET_INTERNET_PRICE_BUTTON = By.CssSelector("button[name='submit']");
        private static By BY_AGE_CHECKBOX = By.XPath("//div[contains(@class, 'ValidationRequired')]//input[@type='checkbox']");
        private static By BY_EMAIL_UPDATES_CHECKBOX = By.CssSelector("div[data-form-mapping='EmailUpdates'] input");
        private static By BY_FORM_COMMERCIAL_OPTION = By.XPath("//div[contains(@class, 'Form__Element  ')]//input[@value='commercial']");
        private static By BY_FORM_PERSONAL_OPTION = By.XPath("//div[contains(@class, 'Form__Element  ')]//input[@value='personal']");
        private static By BY_FORM_GOVERNMENT_OPTION = By.XPath("//div[contains(@class, 'Form__Element  ')]//input[contains(@value, 'government')]");
        private static By BY_LAST_NAME_VALIDATION_ERROR = By.XPath("//div[@data-form-mapping='LastName']//span[contains(@class,'Error')]");
        private static By BY_FIRST_NAME_VALIDATION_ERROR = By.XPath("//div[@data-form-mapping='FirstName']//span[contains(@class,'Error')]");
        private static By BY_EMAIL_VALIDATION_ERROR = By.XPath("//div[@data-form-mapping='Email']//span[contains(@class,'Error')]");
        private static By BY_POSTAL_CODE_VALIDATION_ERROR = By.XPath("//div[@data-form-mapping='DealerLocator']//span[contains(@class,'Error')]");
        private static By BY_AGE_CHECKBOX_VALIDATION_ERROR = By.XPath("//div[@data-f-type='choice']//span[@class='Form__Element__ValidationError']");
        private static By BY_SELECTED_DEALER_NAME = By.XPath("//div[contains(@class,'dlecb__dealer-name')]");
        private static By BY_QUOTE_PAGE_TITLE = By.CssSelector("h1[class~='heading-generic__heading']");
        private static By BY_QUOTE_PAGE_COMMENTS_PLUS = By.CssSelector("span[class='text-area-element-custom-block-toggle__icon']");
        private static By BY_QUOTE_PAGE_COMMENTS_TEXT_AREA = By.CssSelector("div[class='text-area-element-custom-block-content'] textarea");
        private static By BY_QUOTE_PAGE_HEADER_TITLE = By.CssSelector("div[class~='heading-generic__content'] h1");
        private static By BY_QUOTE_PAGE_HEADER_MENU = By.Id("kampyle_abandon_zone");
        private static By BY_QUOTE_PAGE_PRIVACY_TERMS = By.CssSelector("p[class='terms__anti-span-legislation']");
        private static By BY_QUOTE_PAGE_GLOBAL_FOOTER = By.CssSelector("div[class='global-footer__wrapper']");
        private static By BY_QUOTE_PAGE_VIRTUAL_KEYBOARD = By.CssSelector("div[class~='ui-keyboard']");

        public QuotePage(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }


        public void SetFirstName()
        {
            Driver.FindElement(BY_FIRST_NAME_FIELD).SendKeys(AccountDetails.TEST_USER_1.FirstName);
        }

        public void ClickFirstNameTextBox()
        {
            DriverActions.clickElement(BY_FIRST_NAME_FIELD);
            DriverActions.waitForAjaxRequestToComplete();
        }

        public void SetFirstName(string firstName)
        {
            Driver.FindElement(BY_FIRST_NAME_FIELD).SendKeys(firstName);
        }

        public void SetLastName()
        {
            Driver.FindElement(BY_LAST_NAME_FIELD).SendKeys(AccountDetails.TEST_USER_1.LastName);
        }

        public void SetLastName(string lastName)
        {
            Driver.FindElement(BY_LAST_NAME_FIELD).SendKeys(lastName);
        }

        public void SetEmail()
        {
            Driver.FindElement(BY_EMAIL_FIELD).SendKeys(AccountDetails.TEST_USER_1.Email);
        }

        public void SetEmail(string email)
        {
            Driver.FindElement(BY_EMAIL_FIELD).SendKeys(email);
        }

        public void SetPhoneNumber()
        {
            Driver.FindElement(BY_PHONE_FIELD).SendKeys(AccountDetails.TEST_USER_1.PhoneNumber);
        }

        public void SetPhoneNumber(string phoneNumber)
        {
            Driver.FindElement(BY_PHONE_FIELD).SendKeys(phoneNumber);
        }

        public void SetPostalCode()
        {
            Driver.FindElement(BY_POSTAL_CODE_FIELD).SendKeys(AccountDetails.TEST_USER_1.ZipCode);
        }

        public void SetPostalCode(string postalCode)
        {
            Driver.FindElement(BY_POSTAL_CODE_FIELD).SendKeys(postalCode);
        }

        public void ClickGetInternetPriceButton()
        {
            DriverActions.clickElement(BY_GET_INTERNET_PRICE_BUTTON);
        }

        public void ClickAgeCheckBox()
        {
            DriverActions.clickElement(BY_AGE_CHECKBOX);
        }

        public void ClickEmailUpdatesCheckBox()
        {
            DriverActions.clickElement(BY_EMAIL_UPDATES_CHECKBOX);
        }

        public void WaitForBuildQuotePageToLoad()
        {
            DriverActions.waitForElementToBeEnabled(BY_FIRST_NAME_FIELD);
        }

        public void ClickFormCommercialUseOption()
        {
            DriverActions.clickElement(BY_FORM_COMMERCIAL_OPTION);
        }

        public void ClickFormPersonalUseOption()
        {
            DriverActions.clickElement(BY_FORM_PERSONAL_OPTION);
        }

        public void ClickFormGovernmentUseOption()
        {
            DriverActions.clickElement(BY_FORM_GOVERNMENT_OPTION);
        }

        public bool IsFirstNameValidationErrorDisplayed()
        {
            return DriverActions.IsElementPresent(BY_FIRST_NAME_VALIDATION_ERROR);
        }

        public bool IsLastNameValidationErrorDisplayed()
        {
            return DriverActions.IsElementPresent(BY_LAST_NAME_VALIDATION_ERROR);
        }

        public bool IsEmailValidationErrorDisplayed()
        {
            return DriverActions.IsElementPresent(BY_EMAIL_VALIDATION_ERROR);
        }

        public bool IsPostalCodeValidationErrorDisplayed()
        {
            return DriverActions.IsElementPresent(BY_POSTAL_CODE_VALIDATION_ERROR);
        }

        public bool IsAgeCheckboxValidationErrorDisplayed()
        {
            return DriverActions.IsElementPresent(BY_AGE_CHECKBOX_VALIDATION_ERROR);
        }

        public void WaitForDealerNameToBeDisplayed()
        {
            DriverActions.waitForElementVisibleAndEnabled(BY_SELECTED_DEALER_NAME);
        }

        public void ClickAwayForFocusQuotePage()
        {
            DriverActions.clickElement(BY_QUOTE_PAGE_TITLE);
        }

        public void ClickQuoteCommentsPlusSign()
        {
            DriverActions.clickElement(BY_QUOTE_PAGE_COMMENTS_PLUS);
        }

        public void EnterQuoteComments()
        {
            Driver.FindElement(BY_QUOTE_PAGE_COMMENTS_TEXT_AREA).SendKeys(AccountDetails.TEST_USER_1.Comments);
        }

        public string GetQuotePageHeaderTitle()
        {
            return Driver.FindElement(BY_QUOTE_PAGE_HEADER_TITLE).Text;
        }

        public bool IsQuotePageHeaderMenuDisplayed()
        {
            return DriverActions.IsElementPresent(BY_QUOTE_PAGE_HEADER_MENU);
        }

        public bool IsQuotePagePrivacyTermsDisplayed()
        {
            return DriverActions.IsElementPresent(BY_QUOTE_PAGE_PRIVACY_TERMS);
        }

        public bool IsQuotePageGlobalFooterDisplayed()
        {
            return DriverActions.IsElementPresent(BY_QUOTE_PAGE_GLOBAL_FOOTER);
        }

        public bool IsQuotePageVirtualKeyboardDisplayed()
        {
            return DriverActions.IsElementPresent(BY_QUOTE_PAGE_VIRTUAL_KEYBOARD);
        }
    }
}
