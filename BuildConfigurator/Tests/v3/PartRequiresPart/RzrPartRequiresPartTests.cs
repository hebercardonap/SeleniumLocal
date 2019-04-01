using AutomationFramework.DataProvider;
using AutomationFramework.Helpers;
using AutomationFramework.Utils;
using BuildConfigurator.Hooks;
using NUnit.Framework;

namespace BuildConfigurator.Tests.v3.PartRequiresPart
{
    [TestFixture]
    public class RzrPartRequiresPartTests : TestBase
    {
        [Test, Category(TestCategories.RZR), Category(TestCategories.PART_REQUIRES_PART), RetryDynamic]
        public void VerifyPrpRuleIsTriggeredForRzr()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RZR, ModelPageUrl.RZR_XP_1000_EPS_PRP);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Utility & Performance");
            Accessories.ClickSubcategoryByName("Winches");
            Accessories.ClickAccessoryAddByProductName("Winch Cover Kit");
            Assert.IsTrue(Accessories.IsPrpContainerDisplayed(), "Part Requires Part was nod triggered");
            Accessories.ClickPrpSecondaryPartSelectByDesc("Rapid Rope Recovery");
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.VerifyItemsDescPresentBuildSummary(new string[] { "Winch Cover Kit", "Rapid Rope Recovery" });
        }

        [Test, Category(TestCategories.RZR), Category(TestCategories.PART_REQUIRES_PART), RetryDynamic]
        public void VerifyPrpDisplayedUponSecondaryPartRemovedRzr()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RZR, ModelPageUrl.RZR_XP_1000_EPS_PRP);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Utility & Performance");
            Accessories.ClickSubcategoryByName("Winches");
            Accessories.ClickAccessoryAddByProductName("Winch Cover Kit");
            Assert.IsTrue(Accessories.IsPrpContainerDisplayed(), "Part Requires Part was nod triggered");
            Accessories.ClickPrpSecondaryPartSelectByDesc("Rapid Rope Recovery");
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.RemoveAccessoryFromSummaryByDesc("Rapid Rope Recovery");
            Assert.IsTrue(Accessories.IsPrpContainerDisplayed(), "Part Requires Part was nod triggered");
        }

        [Test, Category(TestCategories.RZR), Category(TestCategories.PART_REQUIRES_PART), RetryDynamic]
        public void VerifySecondaryAccessoryPersistPrpRzr()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RZR, ModelPageUrl.RZR_XP_1000_EPS_PRP);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Protection");
            Accessories.ClickSubcategoryByName("Front Bumpers");
            Accessories.ClickAccessoryAddByProductName("Front - Indy Red");
            Accessories.ClickCategoryByName("Audio & Lighting");
            Accessories.ClickSubcategoryByName("Lighting");
            Accessories.ClickAccessoryAddByProductName("LED Spot Light");
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.RemoveAccessoryFromSummaryByDesc("LED Spot Light");
            Accessories.VerifyItemsDescPresentBuildSummary(new string[] { "Front - Indy Red" });
        }
    }
}
