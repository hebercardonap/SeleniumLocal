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
    public class GemSteppedProccessTests : TestBase
    {
        [Test, Category(TestCategories.GEM), Category(TestCategories.STEPPED_PROCESS), CustomRetry(3)]
        public void VerifyGemSteppedProcessPassenger()
        {
            CPQNavigate.NavigateToModelsPage(Brand.GEM);
            BuildModelPage.ClickFamilyCategorySlide("Passenger");
            BuildModelPage.ClickRandomWholeGoodCard();
            BuildConfigurePage.WaitForBuildPageToLoad();
            BuildConfigurePage.ClickAccessoryCategory("Exterior");
            BuildConfigurePage.ClickAccessorySubCategory("Bumper");
            BuildConfigurePage.ClickRandomAccessoryCardAddButton();
            BuildConfigurePage.ClickIamFinishedButtonOld();
            BuildQuotePage.WaitForBuildQuotePgeToLoad();
            BuildQuotePage.FillQuoteFormDefaultData();
            BuildQuotePage.ClickFormPersonalUseOption();
            BuildQuotePage.ClickGetInternetPriceButton();
            BuildConfirmationPage.WaitForGemConfirmationPageToLoad();
            BuildConfirmationPage.ClickBuildSummaryToggleCaret();
            Assert.IsTrue(BuildConfirmationPage.GetGemAddedAccessoriesCount() > 0);
        }

        [Test, Category(TestCategories.GEM), Category(TestCategories.STEPPED_PROCESS), CustomRetry(3)]
        public void VerifyGemSteppedProcessUtility()
        {
            CPQNavigate.NavigateToModelsPage(Brand.GEM);
            BuildModelPage.ClickFamilyCategorySlide("Utility");
            BuildModelPage.ClickRandomWholeGoodCard();
            BuildConfigurePage.WaitForBuildPageToLoad();
            BuildConfigurePage.ClickAccessoryCategory("Exterior");
            BuildConfigurePage.ClickAccessorySubCategory("Roof");
            BuildConfigurePage.ClickRandomAccessoryCardAddButton();
            BuildConfigurePage.ClickIamFinishedButtonOld();
            BuildQuotePage.WaitForBuildQuotePgeToLoad();
            BuildQuotePage.FillQuoteFormDefaultData();
            BuildQuotePage.ClickFormPersonalUseOption();
            BuildQuotePage.ClickGetInternetPriceButton();
            BuildConfirmationPage.WaitForGemConfirmationPageToLoad();
            BuildConfirmationPage.ClickBuildSummaryToggleCaret();
            Assert.IsTrue(BuildConfirmationPage.GetGemAddedAccessoriesCount() > 0);
        }
    }
}
