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
    [Ignore("ATV is not in CPQ v3 yet")]
    public class AtvSummaryTests : TestBase
    {
        private static string DEALER_ID = "02040900";

        [Test, Category(TestCategories.ATV), Category(TestCategories.BUILD_SUMMARY), RetryDynamic]
        public void VerifySummaryDisplaysAddedAccessoryAtv()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.ATV, ModelPageUrl.ATV_450_HO_BASE_TEST);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Protection");
            Accessories.ClickSubcategoryByName("Handguards");
            Accessories.ClickAccessoryAddByProductName("Handguards- Black");
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.VerifyItemsDescPresentBuildSummary(new string[] { "Handguards- Black" });
        }

        [Test, Category(TestCategories.ATV), Category(TestCategories.BUILD_SUMMARY), RetryDynamic]
        public void VerifySummaryAccessoryRemoveRan()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RAN, ModelPageUrl.ATV_450_HO_BASE_TEST);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Protection");
            Accessories.ClickSubcategoryByName("Handguards");
            Accessories.ClickAccessoryAddByProductName("Handguards- Black");
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.RemoveAccessoryFromSummaryByDesc("Handguards- Black");
            Accessories.VerifyItemsDescNotPresentBuildSummary(new string[] { "Handguards- Black" });
        }

        [Test, Category(TestCategories.ATV), Category(TestCategories.BUILD_SUMMARY), RetryDynamic]
        public void VerifySummaryUIIconsAndNotesAtv()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RAN, ModelPageUrl.ATV_450_HO_BASE_TEST);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Protection");
            Accessories.ClickSubcategoryByName("Handguards");
            Accessories.ClickAccessoryAddByProductName("Handguards- Black");
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.VerifyBuildSummaryIconsNotPresent();
            Assert.IsTrue(Accessories.IsSummaryAdditionalNotesDisplayed(), "Additional Notes section was not displayed");
        }

        [Test, Category(TestCategories.ATV), Category(TestCategories.BUILD_SUMMARY), RetryDynamic]
        public void VerifySummaryDealerExperienceAtv()
        {
            CPQNavigate.NavigateToBrandDealerExpAccessoriesPage(Brand.RAN, ModelPageUrl.ATV_450_HO_BASE_TEST, DEALER_ID);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.VerifyIconsAndAdditionalNotesNotPresent();
        }

        [Test, Category(TestCategories.ATV), Category(TestCategories.BUILD_SUMMARY), RetryDynamic]
        public void VerifyKitAddedDisplayedSummaryAtv()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RAN, ModelPageUrl.ATV_450_HO_BASE_TEST);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Utility");
            Accessories.ClickSubcategoryByName("Plow Systems");
            Accessories.ClickAccessoryAddByProductName("Steel Blade");
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.VerifyKitPackageDescPresentBuildSummary(new string[] { "Poly Plow Blade System" });
            Accessories.Toolbar.ClickToolbarSaveIcon();
            Accessories.EnterBuildName();
            Accessories.ClickSaveBuildModalSave();
            AccountMgmt.Login(UserAccountData.NON_EMPLOYEE_1);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.VerifyKitPackageDescPresentBuildSummary(new string[] { "Poly Plow Blade System" });
            Accessories.OpenSavedBuildAndDelete();
        }
    }
}
