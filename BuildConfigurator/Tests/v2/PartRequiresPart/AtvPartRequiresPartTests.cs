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
    [Ignore("Brand running CPQ v3 version")]
    public class AtvPartRequiresPartTests : TestBase
    {
        //[Test, Category(TestCategories.ATV), Category(TestCategories.PART_REQUIRES_PART), RetryDynamic]
        public void VerifyPartRequiresPartTriggeredAtv()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.ATV, ModelPageUrl.ATV_6x6_570_EPS_PRP);
            BuildConfigurePage.WaitForBuildPageToLoad();
            BuildConfigurePage.ClickAccessoryCategory("Utility");
            BuildConfigurePage.ClickAccessorySubCategory("Lighting");
            BuildConfigurePage.ClickSpecificAccessoryCardAddButton("Cube - LED Spot Light");
            Assert.IsTrue(BuildConfigurePage.IsPRPHeaderDisplayed(), "Part Requires Part was not triggered");

        }
    }
}
