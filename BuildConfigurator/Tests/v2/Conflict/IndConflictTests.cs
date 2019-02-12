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
    public class IndConflictTests : TestBase
    {
        [Test, Category(TestCategories.GEM), Category(TestCategories.ACCESSORY_CONFLICTS), RetryDynamic]
        public void VerifyConflictIsTriggeredInd()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.IND, ModelPageUrl.INDIAN_CHIEFTAIN_CONFLICT);
            BuildConfigurePage.WaitForBuildPageToLoad();
            BuildConfigurePage.ClickAccessoryCategory("Storage");
            BuildConfigurePage.ClickAccessorySubCategory("Quick Release");
            BuildConfigurePage.ClickSpecificAccessoryCardAddButton("Steel Gray");
            BuildConfigurePage.ClickAccessoryCategory("Seats");
            BuildConfigurePage.ClickAccessorySubCategory("Passenger sissybar");
            BuildConfigurePage.ClickRandomAccessoryCardAddButton();
            BuildConfigurePage.VerifyConflictContainerDisplayed();
        }
    }
}
