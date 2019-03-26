using AutomationFramework.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Pages.v3
{
    public class ModalsDialogPage : BasePage
    {
        private static By BY_PURPOSE_PROMPT_MODAL = By.Id("purpose-prompt-modal-dialog");
        private static By BY_ICON_FOR_FUN = By.CssSelector("div[class='icon icon__forFun']");
        private static By BY_PURPOSE_PROMPT_BUILD_BUTTON = By.XPath("//div[@id='purpose-prompt-modal-dialog']//button[contains(@class,'btn-lg')]");
        public ModalsDialogPage(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public void WaitForModalToDisplay()
        {
            DriverActions.waitForElementToBeEnabled(BY_PURPOSE_PROMPT_MODAL);
        }

        public void HandlePurposePromptModal()
        {
            try
            {
                if (DriverActions.IsElementPresent(BY_PURPOSE_PROMPT_MODAL))
                {
                    DriverActions.clickElement(BY_ICON_FOR_FUN);
                    DriverActions.waitForAjaxRequestToComplete();
                    DriverActions.clickElement(BY_PURPOSE_PROMPT_BUILD_BUTTON);
                    DriverActions.waitForAjaxRequestToComplete();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
