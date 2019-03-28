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

namespace BuildConfigurator.Tests.v2.Features
{
    [TestFixture]
    public class DataValidationTests : TestBase
    {
        //[Test, Category(TestCategories.DATA_VALIDATION), Category(TestCategories.RZR),  RetryDynamic]
        public void VerifyAccessoryCardsPresentRzr()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RZR, ModelPageUrl.RZR_XP_1000_EPS_BASE_TEST);
            BuildConfigurePage.WaitForBuildPageToLoad();
            VerifyAccessoryCardsPresent();
        }

        //[Test, Category(TestCategories.DATA_VALIDATION), Category(TestCategories.ATV), RetryDynamic]
        public void VerifyAccessoryCardsPresentAtv()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.ATV, ModelPageUrl.ATV_450_HO_BASE_TEST);
            BuildConfigurePage.WaitForBuildPageToLoad();
            VerifyAccessoryCardsPresent();
        }

        //[Test, Category(TestCategories.DATA_VALIDATION), Category(TestCategories.ACE),  RetryDynamic]
        public void VerifyAccessoryCardsPresentAce()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.ACE, ModelPageUrl.ACE_570_EPS_BASE_TEST);
            BuildConfigurePage.WaitForBuildPageToLoad();
            VerifyAccessoryCardsPresent();
        }

        //[Test, Category(TestCategories.DATA_VALIDATION), Category(TestCategories.GEN), RetryDynamic]
        public void VerifyAccessoryCardsPresentGen()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.GEN, ModelPageUrl.GENERAL_1000_EPS_BASE_TEST);
            BuildConfigurePage.WaitForBuildPageToLoad();
            VerifyAccessoryCardsPresent();
        }

        //[Test, Category(TestCategories.DATA_VALIDATION), Category(TestCategories.GEM), RetryDynamic]
        public void VerifyAccessoryCardsPresentGem()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.GEM, ModelPageUrl.GEM_EL_XD_BASE_TEST);
            BuildConfigurePage.WaitForBuildPageToLoad();
            VerifyAccessoryCardsPresent();
        }

        [Test, Category(TestCategories.DATA_VALIDATION), Category(TestCategories.IND), RetryDynamic]
        public void VerifyAccessoryCardsPresentInd()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.IND, ModelPageUrl.INDIAN_SPRINGFIELD_BASE_TEST);
            BuildConfigurePage.WaitForBuildPageToLoad();
            VerifyAccessoryCardsPresent();
        }

        [Test, Category(TestCategories.DATA_VALIDATION), Category(TestCategories.SLG), RetryDynamic]
        public void VerifyAccessoryCardsPresentSlg()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.SLG, ModelPageUrl.SLG_S_BASE_TEST);
            BuildConfigurePage.WaitForBuildPageToLoad();
            VerifyAccessoryCardsPresent();
        }

        private void VerifyAccessoryCardsPresent()
        {
            Assert.IsTrue(BuildConfigurePage.VerifyDataPresentForCategories(), "No categories are present");
            Assert.IsTrue(BuildConfigurePage.VerifyDataPresentForSubCategories(), "No subcategories are present");
            Assert.IsTrue(BuildConfigurePage.VerifyDataPresentForAccessoryCards(), "No accessory cards are present");
        }
    }
}
