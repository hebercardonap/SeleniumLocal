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
    public class GenPartRequiresPartTests : TestBase
    {
        [Test, Category(TestCategories.GEN), Category(TestCategories.PART_REQUIRES_PART), RetryDynamic]
        public void VerifyPrpRuleIsTriggeredForGen()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.GEN, ModelPageUrl.GENERAL_1000_EPS_PRP);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Cab Components");
            Accessories.ClickSubcategoryByName("Windshields");
            Accessories.ClickAccessoryAddByProductName("Windshield Wiper Kit");
            Assert.IsTrue(Accessories.IsPrpContainerDisplayed(), "Part Requires Part was nod triggered");
            Accessories.ClickPrpSecondaryPartSelectByDesc("Glass Windshield");
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.VerifyItemsDescPresentBuildSummary(new string[] { "Windshield Wiper Kit", "Glass Windshield" });
        }
    }
}
