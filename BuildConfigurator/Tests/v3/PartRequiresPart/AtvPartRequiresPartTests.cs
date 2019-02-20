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
    [Ignore("ATV is not on CPQ v3 yet, Ignore flag will be removed when ATV switches to v3 UI")]
    public class AtvPartRequiresPartTests : TestBase
    {
        [Test, Category(TestCategories.ATV), Category(TestCategories.PART_REQUIRES_PART), RetryDynamic]
        public void VerifyPrpRuleIsTriggeredForAtv()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.ATV, ModelPageUrl.ATV_450_HO_BASE_TEST);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Utility");
            Accessories.ClickSubcategoryByName("Lighting");
            Accessories.ClickAccessoryAddByProductName("Cube - LED Spot Light");
            Assert.IsTrue(Accessories.IsPrpContainerDisplayed());
            Accessories.ClickPrpSecondaryPartSelectByDesc("Front Brushguard- Black");
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.ClickKitPackageDropDown();
            Accessories.VerifyItemsDescPresentBuildSummary(new string[] { "Cube - LED Spot Light", "Front Brushguard- Black" });
        }
    }
}
