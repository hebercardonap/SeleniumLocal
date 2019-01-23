using AutomationFramework.Base;
using AutomationFramework.Extensions;
using BuildConfigurator.Modules;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Pages.v2
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
        private static By BY_FAMILY_CATEGORIES = By.XPath("//div[contains(@class, 'family')]//span");
        private static By BY_BUILD_MODEL_HEADER = By.XPath("//div[@class='title']");
        private static By BY_WHOLEGOOD_CARD_TITLE_LABEL = By.CssSelector("a[class='wholegood-models-card'] div[class='wholegood-models-card-inner'] label");
        private static By BY_SELECT_SEATS_DROPDOWN = By.XPath("//button[@class='cpq-title-nav-items-select']");
        private static By BY_WHOLEGOOD_MODELS_CARDS = By.CssSelector("a[class='wholegood-models-card']");
        private static By BY_DROPDOWN_SEAT_OPTIONS = By.CssSelector("div[class='cpq-title-nav-items-item'] div[class='cpq-title-nav-items-item-inner']");



        private static string A_TAG_NAME = "a";
        private static string LABEL_TAG_NAME = "label";
        private static string GENERAL_COLOR_OPTION = "Deluxe";
        private static string TEXT_ATTRIBUTE = "Text";

        private static Random rnd = new Random();

        public HeaderModule HeaderModule { get { return new HeaderModule(_parallelConfig); } }

        public CalculatorModule CalculatorModule { get { return new CalculatorModule(_parallelConfig); } }

        public FooterModule FooterModule { get { return new FooterModule(_parallelConfig); } }

        public BuildModelPage(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public void ClickOneSeat()
        {
            Driver.FindElement(BY_ONE_SEAT).Click();
        }

        public void ClickTwoSeat()
        {
            Driver.FindElement(BY_TWO_SEAT).Click();
        }

        public void ClickThreeSeat()
        {
            Driver.FindElement(BY_THREE_SEAT).Click();
        }

        public void ClickFourSeat()
        {
            Driver.FindElement(BY_FOUR_SEAT).Click();
        }

        public void ClickSixSeat()
        {
            Driver.FindElement(BY_SIX_SEAT).Click();
        }

        public void ClickRandomModel()
        {
            List<IWebElement> models = Driver.FindElement(BY_MODELS_SECTION)
                .FindElements(By.TagName(A_TAG_NAME)).ToList();
            int model = rnd.Next(0, models.Count);
            models[model].Click();
        }

        public void ClickUniqueColorGeneralModel()
        {
            List<IWebElement> models = Driver.FindElement(BY_MODELS_SECTION)
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

        public void ClickRangerModelMultipleColorAvailable()
        {
            List<IWebElement> models = Driver.FindElement(BY_MODELS_SECTION)
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

        public void ClickSlingshotByVersion(string slgVersion)
        {
            List<IWebElement> versions = Driver.FindElements(BY_SLG_VERSION).ToList();
            foreach (var version in versions)
            {
                if (stringEqualsIgnoreCase(slgVersion.Replace(" ", string.Empty), version.Text.Split(' ').Last()))
                {
                    WebElementExtensions.clickElement(version);
                    break;
                }
            }
        }

        public void ClickByFamilyVersion(string snoVersion)
        {
            List<IWebElement> versions = Driver.FindElements(BY_SNO_VERSION).ToList();
            foreach (var version in versions)
            {
                if (stringContainsIgnoreCase(version.Text, snoVersion))
                {
                    WebElementExtensions.clickElement(version);
                    break;
                }
            }
        }

        public void ClickRandomWholeGoodCard()
        {
            List<IWebElement> cards = Driver.FindElement(BY_WHOLEGOOD_CONTAINER)
                .FindElements(BY_WHOLEGOOD_CARD).ToList();

            int card = rnd.Next(0, cards.Count);
            WebElementExtensions.clickElement(cards[card]);

        }

        public void ClickFamilyCategorySlide(string family)
        {
            List<IWebElement> familyCategories = Driver.FindElements(BY_FAMILY_CATEGORIES).ToList();
            foreach (var fam in familyCategories)
            {
                string familyName = fam.Text;
                if (stringEqualsIgnoreCase(family, familyName) || stringContainsIgnoreCase(familyName, family))
                {
                    WebElementExtensions.clickElement(fam);
                    break;
                }
            }

        }

        public bool IsBuildModelHeaderDisplayed()
        {
            return DriverActions.IsElementPresent(BY_BUILD_MODEL_HEADER);
        }

        public void WaitForBuildModelPageToLoad()
        {
            DriverActions.waitForElementPresent(BY_BUILD_MODEL_HEADER);
        }

        public List<string> GetWholegoodCardTitleLabels()
        {
            List<string> cardlabels = new List<string>();
            List<IWebElement> wholegoodCardsLabels = Driver.FindElements(BY_WHOLEGOOD_CARD_TITLE_LABEL).ToList();

            foreach (var item in wholegoodCardsLabels)
            {
                cardlabels.Add(item.Text);
            }

            return cardlabels;
        }

        public void ClickSelectSeatsDropdown()
        {
            DriverActions.clickElement(BY_SELECT_SEATS_DROPDOWN);
        }

        public List<IWebElement> GetWholegoodsModelsCards()
        {
            List<IWebElement> wholegoodModelsCards = Driver.FindElements(BY_WHOLEGOOD_MODELS_CARDS).ToList();
            return wholegoodModelsCards;
        }

        public void SelectRandomSeatOption()
        {
            List<IWebElement> seatOptions = Driver.FindElements(BY_DROPDOWN_SEAT_OPTIONS).ToList();
            DriverActions.clickElement(seatOptions[rnd.Next(0, seatOptions.Count)]);
        }

    }
}
