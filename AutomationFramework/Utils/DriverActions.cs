﻿using AutomationFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
                Thread.Sleep(100);
            }
        }

        public void Hover(IWebElement element)
        {
            Actions actions = new Actions(Driver);
            actions.MoveToElement(element).Perform();
        }

        public bool IsElementPresent(By locator)
        {
            try
            {
                Driver.FindElement(locator);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void clickElement(By locator)
        {
            if (IsElementPresent(locator))
                Driver.FindElement(locator).Click();
        }



    }
}
