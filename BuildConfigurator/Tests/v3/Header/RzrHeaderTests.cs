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
    public class RzrHeaderTests : TestBase
    {

        [Test, Category(TestCategories.RZR), Category(TestCategories.HEADER), RetryDynamic]
        public void VerifyModelsPageHeaderElementsRzr()
        {
            CPQNavigate.NavigateToModelsPage(Brand.RZR);
            Models.WaitForModelsPageToLoad();
            Assert.IsTrue(Models.HeaderModule.IsHeaderSignInIconDisplayed(), "Header Sign In is not displayed");
            Assert.IsTrue(Models.HeaderModule.IsHeaderBrandNameDisplayed("RZR"));
            Models.HeaderModule.ClickHeaderCloseIcon();
            Assert.AreEqual(CPQNavigate.GetCurrentUrl(), UrlBuilder.getRzrLandingPageURL());
        }

        [Test, Category(TestCategories.RZR), Category(TestCategories.HEADER), RetryDynamic]
        public void VerifyTrimsPageHeaderElementsRzr()
        {
            CPQNavigate.NavigateToTrimsPage(Brand.RZR, ModelPageUrl.RZR_XP_1000_MODEL);
            Trims.WaitForTrimsPageToLoad();
            Assert.IsTrue(Trims.HeaderModule.IsHeaderSignInIconDisplayed(), "Header Sign In is not displayed");
            Assert.IsTrue(Trims.HeaderModule.IsHeaderBrandNameDisplayed("RZR"), "Header brand name not displayed");
            Trims.HeaderModule.ClickHeaderCloseIcon();
            Assert.AreEqual(CPQNavigate.GetCurrentUrl(), UrlBuilder.getRzrLandingPageURL());
        }

        [Test, Category(TestCategories.RZR), Category(TestCategories.HEADER), RetryDynamic]
        public void VerifyColorsPageHeaderElementsRzr()
        {
            CPQNavigate.NavigateToColorsPage(Brand.RZR, ModelPageUrl.RZR_XP_1000_MODEL);
            Colors.WaitForColorsPageToLoad();
            Assert.IsTrue(Colors.HeaderModule.IsHeaderSignInIconDisplayed(), "Header Sign In is not displayed");
            Assert.IsTrue(Colors.HeaderModule.IsHeaderBrandNameDisplayed("RZR"), "Header brand name not displayed");
            Trims.HeaderModule.ClickHeaderCloseIcon();
            Assert.AreEqual(CPQNavigate.GetCurrentUrl(), UrlBuilder.getRzrLandingPageURL());
        }

        [Test, Category(TestCategories.RZR), Category(TestCategories.HEADER), RetryDynamic]
        public void VerifyAccessoriesPageHeaderElementsRzr()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RZR, ModelPageUrl.RZR_XP_1000_EPS_BASE_TEST);
            Accessories.WaitForAccessoriesPageToLoad();
            Assert.IsTrue(Accessories.HeaderModule.IsHeaderSignInIconDisplayed(), "Header Sign In is not displayed");
            Assert.IsTrue(Accessories.HeaderModule.IsHeaderBrandNameDisplayed("RZR"), "Header brand name not displayed");
            Assert.IsFalse(Accessories.HeaderModule.IsSaveHeaderIconDisplayed(), "Save icon was not expected to be displayed");
            Assert.IsFalse(Accessories.HeaderModule.IsEmailHeaderIconDisplayed(), "Email icon was not expected to be displayed");
            Accessories.HeaderModule.ClickHeaderCloseIcon();
            Assert.AreEqual(CPQNavigate.GetCurrentUrl(), UrlBuilder.getRzrLandingPageURL());
        }
    }
}
