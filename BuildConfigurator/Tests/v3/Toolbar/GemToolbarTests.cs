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
    public class GemToolbarTests : TestBase
    {
        [Test, Category(TestCategories.GEM), Category(TestCategories.TOOLBAR), RetryDynamic]
        public void VerifyToolbarElementsAccessoryPageGem()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.GEM, ModelPageUrl.GEM_EL_XD_BASE_TEST);
            Accessories.WaitForAccessoriesPageToLoad();
            Assert.IsTrue(Accessories.Toolbar.IsToolbarDisplayed(), "Toolbar was not displayed");
            Accessories.VerifyToolbarIconsAreEnabled();
        }
    }
}
