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

namespace BuildConfigurator.Tests.v3.Package
{
    [TestFixture]
    public class RangerPackageTests : TestBase
    {
        [Test, Category(TestCategories.PACKAGES_PAGE), Category(TestCategories.RAN), RetryDynamic]
        [Ignore("Ignoring this tests as id is not changing until submission is done")]
        public void VerifyPackageAddPersistUntilBuildSubmission()
        {
            CPQNavigate.NavigateToPackagesPage(Brand.RAN, ModelPageUrl.RANGER_XP1000_EPS_STEEL_BLUE_PACKAGES);
            Packages.WaitForPackagesPageToLoad();
            string ModelId = Packages.GetWholegoodModelId();
            Packages.AddRandomAvailablePackage();
            Assert.IsTrue(Packages.VerifyModelIdChangedAfterPackageAdd(ModelId));
            ModelId = Packages.GetWholegoodModelId();
            Packages.FooterModule.ClickFooterNextButton();
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Wheel");
            Accessories.ClickSubcategoryByName("Trail");
            Accessories.ClickAccessoryAddByProductName("Buckle- Accent");
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.ClikIamFinishedButton();
            Quote.WaitForBuildQuotePageToLoad();
            Quote.FillQuoteFormDefaultData();
            Quote.ClickGetInternetPriceButton();
            Confirmation.WaitUntilConfirmationPageLoads();
            Assert.AreEqual(Confirmation.GetQuoteModelId(), ModelId);
        }

        [Test, Category(TestCategories.PACKAGES_PAGE), Category(TestCategories.RAN), RetryDynamic]
        public void VerifyPackageAddPersistsAfterBuildSaved()
        {
            CPQNavigate.NavigateToPackagesPage(Brand.RAN, ModelPageUrl.RANGER_XP1000_EPS_STEEL_BLUE_PACKAGES);
            Packages.WaitForPackagesPageToLoad();
            Packages.ClickAddPackageByDesc("Ride Command");
            Packages.FooterModule.ClickFooterNextButton();
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Wheel");
            Accessories.ClickSubcategoryByName("Trail");
            Accessories.ClickAccessoryAddByProductName("Buckle- Accent");
            Accessories.Toolbar.ClickToolbarSaveIcon();
            Accessories.EnterBuildName();
            Accessories.ClickSaveBuildModalSave();
            AccountMgmt.Login(UserAccountData.NON_EMPLOYEE_1);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.VerifyKitPackageDescPresentBuildSummary(new string[] { "Ride Command" });
        }

    }
}
