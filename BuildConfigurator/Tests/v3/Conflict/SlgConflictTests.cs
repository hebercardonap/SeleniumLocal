using AutomationFramework.DataProvider;
using AutomationFramework.Helpers;
using AutomationFramework.Utils;
using BuildConfigurator.Hooks;
using NUnit.Framework;

namespace BuildConfigurator.Tests.v3.Conflict
{
    [TestFixture]
    public class SlgConflictTests : TestBase
    {
        [Test, Category(TestCategories.SLG), Category(TestCategories.ACCESSORY_CONFLICTS), RetryDynamic]
        public void VerifyConflictRuleIsTriggeredSlg()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.SLG, ModelPageUrl.SLG_S_CONFLICT);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Functional");
            Accessories.ClickSubcategoryByName("Performance");
            Accessories.ClickAccessoryAddByProductName("wheel kit");
            Accessories.ClickCategoryByName("Style");
            Accessories.ClickSubcategoryByName("Narrow fenders");
            Accessories.ClickAccessoryAddByProductName("Fender");
            Assert.IsTrue(Accessories.IsConflictContainerDisplayed(), "Conflict container not displayed as expected");
        }
    }
}
