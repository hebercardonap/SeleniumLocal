using AutomationFramework.Base;
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
        private static By BY_POSTAL_CODE_FIELD = By.CssSelector("input[class*='postal-code-submit']");
        private static By BY_GET_INTERNET_PRICE_BUTTON = By.CssSelector("button[name='submit']");
        private static By BY_AGE_CHECKBOX = By.XPath("//div[contains(@class, 'ValidationRequired')]//input[@type='checkbox']");
        private static By BY_EMAIL_UPDATES_CHECKBOX = By.CssSelector("div[data-form-mapping='EmailUpdates'] input");


        public void setFirstName()
        {
            driver.FindElement(BY_FIRST_NAME_FIELD).SendKeys(AccountDetails.TEST_USER_1.FirstName);
        }

        public void setLastName()
        {
            driver.FindElement(BY_LAST_NAME_FIELD).SendKeys(AccountDetails.TEST_USER_1.LastName);
        }

        public void setEmail()
        {
            driver.FindElement(BY_EMAIL_FIELD).SendKeys(AccountDetails.TEST_USER_1.Email);
        }

        public void setPhoneNumber()
        {
            driver.FindElement(BY_PHONE_FIELD).SendKeys(AccountDetails.TEST_USER_1.PhoneNumber);
        }

        public void setPostalCode()
        {
            driver.FindElement(BY_POSTAL_CODE_FIELD).SendKeys(AccountDetails.TEST_USER_1.ZipCode);
        }

        public void clickGetInternetPriceButton()
        {
            WebElementExtensions.clickElement(BY_GET_INTERNET_PRICE_BUTTON);
        }

        public void clickAgeCheckBox()
        {
            WebElementExtensions.clickElement(BY_AGE_CHECKBOX);
        }

        public void clickEmailUpdatesCheckBox()
        {
            WebElementExtensions.clickElement(BY_EMAIL_UPDATES_CHECKBOX);
        }

        public void waitForBuildQuotePgeToLoad()
        {
            WebDriverExtensions.waitForElementToBeEnabled(BY_FIRST_NAME_FIELD);
        }


    }
}
