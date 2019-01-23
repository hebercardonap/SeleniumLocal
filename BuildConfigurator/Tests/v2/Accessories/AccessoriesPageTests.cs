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

        [Test, Category(TestCategories.RZR), Category(TestCategories.TRIMS_PAGE), CustomRetry(3)]
        public void VerifyPageUpForModelsRzr()
        {
            //List<string> modelColors = BuildConfigurePage.GetAllModelsColorsFromApi(Brand.RZR, MODELS_YEAR, TEST_DEALER_ID);

            //foreach (var modelColor in modelColors)
            //{
            //    CPQNavigate.NavigateToAccessoriesPage(Brand.RZR, modelColor);
            //    BuildConfigurePage.WaitForBuildPageToLoad();
            //    BuildConfigurePage.VerifyAccessoriesPageElements();
            //}

            CPQNavigate.NavigateToAccessoriesPage(Brand.RZR, BuildConfigurePage.GetRandomModelColorFromApi(Brand.RZR, MODELS_YEAR, TEST_DEALER_ID));
            BuildConfigurePage.WaitForBuildPageToLoad();
            BuildConfigurePage.VerifyAccessoriesPageElements();
        }
    }
}
