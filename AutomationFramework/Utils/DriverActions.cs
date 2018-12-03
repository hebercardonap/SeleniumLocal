using AutomationFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace AutomationFramework.Utils
{
    public class DriverActions : BasePage
    {
        public DriverActions(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public void waitForElementToBeEnabled(By locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(50));
            wait.Until(ExpectedConditions.ElementToBeClickable(locator));
        }

        public void waitForElementPresent(By locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(40));
            wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        public void waitforStalenessOfelement(By locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(40));
            wait.Until(ExpectedConditions.StalenessOf(Driver.FindElement(locator)));
        }

        public void waitForAjaxRequestToComplete()
        {
            while (true)
            {
                var ajaxIsComplete = (bool)(Driver as IJavaScriptExecutor).ExecuteScript("return jQuery.active == 0");
                if (ajaxIsComplete)
                {
                    break;
                }
                Thread.Sleep(1000);
            }
        }

        public void waitForElementVisibleAndEnabled(By locator)
        {
            int counter = 10;
            IWebElement element;
            while (counter > 0)
            {
                try
                {
                    element = Driver.FindElement(locator);
                    if (element.Displayed && element.Enabled)
                    {
                        Thread.Sleep(3000);
                        break;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                Thread.Sleep(3000);
                counter--;
            }
        }

        public void Hover(IWebElement element)
        {
            Actions actions = new Actions(Driver);
            actions.MoveToElement(element).Perform();
        }

        public bool IsElementPresent(By locator)
        {
            bool isFOund = false;
            try
            {
                IWebElement element = Driver.FindElement(locator);
                if (element.Displayed && element.Enabled)
                {
                    isFOund = true;
                }
                return isFOund;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public bool IsElementPresent(IWebElement element)
        {
            bool isDisplayed = false;
            try
            {
                if (element.Displayed && element.Enabled)
                    isDisplayed = true;
            }
            catch (NoSuchElementException)
            {
                isDisplayed = false;
            }
            return isDisplayed;
        }


        public void clickElement(By locator)
        {
            if (IsElementPresent(locator))
                Driver.FindElement(locator).Click();
        }

        public void clickElement(IWebElement element)
        {
            if (IsElementPresent(element))
                element.Click();
        }

        public void ScrollToElement(IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", element);
            Thread.Sleep(500);
        }

        public void ScrollToElement(By locator)
        {
            IWebElement element = Driver.FindElement(locator);
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", element);
            Thread.Sleep(500);
        }

        public void WaitForCanvassToComplete()
        {
            Thread.Sleep(5000);   
        }

    }
}
