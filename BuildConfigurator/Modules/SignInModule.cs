using AutomationFramework.Base;
using AutomationFramework.DataProvider;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Modules
{
    public class SignInModule : BasePage
    {
        private static By BY_EMAIL_FIELD = By.CssSelector("input[type='email']");
        private static By BY_PASSWORD_FIELD = By.CssSelector("input[type='password']");
        private static By BY_LOG_IN_BUTTON = By.CssSelector("button[name='submit']");
        //TODO: Update selectors
        private static By BY_SIGN_IN_MODAL = By.XPath("");
        private static By BY_SIGN_IN_CANCEL_BUTTON = By.XPath("");


        public SignInModule(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

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
