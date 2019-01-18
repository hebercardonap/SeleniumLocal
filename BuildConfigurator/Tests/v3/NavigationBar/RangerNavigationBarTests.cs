using AutomationFramework.Base;
using AutomationFramework.DataProvider;
using AutomationFramework.Helpers;
using AutomationFramework.UrlBuilderSites;
using AutomationFramework.Utils;
using BuildConfigurator.Hooks;
using BuildConfigurator.TestBases;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BuildConfigurator.Tests.v3.NavigationBar
{
    [TestFixture]
    public class RangerNavigationBarTests : TestBase
    {
        private static string DEALER_ID = "02040900";


        [Test, Category("Ranger"), Category("Navigation"), CustomRetry(3)]
        public void VerifyBackNavigationBar()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RAN, ModelPageUrl.RANGER_500_SAGE_GREEN_ACCESSORIES);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.NavigationBarModule.WaitForNavigationBarToLoad();
            Accessories.NavigationBarModule.ClickColorNavigation();
            Colors.NavigationBarModule.ClickTrimNavigation();
            Trims.NavigationBarModule.ClickModelsNavigation();
            Assert.IsTrue(Models.IsChooseModelTitleDisplayed());
        }

        [Test, Category("Ranger"), Category("Navigation"), CustomRetry(3)]
        public void VerifyClickingModelsRevertSeatSelection()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RAN, ModelPageUrl.RANGER_500_SAGE_GREEN_ACCESSORIES);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.NavigationBarModule.WaitForNavigationBarToLoad();
            Accessories.NavigationBarModule.ClickModelsNavigation();
            Models.WaitForModelsPageToLoad();
            Assert.IsTrue(Models.IsChooseModelTitleDisplayed());
            Models.VerifySeatSelectionIsDisplayed();
        }

        [Test, Category("Ranger"), Category("Navigation"), CustomRetry(3)]
        public void VerifyNavigationBarNotDisplayedDealerExp()
        {
            CPQNavigate.NavigateToBrandDealerExpAccessoriesPage(Brand.RAN, ModelPageUrl.RANGER_500_SAGE_GREEN_ACCESSORIES, DEALER_ID);
            Accessories.WaitForAccessoriesPageToLoad();
            Assert.IsFalse(Accessories.NavigationBarModule.IsNavigationBarDisplayed());
        }
    }
}
