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
    public class RangerHeaderTests : TestBase
    {
        [Test, Category(TestCategories.RAN), Category(TestCategories.HEADER), RetryDynamic]
        public void VerifyModelsPageHeaderElementsRan()
        {
            CPQNavigate.NavigateToModelsPage(Brand.RAN);
            Models.WaitForModelsPageToLoad();
            Assert.IsTrue(Models.HeaderModule.IsHeaderSignInIconDisplayed(), "Header Sign In is not displayed");
            Assert.IsTrue(Models.HeaderModule.IsHeaderBrandNameDisplayed("Ranger"), "Header brand name not displayed");
            Models.HeaderModule.ClickHeaderCloseIcon();
            Assert.AreEqual(CPQNavigate.GetCurrentUrl(), UrlBuilder.GetRangerBrandHomePage());
        }

        [Test, Category(TestCategories.RAN), Category(TestCategories.HEADER), RetryDynamic]
        public void VerifyTrimsPageHeaderElementsRan()
        {
            CPQNavigate.NavigateToTrimsPage(Brand.RAN, ModelPageUrl.RANGER_500_MODEL);
            Trims.WaitForTrimsPageToLoad();
            Assert.IsTrue(Trims.HeaderModule.IsHeaderSignInIconDisplayed(), "Header Sign In is not displayed");
            Assert.IsTrue(Trims.HeaderModule.IsHeaderBrandNameDisplayed("Ranger"), "Header brand name not displayed");
            Trims.HeaderModule.ClickHeaderCloseIcon();
            Assert.AreEqual(CPQNavigate.GetCurrentUrl(), UrlBuilder.GetRangerBrandHomePage());
        }

        [Test, Category(TestCategories.RAN), Category(TestCategories.HEADER), RetryDynamic]
        public void VerifyColorsPageHeaderElementsRan()
        {
            CPQNavigate.NavigateToColorsPage(Brand.RAN, ModelPageUrl.RANGER_500_MODEL);
            Colors.WaitForColorsPageToLoad();
            Assert.IsTrue(Colors.HeaderModule.IsHeaderSignInIconDisplayed(), "Header Sign In is not displayed");
            Assert.IsTrue(Colors.HeaderModule.IsHeaderBrandNameDisplayed("Ranger"), "Header brand name not displayed");
            Trims.HeaderModule.ClickHeaderCloseIcon();
            Assert.AreEqual(CPQNavigate.GetCurrentUrl(), UrlBuilder.GetRangerBrandHomePage());
        }

        [Test, Category(TestCategories.RAN), Category(TestCategories.HEADER), RetryDynamic]
        public void VerifyPackagesPageHeaderElementsRan()
        {
            CPQNavigate.NavigateToPackagesPage(Brand.RAN, ModelPageUrl.RANGER_XP1000_EPS_STEEL_BLUE_PACKAGES);
            Packages.WaitForPackagesPageToLoad();
            Assert.IsTrue(Packages.HeaderModule.IsHeaderSignInIconDisplayed(), "Header Sign In is not displayed");
            Assert.IsTrue(Packages.HeaderModule.IsHeaderBrandNameDisplayed("Ranger"), "Header brand name not displayed");
            Packages.HeaderModule.ClickHeaderCloseIcon();
            Assert.AreEqual(CPQNavigate.GetCurrentUrl(), UrlBuilder.GetRangerBrandHomePage());
        }

        [Test, Category(TestCategories.RAN), Category(TestCategories.HEADER), RetryDynamic]
        public void VerifyAccessoriesPageHeaderElementsRan()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RAN, ModelPageUrl.RANGER_500_SAGE_GREEN_ACCESSORIES);
            Accessories.WaitForAccessoriesPageToLoad();
            Assert.IsTrue(Accessories.HeaderModule.IsHeaderSignInIconDisplayed(), "Header Sign In is not displayed");
            Assert.IsTrue(Accessories.HeaderModule.IsHeaderBrandNameDisplayed("Ranger"), "Header brand name not displayed");
            Assert.IsFalse(Accessories.HeaderModule.IsSaveHeaderIconDisplayed(), "Save icon was not expected to be displayed");
            Assert.IsFalse(Accessories.HeaderModule.IsEmailHeaderIconDisplayed(), "Email icon was not expected to be displayed");
            Accessories.HeaderModule.ClickHeaderCloseIcon();
            Assert.AreEqual(CPQNavigate.GetCurrentUrl(), UrlBuilder.getRangerLandingPageURL());
        }

    }
}
