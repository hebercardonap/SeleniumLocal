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
    public class SnoToolbarTests : TestBase
    {
        [Test, Category(TestCategories.SNO), Category(TestCategories.TOOLBAR), RetryDynamic]
        public void VerifyToolbarElementsAccessoryPageSno()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.SNO, ModelPageUrl.SNO_SWITCHBACK_600_BASE_TEST);
            Accessories.WaitForAccessoriesPageToLoad();
            Assert.IsTrue(Accessories.Toolbar.IsToolbarDisplayed());
            Accessories.VerifyToolbarIconsAreEnabled();

        }

        [Test, Category(TestCategories.SNO), Category(TestCategories.TOOLBAR), RetryDynamic]
        public void VerifyToolbarElementsEnginePageSno()
        {
            CPQNavigate.NavigateToEnginePage(Brand.SNO, ModelPageUrl.SNO_TRACK_ENGINE_PAGE_MODEL);
            Engine.WaitForEnginePageToLoad();
            Assert.IsTrue(Engine.Toolbar.IsToolbarDisplayed());
            Engine.VerifyToolbarIconsStateEnginePage();

        }


        [Test, Category(TestCategories.SNO), Category(TestCategories.TOOLBAR), RetryDynamic]
        public void VerifyToolbarRestartBuildFunctionalitySno()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.SNO, ModelPageUrl.SNO_SWITCHBACK_600_BASE_TEST);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Protection");
            Accessories.ClickSubcategoryByName("Covers");
            Accessories.ClickAccessoryAddByProductName("Cover - Black");
            Assert.IsTrue(Accessories.Toolbar.IsToolbarDisplayed(), "Toolbar is not displayed");
            Accessories.Toolbar.ClickToolbarRestartIcon();
            Accessories.ClickConfirmationBuildContinueButton();
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.VerifyItemsDescNotPresentBuildSummary(new string[] { "Cover - Black" });

        }
    }
}
