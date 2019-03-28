using AutomationFramework.Helpers;
using AutomationFramework.Utils;
using BuildConfigurator.Hooks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Tests.v2.Accessories
{
    [TestFixture]
    public class AccessoriesPageTests : TestBase
    {
        private static readonly string TEST_DEALER_ID = "02040900";
        private static readonly string MODELS_YEAR = "2019";

        //[Test, Category(TestCategories.RZR), Category(TestCategories.ACCESSORIES_PAGE), RetryDynamic]
        //[Ignore("Brand running CPQ v3 version")]
        public void VerifyPageUpForRandomModelsRzr()
        {
            List<string> modelColors = BuildConfigurePage.GetOneModelsColorsEachCategoryFromApi(Brand.RZR, MODELS_YEAR, TEST_DEALER_ID);

            foreach (var modelColor in modelColors)
            {
                CPQNavigate.NavigateToAccessoriesPage(Brand.RZR, modelColor);
                BuildConfigurePage.WaitForBuildPageToLoad();
                BuildConfigurePage.VerifyAccessoriesPageElements(modelColor);
            }
        }

        [Test, Category(TestCategories.IND), Category(TestCategories.ACCESSORIES_PAGE), RetryDynamic]
        public void VerifyPageUpForRandomModelsInd()
        {
            List<string> modelColors = BuildConfigurePage.GetOneModelsColorsEachCategoryFromApi(Brand.IND, MODELS_YEAR, TEST_DEALER_ID);

            foreach (var modelColor in modelColors)
            {
                CPQNavigate.NavigateToAccessoriesPage(Brand.IND, modelColor);
                BuildConfigurePage.WaitForBuildPageToLoad();
                BuildConfigurePage.VerifyAccessoriesPageElements(modelColor);
            }
        }

        //[Test, Category(TestCategories.GEN), Category(TestCategories.ACCESSORIES_PAGE), RetryDynamic]
        //[Ignore("Brand running CPQ v3 version")]
        public void VerifyPageUpForRandomModelsGen()
        {
            List<string> modelColors = BuildConfigurePage.GetOneModelsColorsEachCategoryFromApi(Brand.GEN, MODELS_YEAR, TEST_DEALER_ID);

            foreach (var modelColor in modelColors)
            {
                CPQNavigate.NavigateToAccessoriesPage(Brand.GEN, modelColor);
                BuildConfigurePage.WaitForBuildPageToLoad();
                BuildConfigurePage.VerifyAccessoriesPageElements(modelColor);
            }
        }

        //[Test, Category(TestCategories.ACE), Category(TestCategories.ACCESSORIES_PAGE), RetryDynamic]
        //[Ignore("Brand running CPQ v3 version")]
        public void VerifyPageUpForRandomModelsAce()
        {
            List<string> modelColors = BuildConfigurePage.GetOneModelsColorsEachCategoryFromApi(Brand.ACE, MODELS_YEAR, TEST_DEALER_ID);

            foreach (var modelColor in modelColors)
            {
                CPQNavigate.NavigateToAccessoriesPage(Brand.ACE, modelColor);
                BuildConfigurePage.WaitForBuildPageToLoad();
                BuildConfigurePage.VerifyAccessoriesPageElements(modelColor);
            }
        }

        //[Test, Category(TestCategories.ATV), Category(TestCategories.ACCESSORIES_PAGE), RetryDynamic]
        //[Ignore("Brand running CPQ v3 version")]
        public void VerifyPageUpForRandomModelsAtv()
        {
            List<string> modelColors = BuildConfigurePage.GetOneModelsColorsEachCategoryFromApi(Brand.ATV, MODELS_YEAR, TEST_DEALER_ID);

            foreach (var modelColor in modelColors)
            {
                CPQNavigate.NavigateToAccessoriesPage(Brand.ATV, modelColor);
                BuildConfigurePage.WaitForBuildPageToLoad();
                BuildConfigurePage.VerifyAccessoriesPageElements(modelColor);
            }
        }
    }
}
