using AutomationFramework.Base;
using BuildConfigurator.Pages;
using NUnit.Framework;
using System.Threading;
using TechTalk.SpecFlow;

namespace BuildConfigurator.Steps
{
    [Binding]
    class BuildColorSteps : BasePage
    {
        public BuildColorSteps(ParallelConfig parallelConfig) : base(parallelConfig)
        {
            _parallelConfig.CurrentPage = new BuildColorPage(_parallelConfig);
        }

        [When(@"I select random color")]
        public void GivenISelectRandomColor()
        {
            _parallelConfig.CurrentPage.As<BuildColorPage>().clickColor();
        }

        [When(@"Model (.*) is displayed build color header")]
        public void GivenModelIsDisplayedBuildColorHeader(string model)
        {
            Assert.IsTrue(_parallelConfig.CurrentPage.As<BuildColorPage>().HeaderModule.IsNavigationBarBrandNameDisplayed());
            Assert.IsTrue(stringContainsIgnoreCase(_parallelConfig.CurrentPage.As<BuildColorPage>().HeaderModule.GetHeaderBrandName(),
                model));
        }

        [When(@"I click close icon from build color header")]
        public void WhenIClickCloseIconFromBuildColorNavigationBar()
        {
            _parallelConfig.CurrentPage.As<BuildColorPage>().HeaderModule.ClickHeaderCloseIcon();
        }

        [When(@"I get to build color page")]
        public void GivenIGetToBuildColorPage()
        {
            _parallelConfig.CurrentPage.As<BuildColorPage>().HeaderModule.WaitForHeaderToBeDisplayed();
            _parallelConfig.CurrentPage.As<BuildColorPage>().HeaderModule.WaitForCloseIconToBeEnabled();
        }


    }
}
