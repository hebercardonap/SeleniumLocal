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
    public class SlgConflictTests : TestBase
    {
        [Test, Category(TestCategories.SLG), Category(TestCategories.ACCESSORY_CONFLICTS), CustomRetry(3)]
        public void VerifyConflictIsTriggeredSlg()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.SLG, ModelPageUrl.SLG_S_CONFLICT);
            BuildConfigurePage.WaitForBuildPageToLoad();
            BuildConfigurePage.ClickAccessoryCategory("Functional");
            BuildConfigurePage.ClickAccessorySubCategory("Performance");
            BuildConfigurePage.ClickSpecificAccessoryCardAddButton("wheel kit");
            BuildConfigurePage.ClickAccessoryCategory("Style");
            BuildConfigurePage.ClickAccessorySubCategory("narrow fenders");
            BuildConfigurePage.ClickRandomAccessoryCardAddButton();
            BuildConfigurePage.VerifyConflictContainerDisplayed();
        }
    }
}
