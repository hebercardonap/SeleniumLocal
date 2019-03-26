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

namespace BuildConfigurator.Tests.v3.Conflict
{
    [TestFixture]
    public class RzrConflictTests : TestBase
    {
        [Test, Category(TestCategories.RZR), Category(TestCategories.ACCESSORY_CONFLICTS), RetryDynamic]
        public void VerifyConflictRuleIsTriggeredRzr()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RZR, ModelPageUrl.RZR_XP_1000_EPS_CONFLICT);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Utility");
            Accessories.ClickSubcategoryByName("Storage & Bed Accessories");
            Accessories.ClickAccessoryAddByProductName("Spare Tire Carrier");
            Accessories.ClickCategoryByName("Protection");
            Accessories.ClickSubcategoryByName("Cage System");
            Accessories.ClickAccessoryAddByProductName("Cage System - Black");
            Assert.IsTrue(Accessories.IsConflictContainerDisplayed(), "Conflict container not displayed as expected");
        }

        [Test, Category(TestCategories.RZR), Category(TestCategories.ACCESSORY_CONFLICTS), RetryDynamic]
        public void VerifyRemovedPartFromConflictInBuildSummaryRzr()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RZR, ModelPageUrl.RZR_XP_1000_EPS_CONFLICT);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Utility");
            Accessories.ClickSubcategoryByName("Storage & Bed Accessories");
            Accessories.ClickAccessoryAddByProductName("Spare Tire Carrier");
            Accessories.ClickCategoryByName("Protection");
            Accessories.ClickSubcategoryByName("Cage System");
            Accessories.ClickAccessoryAddByProductName("Cage system - Black");
            Assert.IsTrue(Accessories.IsConflictContainerDisplayed(), "Conflict container not displayed as expected");
            Assert.IsFalse(Accessories.RemoveConlfictPartAndValidateInBuildSummary("Cage system - Black"),
                "Conflicting part was not removed from build summary");
        }
    }
}
