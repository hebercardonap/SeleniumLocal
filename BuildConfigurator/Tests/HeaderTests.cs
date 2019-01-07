using AutomationFramework.DataProvider;
using AutomationFramework.UrlBuilderSites;
using AutomationFramework.Utils;
using BuildConfigurator.Hooks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Tests
{
    [TestFixture]
    public class HeaderTests : TestBase
    {
        [Test, Category("Ranger"), Category("Header")]
        public void VerifyModelsPageHeaderElements()
        {
            CPQNavigate.NavigateToModelsPage(Brand.RAN);
            Models.WaitForModelsPageToLoad();
            Assert.IsTrue(Models.HeaderModule.IsHeaderSignInIconDisplayed());
            Assert.IsTrue(Models.HeaderModule.IsHeaderBrandNameDisplayed("Ranger"));
            Models.HeaderModule.ClickHeaderCloseIcon();
            Assert.AreEqual(CPQNavigate.GetCurrentUrl(), UrlBuilder.GetRangerBrandHomePage());
        }

        [Test, Category("Ranger"), Category("Header")]
        public void VerifyTrimsPageHeaderElements()
        {
            CPQNavigate.NavigateToTrimsPage(Brand.RAN, "ranger-500");
            Trims.WaitForTrimsPageToLoad();
            Assert.IsTrue(Trims.HeaderModule.IsHeaderSignInIconDisplayed());
            Assert.IsTrue(Trims.HeaderModule.IsHeaderBrandNameDisplayed("Ranger"));
            Trims.HeaderModule.ClickHeaderCloseIcon();
            Assert.AreEqual(CPQNavigate.GetCurrentUrl(), UrlBuilder.GetRangerBrandHomePage());
        }

        [Test, Category("Ranger"), Category("Header")]
        public void VerifyColorsPageHeaderElements()
        {
            CPQNavigate.NavigateToColorsPage(Brand.RAN, "ranger-500");
            Colors.WaitForColorsPageToLoad();
            Assert.IsTrue(Colors.HeaderModule.IsHeaderSignInIconDisplayed());
            Assert.IsTrue(Colors.HeaderModule.IsHeaderBrandNameDisplayed("Ranger"));
            Trims.HeaderModule.ClickHeaderCloseIcon();
            Assert.AreEqual(CPQNavigate.GetCurrentUrl(), UrlBuilder.GetRangerBrandHomePage());
        }

        [Test, Category("Ranger"), Category("Header")]
        public void VerifyPackagesPageHeaderElements()
        {
            CPQNavigate.NavigateToPackagesPage(Brand.RAN, "ranger-xp-1000-eps-steel-blue");
            Packages.WaitForPackagesPageToLoad();
            Assert.IsTrue(Packages.HeaderModule.IsHeaderSignInIconDisplayed());
            Assert.IsTrue(Packages.HeaderModule.IsHeaderBrandNameDisplayed("Ranger"));
            Packages.HeaderModule.ClickHeaderCloseIcon();
            Assert.AreEqual(CPQNavigate.GetCurrentUrl(), UrlBuilder.GetRangerBrandHomePage());
        }

        [Test, Category("Ranger"), Category("Header")]
        public void VerifyAccessoriesPageHeaderElements()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RAN, "ranger-500-sage-green");
            Accessories.WaitForAccessoriesPageToLoad();
            Assert.IsTrue(Accessories.HeaderModule.IsHeaderSignInIconDisplayed());
            Assert.IsTrue(Accessories.HeaderModule.IsHeaderBrandNameDisplayed("Ranger"));
            Assert.IsTrue(Accessories.HeaderModule.IsSaveHeaderIconDisplayed());
            Assert.IsTrue(Accessories.HeaderModule.IsEmailHeaderIconDisplayed());
            Accessories.HeaderModule.ClickHeaderCloseIcon();
            Assert.AreEqual(CPQNavigate.GetCurrentUrl(), UrlBuilder.getRangerLandingPageURL());
        }

    }
}
