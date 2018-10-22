using AutomationFramework.Base;
using AutomationFramework.Extensions;
using AutomationFramework.UrlBuilderSites;
using BuildConfigurator.Pages;
using TechTalk.SpecFlow;

namespace BuildConfigurator.Steps
{
    [Binding]
    class BuildModelSteps : BasePage


    {

        public BuildModelSteps(ParallelConfig parallelConfig) : base(parallelConfig)
        {
            CurrentPage = new BuildModelPage(_parallelConfig);
        }

        [When(@"I select random model")]
        public void GivenISelectRandomModel()
        {
            CurrentPage.As<BuildModelPage>().clickRandomModel();
        }

        [When(@"I select unique color General model")]
        public void WhenISelectUniqueColorGeneralModel()
        {
            CurrentPage.As<BuildModelPage>().clickUniqueColorGeneralModel();
        }

        [When(@"I select General model color pick")]
        public void WhenISelectGeneralModelColorPick()
        {
            CurrentPage.As<BuildModelPage>().clickRangerModelMultipleColorAvailable();
        }

        [When(@"I select slingshot (.*)")]
        public void WhenISelectSlingshot(string slgVersion)
        {
            CurrentPage.As<BuildModelPage>().clickSlingshotByVersion(slgVersion);
        }

        [When(@"I select random available version")]
        public void WhenISelectRandomAvailableVersion()
        {
            CurrentPage.As<BuildModelPage>().clickRandomWholeGoodCard();
        }

        [When(@"I filter by (.*) family")]
        public void WhenIFilterByFamily(string family)
        {
            CurrentPage.As<BuildModelPage>().clickFamilyCategorySlide(family);
        }

        [When(@"I select family (.*)")]
        public void WhenISelectVersion(string version)
        {
            CurrentPage.As<BuildModelPage>().clickByFamilyVersion(version);
        }

    }
}
