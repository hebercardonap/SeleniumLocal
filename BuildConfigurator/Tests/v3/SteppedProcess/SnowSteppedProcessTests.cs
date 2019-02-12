using AutomationFramework.Helpers;
using AutomationFramework.Utils;
using BuildConfigurator.Hooks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Tests.v3.SteppedProcess
{
    [TestFixture]
    class SnowSteppedProcessTests : TestBase
    {
        [Test, Category(TestCategories.SNO), Category(TestCategories.STEPPED_PROCESS), RetryDynamic]
        public void SnowSteppedProcess()
        {
            CPQNavigate.NavigateToModelsPage(Brand.SNO);
            Models.SelectSnowCardByFamily("rush");
            Models.SelectRandomModelVersion();
            Track.WaitForTrackPageToLoad();
            Track.ClickRandomTrack();
            Engine.WaitForEnginePageToLoad();
            Engine.ClickRandomWholegoodEngine();
            Engine.FooterModule.ClickFooterNextButton();
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Protection");
            Accessories.ClickSubcategoryByName("Covers");
            Accessories.ClickAccessoryAddByProductName("Undercover");
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.ClikIamFinishedButton();
            Quote.WaitForBuildQuotePageToLoad();
            Quote.FillQuoteFormDefaultData();
            Quote.ClickGetInternetPriceButton();
            Confirmation.WaitUntilConfirmationPageLoads();
            Confirmation.ConfirmationPageElementsAreAsExpected();
        }
    }
}
