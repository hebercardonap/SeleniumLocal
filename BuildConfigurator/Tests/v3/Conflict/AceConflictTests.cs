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

namespace BuildConfigurator.Tests.v3.Conflict
{
    [TestFixture]
    public class AceConflictTests : TestBase
    {
        [Test, Category(TestCategories.ACE), Category(TestCategories.ACCESSORY_CONFLICTS), RetryDynamic]
        public void VerifyConflictRuleIsTriggeredAce()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.ACE, ModelPageUrl.ACE_570_EPS_CONFLICT);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Utility");
            Accessories.ClickSubcategoryByName("Rack Extenders");
            Accessories.ClickAccessoryAddByProductName("Steel Bed Extender");
            Accessories.ClickSubcategoryByName("Storage");
            Accessories.ClickAccessoryAddByProductName("Rear Cargo Box");
            Assert.IsTrue(Accessories.IsConflictContainerDisplayed(), "Conflict container not displayed as expected");
        }
    }
}
