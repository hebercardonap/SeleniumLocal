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
    class BuildTrimSteps : BasePage
    {
        public BuildTrimSteps()
        {
            CurrentPage = GetInstance<BuildTrimPage>();
        }

        [When(@"I select trim")]
        public void GivenISelectTrim()
        {
            //CurrentPage = GetInstance<BuildTrimPage>();
            CurrentPage.As<BuildTrimPage>().clickRandomTrim();
        }

    }
}
