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
    class BuildColorSteps : BuildColorPage
    {
        BuildColorSteps()
        {
            CurrentPage = GetInstance<BuildColorPage>();
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
