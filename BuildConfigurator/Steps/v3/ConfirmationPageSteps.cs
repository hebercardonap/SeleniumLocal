using AutomationFramework.Base;
using BuildConfigurator.Pages.v3;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BuildConfigurator.Steps.v3
{
    [Binding]
    public class ConfirmationPageSteps : ConfirmationPage
    {
        public ConfirmationPageSteps(ParallelConfig parallelConfig) : base(parallelConfig)
        {
            _parallelConfig.CurrentPage = new ConfirmationPage(_parallelConfig);
        }

        [When(@"I wait until confirmation page loads")]
        public void WhenIWaitUntilConfirmationPageLoads()
        {
            _parallelConfig.CurrentPage.As<ConfirmationPage>().WaitUntilConfirmationPageLoads();
        }

        [Then(@"Confirmation page is as expected")]
        public void ThenConfirmationPageIsAsExpected()
        {
            Assert.Greater(_parallelConfig.CurrentPage.As<ConfirmationPage>().AccessoryAddedCount(), 0);
        }

    }
}
