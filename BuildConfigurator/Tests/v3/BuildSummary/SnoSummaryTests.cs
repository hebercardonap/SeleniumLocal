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

namespace BuildConfigurator.Tests.v3.BuildSummary
{
    [TestFixture]
    public class SnoSummaryTests : TestBase
    {
        private static string DEALER_ID = "02040900";

        [Test, Category(TestCategories.SNO), Category(TestCategories.BUILD_SUMMARY), RetryDynamic]
        public void VerifySummaryDisplaysAddedAccessorySno()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.SNO, ModelPageUrl.SNO_SWITCHBACK_600_BASE_TEST);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Protection");
            Accessories.ClickSubcategoryByName("Covers");
            Accessories.ClickAccessoryAddByProductName("Cover - Black");
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.VerifyItemsDescPresentBuildSummary(new string[] { "Cover - Black" });
        }

        [Test, Category(TestCategories.SNO), Category(TestCategories.BUILD_SUMMARY), RetryDynamic]
        public void VerifySummaryAccessoryRemoveSno()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.SNO, ModelPageUrl.SNO_SWITCHBACK_600_BASE_TEST);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Protection");
            Accessories.ClickSubcategoryByName("Covers");
            Accessories.ClickAccessoryAddByProductName("Cover - Black");
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.RemoveAccessoryFromSummaryByDesc("Cover - Black");
            Accessories.VerifyItemsDescNotPresentBuildSummary(new string[] { "Cover - Black" });
        }

        [Test, Category(TestCategories.SNO), Category(TestCategories.BUILD_SUMMARY), RetryDynamic]
        public void VerifySummaryUIIconsAndNotesSno()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.SNO, ModelPageUrl.SNO_SWITCHBACK_600_BASE_TEST);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Protection");
            Accessories.ClickSubcategoryByName("Covers");
            Accessories.ClickAccessoryAddByProductName("Cover - Black");
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.VerifyBuildSummaryIconsNotPresent();
            Assert.IsTrue(Accessories.IsSummaryAdditionalNotesDisplayed());
        }

        [Test, Category(TestCategories.SNO), Category(TestCategories.BUILD_SUMMARY), RetryDynamic]
        public void VerifySummaryDealerExperienceSno()
        {
            CPQNavigate.NavigateToBrandDealerExpAccessoriesPage(Brand.SNO, ModelPageUrl.SNO_SWITCHBACK_600_BASE_TEST, DEALER_ID);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.VerifyIconsAndAdditionalNotesNotPresent();
        }
    }
}
