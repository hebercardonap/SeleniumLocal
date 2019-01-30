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
    public class SnoHeaderTests : TestBase
    {
        [Test, Category(TestCategories.SNO), Category(TestCategories.HEADER), RetryDynamic]
        public void VerifyModelsPageHeaderElementsSno()
        {
            CPQNavigate.NavigateToModelsPage(Brand.SNO);
            Models.WaitForModelsPageToLoad();
            Assert.IsTrue(Models.HeaderModule.IsHeaderSignInIconDisplayed());
            Assert.IsTrue(Models.HeaderModule.IsHeaderBrandNameDisplayed("Snowmobiles"));
            Models.HeaderModule.ClickHeaderCloseIcon();
            Assert.AreEqual(CPQNavigate.GetCurrentUrl(), UrlBuilder.getSnoLandingPageURL());
        }

        [Test, Category(TestCategories.RAN), Category(TestCategories.HEADER), RetryDynamic]
        public void VerifyTrackPageHeaderElementsSno()
        {
            CPQNavigate.NavigateToTrackPage(Brand.SNO, ModelPageUrl.SNO_TRACK_ENGINE_PAGE_MODEL);
            Track.WaitForTrackPageToLoad();
            Assert.IsTrue(Track.HeaderModule.IsHeaderSignInIconDisplayed());
            Assert.IsTrue(Track.HeaderModule.IsHeaderBrandNameDisplayed("Rush"));
            Track.HeaderModule.ClickHeaderCloseIcon();
            Assert.AreEqual(CPQNavigate.GetCurrentUrl(), UrlBuilder.getSnoLandingPageURL());
        }

        [Test, Category(TestCategories.SNO), Category(TestCategories.HEADER), RetryDynamic]
        public void VerifyEnginePageHeaderElementsSno()
        {
            CPQNavigate.NavigateToEnginePage(Brand.SNO, ModelPageUrl.SNO_TRACK_ENGINE_PAGE_MODEL);
            Engine.WaitForEnginePageToLoad();
            Assert.IsTrue(Engine.HeaderModule.IsHeaderSignInIconDisplayed());
            Assert.IsTrue(Engine.HeaderModule.IsHeaderBrandNameDisplayed("Rush"));
            Engine.HeaderModule.ClickHeaderCloseIcon();
            Assert.AreEqual(CPQNavigate.GetCurrentUrl(), UrlBuilder.getSnoLandingPageURL());
        }


        [Test, Category(TestCategories.SNO), Category(TestCategories.HEADER), RetryDynamic]
        public void VerifyAccessoriesPageHeaderElementsSno()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.SNO, ModelPageUrl.SNO_SWITCHBACK_600_BASE_TEST);
            Accessories.WaitForAccessoriesPageToLoad();
            Assert.IsTrue(Accessories.HeaderModule.IsHeaderSignInIconDisplayed());
            Assert.IsTrue(Accessories.HeaderModule.IsHeaderBrandNameDisplayed("Switchback"));
            Assert.IsFalse(Accessories.HeaderModule.IsSaveHeaderIconDisplayed());
            Assert.IsFalse(Accessories.HeaderModule.IsEmailHeaderIconDisplayed());
            Accessories.HeaderModule.ClickHeaderCloseIcon();
            Assert.AreEqual(CPQNavigate.GetCurrentUrl(), UrlBuilder.getSnoLandingPageURL());
        }
    }
}
