using AutomationFramework.DataProvider;
using AutomationFramework.Helpers;
using AutomationFramework.Utils;
using BuildConfigurator.Hooks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Tests.v3.QuoteConfirmation
{
    [TestFixture]
    public class QuoteConfirmationPageTests : TestBase
    {
        private static string DEALER_ID = "02040900";

        [Test, Category(TestCategories.RAN), Category(TestCategories.DEALER_EXPERIENCE), RetryDynamic]
        public void VerifyPrintNotDisplayedSummaryRan()
        {
            CPQNavigate.NavigateToBrandDealerExpAccessoriesPage(Brand.RAN, ModelPageUrl.RANGER_500_SAGE_GREEN_ACCESSORIES, DEALER_ID);
            Accessories.WaitForAccessoriesPageToLoad();
            Assert.IsFalse(Accessories.NavigationBarModule.IsNavigationBarDisplayed());
            Accessories.ClickCategoryByName("Wheel");
            Accessories.ClickSubcategoryByName("Trail");
            Accessories.ClickAccessoryAddByProductName("Buckle- Accent");
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.ClikIamFinishedButton();
            Quote.WaitForBuildQuotePageToLoad();
            Quote.FillDealerExpQuoteFormDefaultData();
            Quote.ClickGetInternetPriceButton();
            Confirmation.WaitUntilConfirmationPageLoads();
            Assert.IsFalse(Confirmation.IsSummaryPrintLinkDisplayed(), "Print summary is present on the page");
        }
    }
}
