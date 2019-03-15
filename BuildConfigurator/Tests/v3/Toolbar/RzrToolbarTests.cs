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
    public class RzrToolbarTests : TestBase
    {
        [Test, Category(TestCategories.RZR), Category(TestCategories.TOOLBAR), RetryDynamic]
        public void VerifyToolbarElementsAccessoryPageRzr()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RZR, ModelPageUrl.RZR_XP_1000_EPS_BASE_TEST);
            Accessories.WaitForAccessoriesPageToLoad();
            Assert.IsTrue(Accessories.Toolbar.IsToolbarDisplayed(), "Toolbar was not displayed");
            Accessories.VerifyToolbarIconsAreEnabled();
        }

        [Test, Category(TestCategories.RZR), Category(TestCategories.TOOLBAR), RetryDynamic]
        public void VerifyToolbarElementsColorPageRzr()
        {
            CPQNavigate.NavigateToColorsPage(Brand.RZR, ModelPageUrl.RZR_XP_1000_MODEL);
            Colors.WaitForColorsPageToLoad();
            Assert.IsTrue(Colors.Toolbar.IsToolbarDisplayed(), "Toolbar was not displayed");
            Colors.VerifyToolbarIconsStateColorPage();
        }

        [Test, Category(TestCategories.RZR), Category(TestCategories.TOOLBAR), RetryDynamic]
        public void VerifyToolbarRestartBuildFunctionalityRzr()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RZR, ModelPageUrl.RZR_XP_1000_EPS_BASE_TEST);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Tire & Wheel Sets");
            Accessories.ClickSubcategoryByName("Trail");
            Accessories.ClickAccessoryAddByProductName("Wheel & Tire Set");
            Assert.IsTrue(Accessories.Toolbar.IsToolbarDisplayed(), "Toolbar was not displayed");
            Accessories.Toolbar.ClickToolbarRestartIcon();
            Accessories.ClickConfirmationBuildContinueButton();
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.VerifyItemsDescNotPresentBuildSummary(new string[] { "Wheel & Tire Set" });
        }
    }
}
