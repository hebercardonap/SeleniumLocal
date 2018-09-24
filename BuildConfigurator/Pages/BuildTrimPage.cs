using AutomationFramework.Base;
using AutomationFramework.Extensions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Pages
{
    public class BuildTrimPage : BasePage
    {

        private static By BY_TRIM_SECTION = By.XPath("//section[@class='trim-models']");
        private static string A_TAG_NAME = "a";
        private static Random rnd = new Random();

        public void clickRandomTrim()
        {
            List<IWebElement> trims = driver.FindElement(BY_TRIM_SECTION).FindElements(By.TagName(A_TAG_NAME)).ToList();
            int trim = rnd.Next(0, trims.Count);
            trims[trim].Click();
        }
    }
}
