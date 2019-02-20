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
    [Ignore("ATV is not on CPQ v3 yet, Ignore flag will be removed when ATV switches to v3 UI")]
    public class AtvNavigationBarTests : TestBase
    {
        private static string DEALER_ID = "02040900";

        [Test, Category(TestCategories.ATV), Category(TestCategories.NAVIGATION), RetryDynamic]
        public void VerifyBackNavigationBarAtv()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.ATV, ModelPageUrl.ATV_450_HO_BASE_TEST);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.NavigationBarModule.WaitForNavigationBarToLoad();
            Accessories.NavigationBarModule.ClickColorNavigation();
            Colors.NavigationBarModule.ClickTrimNavigation();
            Trims.NavigationBarModule.ClickModelsNavigation();
            Assert.IsTrue(Models.IsChooseModelTitleDisplayed(), "Choose model page title is not displayed");
        }

        [Test, Category(TestCategories.ATV), Category(TestCategories.NAVIGATION), RetryDynamic]
        public void VerifyClickingModelsRevertSeatSelectionAtv()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.ATV, ModelPageUrl.ATV_450_HO_BASE_TEST);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.NavigationBarModule.WaitForNavigationBarToLoad();
            Accessories.NavigationBarModule.ClickModelsNavigation();
            Models.WaitForModelsPageToLoad();
            Assert.IsTrue(Models.IsChooseModelTitleDisplayed(), "Choose model page title is not displayed");
            Models.VerifySeatSelectionIsDisplayed();
        }

        [Test, Category(TestCategories.ATV), Category(TestCategories.NAVIGATION), RetryDynamic]
        public void VerifyNavigationBarNotDisplayedDealerExpAtv()
        {
            CPQNavigate.NavigateToBrandDealerExpAccessoriesPage(Brand.ATV, ModelPageUrl.ATV_450_HO_BASE_TEST, DEALER_ID);
            Accessories.WaitForAccessoriesPageToLoad();
            Assert.IsFalse(Accessories.NavigationBarModule.IsNavigationBarDisplayed(), 
                "Navigation bar is not expected for dealer experience");
        }
    }
}
