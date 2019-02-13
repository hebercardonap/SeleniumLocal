using AutomationFramework.Helpers;
using AutomationFramework.Utils;
using BuildConfigurator.Hooks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Tests.v2.SteppedProcess
{
    [TestFixture]
    public class AceSteppedProccessTests : TestBase
    {
        [Test, Category(TestCategories.ACE), Category(TestCategories.STEPPED_PROCESS), RetryDynamic]
        public void VerifyAceSteppedProcess()
        {
            CPQNavigate.NavigateToModelsPage(Brand.ACE);
            BuildModelPage.WaitForBuildModelPageToLoad();
            BuildModelPage.ClickRandomModel();
            BuildConfigurePage.WaitForBuildPageToLoad();
            BuildConfigurePage.ClickRandomAccessoryAvoidPRP();
            BuildConfigurePage.ClickIamFinishedButton();
            BuildQuotePage.WaitForBuildQuotePgeToLoad();
            BuildQuotePage.FillQuoteFormDefaultData();
            BuildQuotePage.ClickGetInternetPriceButton();
            BuildConfirmationPage.WaitForBuildConfirmationPageToLoad();
            BuildConfirmationPage.VerifyNewBuildConfirmationAsExpected();
        }
    }
}
