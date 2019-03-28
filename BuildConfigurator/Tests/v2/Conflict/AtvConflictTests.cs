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
    public class AtvConflictTests : TestBase
    {
        //[Test, Category(TestCategories.ATV), Category(TestCategories.ACCESSORY_CONFLICTS), RetryDynamic]
        public void VerifyConflictIsTriggeredAtv()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.ATV, ModelPageUrl.ATV_450_HO_CONFLICT);
            BuildConfigurePage.WaitForBuildPageToLoad();
            BuildConfigurePage.ClickAccessoryCategory("Protection");
            BuildConfigurePage.ClickAccessorySubCategory("Windshields");
            BuildConfigurePage.ClickSpecificAccessoryCardAddButton("Windshield- Clear");
            BuildConfigurePage.ClickAccessorySubCategory("handguards");
            BuildConfigurePage.ClickRandomAccessoryCardAddButton();
            BuildConfigurePage.VerifyConflictContainerDisplayed();
        }
    }
}
