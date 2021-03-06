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

namespace BuildConfigurator.Tests.v2.PartRequiresPart
{
    [TestFixture]
    [Ignore("Brand running CPQ v3 version")]
    public class GenPartRequiresPartTests : TestBase
    {
        //[Test, Category(TestCategories.GEN), Category(TestCategories.PART_REQUIRES_PART), RetryDynamic]
        public void VerifyPartRequiresPartTriggeredGen()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.GEN, ModelPageUrl.GENERAL_1000_EPS_PRP);
            BuildConfigurePage.WaitForBuildPageToLoad();
            BuildConfigurePage.ClickAccessoryCategory("Cab Components");
            BuildConfigurePage.ClickAccessorySubCategory("Windshields");
            BuildConfigurePage.ClickSpecificAccessoryCardAddButton("Windshield Wiper Kit");
            Assert.IsTrue(BuildConfigurePage.IsPRPHeaderDisplayed(), "Part Requires Part was not triggered");
            BuildConfigurePage.ClickSecondaryAccessoryByProductId("2881108");
            BuildConfigurePage.ClickBuildSummaryButton();
            BuildConfigurePage.VerifyItemsIdsPresentBuildSummary(new string[] { "2881090", "2881108" });

        }
    }
}
