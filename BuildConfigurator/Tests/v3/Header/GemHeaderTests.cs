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
    public class GemHeaderTests : TestBase
    {
        [Test, Category(TestCategories.GEM), Category(TestCategories.HEADER), RetryDynamic]
        public void VerifyModelsPageHeaderElementsGem()
        {
            CPQNavigate.NavigateToModelsPage(Brand.GEM);
            Models.WaitForModelsPageToLoad();
            Assert.IsTrue(Models.HeaderModule.IsHeaderSignInIconDisplayed(), "Header Sign In is not displayed");
            Assert.IsTrue(Models.HeaderModule.IsHeaderBrandNameDisplayed("GEM"));
            Models.HeaderModule.ClickHeaderCloseIcon();
            Assert.AreEqual(CPQNavigate.GetCurrentUrl(), UrlBuilder.getGemLandingPageURL());
        }

        [Test, Category(TestCategories.GEM), Category(TestCategories.HEADER), RetryDynamic]
        public void VerifyAccessoriesPageHeaderElementsGem()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.GEM, ModelPageUrl.GEM_EL_XD_BASE_TEST);
            Accessories.WaitForAccessoriesPageToLoad();
            Assert.IsTrue(Accessories.HeaderModule.IsHeaderSignInIconDisplayed(), "Header Sign In is not displayed");
            Assert.IsTrue(Accessories.HeaderModule.IsHeaderBrandNameDisplayed("GEM"), "Header brand name not displayed");
            Assert.IsFalse(Accessories.HeaderModule.IsSaveHeaderIconDisplayed(), "Save icon was not expected to be displayed");
            Assert.IsFalse(Accessories.HeaderModule.IsEmailHeaderIconDisplayed(), "Email icon was not expected to be displayed");
            Accessories.HeaderModule.ClickHeaderCloseIcon();
            Assert.AreEqual(CPQNavigate.GetCurrentUrl(), UrlBuilder.getGemLandingPageURL());
        }
    }
}
