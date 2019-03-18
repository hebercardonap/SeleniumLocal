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
    public class AcePartRequiresPartTests : TestBase
    {
        [Test, Category(TestCategories.ACE), Category(TestCategories.PART_REQUIRES_PART), RetryDynamic]
        public void VerifyPrpRuleIsTriggeredForAce()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.ACE, ModelPageUrl.ACE_570_EPS_PRP);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Utility");
            Accessories.ClickSubcategoryByName("Lighting");
            Accessories.ClickAccessoryAddByProductName("Dual Row LED Light Bar");
            Assert.IsTrue(Accessories.IsPrpContainerDisplayed(), "Part Requires Part was nod triggered");
            Accessories.ClickPrpSecondaryPartSelectByDesc("Poly Sport Roof");
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.VerifyItemsDescPresentBuildSummary(new string[] { "Dual Row LED Light Bar", "Poly Sport Roof" });
        }
    }
}
