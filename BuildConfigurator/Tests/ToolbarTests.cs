using AutomationFramework.DataProvider;
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
    public class ToolbarTests : TestBase
    {
        [Test, Category("Ranger"), Category("Toolbar")]
        public void VerifyToolbarElementsAccessoryPage()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RAN, "ranger-500-sage-green");
            Accessories.WaitForAccessoriesPageToLoad();
            Assert.IsTrue(Accessories.Toolbar.IsToolbarDisplayed());
            Accessories.VerifyToolbarIconsAreEnabled();

        }

        [Test, Category("Ranger"), Category("Toolbar")]
        public void VerifyToolbarElementsColorPage()
        {
            CPQNavigate.NavigateToColorsPage(Brand.RAN, "ranger-500");
            Colors.WaitForColorsPageToLoad();
            Assert.IsTrue(Colors.Toolbar.IsToolbarDisplayed());
            Colors.VerifyToolbarIconsStateColorPage();

        }

        [Test, Category("Ranger"), Category("Toolbar")]
        public void VerifyToolbarElementsPackagesPage()
        {
            CPQNavigate.NavigateToPackagesPage(Brand.RAN, ModelPageUrl.RangerPackagesPageTest);
            Packages.WaitForPackagesPageToLoad();
            Assert.IsTrue(Packages.Toolbar.IsToolbarDisplayed());
            Colors.VerifyToolbarIconsStateColorPage();

        }

        [Test, Category("Ranger"), Category("Toolbar")]
        public void VerifyToolbarRestartBuildFunctionality()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RAN, ModelPageUrl.RangerBasicAccessoriesPage);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Wheel");
            Accessories.ClickSubcategoryByName("Trail");
            Accessories.ClickAccessoryAddByProductName("Buckle- Accent");
            Assert.IsTrue(Accessories.Toolbar.IsToolbarDisplayed());
            Accessories.Toolbar.ClickToolbarRestartIcon();
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Assert.IsFalse(Accessories.AreProductDescPresentBuildSummary(new List<string> { "Buckle- Accent" }));

        }
    }
}
