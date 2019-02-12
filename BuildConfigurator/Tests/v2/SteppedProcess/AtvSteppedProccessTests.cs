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
    public class AtvSteppedProccessTests : TestBase
    {
        [Test, Category(TestCategories.ATV), Category(TestCategories.STEPPED_PROCESS), RetryDynamic]
        public void VerifyAtvSteppedProcessOneSeat()
        {
            CPQNavigate.NavigateToModelsPage(Brand.ATV);
            BuildModelPage.WaitForBuildModelPageToLoad();
            BuildModelPage.ClickOneSeat();
            CompleteSteppedProcessAndValidate();
        }

        [Test, Category(TestCategories.ATV), Category(TestCategories.STEPPED_PROCESS), RetryDynamic]
        public void VerifyAtvSteppedProcessTwoSeat()
        {
            CPQNavigate.NavigateToModelsPage(Brand.ATV);
            BuildModelPage.WaitForBuildModelPageToLoad();
            BuildModelPage.ClickTwoSeat();
            CompleteSteppedProcessAndValidate();
        }

        private void CompleteSteppedProcessAndValidate()
        {
            BuildModelPage.ClickRandomModel();
            BuildTrimPage.WaitForTrimPageToLoad();
            BuildTrimPage.ClickRandomTrim();
            BuildColorPage.WaitForColorPageToLoad();
            BuildColorPage.ClickColor();
            BuildColorPage.ClickNextButton();
            BuildConfigurePage.WaitForBuildPageToLoad();
            BuildConfigurePage.ClickAccessoryCategory("Protection");
            BuildConfigurePage.ClickAccessorySubCategory("Handguards");
            BuildConfigurePage.ClickRandomAccessoryCardAddButton();
            BuildConfigurePage.ClickIamFinishedButton();
            BuildQuotePage.WaitForBuildQuotePgeToLoad();
            BuildQuotePage.FillQuoteFormDefaultData();
            BuildQuotePage.ClickGetInternetPriceButton();
            BuildConfirmationPage.WaitForBuildConfirmationPageToLoad();
            BuildConfirmationPage.VerifyBuildconfirmationPageIsAsExpected();
        }
    }
}
