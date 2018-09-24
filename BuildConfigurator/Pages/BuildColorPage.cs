using AutomationFramework.Base;
using AutomationFramework.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Pages
{
    public class BuildColorPage : BasePage
    {
        private static By BY_COLORS_SECTION = By.XPath("//ul[@class='wholegood-colors-items']");
        private static By BY_NEXT_BUTTON = By.XPath("//a[@class='btn-next']");
        private static By BY_FULL_SCREEN_BUTTON = By.XPath("//button[@id='build-variant__fullscreen']");

        private static string LI_TAG_NAME = "li";
        private static Random rnd = new Random();
        public void clickColor()
        {
            List<IWebElement> colors = driver.FindElement(BY_COLORS_SECTION).FindElements(By.TagName(LI_TAG_NAME)).ToList();
            int color = rnd.Next(0, colors.Count);
            colors[color].Click();
            WebDriverExtensions.WaitForPageLoaded(driver);
        }

        public void clickNextButton()
        {
            driver.FindElement(BY_NEXT_BUTTON).Click();
        }

        public void getToBuildPage()
        {
            WebDriverExtensions.waitForElementToBeEnabled(BY_FULL_SCREEN_BUTTON);
            Assert.IsTrue((driver.Url).Contains("build"));
        }
    }
}
