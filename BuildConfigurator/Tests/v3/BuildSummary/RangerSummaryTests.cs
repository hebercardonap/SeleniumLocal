﻿using AutomationFramework.DataProvider;
using AutomationFramework.Utils;
using BuildConfigurator.Hooks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Tests.v3.BuildSummary
{
    [TestFixture]
    public class RangerSummaryTests : TestBase
    {
        [Test, Category("Ranger"), Category("BuildSummary")]
        public void VerifySummaryDisplaysAddedAccessory()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RAN, ModelPageUrl.RANGER_500_SAGE_GREEN_ACCESSORIES);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Utility");
            Accessories.ClickSubcategoryByName("Cargo & Bed Storage");
            Accessories.ClickAccessoryAddByProductName("Cargo Box");
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Assert.IsTrue(Accessories.AreProductDescPresentBuildSummary(new List<string> { "Cargo Box" }));
        }

        [Test, Category("Ranger"), Category("BuildSummary")]
        public void VerifySummaryAccessoryRemove()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RAN, ModelPageUrl.RANGER_500_SAGE_GREEN_ACCESSORIES);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Utility");
            Accessories.ClickSubcategoryByName("Cargo & Bed Storage");
            Accessories.ClickAccessoryAddByProductName("Cargo Box");
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.RemoveAccessoryFromSummaryByDesc("Cargo Box");
            Assert.IsFalse(Accessories.AreProductDescPresentBuildSummary(new List<string> { "Cargo Box" }));
        }

        [Test, Category("Ranger"), Category("BuildSummary")]
        public void VerifySummaryUIIconsAndNotes()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RAN, ModelPageUrl.RANGER_500_SAGE_GREEN_ACCESSORIES);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Utility");
            Accessories.ClickSubcategoryByName("Cargo & Bed Storage");
            Accessories.ClickAccessoryAddByProductName("Cargo Box");
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.VerifyIconsAndAdditionalNotesPresent();
        }

        [Test, Category("Ranger"), Category("BuildSummary")]
        public void VerifySummaryDealerExperience()
        {
            CPQNavigate.NavigateToBrandDealerExpUrl(Brand.RAN, ModelPageUrl.RANGER_500_SAGE_GREEN_ACCESSORIES);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.VerifyIconsAndAdditionalNotesNotPresent();
        }
    }
}
