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
    public class AceFooterTests : TestBase
    {
        [Test, Category(TestCategories.ACE), Category(TestCategories.FOOTER), RetryDynamic]
        public void VerifyModelsPageFooterElementsAce()
        {
            CPQNavigate.NavigateToModelsPage(Brand.ACE);
            Assert.IsTrue(Models.FooterModule.IsStartingPriceDisplayed(), "Starting price is not displayed");
            Assert.IsTrue(Models.FooterModule.IsPaymentCalculatorDisplayed(), "Payment calculator icon is not displayed");
            Assert.IsFalse(Models.FooterModule.IsNextButtonDisplayed(), "Next button was not expected to be displayed");
            Models.FooterModule.ClickFooterPaymentCalculator();
            Assert.IsTrue(Models.CalculatorModule.IsPaymentCalculatorDisplayed(), "Payment Calculator is not displayed");
        }

        [Test, Category(TestCategories.ACE), Category(TestCategories.FOOTER), RetryDynamic]
        public void VerifyAccessoriesPageFooterElementsAce()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.ACE, ModelPageUrl.ACE_570_EPS_BASE_TEST);
            Accessories.WaitForAccessoriesPageToLoad();
            Assert.IsTrue(Colors.FooterModule.IsStartingPriceDisplayed(), "Starting price is not displayed");
            Assert.IsTrue(Colors.FooterModule.IsPaymentCalculatorDisplayed(), "Payment calculator icon is not displayed");
            Assert.IsTrue(Accessories.FooterModule.IsNextOpenBuildSummaryDisplayed(), "Next button is not displayed");
            Accessories.FooterModule.ClickFooterPaymentCalculator();
            Assert.IsTrue(Accessories.CalculatorModule.IsPaymentCalculatorDisplayed(), "Payment Calculator is not displayed");
        }
    }
}
