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
        private static string BUILD_CATEGORY_PART_URL = "/build-category";

        [Test, Category(TestCategories.NAVIGATION), RetryDynamic]
        public void VerifyNavigationBarAndIconsPresentV2()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.IND, ModelPageUrl.INDIAN_SPRINGFIELD_BASE_TEST);
            BuildConfigurePage.WaitForBuildPageToLoad();
            Assert.IsTrue(BuildConfigurePage.IsNavigationBarDisplayed(), "Navigation bar is not present");
            Assert.IsTrue(BuildConfigurePage.IsIconContainerDisplayed(), "Icon container is not displayed");
            BuildConfigurePage.ClickBuildSummaryButton();
            Assert.IsTrue(BuildConfigurePage.IsSummaryAccessorySocialDisplayed(), "Social share icons are not displayed");
        }

        [Test, Category(TestCategories.NAVIGATION), RetryDynamic]
        public void VerifyIndNavigationBackV2()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.IND, ModelPageUrl.INDIAN_SPRINGFIELD_BASE_TEST);
            BuildConfigurePage.WaitForBuildPageToLoad();
            Assert.IsTrue(BuildConfigurePage.IsNavigationBarDisplayed(), "Navigation bar is not present");
            BuildConfigurePage.ClickColorFromNavigationBar();
            BuildColorPage.WaitForColorPageToLoad();
            Assert.IsTrue(BuildColorPage.UrlContains(BUILD_COLOR_PART_URL));
            BuildConfigurePage.ClickCategoriesFromNavigationBar();
            Assert.IsTrue(BuildModelPage.UrlContains(BUILD_CATEGORY_PART_URL));
        }
    }
}
