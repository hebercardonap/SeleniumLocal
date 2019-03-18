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

namespace BuildConfigurator.Tests.v3.Footer
{
    [TestFixture]
    public class GenFooterTests : TestBase
    {
        [Test, Category(TestCategories.GEN), Category(TestCategories.FOOTER), RetryDynamic]
        public void VerifyModelsPageFooterElementsGen()
        {
            CPQNavigate.NavigateToModelsPage(Brand.GEN);
            Models.WaitForModelsPageToLoad();
            Assert.IsTrue(Models.FooterModule.IsStartingPriceDisplayed(), "Starting price is not displayed");
            Assert.IsTrue(Models.FooterModule.IsPaymentCalculatorDisplayed(), "Payment calculator icon is not displayed");
            Assert.IsFalse(Models.FooterModule.IsNextButtonDisplayed(), "Next button was not expected to be displayed");
            Models.FooterModule.ClickFooterPaymentCalculator();
            Assert.IsTrue(Models.CalculatorModule.IsPaymentCalculatorDisplayed(), "Payment Calculator is not displayed");
        }

        [Test, Category(TestCategories.GEN), Category(TestCategories.FOOTER), RetryDynamic]
        public void VerifyTrimsPageFooterElementsGen()
        {
            CPQNavigate.NavigateToTrimsPage(Brand.GEN, ModelPageUrl.GENERAL_1000_EPS_TRIM_COLOR_PAGE);
            Trims.WaitForTrimsPageToLoad();
            Assert.IsTrue(Models.FooterModule.IsStartingPriceDisplayed(), "Starting price is not displayed");
            Assert.IsTrue(Models.FooterModule.IsPaymentCalculatorDisplayed(), "Payment calculator icon is not displayed");
            Assert.IsFalse(Models.FooterModule.IsNextButtonDisplayed(), "Next button was not expected to be displayed");
            Trims.FooterModule.ClickFooterPaymentCalculator();
            Assert.IsTrue(Trims.CalculatorModule.IsPaymentCalculatorDisplayed(), "Payment Calculator is not displayed");
        }

        [Test, Category(TestCategories.GEN), Category(TestCategories.FOOTER), RetryDynamic]
        public void VerifyColorsPageFooterElementsGen()
        {
            CPQNavigate.NavigateToColorsPage(Brand.GEN, ModelPageUrl.GENERAL_1000_EPS_TRIM_COLOR_PAGE);
            Colors.WaitForColorsPageToLoad();
            Assert.IsTrue(Colors.FooterModule.IsStartingPriceDisplayed(), "Starting price is not displayed");
            Assert.IsTrue(Colors.FooterModule.IsPaymentCalculatorDisplayed(), "Payment calculator icon is not displayed");
            Assert.IsTrue(Colors.FooterModule.IsNextButtonDisplayed(), "Next button was not expected to be displayed");
            Colors.FooterModule.ClickFooterPaymentCalculator();
            Assert.IsTrue(Colors.CalculatorModule.IsPaymentCalculatorDisplayed(), "Payment Calculator is not displayed");
        }

        [Test, Category(TestCategories.GEN), Category(TestCategories.FOOTER), RetryDynamic]
        public void VerifyAccessoriesPageFooterElementsGen()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.GEN, ModelPageUrl.GENERAL_1000_EPS_BASE_TEST);
            Accessories.WaitForAccessoriesPageToLoad();
            Assert.IsTrue(Colors.FooterModule.IsStartingPriceDisplayed(), "Starting price is not displayed");
            Assert.IsTrue(Colors.FooterModule.IsPaymentCalculatorDisplayed(), "Payment calculator icon is not displayed");
            Assert.IsTrue(Accessories.FooterModule.IsNextOpenBuildSummaryDisplayed(), "Next button is not displayed");
            Accessories.FooterModule.ClickFooterPaymentCalculator();
            Assert.IsTrue(Accessories.CalculatorModule.IsPaymentCalculatorDisplayed(), "Payment Calculator is not displayed");
        }
    }
}
