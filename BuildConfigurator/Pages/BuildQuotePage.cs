﻿using AutomationFramework.Base;
using AutomationFramework.DataProvider;
using AutomationFramework.Extensions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Pages
{
    internal class BuildQuotePage : BasePage
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

        public BuildQuotePage(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public void setFirstName()
        {
            Driver.FindElement(BY_FIRST_NAME_FIELD).SendKeys(AccountDetails.TEST_USER_1.FirstName);
        }

        public void setFirstName(string firstName)
        {
            Driver.FindElement(BY_FIRST_NAME_FIELD).SendKeys(firstName);
        }

        public void setLastName()
        {
            Driver.FindElement(BY_LAST_NAME_FIELD).SendKeys(AccountDetails.TEST_USER_1.LastName);
        }

        public void setLastName(string lastName)
        {
            Driver.FindElement(BY_LAST_NAME_FIELD).SendKeys(lastName);
        }

        public void setEmail()
        {
            Driver.FindElement(BY_EMAIL_FIELD).SendKeys(AccountDetails.TEST_USER_1.Email);
        }

        public void setEmail(string email)
        {
            Driver.FindElement(BY_EMAIL_FIELD).SendKeys(email);
        }

        public void setPhoneNumber()
        {
            Driver.FindElement(BY_PHONE_FIELD).SendKeys(AccountDetails.TEST_USER_1.PhoneNumber);
        }

        public void setPhoneNumber(string phoneNumber)
        {
            Driver.FindElement(BY_PHONE_FIELD).SendKeys(phoneNumber);
        }

        public void setPostalCode()
        {
            Driver.FindElement(BY_POSTAL_CODE_FIELD).SendKeys(AccountDetails.TEST_USER_1.ZipCode);
        }

        public void setPostalCode(string postalCode)
        {
            Driver.FindElement(BY_POSTAL_CODE_FIELD).SendKeys(postalCode);
        }

        public void clickGetInternetPriceButton()
        {
            DriverActions.clickElement(BY_GET_INTERNET_PRICE_BUTTON);
        }

        public void clickAgeCheckBox()
        {
            DriverActions.clickElement(BY_AGE_CHECKBOX);
        }

        public void clickEmailUpdatesCheckBox()
        {
            DriverActions.clickElement(BY_EMAIL_UPDATES_CHECKBOX);
        }

        public void waitForBuildQuotePgeToLoad()
        {
            DriverActions.waitForElementToBeEnabled(BY_FIRST_NAME_FIELD);
        }

        public void clickFormCommercialUseOption()
        {
            DriverActions.clickElement(BY_FORM_COMMERCIAL_OPTION);
        }

        public void clickFormPersonalUseOption()
        {
            DriverActions.clickElement(BY_FORM_PERSONAL_OPTION);
        }

        public void clickFormGovernmentUseOption()
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
    }
}
