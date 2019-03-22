using AutomationFramework.DataProvider;
using AutomationFramework.Helpers;
using AutomationFramework.UrlBuilderSites;
using AutomationFramework.Utils;
using BuildConfigurator.Hooks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Tests.v3.Header
{
    [TestFixture]
    public class AtvHeaderTests : TestBase
    {
        [Test, Category(TestCategories.ATV), Category(TestCategories.HEADER), RetryDynamic]
        public void VerifyModelsPageHeaderElementsAtv()
        {
            CPQNavigate.NavigateToModelsPage(Brand.ATV);
            Models.WaitForModelsPageToLoad();
            Assert.IsTrue(Models.HeaderModule.IsHeaderSignInIconDisplayed(), "Header Sign In is not displayed");
            Assert.IsTrue(Models.HeaderModule.IsHeaderBrandNameDisplayed("Sportsman"));
            Models.HeaderModule.ClickHeaderCloseIcon();
            Assert.AreEqual(CPQNavigate.GetCurrentUrl(), UrlBuilder.getSportsmanLandingPageURL());
        }

        [Test, Category(TestCategories.ATV), Category(TestCategories.HEADER), RetryDynamic]
        public void VerifyTrimsPageHeaderElementsAtv()
        {
            CPQNavigate.NavigateToTrimsPage(Brand.ATV, ModelPageUrl.ATV_450_TRIM_COLOR_PAGE);
            Trims.WaitForTrimsPageToLoad();
            Assert.IsTrue(Trims.HeaderModule.IsHeaderSignInIconDisplayed(), "Header Sign In is not displayed");
            Assert.IsTrue(Trims.HeaderModule.IsHeaderBrandNameDisplayed("Sportsman"), "Header brand name not displayed");
            Trims.HeaderModule.ClickHeaderCloseIcon();
            Assert.AreEqual(CPQNavigate.GetCurrentUrl(), UrlBuilder.getSportsmanLandingPageURL());
        }

        [Test, Category(TestCategories.ATV), Category(TestCategories.HEADER), RetryDynamic]
        public void VerifyColorsPageHeaderElementsAtv()
        {
            CPQNavigate.NavigateToColorsPage(Brand.ATV, ModelPageUrl.ATV_450_TRIM_COLOR_PAGE);
            Colors.WaitForColorsPageToLoad();
            Assert.IsTrue(Colors.HeaderModule.IsHeaderSignInIconDisplayed(), "Header Sign In is not displayed");
            Assert.IsTrue(Colors.HeaderModule.IsHeaderBrandNameDisplayed("Sportsman"), "Header brand name not displayed");
            Trims.HeaderModule.ClickHeaderCloseIcon();
            Assert.AreEqual(CPQNavigate.GetCurrentUrl(), UrlBuilder.getSportsmanLandingPageURL());
        }

        [Test, Category(TestCategories.ATV), Category(TestCategories.HEADER), RetryDynamic]
        public void VerifyAccessoriesPageHeaderElementsAtv()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.ATV, ModelPageUrl.ATV_450_HO_BASE_TEST);
            Accessories.WaitForAccessoriesPageToLoad();
            Assert.IsTrue(Accessories.HeaderModule.IsHeaderSignInIconDisplayed(), "Header Sign In is not displayed");
            Assert.IsTrue(Accessories.HeaderModule.IsHeaderBrandNameDisplayed("Sportsman"), "Header brand name not displayed");
            Assert.IsFalse(Accessories.HeaderModule.IsSaveHeaderIconDisplayed(), "Save icon was not expected to be displayed");
            Assert.IsFalse(Accessories.HeaderModule.IsEmailHeaderIconDisplayed(), "Email icon was not expected to be displayed");
            Accessories.HeaderModule.ClickHeaderCloseIcon();
            Assert.AreEqual(CPQNavigate.GetCurrentUrl(), UrlBuilder.getSportsmanLandingPageURL());
        }
    }
}
