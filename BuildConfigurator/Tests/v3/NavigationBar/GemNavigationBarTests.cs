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

namespace BuildConfigurator.Tests.v3.NavigationBar
{
    [TestFixture]
    public class GemNavigationBarTests : TestBase
    {
        private static string DEALER_ID = "54321";

        [Test, Category(TestCategories.GEM), Category(TestCategories.NAVIGATION), RetryDynamic]
        public void VerifyBackNavigationBarGem()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.GEM, ModelPageUrl.GEM_EL_XD_BASE_TEST);
            Accessories.NavigationBarModule.WaitForNavigationBarToLoad();
            Accessories.NavigationBarModule.ClickModelsNavigation();
            Assert.IsTrue(Models.IsChooseModelTitleDisplayed(), "Choose Model title is not displayed");
        }

        [Test, Category(TestCategories.GEM), Category(TestCategories.NAVIGATION), RetryDynamic]
        public void VerifyNavigationBarNotDisplayedDealerExpGem()
        {
            CPQNavigate.NavigateToBrandDealerExpAccessoriesPage(Brand.GEM, ModelPageUrl.GEM_EL_XD_BASE_TEST, DEALER_ID);
            Accessories.WaitForAccessoriesPageToLoad();
            Assert.IsFalse(Accessories.NavigationBarModule.IsNavigationBarDisplayed());
        }
    }
}
