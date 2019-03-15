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
    public class RzrSummaryTests : TestBase
    {
        private static string DEALER_ID = "54321";

        [Test, Category(TestCategories.RZR), Category(TestCategories.BUILD_SUMMARY), RetryDynamic]
        public void VerifySummaryDisplaysAddedAccessoryRzr()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RZR, ModelPageUrl.RZR_XP_1000_EPS_BASE_TEST);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Tire & Wheel Sets");
            Accessories.ClickSubcategoryByName("Trail");
            Accessories.ClickAccessoryAddByProductName("Dual-Threat 32");
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.VerifyItemsDescPresentBuildSummary(new string[] { "Dual-Threat 32" });
        }

        [Test, Category(TestCategories.RZR), Category(TestCategories.BUILD_SUMMARY), RetryDynamic]
        public void VerifySummaryAccessoryRemoveRzr()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RZR, ModelPageUrl.RZR_XP_1000_EPS_BASE_TEST);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Tire & Wheel Sets");
            Accessories.ClickSubcategoryByName("Trail");
            Accessories.ClickAccessoryAddByProductName("Dual-Threat 32");
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.RemoveAccessoryFromSummaryByDesc("Dual-Threat 32");
            Accessories.VerifyItemsDescNotPresentBuildSummary(new string[] { "Dual-Threat 32" });
        }

        [Test, Category(TestCategories.RZR), Category(TestCategories.BUILD_SUMMARY), RetryDynamic]
        public void VerifySummaryUIIconsAndNotesRzr()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RZR, ModelPageUrl.RZR_XP_1000_EPS_BASE_TEST);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Tire & Wheel Sets");
            Accessories.ClickSubcategoryByName("Trail");
            Accessories.ClickAccessoryAddByProductName("Dual-Threat 32");
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.VerifyBuildSummaryIconsNotPresent();
            Assert.IsTrue(Accessories.IsSummaryAdditionalNotesDisplayed(), "Additional Notes section was not displayed");
        }

        [Test, Category(TestCategories.RZR), Category(TestCategories.BUILD_SUMMARY), RetryDynamic]
        public void VerifySummaryDealerExperienceRzr()
        {
            CPQNavigate.NavigateToBrandDealerExpAccessoriesPage(Brand.RZR, ModelPageUrl.RZR_XP_1000_EPS_BASE_TEST, DEALER_ID);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.VerifyIconsAndAdditionalNotesNotPresent();
        }

        [Test, Category(TestCategories.RZR), Category(TestCategories.BUILD_SUMMARY), RetryDynamic]
        public void VerifyKitAddedDisplayedSummaryRzr()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RZR, ModelPageUrl.RZR_XP_1000_EPS_BASE_TEST);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Utility & Performance");
            Accessories.ClickSubcategoryByName("Winches");
            Accessories.ClickAccessoryAddByProductName("Winch Cover Kit");
            Accessories.ClickPrpSecondaryPartSelectByDesc("Rapid Rope Recovery");
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.VerifyKitPackageDescPresentBuildSummary(new string[] { "Winch Cover Kit" });
            Accessories.Toolbar.ClickToolbarSaveIcon();
            Accessories.EnterBuildName();
            Accessories.ClickSaveBuildModalSave();
            AccountMgmt.Login(UserAccountData.NON_EMPLOYEE_1);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.VerifyItemsDescPresentBuildSummary(new string[] { "Winch Cover Kit", "Rapid Rope Recovery" });
            Accessories.OpenSavedBuildAndDelete();
        }
    }
}
