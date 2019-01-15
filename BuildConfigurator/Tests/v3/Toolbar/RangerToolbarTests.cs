using AutomationFramework.DataProvider;
using AutomationFramework.Utils;
using BuildConfigurator.Hooks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Tests.Toolbar
{
    [TestFixture]
    public class RangerToolbarTests : TestBase
    {
        [Test, Category("Ranger"), Category("Toolbar")]
        public void VerifyToolbarElementsAccessoryPage()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RAN, ModelPageUrl.RANGER_500_SAGE_GREEN_ACCESSORIES);
            Accessories.WaitForAccessoriesPageToLoad();
            Assert.IsTrue(Accessories.Toolbar.IsToolbarDisplayed());
            Accessories.VerifyToolbarIconsAreEnabled();

        }

        [Test, Category("Ranger"), Category("Toolbar")]
        public void VerifyToolbarElementsColorPage()
        {
            CPQNavigate.NavigateToColorsPage(Brand.RAN, ModelPageUrl.RANGER_500_MODEL);
            Colors.WaitForColorsPageToLoad();
            Assert.IsTrue(Colors.Toolbar.IsToolbarDisplayed());
            Colors.VerifyToolbarIconsStateColorPage();

        }

        [Test, Category("Ranger"), Category("Toolbar")]
        public void VerifyToolbarElementsPackagesPage()
        {
            CPQNavigate.NavigateToPackagesPage(Brand.RAN, ModelPageUrl.RANGER_XP1000_EPS_STEEL_BLUE_PACKAGES);
            Packages.WaitForPackagesPageToLoad();
            Assert.IsTrue(Packages.Toolbar.IsToolbarDisplayed());
            Colors.VerifyToolbarIconsStateColorPage();

        }

        [Test, Category("Ranger"), Category("Toolbar")]
        public void VerifyToolbarRestartBuildFunctionality()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RAN, ModelPageUrl.RANGER_500_SAGE_GREEN_ACCESSORIES);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Wheel");
            Accessories.ClickSubcategoryByName("Trail");
            Accessories.ClickAccessoryAddByProductName("Buckle- Accent");
            Assert.IsTrue(Accessories.Toolbar.IsToolbarDisplayed());
            Accessories.Toolbar.ClickToolbarRestartIcon();
            Accessories.ClickConfirmationBuildContinueButton();
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Assert.IsFalse(Accessories.AreProductDescPresentBuildSummary(new List<string> { "Buckle- Accent" }));

        }
    }
}
