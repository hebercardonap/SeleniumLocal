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

namespace BuildConfigurator.Tests.v3.Toolbar
{
    [TestFixture]
    public class RangerToolbarTests : TestBase
    {
        [Test, Category(TestCategories.RAN), Category(TestCategories.TOOLBAR), RetryDynamic]
        public void VerifyToolbarElementsAccessoryPageRan()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RAN, ModelPageUrl.RANGER_500_SAGE_GREEN_ACCESSORIES);
            Accessories.WaitForAccessoriesPageToLoad();
            Assert.IsTrue(Accessories.Toolbar.IsToolbarDisplayed(), "Toolbar was not displayed");
            Accessories.VerifyToolbarIconsAreEnabled();

        }

        [Test, Category(TestCategories.RAN), Category(TestCategories.TOOLBAR), RetryDynamic]
        public void VerifyToolbarElementsColorPageRan()
        {
            CPQNavigate.NavigateToColorsPage(Brand.RAN, ModelPageUrl.RANGER_500_MODEL);
            Colors.WaitForColorsPageToLoad();
            Assert.IsTrue(Colors.Toolbar.IsToolbarDisplayed());
            Colors.VerifyToolbarIconsStateColorPage();

        }

        [Test, Category(TestCategories.RAN), Category(TestCategories.TOOLBAR), RetryDynamic]
        public void VerifyToolbarElementsPackagesPageRan()
        {
            CPQNavigate.NavigateToPackagesPage(Brand.RAN, ModelPageUrl.RANGER_XP1000_EPS_STEEL_BLUE_PACKAGES);
            Packages.WaitForPackagesPageToLoad();
            Assert.IsTrue(Packages.Toolbar.IsToolbarDisplayed(), "Toolbar was not displayed");
            Packages.VerifyToolbarIconsStatePackagesPage();

        }

        [Test, Category(TestCategories.RAN), Category(TestCategories.TOOLBAR), RetryDynamic]
        public void VerifyToolbarRestartBuildFunctionalityRan()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RAN, ModelPageUrl.RANGER_500_SAGE_GREEN_ACCESSORIES);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Wheel");
            Accessories.ClickSubcategoryByName("Trail");
            Accessories.ClickAccessoryAddByProductName("Buckle- Accent");
            Assert.IsTrue(Accessories.Toolbar.IsToolbarDisplayed(), "Toolbar was not displayed");
            Accessories.Toolbar.ClickToolbarRestartIcon();
            Accessories.ClickConfirmationBuildContinueButton();
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.VerifyItemsDescNotPresentBuildSummary(new string[] { "Buckle- Accent" });

        }
    }
}
