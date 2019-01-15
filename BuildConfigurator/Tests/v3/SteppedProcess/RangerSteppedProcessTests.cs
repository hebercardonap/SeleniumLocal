using AutomationFramework.Base;
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

namespace BuildConfigurator.Tests.SteppedProcess
{
    [TestFixture]
    public class RangerSteppedProcessTests : TestBase
    {

        [Test, Category("Ranger"), Category("Stepped Process")]
        public void RangerSteppedProcess()
        {
            CPQNavigate.NavigateToModelsPage(Brand.RAN);
            Models.SelectModelBySeatNumber("two");
            Models.SelectRandomModelVersion();
            Trims.WaitForTrimsPageToLoad();
            Trims.ClickRandomTrim();
            Colors.WaitForColorsPageToLoad();
            Colors.ClickRandomWholegoodColor();
            Colors.FooterModule.ClickFooterNextButton();
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Wheel");
            Accessories.ClickSubcategoryByName("Trail");
            Accessories.ClickAccessoryAddByProductName("Buckle- Accent");
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
