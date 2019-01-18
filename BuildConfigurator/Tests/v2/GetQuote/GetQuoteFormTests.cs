using AutomationFramework.DataProvider;
using AutomationFramework.Helpers;
using AutomationFramework.Utils;
using BuildConfigurator.Hooks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Tests.v2.GetQuote
{
    [TestFixture]
    public class GetQuoteFormTests : TestBase
    {
        [Test, Category(TestCategories.QUOTE_PAGE), CustomRetry(3)]
        public void VerifyFirstNameValidationError()
        {
            CPQNavigate.NavigateToQuoteDefaultPage();
            BuildQuotePage.WaitForBuildQuotePgeToLoad();
            BuildQuotePage.SetLastName(AccountDetails.TEST_USER_1.LastName);
            BuildQuotePage.SetEmail(AccountDetails.TEST_USER_1.Email);
            BuildQuotePage.SetPhoneNumber(AccountDetails.TEST_USER_1.PhoneNumber);
            BuildQuotePage.SetPostalCode(AccountDetails.TEST_USER_1.ZipCode);
            BuildQuotePage.ClickAgeCheckBox();
            BuildQuotePage.ClickGetInternetPriceButton();
            Assert.IsTrue(BuildQuotePage.IsFirstNameValidationErrorDisplayed());

        }

        [Test, Category(TestCategories.QUOTE_PAGE), CustomRetry(3)]
        public void VerifyLastNameValidationError()
        {
            CPQNavigate.NavigateToQuoteDefaultPage();
            BuildQuotePage.WaitForBuildQuotePgeToLoad();
            BuildQuotePage.SetFirstName(AccountDetails.TEST_USER_1.FirstName);
            BuildQuotePage.SetEmail(AccountDetails.TEST_USER_1.Email);
            BuildQuotePage.SetPhoneNumber(AccountDetails.TEST_USER_1.PhoneNumber);
            BuildQuotePage.SetPostalCode(AccountDetails.TEST_USER_1.ZipCode);
            BuildQuotePage.ClickAgeCheckBox();
            BuildQuotePage.ClickGetInternetPriceButton();
            Assert.IsTrue(BuildQuotePage.IsLastNameValidationErrorDisplayed());

        }

        [Test, Category(TestCategories.QUOTE_PAGE), CustomRetry(3)]
        public void VerifyEmailValidationError()
        {
            CPQNavigate.NavigateToQuoteDefaultPage();
            BuildQuotePage.WaitForBuildQuotePgeToLoad();
            BuildQuotePage.SetFirstName(AccountDetails.TEST_USER_1.FirstName);
            BuildQuotePage.SetLastName(AccountDetails.TEST_USER_1.LastName);
            BuildQuotePage.SetPhoneNumber(AccountDetails.TEST_USER_1.PhoneNumber);
            BuildQuotePage.SetPostalCode(AccountDetails.TEST_USER_1.ZipCode);
            BuildQuotePage.ClickAgeCheckBox();
            BuildQuotePage.ClickGetInternetPriceButton();
            Assert.IsTrue(BuildQuotePage.IsEmailValidationErrorDisplayed());

        }

        [Test, Category(TestCategories.QUOTE_PAGE), CustomRetry(3)]
        public void VerifyInvalidEmailValidationError()
        {
            CPQNavigate.NavigateToQuoteDefaultPage();
            BuildQuotePage.WaitForBuildQuotePgeToLoad();
            BuildQuotePage.SetFirstName(AccountDetails.TEST_USER_1.FirstName);
            BuildQuotePage.SetLastName(AccountDetails.TEST_USER_1.LastName);
            BuildQuotePage.SetEmail("invalid@");
            BuildQuotePage.SetPhoneNumber(AccountDetails.TEST_USER_1.PhoneNumber);
            BuildQuotePage.SetPostalCode(AccountDetails.TEST_USER_1.ZipCode);
            BuildQuotePage.ClickAgeCheckBox();
            BuildQuotePage.ClickGetInternetPriceButton();
            Assert.IsTrue(BuildQuotePage.IsEmailValidationErrorDisplayed());

        }

        [Test, Category(TestCategories.QUOTE_PAGE), CustomRetry(3)]
        public void VerifyAgeCheckboxValidationError()
        {
            CPQNavigate.NavigateToQuoteDefaultPage();
            BuildQuotePage.WaitForBuildQuotePgeToLoad();
            BuildQuotePage.SetFirstName(AccountDetails.TEST_USER_1.FirstName);
            BuildQuotePage.SetLastName(AccountDetails.TEST_USER_1.LastName);
            BuildQuotePage.SetEmail(AccountDetails.TEST_USER_1.Email);
            BuildQuotePage.SetPhoneNumber(AccountDetails.TEST_USER_1.PhoneNumber);
            BuildQuotePage.SetPostalCode(AccountDetails.TEST_USER_1.ZipCode);
            BuildQuotePage.ClickGetInternetPriceButton();
            Assert.IsTrue(BuildQuotePage.IsAgeCheckboxValidationErrorDisplayed());

        }
    }
}
