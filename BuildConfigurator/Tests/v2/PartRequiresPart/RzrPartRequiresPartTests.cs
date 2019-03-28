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

namespace BuildConfigurator.Tests.v2.PartRequiresPart
{
    [TestFixture]
    [Ignore("Brand running CPQ v3 version")]
    public class RzrPartRequiresPartTests : TestBase
    {
        //[Test, Category(TestCategories.RZR), Category(TestCategories.PART_REQUIRES_PART), RetryDynamic]
        public void VerifyPartRequiresPartTriggeredRzr()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RZR, ModelPageUrl.RZR_XP_1000_EPS_PRP);
            BuildConfigurePage.WaitForBuildPageToLoad();
            BuildConfigurePage.ClickAccessoryCategory("Utility & Performance");
            BuildConfigurePage.ClickAccessorySubCategory("Winches");
            BuildConfigurePage.ClickSpecificAccessoryCardAddButton("Winch Cover Kit");
            Assert.IsTrue(BuildConfigurePage.IsPRPHeaderDisplayed(), "Part Requires Part was nod triggered");
            BuildConfigurePage.ClickSecondaryAccessoryByProductId("2882240");
            BuildConfigurePage.ClickBuildSummaryButton();
            BuildConfigurePage.VerifyItemsIdsPresentBuildSummary(new string[] { "2884118", "2882240" });

        }

        //[Test, Category(TestCategories.RZR), Category(TestCategories.PART_REQUIRES_PART), RetryDynamic]
        public void VerifyPrpDisplayedUponSecondaryPartRemovedRzr()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RZR, ModelPageUrl.RZR_XP_1000_EPS_PRP);
            BuildConfigurePage.WaitForBuildPageToLoad();
            BuildConfigurePage.ClickAccessoryCategory("Utility & Performance");
            BuildConfigurePage.ClickAccessorySubCategory("Winches");
            BuildConfigurePage.ClickSpecificAccessoryCardAddButton("Winch Cover Kit");
            Assert.IsTrue(BuildConfigurePage.IsPRPHeaderDisplayed(), "Part Requires Part was nod triggered");
            BuildConfigurePage.ClickSecondaryAccessoryByProductId("2882240");
            BuildConfigurePage.ClickBuildSummaryButton();
            BuildConfigurePage.ClickRemoveLinkByProductId("2882240");
            Assert.IsTrue(BuildConfigurePage.IsPRPHeaderDisplayed(), "Part Requires Part was nod triggered");

        }

        //[Test, Category(TestCategories.RZR), Category(TestCategories.PART_REQUIRES_PART), RetryDynamic]
        public void VerifySecondaryAccessoryPersistPrpRzr()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RZR, ModelPageUrl.RZR_XP_1000_EPS_PRP);
            BuildConfigurePage.WaitForBuildPageToLoad();
            BuildConfigurePage.ClickAccessoryCategory("Audio & Lighting");
            BuildConfigurePage.ClickAccessorySubCategory("Lighting");
            BuildConfigurePage.ClickSpecificAccessoryCardAddButton("LED Spot Light");
            Assert.IsTrue(BuildConfigurePage.IsPRPHeaderDisplayed(), "Part Requires Part was nod triggered");
            BuildConfigurePage.ClickSecondaryAccessoryByProductId("2884019-293");
            BuildConfigurePage.ClickBuildSummaryButton();
            BuildConfigurePage.ClickRemoveLinkByProductId("2882076");
            BuildConfigurePage.VerifyItemsIdsPresentBuildSummary(new string[] { "2884019-293" });

        }
    }
}
