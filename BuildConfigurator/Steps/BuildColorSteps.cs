using AutomationFramework.Base;
using BuildConfigurator.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


        [When(@"I get to build page")]
        public void ThenIGetToBuildPage()
        {
            _parallelConfig.CurrentPage.As<BuildColorPage>().getToBuildPage();
        }


    }
}
