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
            _parallelConfig.CurrentPage.As<BuildQuotePage>().clickAgeCheckBox();
        }

        [When(@"I click on Personal use option")]
        public void WhenIClickOnPersonalUseOption()
        {
            _parallelConfig.CurrentPage.As<BuildQuotePage>().clickFormPersonalUseOption();
        }


    }
}
