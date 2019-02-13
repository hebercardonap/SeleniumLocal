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

namespace BuildConfigurator.Tests.v3.UIFeatures
{
    [TestFixture]
    public class CTAAndLinksTests : TestBase
    {
        [Test, Category(TestCategories.UI_FEATURES), RetryDynamic]
        public void VerifyAccessorySeeDetailsLink()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RAN, ModelPageUrl.RANGER_500_SAGE_GREEN_ACCESSORIES);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Wheel");
            Accessories.ClickSubcategoryByName("Trail");
            Accessories.ClickProductDetailsLinkByDesc("Buckle- Accent");
            Assert.IsTrue(Accessories.IsProductInfoDescDisplayed(), "Product Info Details is not displayed");
            Accessories.ClickProductDetailsLinkByDesc("Buckle- Accent");
            Assert.IsFalse(Accessories.IsProductInfoDescDisplayed(), "Product Info Details is not hidden");
        }

        [Test, Category(TestCategories.UI_FEATURES), RetryDynamic]
        public void VerifyAccessorySeeDetailsLinkPackageSubProducts()
        {
            CPQNavigate.NavigateToPackagesPage(Brand.RAN, ModelPageUrl.RANGER_XP1000_EPS_STEEL_BLUE_PACKAGES);
            Accessories.WaitForAccessoriesPageToLoad();
            Packages.ClickPackageDetailsLinkByDesc("Ride Command");
            Assert.IsTrue(Packages.IsPackageInfoDescDisplayed(), "Package Info Details is not displayed");
            Packages.ClickSubProductDetailsLinkByDesc("Touch Display");
            Assert.IsTrue(Packages.IsSubProductInfoDescDisplayed(), "Sub product Info Details is not displayed");
        }
    }
}
