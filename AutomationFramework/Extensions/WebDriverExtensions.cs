using AutomationFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Diagnostics;
using System.Threading;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace AutomationFramework.Extensions
{
    public static class WebDriverExtensions
    {
        
        public static void WaitForPageLoaded(this IWebDriver driver)
        {
            driver.WaitForCondition(dri =>
            {
                string state = dri.ExecuteJs("return document.readyState").ToString();
                return state == "complete";
            }, 10);
        }

        public static void waitForElementToBeEnabled(By locator)
        {
            WebDriverWait wait = new WebDriverWait(DriverContext.Driver, TimeSpan.FromSeconds(50));
            wait.Until(ExpectedConditions.ElementToBeClickable(locator));
        }

        public static void waitForElementPresent(By locator)
        {
            WebDriverWait wait = new WebDriverWait(DriverContext.Driver, TimeSpan.FromSeconds(40));
            wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        public static void waitforStalenessOfelement(By locator)
        {
            WebDriverWait wait = new WebDriverWait(DriverContext.Driver, TimeSpan.FromSeconds(40));
            wait.Until(ExpectedConditions.StalenessOf(DriverContext.Driver.FindElement(locator)));
        }

        public static void WaitForCondition<T>(this T obj, Func<T, bool> condition, int timeOut)
        {
            Func<T, bool> execute =
                (arg) =>
                {
                    try
                    {
                        return condition(arg);
                    }
                    catch (Exception e)
                    {
                        return false;
                    }
                };

            var stopWatch = Stopwatch.StartNew();
            while (stopWatch.ElapsedMilliseconds < timeOut)
            {
                if (execute(obj))
                {
                    break;
                }
            }
        }

        public static void waitForAjaxRequestToComplete()
        {
            while (true)
            {
                var ajaxIsComplete = (bool)(DriverContext.Driver as IJavaScriptExecutor).ExecuteScript("return jQuery.active == 0");
                if (ajaxIsComplete)
                {
                    break;
                }
                Thread.Sleep(100);
            }
        }


        public static object ExecuteJs(this IWebDriver driver, string script)
        {
            return ((IJavaScriptExecutor)DriverContext.Driver).ExecuteScript(script);
        }
    }
}
