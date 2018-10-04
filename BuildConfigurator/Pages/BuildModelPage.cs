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
    public class BuildModelPage : BasePage
    {
        private static By BY_ONE_SEAT = By.XPath("//label[contains(@title, '1-Seat')]");
        private static By BY_TWO_SEAT = By.XPath("//label[contains(@title, '2-Seat')]");
        private static By BY_THREE_SEAT = By.XPath("//label[contains(@title, '3-Seat')]");
        private static By BY_FOUR_SEAT = By.XPath("//label[contains(@title, '4-Seat')]");
        private static By BY_SIX_SEAT = By.XPath("//label[contains(@title, '6-Seat')]");

        private static By BY_MODELS_SECTION = By.XPath("//section[@class='wholegood-models-section']");
        private static By BY_CHOOSE_MODEL_TITLE = By.XPath("//div[@class='cpq-title-nav-items']");
        private static By BY_SLG_VERSION = By.XPath("//div[@class='wholegood-container']//h4");
        private static By BY_SNO_VERSION = By.XPath("//div[@class='wholegood-container']//h4");
        private static By BY_WHOLEGOOD_CONTAINER = By.XPath("//div[@class='wholegood-container']");
        private static By BY_WHOLEGOOD_CARD = By.XPath(".//div[@class='wholegood-card']//div//h4");
        private static By BY_FAMILY_SLIDE = By.XPath("//div[@class='family family--slide']");
        private static string BY_FAMILY_SLIDE_CATEGORY = "//section//span[contains(text(), '{0}')]";



        private static string A_TAG_NAME = "a";
        private static string LABEL_TAG_NAME = "label";
        private static string GENERAL_COLOR_OPTION = "Deluxe";

        private static Random rnd = new Random();

        public void clickOneSeat()
        {
            driver.FindElement(BY_ONE_SEAT).Click();
        }

        public void clickTwoSeat()
        {
            driver.FindElement(BY_TWO_SEAT).Click();
        }

        public void clickThreeSeat()
        {
            driver.FindElement(BY_THREE_SEAT).Click();
        }

        public void clickFourSeat()
        {
            driver.FindElement(BY_FOUR_SEAT).Click();
        }

        public void clickSixSeat()
        {
            driver.FindElement(BY_SIX_SEAT).Click();
        }

        public void clickRandomModel()
        {
            List<IWebElement> models = driver.FindElement(BY_MODELS_SECTION)
                .FindElements(By.TagName(A_TAG_NAME)).ToList();
            int model = rnd.Next(0, models.Count);
            models[model].Click();
        }

        public void clickUniqueColorGeneralModel()
        {
            List<IWebElement> models = driver.FindElement(BY_MODELS_SECTION)
                .FindElements(By.TagName(A_TAG_NAME)).ToList();

            while (true)
            {
                int model = rnd.Next(0, models.Count);
                string modelName = models[model].FindElement(By.TagName(LABEL_TAG_NAME)).Text;

                if (!modelName.Contains(GENERAL_COLOR_OPTION))
                {
                    models[model].Click();
                    break;
                }
            }
        }

        public void clickRangerModelMultipleColorAvailable()
        {
            List<IWebElement> models = driver.FindElement(BY_MODELS_SECTION)
                .FindElements(By.TagName(A_TAG_NAME)).ToList();

            while (true)
            {
                int model = rnd.Next(0, models.Count);
                string modelName = models[model].FindElement(By.TagName(LABEL_TAG_NAME)).Text;

                if (modelName.Contains(GENERAL_COLOR_OPTION))
                {
                    models[model].Click();
                    break;
                }
            }
        }

        public void clickSlingshotByVersion(string slgVersion)
        {
            List<IWebElement> versions = driver.FindElements(BY_SLG_VERSION).ToList();
            foreach (var version in versions)
            {
                if (stringEqualsIgnoreCase(slgVersion.Replace(" ", string.Empty), version.Text.Split(' ').Last()))
                {
                    WebElementExtensions.clickElement(version);
                    break;
                }
            }
        }

        public void clickSnowByVersion(string snoVersion)
        {
            List<IWebElement> versions = driver.FindElements(BY_SNO_VERSION).ToList();
            foreach (var version in versions)
            {
                if (stringContainsIgnoreCase(version.Text, snoVersion))
                {
                    WebElementExtensions.clickElement(version);
                    break;
                }
            }
        }

        public void clickRandomWholeGoodCard()
        {
            List<IWebElement> cards = driver.FindElement(BY_WHOLEGOOD_CONTAINER)
                .FindElements(BY_WHOLEGOOD_CARD).ToList();

            int card = rnd.Next(0, cards.Count);
            WebElementExtensions.clickElement(cards[card]);

        }

        public void clickFamilyCategorySlide(string family)
        {
            string xpathString = string.Format(BY_FAMILY_SLIDE_CATEGORY, family);
            WebElementExtensions.clickElement(By.XPath(xpathString));
        }

    }
}
