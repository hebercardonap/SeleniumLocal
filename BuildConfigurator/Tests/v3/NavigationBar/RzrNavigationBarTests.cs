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
    public class RzrNavigationBarTests : TestBase
    {
        private static string DEALER_ID = "54321";

        [Test, Category(TestCategories.RZR), Category(TestCategories.NAVIGATION), RetryDynamic]
        public void VerifyBackNavigationBarRzr()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RZR, ModelPageUrl.RZR_XP_1000_EPS_BASE_TEST);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.NavigationBarModule.WaitForNavigationBarToLoad();
            Accessories.NavigationBarModule.ClickColorNavigation();
            Colors.NavigationBarModule.ClickTrimNavigation();
            Trims.NavigationBarModule.ClickModelsNavigation();
            Assert.IsTrue(Models.IsChooseModelTitleDisplayed());
        }

        [Test, Category(TestCategories.RZR), Category(TestCategories.NAVIGATION), RetryDynamic]
        public void VerifyClickingModelsRevertSeatSelectionRzr()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RZR, ModelPageUrl.RZR_XP_1000_EPS_BASE_TEST);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.NavigationBarModule.WaitForNavigationBarToLoad();
            Accessories.NavigationBarModule.ClickModelsNavigation();
            Models.WaitForModelsPageToLoad();
            Assert.IsTrue(Models.IsChooseModelTitleDisplayed());
            Models.VerifySeatSelectionIsDisplayed();
        }

        [Test, Category(TestCategories.RZR), Category(TestCategories.NAVIGATION), RetryDynamic]
        public void VerifyNavigationBarNotDisplayedDealerExpRzr()
        {
            CPQNavigate.NavigateToBrandDealerExpAccessoriesPage(Brand.RZR, ModelPageUrl.RZR_XP_1000_EPS_BASE_TEST, DEALER_ID);
            Accessories.WaitForAccessoriesPageToLoad();
            Assert.IsFalse(Accessories.NavigationBarModule.IsNavigationBarDisplayed());
        }
    }
}
