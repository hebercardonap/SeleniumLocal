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

namespace BuildConfigurator.Tests.v2.Conflict
{
    [TestFixture]
    public class GemConflictTests : TestBase
    {
        [Test, Category(TestCategories.GEM), Category(TestCategories.ACCESSORY_CONFLICTS), RetryDynamic]
        public void VerifyConflictIsTriggeredGem()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.GEM, ModelPageUrl.GEM_EL_XD_CONFLICT);
            BuildConfigurePage.WaitForBuildPageToLoad();
            BuildConfigurePage.ClickAccessoryCategory("Power");
            BuildConfigurePage.ClickAccessorySubCategory("Battery");
            BuildConfigurePage.ClickSpecificAccessoryCardAddButton("Distance AGM");
            BuildConfigurePage.ClickAccessorySubCategory("Charging");
            BuildConfigurePage.ClickSpecificAccessoryCardAddButton("Level 2 Charger");
            BuildConfigurePage.VerifyConflictContainerDisplayed();
        }
    }
}
