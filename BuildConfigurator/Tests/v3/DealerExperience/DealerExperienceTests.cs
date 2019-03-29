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

namespace BuildConfigurator.Tests.v3.DealerExperience
{
    [TestFixture]
    public class DealerExperienceTests : TestBase
    {
        private static string DEALER_ID = "54321";
        private static string NAVIGATION_BAR_NOT_EXPECTED = "Navigation bar is displayed and was not expected for dealer experience UI";

        [Test, Category(TestCategories.DEALER_EXPERIENCE), RetryDynamic]
        public void VerifyUIElementsHiddenDealerExpRzr()
        {
            CPQNavigate.NavigateToBrandDealerExpAccessoriesPage(Brand.RZR, ModelPageUrl.RZR_XP_1000_EPS_BASE_TEST, DEALER_ID);
            Accessories.WaitForAccessoriesPageToLoad();
            Assert.IsFalse(Accessories.NavigationBarModule.IsNavigationBarDisplayed(), NAVIGATION_BAR_NOT_EXPECTED);
            Accessories.VerifyHeaderItemsForDealerExp();
            Accessories.VerifyToolBarItemsForDealerExp();
        }

        [Test, Category(TestCategories.RAN), Category(TestCategories.NAVIGATION), RetryDynamic]
        public void VerifyUIElementsHiddenDealerExpRan()
        {
            CPQNavigate.NavigateToBrandDealerExpAccessoriesPage(Brand.RAN, ModelPageUrl.RANGER_500_SAGE_GREEN_ACCESSORIES, DEALER_ID);
            Accessories.WaitForAccessoriesPageToLoad();
            Assert.IsFalse(Accessories.NavigationBarModule.IsNavigationBarDisplayed(), NAVIGATION_BAR_NOT_EXPECTED);
            Accessories.VerifyHeaderItemsForDealerExp();
            Accessories.VerifyToolBarItemsForDealerExp();
        }

        [Test, Category(TestCategories.GEM), Category(TestCategories.NAVIGATION), RetryDynamic]
        public void VerifyUIElementsHiddenDealerExpGem()
        {
            CPQNavigate.NavigateToBrandDealerExpAccessoriesPage(Brand.GEM, ModelPageUrl.GEM_EL_XD_BASE_TEST, DEALER_ID);
            Accessories.WaitForAccessoriesPageToLoad();
            Assert.IsFalse(Accessories.NavigationBarModule.IsNavigationBarDisplayed(), NAVIGATION_BAR_NOT_EXPECTED);
            Accessories.VerifyHeaderItemsForDealerExp();
            Accessories.VerifyToolBarItemsForDealerExp();
        }

        [Test, Category(TestCategories.ATV), Category(TestCategories.NAVIGATION), RetryDynamic]
        public void VerifyUIElementsHiddenDealerExpAtv()
        {
            CPQNavigate.NavigateToBrandDealerExpAccessoriesPage(Brand.ATV, ModelPageUrl.ATV_450_HO_BASE_TEST, DEALER_ID);
            Accessories.WaitForAccessoriesPageToLoad();
            Assert.IsFalse(Accessories.NavigationBarModule.IsNavigationBarDisplayed(), NAVIGATION_BAR_NOT_EXPECTED);
            Accessories.VerifyHeaderItemsForDealerExp();
            Accessories.VerifyToolBarItemsForDealerExp();
        }

        [Test, Category(TestCategories.ACE), Category(TestCategories.NAVIGATION), RetryDynamic]
        public void VerifyUIElementsHiddenDealerExpAce()
        {
            CPQNavigate.NavigateToBrandDealerExpAccessoriesPage(Brand.ACE, ModelPageUrl.ACE_570_EPS_BASE_TEST, DEALER_ID);
            Accessories.WaitForAccessoriesPageToLoad();
            Assert.IsFalse(Accessories.NavigationBarModule.IsNavigationBarDisplayed(), NAVIGATION_BAR_NOT_EXPECTED);
            Accessories.VerifyHeaderItemsForDealerExp();
            Accessories.VerifyToolBarItemsForDealerExp();
        }

        [Test, Category(TestCategories.DEALER_EXPERIENCE), RetryDynamic]
        public void VerifyCalcVirtualKeyboardV3()
        {
            CPQNavigate.NavigateToBrandDealerExpAccessoriesPage(Brand.RZR, ModelPageUrl.RZR_XP_1000_EPS_BASE_TEST, DEALER_ID);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.FooterModule.ClickFooterPaymentCalculator();
            Accessories.CalculatorModule.ClickMsrpField();
            Assert.IsTrue(Accessories.CalculatorModule.IsCalcVirtualKeyboardDisplayed(), "Calculator virtual keyboard is not displayed");
        }

        [Test, Category(TestCategories.DEALER_EXPERIENCE), RetryDynamic]
        public void VerifyNotesVirtualKeyboardV3()
        {
            CPQNavigate.NavigateToBrandDealerExpAccessoriesPage(Brand.RZR, ModelPageUrl.RZR_XP_1000_EPS_BASE_TEST, DEALER_ID);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.FooterModule.ClickFooterNextButtonOpenSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.ClickSummaryNotesTextbox();
            Assert.IsTrue(Accessories.IsSummaryNotesVirtualKeyboardDisplayed(), "Summary Notes Virtual keyboard is not displayed");
        }

        [Test, Category(TestCategories.DEALER_EXPERIENCE), RetryDynamic]
        public void VerifyDealerExperienceQuoteUI()
        {
            CPQNavigate.NavigateToBrandDealerExpAccessoriesPage(Brand.RZR, ModelPageUrl.RZR_XP_1000_EPS_BASE_TEST, DEALER_ID);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.FooterModule.ClickFooterNextButtonOpenSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.ClikIamFinishedButton();
            Quote.VerifyQuotePageDealerExpUI();
        }

        [Test, Category(TestCategories.DEALER_EXPERIENCE), RetryDynamic]
        public void VerifyVirtualKeyboardQuote()
        {
            CPQNavigate.NavigateToBrandDealerExpAccessoriesPage(Brand.RZR, ModelPageUrl.RZR_XP_1000_EPS_BASE_TEST, DEALER_ID);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.FooterModule.ClickFooterNextButtonOpenSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.ClikIamFinishedButton();
            Quote.WaitForBuildQuotePageToLoad();
            Quote.ClickFirstNameTextBox();
            Assert.IsTrue(Quote.IsQuotePageVirtualKeyboardDisplayed(), "Quote page virtual keyboard was not displayed");
        }

        [Test, Category(TestCategories.DEALER_EXPERIENCE), RetryDynamic]
        public void VerifyQuoteConfirmationDealerExp()
        {
            CPQNavigate.NavigateToBrandDealerExpAccessoriesPage(Brand.RZR, ModelPageUrl.RZR_XP_1000_EPS_BASE_TEST, DEALER_ID);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.FooterModule.ClickFooterNextButtonOpenSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.ClikIamFinishedButton();
            Quote.WaitForBuildQuotePageToLoad();
            Quote.FillDealerExpQuoteFormDefaultData();
            Quote.ClickGetInternetPriceButton();
            Confirmation.WaitUntilConfirmationPageLoads();
            Assert.IsFalse(Confirmation.IsSummaryPrintLinkDisplayed(),
                "Print summary is present on the page for dealer experience URL");
        }
    }
}
