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
    public class RangerSummaryTests : TestBase
    {
        private static string DEALER_ID = "02040900";

        [Test, Category(TestCategories.RAN), Category(TestCategories.BUILD_SUMMARY), RetryDynamic]
        public void VerifySummaryDisplaysAddedAccessory()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RAN, ModelPageUrl.RANGER_500_SAGE_GREEN_ACCESSORIES);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Utility");
            Accessories.ClickSubcategoryByName("Cargo & Bed Storage");
            Accessories.ClickAccessoryAddByProductName("Cargo Box");
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.VerifyItemsDescPresentBuildSummary(new string[] { "Cargo Box" });
        }

        [Test, Category(TestCategories.RAN), Category(TestCategories.BUILD_SUMMARY), RetryDynamic]
        public void VerifySummaryAccessoryRemove()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RAN, ModelPageUrl.RANGER_500_SAGE_GREEN_ACCESSORIES);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Utility");
            Accessories.ClickSubcategoryByName("Cargo & Bed Storage");
            Accessories.ClickAccessoryAddByProductName("Cargo Box");
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.RemoveAccessoryFromSummaryByDesc("Cargo Box");
            Accessories.VerifyItemsDescNotPresentBuildSummary(new string[] { "Cargo Box" });
        }

        [Test, Category(TestCategories.RAN), Category(TestCategories.BUILD_SUMMARY), RetryDynamic]
        public void VerifySummaryUIIconsAndNotes()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RAN, ModelPageUrl.RANGER_500_SAGE_GREEN_ACCESSORIES);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Utility");
            Accessories.ClickSubcategoryByName("Cargo & Bed Storage");
            Accessories.ClickAccessoryAddByProductName("Cargo Box");
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.VerifyBuildSummaryIconsNotPresent();
            Assert.IsTrue(Accessories.IsSummaryAdditionalNotesDisplayed());
        }

        [Test, Category(TestCategories.RAN), Category(TestCategories.BUILD_SUMMARY), RetryDynamic]
        public void VerifySummaryDealerExperience()
        {
            CPQNavigate.NavigateToBrandDealerExpAccessoriesPage(Brand.RAN, ModelPageUrl.RANGER_500_SAGE_GREEN_ACCESSORIES, DEALER_ID);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.VerifyIconsAndAdditionalNotesNotPresent();
        }
    }
}
