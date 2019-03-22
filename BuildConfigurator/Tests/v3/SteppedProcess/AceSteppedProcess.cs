using AutomationFramework.Helpers;
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
    public class AceSteppedProcess : TestBase
    {
        [Test, Category(TestCategories.ACE), Category(TestCategories.STEPPED_PROCESS), RetryDynamic]
        public void VerifySteppedProcessAce()
        {
            CPQNavigate.NavigateToModelsPage(Brand.ACE);
            Models.SelectRandomModelVersion();
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
            Assert.IsTrue(Confirmation.IsProductDescPresentBuildConfirmation("Wheel & Tire Set"));
        }
    }
}
