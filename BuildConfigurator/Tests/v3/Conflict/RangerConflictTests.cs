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

namespace BuildConfigurator.Tests.v3.Conflict
{
    [TestFixture]
    public class RangerConflictTests : TestBase
    {
        [Test, Category(TestCategories.RAN), Category(TestCategories.ACCESSORY_CONFLICTS), RetryDynamic]
        public void VerifyConflictRuleIsTriggeredForRanger()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RAN, ModelPageUrl.RANGER_CREW_XP900_SAGE_GREEN_CONFLICT);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Utility");
            Accessories.ClickSubcategoryByName("Cargo & Bed Storage");
            Accessories.ClickAccessoryAddByProductName("Front Hood Storage Rack");
            Accessories.ClickCategoryByName("Cab Components");
            Accessories.ClickSubcategoryByName("Windshields");
            Accessories.ClickAccessoryAddByProductName("Flip-Down Full Windshield");
            Assert.IsTrue(Accessories.IsConflictContainerDisplayed(), "Conflict container not displayed as expected");
        }

        [Test, Category(TestCategories.RAN), Category(TestCategories.ACCESSORY_CONFLICTS), RetryDynamic]
        public void VerifyRemovedPartFromConflictInBuildSummaryRan()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RAN, ModelPageUrl.RANGER_CREW_XP900_SAGE_GREEN_CONFLICT);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Utility");
            Accessories.ClickSubcategoryByName("Cargo & Bed Storage");
            Accessories.ClickAccessoryAddByProductName("Front Hood Storage Rack");
            Accessories.ClickCategoryByName("Cab Components");
            Accessories.ClickSubcategoryByName("Windshields");
            Accessories.ClickAccessoryAddByProductName("Flip-Down Full Windshield");
            Assert.IsTrue(Accessories.IsConflictContainerDisplayed(), "Conflict container not displayed as expected");
            Assert.IsFalse(Accessories.RemoveConlfictPartAndValidateInBuildSummary("Flip-Down Full Windshield"),
                "Conflicting part was not removed from build summary");
        }
    }
}
