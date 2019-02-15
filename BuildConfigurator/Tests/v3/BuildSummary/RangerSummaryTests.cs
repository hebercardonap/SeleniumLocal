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

        [Test, Category(TestCategories.RAN), Category(TestCategories.BUILD_SUMMARY), RetryDynamic]
        public void VerifyKitAddedDisplayedSummary()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RAN, ModelPageUrl.RANGER_500_SAGE_GREEN_ACCESSORIES);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Utility");
            Accessories.ClickSubcategoryByName("Plow Systems");
            Accessories.ClickAccessoryAddByProductName("Steel Blade");
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.VerifyKitPackageDescPresentBuildSummary(new string[] { "Plow System" });
            Accessories.Toolbar.ClickToolbarSaveIcon();
            Accessories.EnterBuildName();
            Accessories.ClickSaveBuildModalSave();
            AccountMgmt.Login(UserAccountData.NON_EMPLOYEE_1);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.VerifyKitPackageDescPresentBuildSummary(new string[] { "Plow System" });
            Accessories.OpenSavedBuildAndDelete();
        }

        [Test, Category(TestCategories.RAN), Category(TestCategories.BUILD_SUMMARY), RetryDynamic]
        public void VerifyPackageSubproductsSummary()
        {
            List<string> subproducts = new List<string>();
            CPQNavigate.NavigateToPackagesPage(Brand.RAN, ModelPageUrl.RANGER_XP1000_EPS_STEEL_BLUE_PACKAGES);
            Packages.WaitForPackagesPageToLoad();
            Packages.ClickPackageDetailsLinkByDesc("Ride Command");
            subproducts = Packages.GetPackageSubproductsNames();
            Packages.ClickAddPackageByDesc("Ride Command");
            Packages.FooterModule.ClickFooterNextButton();
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.ClickKitPackageDropDown();
            Accessories.VerifyItemsDescPresentBuildSummary(subproducts.ToArray());
        }
    }
}
