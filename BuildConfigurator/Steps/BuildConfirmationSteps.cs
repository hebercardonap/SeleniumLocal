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
    class BuildConfirmationSteps : BasePage
    {
        public BuildConfirmationSteps(ParallelConfig parallelConfig) : base(parallelConfig)
        {
            CurrentPage = new BuildConfirmationPage(_parallelConfig);
        }
        [When(@"I get to build confirmation page")]
        public void ThenIGetToBuildConfirmationPage()
        {
            CurrentPage.As<BuildConfirmationPage>().waitForBuildConfirmationPageToLoad();
        }

        [Then(@"build confirmation page is as expected")]
        public void ThenBuildConfirmationPageIsAsExpected()
        {
            Assert.IsTrue(CurrentPage.As<BuildConfirmationPage>().isTotalPriceDisplayed());
            Assert.IsTrue(CurrentPage.As<BuildConfirmationPage>().getAddedAccessoriesCount() > 0);
        }

        [Then(@"GEM build confirmation page is as expected")]
        public void ThenGEMBuildConfirmationPageIsAsExpected()
        {
            //Assert.IsTrue(CurrentPage.As<BuildConfirmationPage>().isTotalPriceDisplayed());
            CurrentPage.As<BuildConfirmationPage>().clickBuildSummaryToggleCaret();
            Assert.IsTrue(CurrentPage.As<BuildConfirmationPage>().getGemAddedAccessoriesCount() > 0);
        }


    }
}
