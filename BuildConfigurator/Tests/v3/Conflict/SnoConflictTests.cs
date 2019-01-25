using AutomationFramework.DataProvider;
using AutomationFramework.Helpers;
using AutomationFramework.Utils;
using BuildConfigurator.Hooks;
using NUnit.Framework;

namespace BuildConfigurator.Tests.v3.Conflict
{
    [TestFixture]
    public class SnoConflictTests : TestBase
    {
        [Test, Category(TestCategories.SNO), Category(TestCategories.STEPPED_PROCESS), CustomRetry(3)]
        public void VerifyConflictRuleIsTriggeredForSno()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.SNO, ModelPageUrl.SNO_SWITCHBACK_600_XCR_CONFLICT);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Storage & Racks");
            Accessories.ClickSubcategoryByName("Underseat Bags");
            Accessories.ClickAccessoryAddByProductName("Rear Seat Bag");
            Accessories.ClickSubcategoryByName("Cargo Rack Bags");
            Accessories.ClickAccessoryAddByProductName("Rear Sport Rack Bag");
            Assert.IsTrue(Accessories.IsConflictContainerDisplayed());
        }

        [Test, Category(TestCategories.SNO), Category(TestCategories.STEPPED_PROCESS), RetryDynamicAttribute]
        public void VerifyRemovedPartFromConflictInBuildSummarySno()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.SNO, ModelPageUrl.SNO_SWITCHBACK_600_XCR_CONFLICT);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Storage & Racks");
            Accessories.ClickSubcategoryByName("Underseat Bags");
            Accessories.ClickAccessoryAddByProductName("Rear Seat Bag");
            Accessories.ClickSubcategoryByName("Cargo Rack Bags");
            Accessories.ClickAccessoryAddByProductName("Rear Sport Rack Bag");
            Assert.IsTrue(Accessories.IsConflictContainerDisplayed());
            Assert.IsFalse(Accessories.RemoveConlfictPartAndValidateInBuildSummary("Rear Sport Rack Bag"));
        }
    }
}
