﻿using AutomationFramework.DataProvider;
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
    public class RzrConflictTests : TestBase
    {
        [Test, Category(TestCategories.RZR), Category(TestCategories.ACCESSORY_CONFLICTS), CustomRetry(3)]
        public void VerifyConflictIsTriggeredRzr()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RZR, ModelPageUrl.RZR_XP_1000_EPS_CONFLICT);
            BuildConfigurePage.WaitForBuildPageToLoad();
            BuildConfigurePage.ClickAccessoryCategory("Utility");
            BuildConfigurePage.ClickAccessorySubCategory("Storage & Bed Accessories");
            BuildConfigurePage.ClickSpecificAccessoryCardAddButton("Spare Tire Carrier");
            BuildConfigurePage.ClickAccessoryCategory("Protection");
            BuildConfigurePage.ClickAccessorySubCategory("Custom Cage Systems");
            BuildConfigurePage.ClickSpecificAccessoryCardAddButton("Cage system - Black");
            BuildConfigurePage.VerifyConflictContainerDisplayed();
        }
    }
}