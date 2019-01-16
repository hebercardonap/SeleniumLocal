using AutomationFramework.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework.DataProvider;

namespace BuildConfigurator.Pages.v2
{
    public class BuildLoginPage : BasePage
    {
        public BuildLoginPage(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        private static By BY_EMAIL_FIELD = By.CssSelector("input[type='email']");
        private static By BY_PASSWORD_FIELD = By.CssSelector("input[type='password']");
        private static By BY_LOG_IN_BUTTON = By.CssSelector("button[name='submit']");


        public void EnterEmailAndPasswordValue(UserAccountData user)
        {
            Driver.FindElement(BY_EMAIL_FIELD).SendKeys(user.UserName);
            Driver.FindElement(BY_PASSWORD_FIELD).SendKeys(user.Password);
        }

        public void ClickLoginCTA()
        {
            DriverActions.clickElement(BY_LOG_IN_BUTTON);
        }

    }
}
