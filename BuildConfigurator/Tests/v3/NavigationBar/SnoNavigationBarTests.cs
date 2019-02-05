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
    public class SnoNavigationBarTests : TestBase
    {
        private static string DEALER_ID = "02040900";


        [Test, Category(TestCategories.SNO), Category(TestCategories.NAVIGATION), RetryDynamic]
        public void VerifyBackNavigationBarSno()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.SNO, ModelPageUrl.SNO_SWITCHBACK_600_BASE_TEST);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.NavigationBarModule.WaitForNavigationBarToLoad();
            Accessories.NavigationBarModule.ClickColorNavigation();
            Engine.NavigationBarModule.ClickTrimNavigation();
            Track.NavigationBarModule.ClickModelsNavigation();
            Assert.IsTrue(Models.IsChooseModelTitleDisplayed());
        }

        [Test, Category(TestCategories.SNO), Category(TestCategories.NAVIGATION), RetryDynamic]
        public void VerifyClickingModelsRevertSeatSelectionSno()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.SNO, ModelPageUrl.SNO_SWITCHBACK_600_BASE_TEST);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.NavigationBarModule.WaitForNavigationBarToLoad();
            Accessories.NavigationBarModule.ClickModelsNavigation();
            Models.WaitForModelsPageToLoad();
            Assert.IsTrue(Models.IsChooseModelTitleDisplayed());
            Models.VerifySnowFamilyCardsDisplayed();
        }

        [Test, Category(TestCategories.SNO), Category(TestCategories.NAVIGATION), RetryDynamic]
        public void VerifyNavigationBarNotDisplayedDealerExpSno()
        {
            CPQNavigate.NavigateToBrandDealerExpAccessoriesPage(Brand.SNO, ModelPageUrl.SNO_SWITCHBACK_600_BASE_TEST, DEALER_ID);
            Accessories.WaitForAccessoriesPageToLoad();
            Assert.IsFalse(Accessories.NavigationBarModule.IsNavigationBarDisplayed());
        }
    }
}
