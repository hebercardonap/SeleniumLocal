using AutomationFramework.Base;
using BuildConfigurator.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BuildConfigurator.Steps
{
    [Binding]
    class BuildQuoteSteps : BasePage
    {

        private static string MESSAGE_TEMPLATE = "Validation Error for field {0} is not displayed";
        public BuildQuoteSteps(ParallelConfig parallelConfig) : base(parallelConfig)
        {
            _parallelConfig.CurrentPage = new BuildQuotePage(_parallelConfig);
        }

        [When(@"I get to build quote page")]
        public void ThenIGetToBuildQuotePage()
        {
            _parallelConfig.CurrentPage.As<BuildQuotePage>().waitForBuildQuotePgeToLoad();
        }

        [When(@"I fill the form")]
        public void ThenIFillTheForm()
        {
            _parallelConfig.CurrentPage.As<BuildQuotePage>().setFirstName();
            _parallelConfig.CurrentPage.As<BuildQuotePage>().setLastName();
            _parallelConfig.CurrentPage.As<BuildQuotePage>().setEmail();
            _parallelConfig.CurrentPage.As<BuildQuotePage>().setPhoneNumber();
            _parallelConfig.CurrentPage.As<BuildQuotePage>().setPostalCode();
            _parallelConfig.CurrentPage.As<BuildQuotePage>().WaitForDealerNameToBeDisplayed();
            _parallelConfig.CurrentPage.As<BuildQuotePage>().clickAgeCheckBox();
        }

        [When(@"I click on Personal use option")]
        public void WhenIClickOnPersonalUseOption()
        {
            _parallelConfig.CurrentPage.As<BuildQuotePage>().clickFormPersonalUseOption();
        }

        [When(@"I enter first name (.*)")]
        public void WhenIEnterFirstName(string firstName)
        {
            _parallelConfig.CurrentPage.As<BuildQuotePage>().setFirstName(firstName);
        }

        [When(@"I enter last name (.*)")]
        public void WhenIEnterLastName(string lastName)
        {
            _parallelConfig.CurrentPage.As<BuildQuotePage>().setLastName(lastName);
        }

        [When(@"I enter email (.*)")]
        public void WhenIEnterEmail(string email)
        {
            _parallelConfig.CurrentPage.As<BuildQuotePage>().setEmail(email);
        }

        [When(@"I enter phone number (.*)")]
        public void WhenIEnterPhoneNumber(string phoneNumber)
        {
            _parallelConfig.CurrentPage.As<BuildQuotePage>().setPhoneNumber(phoneNumber);
        }

        [When(@"I enter postal code (.*)")]
        public void WhenIEnterPostalCode(string postalCode)
        {
            _parallelConfig.CurrentPage.As<BuildQuotePage>().setPostalCode(postalCode);
        }

        [Then(@"(.*) validation error is displayed")]
        public void ThenFirstNameValidationErrorIsDisplayed(string fieldName)
        {
            if (stringEqualsIgnoreCase(fieldName, "first name"))
                Assert.IsTrue(_parallelConfig.CurrentPage.As<BuildQuotePage>().IsFirstNameValidationErrorDisplayed(),
                    string.Format(MESSAGE_TEMPLATE, fieldName));
            else if (stringEqualsIgnoreCase(fieldName, "last name"))
                Assert.IsTrue(_parallelConfig.CurrentPage.As<BuildQuotePage>().IsLastNameValidationErrorDisplayed(),
                    string.Format(MESSAGE_TEMPLATE, fieldName));
            else if (stringEqualsIgnoreCase(fieldName, "email"))
                Assert.IsTrue(_parallelConfig.CurrentPage.As<BuildQuotePage>().IsEmailValidationErrorDisplayed(),
                    string.Format(MESSAGE_TEMPLATE, fieldName));
            else if (stringEqualsIgnoreCase(fieldName, "postal code"))
                Assert.IsTrue(_parallelConfig.CurrentPage.As<BuildQuotePage>().IsPostalCodeValidationErrorDisplayed(),
                    string.Format(MESSAGE_TEMPLATE, fieldName));
            else if (stringEqualsIgnoreCase(fieldName, "age checkbox"))
                Assert.IsTrue(_parallelConfig.CurrentPage.As<BuildQuotePage>().IsAgeCheckboxValidationErrorDisplayed(),
                    string.Format(MESSAGE_TEMPLATE, fieldName));
            else
                Assert.Fail("Field name {0} is not present in the form", fieldName);
        }

        [When(@"I click Age checkbox")]
        public void WhenIClickAgeCheckbox()
        {
            _parallelConfig.CurrentPage.As<BuildQuotePage>().clickAgeCheckBox();
        }



    }
}
