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
    [Ignore("Brand running CPQ v3 version")]
    public class GenConflictTests : TestBase
    {
        [Test, Category(TestCategories.GEN), Category(TestCategories.ACCESSORY_CONFLICTS), RetryDynamic]
        public void VerifyConflictIsTriggeredGen()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.GEN, ModelPageUrl.GENERAL_4_1000_EPS_CONFLICT);
            BuildConfigurePage.WaitForBuildPageToLoad();
            BuildConfigurePage.ClickAccessoryCategory("Utility");
            BuildConfigurePage.ClickAccessorySubCategory("Bumpers");
            BuildConfigurePage.ClickSpecificAccessoryCardAddButton("Front Sport");
            BuildConfigurePage.ClickAccessorySubCategory("cargo & bed storage");
            BuildConfigurePage.ClickSpecificAccessoryCardAddButton("Front Hood Storage Rack");
            BuildConfigurePage.VerifyConflictContainerDisplayed();
        }
    }
}
