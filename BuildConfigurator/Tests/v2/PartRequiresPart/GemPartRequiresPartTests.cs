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
    public class GemPartRequiresPartTests : TestBase
    {
        [Test, Category(TestCategories.GEM), Category(TestCategories.PART_REQUIRES_PART), CustomRetry(3)]
        public void VerifyPartRequiresPartTriggeredGem()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.GEM, ModelPageUrl.GEM_EL_XD_PRP);
            BuildConfigurePage.WaitForBuildPageToLoad();
            BuildConfigurePage.ClickAccessoryCategory("Exterior");
            BuildConfigurePage.ClickAccessorySubCategory("Roof");
            BuildConfigurePage.ClickSpecificAccessoryCardAddButton("Solar Panel");
            Assert.IsTrue(BuildConfigurePage.IsPRPHeaderDisplayed(), "Part Requires Part was not triggered");

        }
    }
}
