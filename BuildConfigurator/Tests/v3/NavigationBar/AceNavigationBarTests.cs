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
    public class AceNavigationBarTests : TestBase
    {
        private static string DEALER_ID = "54321";

        [Test, Category(TestCategories.ACE), Category(TestCategories.NAVIGATION), RetryDynamic]
        public void VerifyBackNavigationBarAce()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.ACE, ModelPageUrl.ACE_570_EPS_BASE_TEST);
            Accessories.NavigationBarModule.WaitForNavigationBarToLoad();
            Accessories.NavigationBarModule.ClickModelsNavigation();
            Assert.IsTrue(Models.IsChooseModelTitleDisplayed());
        }

        [Test, Category(TestCategories.ACE), Category(TestCategories.NAVIGATION), RetryDynamic]
        public void VerifyNavigationBarNotDisplayedDealerExpAce()
        {
            CPQNavigate.NavigateToBrandDealerExpAccessoriesPage(Brand.ACE, ModelPageUrl.ACE_570_EPS_BASE_TEST, DEALER_ID);
            Accessories.WaitForAccessoriesPageToLoad();
            Assert.IsFalse(Accessories.NavigationBarModule.IsNavigationBarDisplayed());
        }
    }
}
