﻿using AutomationFramework.DataProvider;
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
            Assert.IsTrue(Models.HeaderModule.IsHeaderSignInIconDisplayed());
            Assert.IsTrue(Models.HeaderModule.IsHeaderBrandNameDisplayed("Ranger"));
            Models.HeaderModule.ClickHeaderCloseIcon();
            Assert.AreEqual(CPQNavigate.GetCurrentUrl(), UrlBuilder.GetRangerBrandHomePage());
        }

        [Test, Category(TestCategories.RAN), Category(TestCategories.HEADER), RetryDynamic]
        public void VerifyTrimsPageHeaderElementsRan()
        {
            CPQNavigate.NavigateToTrimsPage(Brand.RAN, ModelPageUrl.RANGER_500_MODEL);
            Trims.WaitForTrimsPageToLoad();
            Assert.IsTrue(Trims.HeaderModule.IsHeaderSignInIconDisplayed());
            Assert.IsTrue(Trims.HeaderModule.IsHeaderBrandNameDisplayed("Ranger"));
            Trims.HeaderModule.ClickHeaderCloseIcon();
            Assert.AreEqual(CPQNavigate.GetCurrentUrl(), UrlBuilder.GetRangerBrandHomePage());
        }

        [Test, Category(TestCategories.RAN), Category(TestCategories.HEADER), RetryDynamic]
        public void VerifyColorsPageHeaderElementsRan()
        {
            CPQNavigate.NavigateToColorsPage(Brand.RAN, ModelPageUrl.RANGER_500_MODEL);
            Colors.WaitForColorsPageToLoad();
            Assert.IsTrue(Colors.HeaderModule.IsHeaderSignInIconDisplayed());
            Assert.IsTrue(Colors.HeaderModule.IsHeaderBrandNameDisplayed("Ranger"));
            Trims.HeaderModule.ClickHeaderCloseIcon();
            Assert.AreEqual(CPQNavigate.GetCurrentUrl(), UrlBuilder.GetRangerBrandHomePage());
        }

        [Test, Category(TestCategories.RAN), Category(TestCategories.HEADER), RetryDynamic]
        public void VerifyPackagesPageHeaderElementsRan()
        {
            CPQNavigate.NavigateToPackagesPage(Brand.RAN, ModelPageUrl.RANGER_XP1000_EPS_STEEL_BLUE_PACKAGES);
            Packages.WaitForPackagesPageToLoad();
            Assert.IsTrue(Packages.HeaderModule.IsHeaderSignInIconDisplayed());
            Assert.IsTrue(Packages.HeaderModule.IsHeaderBrandNameDisplayed("Ranger"));
            Packages.HeaderModule.ClickHeaderCloseIcon();
            Assert.AreEqual(CPQNavigate.GetCurrentUrl(), UrlBuilder.GetRangerBrandHomePage());
        }

        [Test, Category(TestCategories.RAN), Category(TestCategories.HEADER), RetryDynamic]
        public void VerifyAccessoriesPageHeaderElementsRan()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RAN, ModelPageUrl.RANGER_500_SAGE_GREEN_ACCESSORIES);
            Accessories.WaitForAccessoriesPageToLoad();
            Assert.IsTrue(Accessories.HeaderModule.IsHeaderSignInIconDisplayed());
            Assert.IsTrue(Accessories.HeaderModule.IsHeaderBrandNameDisplayed("Ranger"));
            Assert.IsFalse(Accessories.HeaderModule.IsSaveHeaderIconDisplayed());
            Assert.IsFalse(Accessories.HeaderModule.IsEmailHeaderIconDisplayed());
            Accessories.HeaderModule.ClickHeaderCloseIcon();
            Assert.AreEqual(CPQNavigate.GetCurrentUrl(), UrlBuilder.getRangerLandingPageURL());
        }

    }
}
