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

namespace BuildConfigurator.Tests
{
    [TestFixture]
    public class PartRequiresPartTests : TestBase
    {
        [Test, Category("Ranger"), Category("PartRequiresPart"), CustomRetry(2)]
        public void VerifyPrpRuleIsTriggeredForRanger()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RAN, ModelPageUrl.RANGER_500_SAGE_GREEN_ACCESSORIES);
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
