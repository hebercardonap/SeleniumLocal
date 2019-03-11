using AutomationFramework.Utils;
using BuildConfigurator.Hooks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Tests.v3.SnowCheck
{
    [TestFixture]
    public class SnowCheckCTATests : TestBase
    {
        [Test, Category(TestCategories.SNOWCHECK)]
        public void VerifyStartingPriceOpensBuildSummary()
        {
            string snowCheckUrl = Options.GetNonStockSnowcheckColorPage();
            CPQNavigate.GoToUrl(snowCheckUrl);
            Colors.WaitForChooseColorTitleToDisplay();

            while (Colors.IsStockModelInfoDisplayed())
            {
                snowCheckUrl = Options.GetNonStockSnowcheckColorPage();
                CPQNavigate.GoToUrl(snowCheckUrl);
                Colors.WaitForChooseColorTitleToDisplay();
            }

            Colors.FooterModule.ClickFooterStartingPrice();
            Assert.IsFalse(Options.IsOptionsBuildSummaryDialogDisplayed(), "Options build summary dialog was not expected");
            Options.FooterModule.ClickFooterNextButton();
            Options.VerifyDefaultSubstepOptionSelected("Starter");
            ClickStartingPriceAndValidateBuildSummaryDialog();
            Options.FooterModule.ClickFooterNextButton();
            Options.VerifyDefaultSubstepOptionSelected("Windshield");
            ClickStartingPriceAndValidateBuildSummaryDialog();
            Options.FooterModule.ClickFooterNextButton();
            Options.VerifyDefaultSubstepOptionSelected("Handlebar");
            ClickStartingPriceAndValidateBuildSummaryDialog();
            Options.FooterModule.ClickFooterNextButton();
            Options.VerifyDefaultSubstepOptionSelected("Shocks");
            ClickStartingPriceAndValidateBuildSummaryDialog();
            Options.FooterModule.ClickFooterNextButton();
            Options.VerifyDefaultSubstepOptionSelected("Gauge");
            ClickStartingPriceAndValidateBuildSummaryDialog();
            Options.FooterModule.ClickFooterNextButtonOpenSummary();
            Options.FooterModule.ClickFooterStartingPrice();
            Assert.IsFalse(Options.IsOptionsBuildSummaryDialogDisplayed(), "Options build summary dialog was not expected");
        }

        private void ClickStartingPriceAndValidateBuildSummaryDialog()
        {
            Options.FooterModule.ClickFooterStartingPrice();
            Assert.IsTrue(Options.IsOptionsBuildSummaryDialogDisplayed(), "Options build summary dialog is not displayed");
            Options.FooterModule.OpenBuildSummary();
        }

        [Test, Category(TestCategories.SNOWCHECK)]
        public void VerifyAddAdditionalAccessoriesLink()
        {
            string snowCheckUrl = Options.GetNonStockSnowcheckColorPage();
            CPQNavigate.GoToUrl(snowCheckUrl);
            Colors.WaitForChooseColorTitleToDisplay();

            while (Colors.IsStockModelInfoDisplayed())
            {
                snowCheckUrl = Options.GetNonStockSnowcheckColorPage();
                CPQNavigate.GoToUrl(snowCheckUrl);
                Colors.WaitForChooseColorTitleToDisplay();
            }
            Colors.FooterModule.ClickFooterNextButton();
            Options.SelectRandomOptionsUntilAccessories();
            Options.ClickSummaryAddAdditionalAccessories();
            Assert.IsTrue(Accessories.IsChooseAccessoriesTitleDisplayed(), "Accessories page is not displayed");
        }
    }
}
