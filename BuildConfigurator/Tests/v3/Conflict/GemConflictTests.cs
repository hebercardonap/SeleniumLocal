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
    public class GemConflictTests : TestBase
    {
        [Test, Category(TestCategories.GEM), Category(TestCategories.ACCESSORY_CONFLICTS), RetryDynamic]
        public void VerifyConflictRuleIsTriggeredGem()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.GEM, ModelPageUrl.GEM_EL_XD_CONFLICT);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Power");
            Accessories.ClickSubcategoryByName("Battery");
            Accessories.ClickAccessoryAddByProductName("Distance AGM");
            Accessories.ClickSubcategoryByName("Charging");
            Accessories.ClickAccessoryAddByProductName("6 kW Level 2 Charger");
            Assert.IsTrue(Accessories.IsConflictContainerDisplayed(), "Conflict container not displayed as expected");
        }

        [Test, Category(TestCategories.GEM), Category(TestCategories.ACCESSORY_CONFLICTS), RetryDynamic]
        public void VerifyRemovedPartFromConflictInBuildSummaryGem()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.GEM, ModelPageUrl.GEM_EL_XD_CONFLICT);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Power");
            Accessories.ClickSubcategoryByName("Battery");
            Accessories.ClickAccessoryAddByProductName("Distance AGM");
            Accessories.ClickSubcategoryByName("Charging");
            Accessories.ClickAccessoryAddByProductName("6 kW Level 2 Charger");
            Assert.IsTrue(Accessories.IsConflictContainerDisplayed(), "Conflict container not displayed as expected");
            Assert.IsFalse(Accessories.RemoveConlfictPartAndValidateInBuildSummary("6 kW Level 2 Charger"),
                "Conflicting part was not removed from build summary");
        }
    }
}
