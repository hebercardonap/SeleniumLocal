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
    public class ColorsPageSteps : BasePage
    {
        public ColorsPageSteps(ParallelConfig parallelConfig) : base(parallelConfig)
        {
            _parallelConfig.CurrentPage = new ColorsPage(_parallelConfig);
        }

        [When(@"I select random color new version")]
        public void WhenISelectRandomColorNewVersion()
        {
            _parallelConfig.CurrentPage.As<ColorsPage>().ClickRandomWholegoodColor();
        }

        [When(@"I click next button from color page")]
        public void WhenIClickNextButtonFromColorPage()
        {
            _parallelConfig.CurrentPage.As<ColorsPage>().FooterModule.ClickFooterNextButton();
        }

        [When(@"I wait until colors page loads")]
        public void WhenIWaitUntilColorsPageLoads()
        {
            _parallelConfig.CurrentPage.As<ColorsPage>().WaitForColorsPageToLoad();
        }

    }
}
