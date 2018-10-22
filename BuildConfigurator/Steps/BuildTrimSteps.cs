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
        public BuildTrimSteps(ParallelConfig parallelConfig) : base(parallelConfig)
        {
            CurrentPage = new BuildTrimPage(_parallelConfig);
        }

        [When(@"I select trim")]
        public void GivenISelectTrim()
        {
            CurrentPage.As<BuildTrimPage>().clickRandomTrim();
        }

        [When(@"I select ranger non package trim")]
        public void WhenISelectRangerNonPackageTrim()
        {
            CurrentPage.As<BuildTrimPage>().clickRangerNonPackageTrim();
        }

        [When(@"I select General trim color pick")]
        public void WhenISelectGeneralTrimColorPick()
        {
            CurrentPage.As<BuildTrimPage>().clickRangerModelWithColorOption();
        }

        [When(@"I select trim old version")]
        public void WhenISelectTrimOldVersion()
        {
            CurrentPage.As<BuildTrimPage>().clickRandomTrimOldVersion();
        }


    }
}
