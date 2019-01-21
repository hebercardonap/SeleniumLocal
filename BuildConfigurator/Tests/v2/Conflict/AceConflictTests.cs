﻿using AutomationFramework.Helpers;
using AutomationFramework.Utils;
using BuildConfigurator.Hooks;
using NUnit.Framework;
using AutomationFramework.DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Tests.v2.Conflict
{
    [TestFixture]
    public class AceConflictTests : TestBase
    {
        [Test, Category(TestCategories.ACE), Category(TestCategories.ACCESSORY_CONFLICTS), CustomRetry(3)]
        public void VerifyConflictIsTriggeredAce()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.ACE, ModelPageUrl.ACE_570_EPS_CONFLICT);
            BuildConfigurePage.WaitForBuildPageToLoad();
            BuildConfigurePage.ClickAccessoryCategory("Utility");
            BuildConfigurePage.ClickAccessorySubCategory("Rack Extenders");
            BuildConfigurePage.ClickSpecificAccessoryCardAddButton("Steel Bed Extender");
            BuildConfigurePage.ClickAccessorySubCategory("Storage");
            BuildConfigurePage.ClickSpecificAccessoryCardAddButton("Rear Cargo Box");
            BuildConfigurePage.VerifyConflictContainerDisplayed();
        }
    }
}