using AutomationFramework.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Pages.v2
{
    public class BuildInfoModalPage : BasePage
    {
        public BuildInfoModalPage(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        private static By BY_INFO_MODAL_CONTENT = By.CssSelector("div[class='modal__content']");
        private static By BY_INFO_MODAL_ADD_BUTTON = By.XPath("//div[@class='modal__content']//button[contains(@class,'add')]");
        private static By BY_INFO_MODAL_REMOVE_BUTTON = By.XPath("//div[@class='modal__content']//button[contains(@class,'remove')]");
        private static By BY_INFO_MODAL_CLOSE_BUTTON = By.XPath("//div[@class='modal__header']//button[contains(@class,'modal__close')]//span");

        public void WaitForInfoModalContentToBeDisplayed()
        {
            DriverActions.waitForElementPresent(BY_INFO_MODAL_CONTENT);
        }

        public void ClickInfoModalAddAccessoryButton()
        {
            DriverActions.clickElement(BY_INFO_MODAL_ADD_BUTTON);
        }

        public void ClickInfoModalRemoveAccessoryButton()
        {
            DriverActions.clickElement(BY_INFO_MODAL_REMOVE_BUTTON);
        }

        public void ClickInfoModalCloseButton()
        {
            DriverActions.clickElement(BY_INFO_MODAL_CLOSE_BUTTON);
        }




    }
}
