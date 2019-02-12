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
    public class SlgPartRequiresPartTests : TestBase
    {
        [Test, Category(TestCategories.SLG), Category(TestCategories.PART_REQUIRES_PART), RetryDynamic]
        public void VerifyPartRequiresPartTriggeredSlg()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.SLG, ModelPageUrl.SLG_S_PRP);
            BuildConfigurePage.WaitForBuildPageToLoad();
            BuildConfigurePage.ClickAccessoryCategory("Style");
            BuildConfigurePage.ClickAccessorySubCategory("Wide Fenders");
            BuildConfigurePage.ClickSpecificAccessoryCardAddButton("Ghost Gray");
            Assert.IsTrue(BuildConfigurePage.IsPRPHeaderDisplayed(), "Part Requires Part was not triggered");

        }
    }
}
