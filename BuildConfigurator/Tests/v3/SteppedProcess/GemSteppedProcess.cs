using AutomationFramework.Helpers;
using AutomationFramework.Utils;
using BuildConfigurator.Hooks;
using NUnit.Framework;

namespace BuildConfigurator.Tests.v3.SteppedProcess
{
    [TestFixture]
    public class GemSteppedProcess : TestBase
    {
        [Test, Category(TestCategories.GEM), Category(TestCategories.STEPPED_PROCESS), RetryDynamic]
        public void VerifySteppedProcessGem()
        {
            CPQNavigate.NavigateToModelsPage(Brand.GEM);
            Models.ClickGemPassengerModelsFamily();
            Models.ClickRandomModelVersion();
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Power");
            Accessories.ClickSubcategoryByName("Battery");
            Accessories.ClickAccessoryAddByProductName("AGM");
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.ClikIamFinishedButton();
            Quote.WaitForBuildQuotePageToLoad();
            Quote.FillQuoteFormDefaultData();
            Quote.ClickFormPersonalUseOption();
            Quote.ClickGetInternetPriceButton();
            Confirmation.ClickBuildSummaryToggleCaret();
            Assert.IsTrue(Confirmation.GetGemAddedAccessoriesCount() > 0, 
                "No accessories added displayed on build confirmation");
        }
    }
}
