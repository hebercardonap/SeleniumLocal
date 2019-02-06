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

namespace BuildConfigurator.Tests.v2.PartRequiresPart
{
    [TestFixture]
    public class IndPartRequiresPartTests : TestBase
    {
        [Test, Category(TestCategories.IND), Category(TestCategories.PART_REQUIRES_PART), RetryDynamic]
        public void VerifyPartRequiresPartTriggeredGen()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.IND, ModelPageUrl.INDIAN_SPRINGFIELD_PRP);
            BuildConfigurePage.WaitForBuildPageToLoad();
            BuildConfigurePage.ClickAccessoryCategory("Storage & Luggage");
            BuildConfigurePage.ClickAccessorySubCategory("Touring Essentials");
            BuildConfigurePage.ClickSpecificAccessoryCardAddButton("Pinnacle Conchos");
            Assert.IsTrue(BuildConfigurePage.IsPRPHeaderDisplayed(), "Part Requires Part was not triggered");
            BuildConfigurePage.ClickSecondaryAccessoryByProductId("2879667-05");
            BuildConfigurePage.ClickBuildSummaryButton();
            BuildConfigurePage.VerifyItemsIdsPresentBuildSummary(new string[] { "2879674-266", "2879667-05" });

        }
    }
}
