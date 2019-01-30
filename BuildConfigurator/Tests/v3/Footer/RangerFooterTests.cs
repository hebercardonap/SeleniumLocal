﻿using AutomationFramework.DataProvider;
using AutomationFramework.Helpers;
using AutomationFramework.UrlBuilderSites;
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
    public class RangerFooterTests : TestBase
    {
        [Test, Category(TestCategories.RAN), Category(TestCategories.FOOTER), RetryDynamic]
        public void VerifyModelsPageFooterElementsRan()
        {
            CPQNavigate.NavigateToModelsPage(Brand.RAN);
            Models.WaitForModelsPageToLoad();
            Assert.IsTrue(Models.FooterModule.IsStartingPriceDisplayed());
            Assert.IsTrue(Models.FooterModule.IsPaymentCalculatorDisplayed());
            Assert.IsFalse(Models.FooterModule.IsNextButtonDisplayed());
            Models.FooterModule.ClickFooterPaymentCalculator();
            Assert.IsTrue(Models.CalculatorModule.IsPaymentCalculatorDisplayed());
        }

        [Test, Category(TestCategories.RAN), Category(TestCategories.FOOTER), RetryDynamic]
        public void VerifyTrimsPageFooterElementsRan()
        {
            CPQNavigate.NavigateToTrimsPage(Brand.RAN, ModelPageUrl.RANGER_500_MODEL);
            Trims.WaitForTrimsPageToLoad();
            Assert.IsTrue(Trims.FooterModule.IsStartingPriceDisplayed());
            Assert.IsTrue(Trims.FooterModule.IsPaymentCalculatorDisplayed());
            Assert.IsFalse(Trims.FooterModule.IsNextButtonDisplayed());
            Trims.FooterModule.ClickFooterPaymentCalculator();
            Assert.IsTrue(Trims.CalculatorModule.IsPaymentCalculatorDisplayed());
        }

        [Test, Category(TestCategories.RAN), Category(TestCategories.FOOTER), RetryDynamic]
        public void VerifyColorsPageFooterElementsRan()
        {
            CPQNavigate.NavigateToColorsPage(Brand.RAN, ModelPageUrl.RANGER_500_MODEL);
            Colors.WaitForColorsPageToLoad();
            Assert.IsTrue(Colors.FooterModule.IsStartingPriceDisplayed());
            Assert.IsTrue(Colors.FooterModule.IsPaymentCalculatorDisplayed());
            Assert.IsTrue(Colors.FooterModule.IsNextButtonDisplayed());
            Colors.FooterModule.ClickFooterPaymentCalculator();
            Assert.IsTrue(Colors.CalculatorModule.IsPaymentCalculatorDisplayed());
        }

        [Test, Category(TestCategories.RAN), Category(TestCategories.FOOTER), RetryDynamic]
        public void VerifyAccessoriesPageFooterElementsRan()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RAN, ModelPageUrl.RANGER_500_SAGE_GREEN_ACCESSORIES);
            Accessories.WaitForAccessoriesPageToLoad();
            Assert.IsTrue(Accessories.FooterModule.IsStartingPriceDisplayed());
            Assert.IsTrue(Accessories.FooterModule.IsPaymentCalculatorDisplayed());
            Assert.IsTrue(Accessories.FooterModule.IsNextOpenBuildSummaryDisplayed());
            Accessories.FooterModule.ClickFooterPaymentCalculator();
            Assert.IsTrue(Accessories.CalculatorModule.IsPaymentCalculatorDisplayed());
        }
    }
}
