using AutomationFramework.DataProvider;
using AutomationFramework.Helpers;
using AutomationFramework.Utils;
using BuildConfigurator.Hooks;
using NUnit.Framework;

namespace BuildConfigurator.Tests.v3.PartRequiresPart
{
    [TestFixture]
    public class SlgPartRequiresPartTests : TestBase
    {
        [Test, 
            Category(TestCategories.SLG), 
            Category(TestCategories.PART_REQUIRES_PART),
            RetryDynamic]
        public void VerifyPrpRuleIsTriggeredForSlg()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.SLG, ModelPageUrl.SLG_S_PRP);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Style");
            Accessories.ClickSubcategoryByName("Wide Fenders");
            Accessories.ClickAccessoryAddByProductName("Ghost Gray");
            Assert.IsTrue(Accessories.IsPrpContainerDisplayed(), "Part Requires Part was nod triggered");
            Accessories.ClickPrpSecondaryPartSelectByDesc("Wheel Kit");
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.VerifyItemsDescPresentBuildSummary(new string[] { "Ghost Gray", "Wheel Kit" });
        }
    }
}
