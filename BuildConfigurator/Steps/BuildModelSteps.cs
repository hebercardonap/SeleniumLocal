using AutomationFramework.Base;
using AutomationFramework.Extensions;
using AutomationFramework.UrlBuilderSites;
using BuildConfigurator.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace BuildConfigurator.Steps
{
    [Binding]
    class BuildModelSteps : BasePage


    {

        public BuildModelSteps(ParallelConfig parallelConfig) : base(parallelConfig)
        {
            _parallelConfig.CurrentPage = new BuildModelPage(_parallelConfig);
        }

        [When(@"I select random model")]
        public void GivenISelectRandomModel()
        {
            _parallelConfig.CurrentPage.As<BuildModelPage>().clickRandomModel();
        }

        [When(@"I select unique color General model")]
        public void WhenISelectUniqueColorGeneralModel()
        {
            _parallelConfig.CurrentPage.As<BuildModelPage>().clickUniqueColorGeneralModel();
        }

        [When(@"I select General model color pick")]
        public void WhenISelectGeneralModelColorPick()
        {
            _parallelConfig.CurrentPage.As<BuildModelPage>().clickRangerModelMultipleColorAvailable();
        }

        [When(@"I select slingshot (.*)")]
        public void WhenISelectSlingshot(string slgVersion)
        {
            _parallelConfig.CurrentPage.As<BuildModelPage>().clickSlingshotByVersion(slgVersion);
        }

        [When(@"I select random available version")]
        public void WhenISelectRandomAvailableVersion()
        {
            _parallelConfig.CurrentPage.As<BuildModelPage>().clickRandomWholeGoodCard();
        }

        [When(@"I filter by (.*) family")]
        public void WhenIFilterByFamily(string family)
        {
            _parallelConfig.CurrentPage.As<BuildModelPage>().clickFamilyCategorySlide(family);
        }

        [When(@"I select family (.*)")]
        public void WhenISelectVersion(string version)
        {
            _parallelConfig.CurrentPage.As<BuildModelPage>().clickByFamilyVersion(version);
        }

        [Then(@"Choose model header is displayed")]
        public void ThenChooseModelHeaderIsDisplayed()
        {
            Assert.IsTrue(_parallelConfig.CurrentPage.As<BuildModelPage>().IsBuildModelHeaderDisplayed());
        }

        [When(@"I get to build model page")]
        public void GivenIGetToBuildModelPage()
        {
            _parallelConfig.CurrentPage.As<BuildModelPage>().WaitForBuildModelPageToLoad();
        }

        [When(@"(.*) brand name is displayed build model header")]
        public void GivenRangerBrandNameIsDisplayed(string brand)
        {
            Assert.IsTrue(_parallelConfig.CurrentPage.As<BuildModelPage>().HeaderModule.IsNavigationBarBrandNameDisplayed());
            Assert.IsTrue(stringContainsIgnoreCase(_parallelConfig.CurrentPage.As<BuildModelPage>().HeaderModule.GetHeaderBrandName(), 
                brand));
        }

        [When(@"Starting price is displayed on build model footer")]
        public void WhenStartingPriceIsDisplayedOnBuildModelFooter()
        {
            Assert.IsTrue(_parallelConfig.CurrentPage.As<BuildModelPage>().FooterModule.IsStartingPriceDisplayed());
        }

        [When(@"Payment calculator is displayed on build model footer")]
        public void WhenPaymentCalculatorIsDisplayedOnBuildModelFooter()
        {
            Assert.IsTrue(_parallelConfig.CurrentPage.As<BuildModelPage>().FooterModule.IsPaymentCalculatorDisplayed());
        }

        [When(@"Next button is not displayed on build model footer")]
        public void WhenNextButtonIsNotDisplayedOnBuildModelFooter()
        {
            Assert.IsFalse(_parallelConfig.CurrentPage.As<BuildModelPage>().FooterModule.IsNextButtonDisplayed());
        }

        [When(@"Build summary toggle is not displayed on build model footer")]
        public void WhenBuildSummaryToggleIsNotDisplayedOnBuildModelFooter()
        {
            Assert.IsFalse(_parallelConfig.CurrentPage.As<BuildModelPage>().FooterModule.IsBuildSummaryToggleDisplayed());
        }

        [Then(@"Calculator modal is displayed")]
        public void ThenCalculatorModalIsDisplayed()
        {
            Assert.IsTrue(_parallelConfig.CurrentPage.As<BuildModelPage>().CalculatorModule.IsPaymentCalculatorDisplayed());
        }

        [When(@"I click calculator icon build model footer")]
        public void WhenIClickCalculatorIconBuildModelFooter()
        {
            _parallelConfig.CurrentPage.As<BuildModelPage>().FooterModule.ClickFooterPaymentCalculator();
        }


    }
}
