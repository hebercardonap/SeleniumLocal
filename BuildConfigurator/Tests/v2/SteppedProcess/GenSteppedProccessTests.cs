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
    public class GenSteppedProccessTests : TestBase
    {
        [Test, Category(TestCategories.STEPPED_PROCESS), Category(TestCategories.GEN), RetryDynamic]
        public void VerifyGenSteppedProcessTwoSeats()
        {
            CPQNavigate.NavigateToModelsPage(Brand.GEN);
            BuildModelPage.ClickTwoSeat();
            CompleteSteppedProcessAndValidate();
        }

        [Test, Category(TestCategories.STEPPED_PROCESS), Category(TestCategories.GEN), RetryDynamic]
        public void VerifyGenSteppedProcessFourSeats()
        {
            CPQNavigate.NavigateToModelsPage(Brand.GEN);
            BuildModelPage.ClickFourSeat();
            CompleteSteppedProcessAndValidate();
        }

        private void CompleteSteppedProcessAndValidate()
        {
            BuildModelPage.ClickUniqueColorGeneralModel();
            BuildTrimPage.ClickRandomTrim();
            BuildConfigurePage.WaitForBuildPageToLoad();
            BuildConfigurePage.AddRandomTiresAccessory();
            BuildConfigurePage.ClickIamFinishedButton();
            BuildQuotePage.WaitForBuildQuotePgeToLoad();
            BuildQuotePage.FillQuoteFormDefaultData();
            BuildQuotePage.ClickGetInternetPriceButton();
            BuildConfirmationPage.WaitForBuildConfirmationPageToLoad();
            BuildConfirmationPage.VerifyBuildconfirmationPageIsAsExpected();
        }
    }
}
