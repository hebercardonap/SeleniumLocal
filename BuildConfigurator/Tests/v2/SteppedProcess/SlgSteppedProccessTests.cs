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
    public class SlgSteppedProccessTests : TestBase
    {
        [Test, Category(TestCategories.GEM), Category(TestCategories.STEPPED_PROCESS), CustomRetry(3)]
        public void VerifySlgSteppedProcessS()
        {
            CPQNavigate.NavigateToModelsPage(Brand.SLG);
            BuildModelPage.ClickSlingshotByVersion("S");
        }

        [Test, Category(TestCategories.GEM), Category(TestCategories.STEPPED_PROCESS), CustomRetry(3)]
        public void VerifySlgSteppedProcessTouring()
        {
            CPQNavigate.NavigateToModelsPage(Brand.SLG);
            BuildModelPage.ClickSlingshotByVersion("touring");
            CompleteSteppedProcessAndValidate();
        }

        [Test, Category(TestCategories.GEM), Category(TestCategories.STEPPED_PROCESS), CustomRetry(3)]
        public void VerifySlgSteppedProcessSL()
        {
            CPQNavigate.NavigateToModelsPage(Brand.SLG);
            BuildModelPage.ClickSlingshotByVersion("SL");
            CompleteTrimSteppedProcessAndValidate();
        }

        [Test, Category(TestCategories.GEM), Category(TestCategories.STEPPED_PROCESS), CustomRetry(3)]
        public void VerifySlgSteppedProcessSLR()
        {
            CPQNavigate.NavigateToModelsPage(Brand.SLG);
            BuildModelPage.ClickSlingshotByVersion("SLR");
            CompleteTrimSteppedProcessAndValidate();
        }

        private void CompleteSteppedProcessAndValidate()
        {
            BuildConfigurePage.WaitForBuildPageToLoad();
            BuildConfigurePage.ClickAccessoryCategory("functional");
            BuildConfigurePage.ClickAccessorySubCategory("covers");
            BuildConfigurePage.ClickRandomAccessoryCardAddButton();
            BuildConfigurePage.ClickIamFinishedButtonOld();
            BuildQuotePage.WaitForBuildQuotePgeToLoad();
            BuildQuotePage.FillQuoteFormDefaultData();
            BuildQuotePage.ClickGetInternetPriceButton();
            BuildConfirmationPage.WaitForBuildConfirmationPageToLoad();
            BuildConfirmationPage.VerifyBuildconfirmationPageIsAsExpected();
        }

        private void CompleteTrimSteppedProcessAndValidate()
        {
            BuildTrimPage.ClickRandomTrimOldVersion();
            BuildConfigurePage.WaitForBuildPageToLoad();
            BuildConfigurePage.ClickAccessoryCategory("functional");
            BuildConfigurePage.ClickAccessorySubCategory("covers");
            BuildConfigurePage.ClickRandomAccessoryCardAddButton();
            BuildConfigurePage.ClickIamFinishedButtonOld();
            BuildQuotePage.WaitForBuildQuotePgeToLoad();
            BuildQuotePage.FillQuoteFormDefaultData();
            BuildQuotePage.ClickGetInternetPriceButton();
            BuildConfirmationPage.WaitForBuildConfirmationPageToLoad();
            BuildConfirmationPage.VerifyBuildconfirmationPageIsAsExpected();
        }
    }
}
