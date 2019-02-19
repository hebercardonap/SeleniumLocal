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
    public class AtvConflictTests : TestBase
    {
        [Test, Category(TestCategories.ATV), Category(TestCategories.ACCESSORY_CONFLICTS), RetryDynamic]
        public void VerifyConflictRuleIsTriggeredForAtv()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.ATV, ModelPageUrl.ATV_450_HO_CONFLICT);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Protection");
            Accessories.ClickSubcategoryByName("Windshields");
            Accessories.ClickAccessoryAddByProductName("Windshield- Clear");
            Accessories.ClickSubcategoryByName("Handguards");
            Accessories.ClickAccessoryAddByProductName("Handguards- Black");
            Assert.IsTrue(Accessories.IsConflictContainerDisplayed(), "Conflict container not displayed as expected");
        }

        [Test, Category(TestCategories.ATV), Category(TestCategories.ACCESSORY_CONFLICTS), RetryDynamic]
        public void VerifyRemovedPartFromConflictInBuildSummaryRan()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RAN, ModelPageUrl.ATV_450_HO_CONFLICT);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Protection");
            Accessories.ClickSubcategoryByName("Windshields");
            Accessories.ClickAccessoryAddByProductName("Windshield- Clear");
            Accessories.ClickSubcategoryByName("Handguards");
            Accessories.ClickAccessoryAddByProductName("Handguards- Black");
            Assert.IsTrue(Accessories.IsConflictContainerDisplayed(), "Conflict container not displayed as expected");
            Assert.IsFalse(Accessories.RemoveConlfictPartAndValidateInBuildSummary("Flip-Down Full Windshield"), 
                "Conflicting part was not removed from build summary");
        }
    }
}
