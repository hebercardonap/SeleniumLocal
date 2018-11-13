using AutomationFramework.Base;
using AutomationFramework.Extensions;
using BuildConfigurator.Modules;
using NUnit.Framework;
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
        //private static By BY_FULL_SCREEN_BUTTON = By.XPath("//button[@id='build-variant__fullscreen']");
        private static By BY_FULL_SCREEN_BUTTON = By.Id("build-variant__fullscreen");
        private static By BY_FLICKITY_SLIDER_BUTTON = By.CssSelector("div[class='flickity-slider']>button");

        private static string LI_TAG_NAME = "li";
        private static Random rnd = new Random();

        public HeaderModule HeaderModule { get { return new HeaderModule(_parallelConfig); } }

        public FooterModule FooterModule { get { return new FooterModule(_parallelConfig); } }
        public BuildColorPage(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public void clickColor()
        {
            List<IWebElement> colors = Driver.FindElement(BY_COLORS_SECTION).FindElements(By.TagName(LI_TAG_NAME)).ToList();
            int color = rnd.Next(0, colors.Count);
            colors[color].Click();
            WebDriverExtensions.WaitForPageLoaded(Driver);
        }

        public void clickNextButton()
        {
            Driver.FindElement(BY_NEXT_BUTTON).Click();
        }

        public void getToBuildPage()
        {
            DriverActions.waitForElementToBeEnabled(BY_FULL_SCREEN_BUTTON);
            DriverActions.waitForElementToBeEnabled(BY_FLICKITY_SLIDER_BUTTON);
            DriverActions.waitForAjaxRequestToComplete();
            WebDriverExtensions.WaitForPageLoaded(Driver);
            Assert.IsTrue((Driver.Url).Contains("build"));
        }
    }
}
