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
    public class AceHeaderTests : TestBase
    {
        [Test, Category(TestCategories.ACE), Category(TestCategories.HEADER), RetryDynamic]
        public void VerifyModelsPageHeaderElementsAce()
        {
            CPQNavigate.NavigateToModelsPage(Brand.ACE);
            Assert.IsTrue(Models.HeaderModule.IsHeaderSignInIconDisplayed(), "Header Sign In is not displayed");
            Assert.IsTrue(Models.HeaderModule.IsHeaderBrandNameDisplayed("ACE"));
            Models.HeaderModule.ClickHeaderCloseIcon();
            Assert.AreEqual(CPQNavigate.GetCurrentUrl(), UrlBuilder.getAceLandingPageURL());
        }

        [Test, Category(TestCategories.ACE), Category(TestCategories.HEADER), RetryDynamic]
        public void VerifyAccessoriesPageHeaderElementsAce()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.ACE, ModelPageUrl.ACE_570_EPS_BASE_TEST);
            Accessories.WaitForAccessoriesPageToLoad();
            Assert.IsTrue(Accessories.HeaderModule.IsHeaderSignInIconDisplayed(), "Header Sign In is not displayed");
            Assert.IsTrue(Accessories.HeaderModule.IsHeaderBrandNameDisplayed("ACE"), "Header brand name not displayed");
            Assert.IsFalse(Accessories.HeaderModule.IsSaveHeaderIconDisplayed(), "Save icon was not expected to be displayed");
            Assert.IsFalse(Accessories.HeaderModule.IsEmailHeaderIconDisplayed(), "Email icon was not expected to be displayed");
            Accessories.HeaderModule.ClickHeaderCloseIcon();
            Assert.AreEqual(CPQNavigate.GetCurrentUrl(), UrlBuilder.getAceLandingPageURL());
        }
    }
}
