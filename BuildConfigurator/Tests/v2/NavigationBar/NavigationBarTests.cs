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

namespace BuildConfigurator.Tests.v2.NavigationBar
{
    [TestFixture]
    public class NavigationBarTests : TestBase
    {
        private static string BUILD_COLOR_PART_URL = "/build-color";
        private static string BUILD_TRIM_PART_URL = "/build-trim";
        private static string BUILD_MODEL_PART_URL = "/build-model";

        [Test, Category(TestCategories.NAVIGATION), RetryDynamic]
        public void VerifyNavigationBarAndIconsPresent()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RZR, ModelPageUrl.RZR_XP_1000_EPS_BASE_TEST);
            BuildConfigurePage.WaitForBuildPageToLoad();
            Assert.IsTrue(BuildConfigurePage.IsNavigationBarDisplayed(), "Navigation bar is not present");
            Assert.True(BuildConfigurePage.IsIconContainerDisplayed(), "Icon container is not displayed");
            BuildConfigurePage.ClickBuildSummaryButton();
            Assert.IsTrue(BuildConfigurePage.IsSummaryAccessorySocialDisplayed(), "Social share icons are not displayed");
        }

        [Test, Category(TestCategories.NAVIGATION), RetryDynamic]
        public void VerifyRzrNavigationBack()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RZR, ModelPageUrl.RZR_XP_1000_EPS_BASE_TEST);
            BuildConfigurePage.WaitForBuildPageToLoad();
            Assert.IsTrue(BuildConfigurePage.IsNavigationBarDisplayed(), "Navigation bar is not present");
            BuildConfigurePage.ClickColorFromNavigationBar();
            Assert.IsTrue(BuildColorPage.UrlContains(BUILD_COLOR_PART_URL));
            BuildConfigurePage.ClickTrimFromNavigationBar();
            Assert.IsTrue(BuildTrimPage.UrlContains(BUILD_TRIM_PART_URL));
            BuildConfigurePage.ClickModelsFromNavigationBar();
            Assert.IsTrue(BuildModelPage.UrlContains(BUILD_MODEL_PART_URL));
        }
    }
}
