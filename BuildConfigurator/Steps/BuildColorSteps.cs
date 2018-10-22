using AutomationFramework.Base;
using BuildConfigurator.Pages;
using TechTalk.SpecFlow;

namespace BuildConfigurator.Steps
{
    [Binding]
    class BuildColorSteps : BasePage
    {
        public BuildColorSteps(ParallelConfig parallelConfig) : base(parallelConfig)
        {
            CurrentPage = new BuildColorPage(_parallelConfig);
        }

        [When(@"I select random color")]
        public void GivenISelectRandomColor()
        {
            CurrentPage.As<BuildColorPage>().clickColor();
        }


        [When(@"I get to build page")]
        public void ThenIGetToBuildPage()
        {
            CurrentPage.As<BuildColorPage>().getToBuildPage();
        }


    }
}
