using AutomationFramework.DataProvider;
using AutomationFramework.Helpers;
using AutomationFramework.UrlBuilderSites;
using AutomationFramework.Utils;
using BuildConfigurator.Hooks;
using NUnit.Framework;

namespace BuildConfigurator.Tests.v3.Header
{
    [TestFixture]
    public class GenHeaderTests : TestBase
    {
        [Test, Category(TestCategories.GEN), Category(TestCategories.HEADER), RetryDynamic]
        public void VerifyModelsPageHeaderElementsGen()
        {
            CPQNavigate.NavigateToModelsPage(Brand.GEN);
            Models.WaitForModelsPageToLoad();
            Assert.IsTrue(Models.HeaderModule.IsHeaderSignInIconDisplayed(), "Header Sign In is not displayed");
            Assert.IsTrue(Models.HeaderModule.IsHeaderBrandNameDisplayed("General"));
            Models.HeaderModule.ClickHeaderCloseIcon();
            Assert.AreEqual(CPQNavigate.GetCurrentUrl(), UrlBuilder.getGeneralLandingPageURL());
        }

        [Test, Category(TestCategories.GEN), Category(TestCategories.HEADER), RetryDynamic]
        public void VerifyTrimsPageHeaderElementsRzr()
        {
            CPQNavigate.NavigateToTrimsPage(Brand.GEN, ModelPageUrl.GENERAL_1000_EPS_TRIM_COLOR_PAGE);
            Trims.WaitForTrimsPageToLoad();
            Assert.IsTrue(Trims.HeaderModule.IsHeaderSignInIconDisplayed(), "Header Sign In is not displayed");
            Assert.IsTrue(Trims.HeaderModule.IsHeaderBrandNameDisplayed("General"), "Header brand name not displayed");
            Trims.HeaderModule.ClickHeaderCloseIcon();
            Assert.AreEqual(CPQNavigate.GetCurrentUrl(), UrlBuilder.getGeneralLandingPageURL());
        }

        [Test, Category(TestCategories.GEN), Category(TestCategories.HEADER), RetryDynamic]
        public void VerifyAccessoriesPageHeaderElementsGen()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.GEN, ModelPageUrl.GENERAL_1000_EPS_BASE_TEST);
            Accessories.WaitForAccessoriesPageToLoad();
            Assert.IsTrue(Accessories.HeaderModule.IsHeaderSignInIconDisplayed(), "Header Sign In is not displayed");
            Assert.IsTrue(Accessories.HeaderModule.IsHeaderBrandNameDisplayed("General"), "Header brand name not displayed");
            Assert.IsFalse(Accessories.HeaderModule.IsSaveHeaderIconDisplayed(), "Save icon was not expected to be displayed");
            Assert.IsFalse(Accessories.HeaderModule.IsEmailHeaderIconDisplayed(), "Email icon was not expected to be displayed");
            Accessories.HeaderModule.ClickHeaderCloseIcon();
            Assert.AreEqual(CPQNavigate.GetCurrentUrl(), UrlBuilder.getGeneralLandingPageURL());
        }
    }
}
