using AutomationFramework.Base;
using BuildConfigurator.Pages.v3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BuildConfigurator.Steps.v3
{
    [Binding]
    public class TrimsPageSteps : BasePage
    {
        public TrimsPageSteps(ParallelConfig parallelConfig) : base(parallelConfig)
        {
            _parallelConfig.CurrentPage = new TrimsPage(_parallelConfig);
        }

        [When(@"I select random trim new version")]
        public void WhenISelectTrimNewVersion()
        {
            _parallelConfig.CurrentPage.As<TrimsPage>().ClickRandomTrim();
        }

        [When(@"I wait until trims page loads")]
        public void WhenIWaitUntilTrimsPageLoads()
        {
            _parallelConfig.CurrentPage.As<TrimsPage>().WaitForTrimsPageToLoad();
        }


    }
}
