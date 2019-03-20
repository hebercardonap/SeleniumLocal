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

namespace BuildConfigurator.Tests.v3.PartRequiresPart
{
    [TestFixture]
    public class GemPartRequiresPart : TestBase
    {
        [Test, Category(TestCategories.GEM), Category(TestCategories.PART_REQUIRES_PART), RetryDynamic]
        public void VerifyPrpRuleIsTriggeredForGem()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.GEM, ModelPageUrl.GEM_EL_XD_PRP);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Exterior");
            Accessories.ClickSubcategoryByName("Roof");
            Accessories.ClickAccessoryAddByProductName("Solar Panel");
            Assert.IsTrue(Accessories.IsPrpContainerDisplayed(), "Part Requires Part was nod triggered");
            Accessories.ClickPrpSecondaryPartSelectByDesc("Ladder Rack");
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.VerifyItemsDescPresentBuildSummary(new string[] { "Solar Panel", "Ladder Rack" });
        }

        [Test, Category(TestCategories.GEM), Category(TestCategories.PART_REQUIRES_PART), RetryDynamic]
        public void VerifyPrpPersistsAfterConflictGem()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.GEM, ModelPageUrl.GEM_EL_XD_PRP);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Power");
            Accessories.ClickSubcategoryByName("Battery");
            Accessories.ClickAccessoryAddByProductName("Distance AGM");
            Accessories.ClickSubcategoryByName("Charging");
            Accessories.ClickAccessoryAddByProductName("6 kW Level 2 Charger");
            Assert.IsTrue(Accessories.IsConflictContainerDisplayed(), "Conflict container was not displayed");
            Accessories.ClickConflictingItemRemoveByDesc("6 kW Level 2 Charger");
            Accessories.ClickCategoryByName("Exterior");
            Accessories.ClickSubcategoryByName("Roof");
            Accessories.ClickAccessoryAddByProductName("Solar Panel");
            Assert.IsTrue(Accessories.IsPrpContainerDisplayed(), "Part Requires Part was nod triggered");
        }
    }
}
