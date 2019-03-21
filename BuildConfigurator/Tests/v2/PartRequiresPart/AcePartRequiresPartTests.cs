using AutomationFramework.Helpers;
using AutomationFramework.Utils;
using BuildConfigurator.Hooks;
using NUnit.Framework;
using AutomationFramework.DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Tests.v2.PartRequiresPart
{
    [TestFixture]
    [Ignore("Brand running CPQ v3 version")]
    public class AcePartRequiresPartTests : TestBase
    {
        [Test, Category(TestCategories.ACE), Category(TestCategories.PART_REQUIRES_PART), RetryDynamic]
        public void VerifyPartRequiresPartTriggeredAce()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.ACE, ModelPageUrl.ACE_570_EPS_PRP);
            BuildConfigurePage.WaitForBuildPageToLoad();
            BuildConfigurePage.ClickAccessoryCategory("Utility");
            BuildConfigurePage.ClickAccessorySubCategory("Lighting");
            BuildConfigurePage.ClickSpecificAccessoryCardAddButton("Dual Row LED Light Bar");
            Assert.IsTrue(BuildConfigurePage.IsPRPHeaderDisplayed(), "Part Requires Part was nod triggered");
            BuildConfigurePage.ClickSecondaryAccessoryByProductId("2881147");
            BuildConfigurePage.ClickBuildSummaryButton();
            BuildConfigurePage.VerifyItemsIdsPresentBuildSummary(new string[] { "2883107", "2881147" });

        }
    }
}
