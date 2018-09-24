using AutomationFramework.Base;
using BuildConfigurator.Pages;
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
        public BuildQuoteSteps()
        {
            CurrentPage = GetInstance<BuildQuotePage>();
        }
        [When(@"I get to build quote page")]
        public void ThenIGetToBuildQuotePage()
        {
            CurrentPage.As<BuildQuotePage>().waitForBuildQuotePgeToLoad();
        }

        [When(@"I fill the form")]
        public void ThenIFillTheForm()
        {
            CurrentPage.As<BuildQuotePage>().setFirstName();
            CurrentPage.As<BuildQuotePage>().setLastName();
            CurrentPage.As<BuildQuotePage>().setEmail();
            CurrentPage.As<BuildQuotePage>().setPhoneNumber();
            CurrentPage.As<BuildQuotePage>().setPostalCode();
            CurrentPage.As<BuildQuotePage>().clickAgeCheckBox();
            CurrentPage.As<BuildQuotePage>().clickGetInternetPriceButton();
        }

    }
}
