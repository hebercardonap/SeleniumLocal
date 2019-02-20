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
    [Ignore("ATV is not on CPQ v3 yet, Ignore flag will be removed when ATV switches to v3 UI")]
    public class AtvToolbarTests : TestBase
    {
        [Test, Category(TestCategories.ATV), Category(TestCategories.TOOLBAR), RetryDynamic]
        public void VerifyToolbarElementsAccessoryPageAtv()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.ATV, ModelPageUrl.ATV_450_HO_BASE_TEST);
            Accessories.WaitForAccessoriesPageToLoad();
            Assert.IsTrue(Accessories.Toolbar.IsToolbarDisplayed(), "Toolbar was not displayed");
            Accessories.VerifyToolbarIconsAreEnabled();

        }

        [Test, Category(TestCategories.ATV), Category(TestCategories.TOOLBAR), RetryDynamic]
        public void VerifyToolbarElementsColorPageAtv()
        {
            CPQNavigate.NavigateToColorsPage(Brand.ATV, ModelPageUrl.ATV_450_TRIM_COLOR_PAGE);
            Colors.WaitForColorsPageToLoad();
            Assert.IsTrue(Colors.Toolbar.IsToolbarDisplayed(), "Toolbar was not displayed");
            Colors.VerifyToolbarIconsStateColorPage();

        }

        [Test, Category(TestCategories.ATV), Category(TestCategories.TOOLBAR), RetryDynamic]
        public void VerifyToolbarRestartBuildFunctionalityAtv()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RAN, ModelPageUrl.ATV_450_HO_BASE_TEST);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Protection");
            Accessories.ClickSubcategoryByName("Handguards");
            Accessories.ClickAccessoryAddByProductName("Handguards");
            Assert.IsTrue(Accessories.Toolbar.IsToolbarDisplayed(), "Toolbar was not displayed");
            Accessories.Toolbar.ClickToolbarRestartIcon();
            Accessories.ClickConfirmationBuildContinueButton();
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.VerifyItemsDescNotPresentBuildSummary(new string[] { "Handguards" });

        }
    }
}
