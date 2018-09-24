using AutomationFramework.Base;
using AutomationFramework.UrlBuilderSites;
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

        [Given(@"I have navigated to RZR build model page")]
        public void GivenIHaveNavigatedToRZRBuildModelPage()
        {
            DriverContext.Browser.GoToUrl(UrlBuilder.getRzrBuildModelUrl());
            //CurrentPage = GetInstance<BuildModelPage>();
        }


        [When(@"I select random model")]
        public void GivenISelectRandomModel()
        {
            CurrentPage.As<BuildModelPage>().clickRandomModel();
        }


    }
}
