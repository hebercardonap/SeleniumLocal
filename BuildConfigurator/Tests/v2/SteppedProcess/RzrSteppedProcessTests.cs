using AutomationFramework.Helpers;
using AutomationFramework.Utils;
using BuildConfigurator.Hooks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Tests.v2.SteppedProcess
{
    [TestFixture]
    [Ignore("Brand running CPQ v3 version")]
    public class RzrSteppedProcessTests : TestBase
    {
        //[Test, Category(TestCategories.RZR), Category(TestCategories.STEPPED_PROCESS), RetryDynamic]
        public void VerifyRzrSteppedProcessOneSeat()
        {
            CPQNavigate.NavigateToModelsPage(Brand.RZR);
            BuildModelPage.WaitForBuildModelPageToLoad();
            BuildModelPage.ClickOneSeat();
            BuildModelPage.ClickRandomModel();
            BuildTrimPage.WaitForTrimPageToLoad();
            BuildTrimPage.ClickRandomTrim();
            BuildColorPage.WaitForColorPageToLoad();
            BuildColorPage.ClickColor();
            BuildColorPage.ClickNextButton();
            BuildConfigurePage.WaitForBuildPageToLoad();
            BuildConfigurePage.ClickRandomAccessoryAvoidPRP();
            BuildConfigurePage.ClickIamFinishedButton();
            BuildQuotePage.WaitForBuildQuotePgeToLoad();
            BuildQuotePage.FillQuoteFormDefaultData();
            BuildQuotePage.ClickGetInternetPriceButton();
            BuildConfirmationPage.WaitForBuildConfirmationPageToLoad();
            BuildConfirmationPage.VerifyNewBuildConfirmationAsExpected();
        }

        //[Test, Category(TestCategories.RZR), Category(TestCategories.STEPPED_PROCESS), RetryDynamic]
        public void VerifyRzrSteppedProcessTwoSeat()
        {
            CPQNavigate.NavigateToModelsPage(Brand.RZR);
            BuildModelPage.WaitForBuildModelPageToLoad();
            BuildModelPage.ClickTwoSeat();
            BuildModelPage.ClickRandomModel();
            BuildTrimPage.WaitForTrimPageToLoad();
            BuildTrimPage.ClickRandomTrim();
            BuildColorPage.WaitForColorPageToLoad();
            BuildColorPage.ClickColor();
            BuildColorPage.ClickNextButton();
            BuildConfigurePage.WaitForBuildPageToLoad();
            BuildConfigurePage.ClickRandomAccessoryAvoidPRP();
            BuildConfigurePage.ClickIamFinishedButton();
            BuildQuotePage.WaitForBuildQuotePgeToLoad();
            BuildQuotePage.FillQuoteFormDefaultData();
            BuildQuotePage.ClickGetInternetPriceButton();
            BuildConfirmationPage.WaitForBuildConfirmationPageToLoad();
            BuildConfirmationPage.VerifyNewBuildConfirmationAsExpected();
        }

        //[Test, Category(TestCategories.RZR), Category(TestCategories.STEPPED_PROCESS), RetryDynamic]
        public void VerifyRzrSteppedProcessFourSeat()
        {
            CPQNavigate.NavigateToModelsPage(Brand.RZR);
            BuildModelPage.WaitForBuildModelPageToLoad();
            BuildModelPage.ClickFourSeat();
            BuildModelPage.ClickRandomModel();
            BuildTrimPage.WaitForTrimPageToLoad();
            BuildTrimPage.ClickRandomTrim();
            BuildColorPage.WaitForColorPageToLoad();
            BuildColorPage.ClickColor();
            BuildColorPage.ClickNextButton();
            BuildConfigurePage.WaitForBuildPageToLoad();
            BuildConfigurePage.ClickRandomAccessoryAvoidPRP();
            BuildConfigurePage.ClickIamFinishedButton();
            BuildQuotePage.WaitForBuildQuotePgeToLoad();
            BuildQuotePage.FillQuoteFormDefaultData();
            BuildQuotePage.ClickGetInternetPriceButton();
            BuildConfirmationPage.WaitForBuildConfirmationPageToLoad();
            BuildConfirmationPage.VerifyNewBuildConfirmationAsExpected();
        }
    }
}
