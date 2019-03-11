using AutomationFramework.ApiUtils.ApiDataProvider;
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
    public class SnowCheckNavigationTests : TestBase
    {
        private static string YEAR = "2020";
        private static string DEALER = "54321";

        ApiDataProvider ApiDataProvider { get { return new ApiDataProvider(); } }

        Random rnd = new Random();

        [Test, Category(TestCategories.SNOWCHECK)]
        public void VerifySnowCheckOptionsNavigation()
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
            Options.VerifyDefaultSubstepOptionSelected("Starter");
            Options.FooterModule.ClickFooterNextButton();
            Options.VerifyDefaultSubstepOptionSelected("Windshield");
            Options.FooterModule.ClickFooterNextButton();
            Options.VerifyDefaultSubstepOptionSelected("Handlebar");
            Options.FooterModule.ClickFooterNextButton();
            Options.VerifyDefaultSubstepOptionSelected("Shocks");
            Options.FooterModule.ClickFooterNextButton();
            Options.VerifyDefaultSubstepOptionSelected("Gauge");
            Options.FooterModule.ClickFooterNextButtonOpenSummary();
            Assert.IsTrue(Options.IsOptionsBuildSummaryDialogDisplayed(), "Options build summary dialog is not displayed");
        }

        [Test, Category(TestCategories.SNOWCHECK)]
        public void VerifyOptionsNavigationBack()
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
            Options.FooterModule.OpenBuildSummary();
            Options.ClickOptionHeadingByName("Shocks");
            Assert.IsTrue(Options.VerifyOptionPageTitleAsExpected("Shocks"), "Options page title was not as per selected option");
            Options.ClickOptionHeadingByName("Handlebar");
            Assert.IsTrue(Options.VerifyOptionPageTitleAsExpected("Handlebar"), "Options page title was not as per selected option");
            Options.ClickOptionHeadingByName("Windshield");
            Assert.IsTrue(Options.VerifyOptionPageTitleAsExpected("Windshield"), "Options page title was not as per selected option");
            Options.ClickOptionHeadingByName("Starter");
            Assert.IsTrue(Options.VerifyOptionPageTitleAsExpected("Starter"), "Options page title was not as per selected option");
        }

        [Test, Category(TestCategories.SNOWCHECK)]
        public void VerifyModelFamilyNavigatesToCategoryPage()
        {
            CPQNavigate.NavigateToCategoryPage(Brand.SNO);
            Category.ClickRandomWholegoodModelCard();
            Options.ClickOptionHeadingByName("Model Family");
            Assert.IsTrue(Category.VerifyTitleHeadingAsExpected("Category"), "Category page title is not as expected");

        }

        [Test, Category(TestCategories.SNOWCHECK)]
        public void VerifyNavigationCategoryToColorStep()
        {
            CPQNavigate.NavigateToCategoryPage(Brand.SNO);
            Category.ClickRandomWholegoodModelCard();
            Options.VerifyDefaultSubstepOptionSelected("Trim");
            Options.FooterModule.ClickFooterNextButton();
            Options.VerifyDefaultSubstepOptionSelected("Engine");
            Options.FooterModule.ClickFooterNextButton();
            Options.VerifyDefaultSubstepOptionSelected("Track");
            Options.FooterModule.ClickFooterNextButton();
            Assert.IsTrue(Colors.IsChooseColorTitleDisplayed(), "Choose Color title page is not displayed");
        }
    }
}
