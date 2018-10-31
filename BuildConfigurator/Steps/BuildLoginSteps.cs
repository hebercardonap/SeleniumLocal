using AutomationFramework.Base;
using AutomationFramework.DataProvider;
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
    public class BuildLoginSteps : BasePage
    {
        public BuildLoginSteps(ParallelConfig parallelConfig) : base(parallelConfig)
        {
            _parallelConfig.CurrentPage = new BuildLoginPage(_parallelConfig);
        }

        [When(@"I login")]
        public void WhenILogin()
        {
            _parallelConfig.CurrentPage.As<BuildLoginPage>().EnterEmailAndPasswordValue(UserAccountData.NON_EMPLOYEE_1);
            _parallelConfig.CurrentPage.As<BuildLoginPage>().ClickLoginCTA();
            _parallelConfig.CurrentPage = new BuildConfigurePage(_parallelConfig);
        }
    }
}
