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
    public class GemFooterTests : TestBase
    {
        [Test, Category(TestCategories.GEM), Category(TestCategories.FOOTER), RetryDynamic]
        public void VerifyModelsPageFooterElementsGem()
        {
            CPQNavigate.NavigateToModelsPage(Brand.GEM);
            Models.WaitForModelsPageToLoad();
            Assert.IsTrue(Models.FooterModule.IsStartingPriceDisplayed(), "Starting price is not displayed");
            Assert.IsFalse(Models.FooterModule.IsPaymentCalculatorDisplayed(), "Payment calculator icon is not displayed");
            Assert.IsFalse(Models.FooterModule.IsNextButtonDisplayed(), "Next button was not expected to be displayed");
        }

        [Test, Category(TestCategories.GEM), Category(TestCategories.FOOTER), RetryDynamic]
        public void VerifyAccessoriesPageFooterElementsGem()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.GEM, ModelPageUrl.GEM_EL_XD_BASE_TEST);
            Accessories.WaitForAccessoriesPageToLoad();
            Assert.IsTrue(Colors.FooterModule.IsStartingPriceDisplayed(), "Starting price is not displayed");
            Assert.IsFalse(Colors.FooterModule.IsPaymentCalculatorDisplayed(), "Payment calculator icon is not displayed");
            Assert.IsTrue(Accessories.FooterModule.IsNextOpenBuildSummaryDisplayed(), "Next button is not displayed");
        }
    }
}
