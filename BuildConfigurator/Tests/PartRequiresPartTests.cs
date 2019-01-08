using AutomationFramework.Utils;
using BuildConfigurator.Hooks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Tests
{
    [TestFixture]
    public class PartRequiresPartTests : TestBase
    {
        [Test, Category("Ranger"), Category("PartRequiresPart")]
        public void VerifyPrpRuleIsTriggeredForRanger()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RAN, "ranger-500-sage-green");
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Utility");
            Accessories.ClickSubcategoryByName("Cargo & Bed Storage");
            Accessories.ClickAccessoryAddByProductName("XL Transport");
            Assert.IsTrue(Accessories.IsPrpContainerDisplayed());
            Accessories.ClickPrpSecondaryPartSelectByProductId("2884106");
            Accessories.AreProductIdsAddedBuildSummary(new List<string>() { "2884106" });
        }
    }
}
