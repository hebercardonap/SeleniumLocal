using AutomationFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
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
            //driver.WaitForCondition(dri =>
            //{
            //    string state = dri.ExecuteJs("return document.readyState").ToString();
            //    return state == "complete";
            //}, 10);
            var timer = new Stopwatch();
            var elementLoadWaitTime = TimeSpan.FromSeconds(30);
            timer.Start();
            while (timer.Elapsed < elementLoadWaitTime)
            {
                var wait = new WebDriverWait(driver, elementLoadWaitTime);
                try
                {
                    wait.Until(x => x.IsDocumentDone() && x.IsAjaxDone() && x.IsAngularDone());
                    break;
                }
                catch (InvalidOperationException)
                {

                }
            }
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

        public static object ExecuteJs(this IWebDriver driver, string script)
        {
            return ((IJavaScriptExecutor)driver).ExecuteScript(script);
        }

        private static bool IsAngularDone(this IWebDriver webDriver)
        {
            try
            {
                var script = @"if(window.angular === undefined) return true;
                           if(!angular.element($('.ng-scope')).injector()) angular.reloadWithDebugInfo(); 
                           return angular.element($('.ng-scope')).injector().get('$http').pendingRequests.length == 0;";
                return webDriver.ExecuteJavaScript<bool>(script);
            }
            catch
            {
                var script = @"return (window.angular !== undefined) && (angular.element(document).injector() !== undefined) && (angular.element(document).injector().get('$http').pendingRequests.length === 0)";
                return webDriver.ExecuteJavaScript<bool>(script);
            }
        }

        private static bool IsAjaxDone(this IWebDriver webDriver)
        {
            var script = "return window.jQuery === undefined || jQuery.active == 0";
            var isAjaxDone = webDriver.ExecuteJavaScript<bool>(script);
            return isAjaxDone;
        }

        private static bool IsDocumentDone(this IWebDriver webDriver)
        {
            var script = "return document.readyState == 'complete'";
            var isAjaxDone = webDriver.ExecuteJavaScript<bool>(script);
            return isAjaxDone;
        }
    }
}
