﻿using AutomationFramework.Helpers;
using AutomationFramework.Utils;
using BuildConfigurator.Hooks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Tests.v3.SteppedProcess
{
    [TestFixture]
    public class GenSteppedProcessTests : TestBase
    {
        [Test, Category(TestCategories.GEN), Category(TestCategories.STEPPED_PROCESS), RetryDynamic]
        public void VerifySteppedProcessGen()
        {
            CPQNavigate.NavigateToModelsPage(Brand.GEN);
            Models.SelectModelBySeatNumber("two");
            Models.SelectRandomModelVersion();
            Trims.WaitForTrimsPageToLoad();
            Trims.ClickRandomTrim();
            Colors.WaitForColorsPageToLoad();
            Colors.ClickRandomWholegoodColor();
            Colors.FooterModule.ClickFooterNextButton();
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Wheel & Tire Sets");
            Accessories.ClickSubcategoryByName("Trail");
            Accessories.ClickAccessoryAddByProductName("Wheel & Tire Set");
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.ClikIamFinishedButton();
            Quote.WaitForBuildQuotePageToLoad();
            Quote.FillQuoteFormDefaultData();
            Quote.ClickGetInternetPriceButton();
            Confirmation.WaitUntilConfirmationPageLoads();
            Confirmation.ConfirmationPageElementsAreAsExpected();
        }
    }
}