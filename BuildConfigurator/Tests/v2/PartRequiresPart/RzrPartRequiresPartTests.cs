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
    public class RzrPartRequiresPartTests : TestBase
    {
        [Test, Category(TestCategories.RZR), Category(TestCategories.PART_REQUIRES_PART), CustomRetry(3)]
        public void VerifyPartRequiresPartTriggeredRzr()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RZR, ModelPageUrl.RZR_XP_1000_EPS_PRP);
            BuildConfigurePage.WaitForBuildPageToLoad();
            BuildConfigurePage.ClickAccessoryCategory("Utility & Performance");
            BuildConfigurePage.ClickAccessorySubCategory("Winches");
            BuildConfigurePage.ClickSpecificAccessoryCardAddButton("Winch Cover Kit");
            Assert.IsTrue(BuildConfigurePage.IsPRPHeaderDisplayed(), "Part Requires Part was nod triggered");
            BuildConfigurePage.ClickSecondaryAccessoryByProductId("2882240");
            BuildConfigurePage.ClickBuildSummaryButton();
            Assert.IsTrue(BuildConfigurePage.VerifyAccesoriesOnBuildSummary(new string[] { "2884118", "2882240" }));

        }
    }
}
