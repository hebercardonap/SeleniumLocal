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
    public class SnoFooterTests : TestBase
    {
        [Test, Category(TestCategories.SNO), Category(TestCategories.FOOTER), RetryDynamic]
        public void VerifyModelsPageFooterElementsSno()
        {
            CPQNavigate.NavigateToModelsPage(Brand.SNO);
            Models.WaitForModelsPageToLoad();
            Assert.IsTrue(Models.FooterModule.IsStartingPriceDisplayed());
            Assert.IsTrue(Models.FooterModule.IsPaymentCalculatorDisplayed());
            Assert.IsFalse(Models.FooterModule.IsNextButtonDisplayed());
            Models.FooterModule.ClickFooterPaymentCalculator();
            Assert.IsTrue(Models.CalculatorModule.IsPaymentCalculatorDisplayed());
        }

        [Test, Category(TestCategories.SNO), Category(TestCategories.FOOTER), RetryDynamic]
        public void VerifyTrackPageFooterElementsSno()
        {
            CPQNavigate.NavigateToTrackPage(Brand.SNO, ModelPageUrl.SNO_TRACK_ENGINE_PAGE_MODEL);
            Trims.WaitForTrimsPageToLoad();
            Assert.IsTrue(Track.FooterModule.IsStartingPriceDisplayed());
            Assert.IsTrue(Track.FooterModule.IsPaymentCalculatorDisplayed());
            Assert.IsFalse(Track.FooterModule.IsNextButtonDisplayed());
            Track.FooterModule.ClickFooterPaymentCalculator();
            Assert.IsTrue(Track.CalculatorModule.IsPaymentCalculatorDisplayed());
        }

        [Test, Category(TestCategories.SNO), Category(TestCategories.FOOTER), RetryDynamic]
        public void VerifyEnginePageFooterElementsSno()
        {
            CPQNavigate.NavigateToEnginePage(Brand.SNO, ModelPageUrl.SNO_TRACK_ENGINE_PAGE_MODEL);
            Colors.WaitForColorsPageToLoad();
            Assert.IsTrue(Engine.FooterModule.IsStartingPriceDisplayed());
            Assert.IsTrue(Engine.FooterModule.IsPaymentCalculatorDisplayed());
            Assert.IsTrue(Engine.FooterModule.IsNextButtonDisplayed());
            Engine.FooterModule.ClickFooterPaymentCalculator();
            Assert.IsTrue(Engine.CalculatorModule.IsPaymentCalculatorDisplayed());
        }

        [Test, Category(TestCategories.SNO), Category(TestCategories.FOOTER), RetryDynamic]
        public void VerifyAccessoriesPageFooterElementsSno()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.SNO, ModelPageUrl.SNO_SWITCHBACK_600_BASE_TEST);
            Accessories.WaitForAccessoriesPageToLoad();
            Assert.IsTrue(Accessories.FooterModule.IsStartingPriceDisplayed());
            Assert.IsTrue(Accessories.FooterModule.IsPaymentCalculatorDisplayed());
            Assert.IsTrue(Accessories.FooterModule.IsNextOpenBuildSummaryDisplayed());
            Accessories.FooterModule.ClickFooterPaymentCalculator();
            Assert.IsTrue(Accessories.CalculatorModule.IsPaymentCalculatorDisplayed());
        }
    }
}
