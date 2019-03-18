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

namespace BuildConfigurator.Tests.v3.Toolbar
{
    [TestFixture]
    public class GenToolbarTests : TestBase
    {
        [Test, Category(TestCategories.GEN), Category(TestCategories.TOOLBAR), RetryDynamic]
        public void VerifyToolbarElementsAccessoryPageGen()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.GEN, ModelPageUrl.GENERAL_1000_EPS_BASE_TEST);
            Accessories.WaitForAccessoriesPageToLoad();
            Assert.IsTrue(Accessories.Toolbar.IsToolbarDisplayed(), "Toolbar was not displayed");
            Accessories.VerifyToolbarIconsAreEnabled();
        }

        [Test, Category(TestCategories.GEN), Category(TestCategories.TOOLBAR), RetryDynamic]
        public void VerifyToolbarElementsColorPageGen()
        {
            CPQNavigate.NavigateToColorsPage(Brand.GEN, ModelPageUrl.GENERAL_1000_EPS_TRIM_COLOR_PAGE);
            Colors.WaitForColorsPageToLoad();
            Assert.IsTrue(Colors.Toolbar.IsToolbarDisplayed(), "Toolbar was not displayed");
            Colors.VerifyToolbarIconsStateColorPage();
        }
    }
}
