using AutomationFramework.Base;
using BuildConfigurator.Pages;
using TechTalk.SpecFlow;

namespace BuildConfigurator.Steps
{
    [Binding]
    class BuildModelSteps : BaseStep


    {

        public BuildModelSteps()
        {
            CurrentPage = GetInstance<BuildModelPage>();
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



    }
}
