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
    public class SnoPartRequiresPartTests : TestBase
    {
        [Test, Category(TestCategories.SNO), Category(TestCategories.PART_REQUIRES_PART), RetryDynamic]
        public void VerifyPrpRuleIsTriggeredForSnow()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.SNO, ModelPageUrl.SNO_SWITCHBACK_600_SP);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Storage & Racks");
            Accessories.ClickSubcategoryByName("Cargo Rack Bags");
            Accessories.ClickAccessoryAddByProductName("Under Rack Bag");
            Assert.IsTrue(Accessories.IsPrpContainerDisplayed());
            Accessories.ClickPrpSecondaryPartSelectByDesc("Rear Seat Rack");
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.ClickKitPackageDropDown();
            Accessories.VerifyItemsDescPresentBuildSummary(new string[] { "Rear Seat Rack", "Under Rack Bag" });
        }
    }
}
