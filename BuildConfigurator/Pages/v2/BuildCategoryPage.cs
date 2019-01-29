using AutomationFramework.Base;
using AutomationFramework.Extensions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Pages.v2
{
    public class BuildCategoryPage : BasePage
    {
        private static By BY_MODELS_SECTION = By.XPath("//section[@class='wholegood-models']");
        private static By BY_MODEL = By.XPath("//section[@class='wholegood-models-section']//a");
        private static By BY_CATEGORY_PAGE_TITLE = By.XPath("//section[@class='cpq-title-nav']");
        private static By BY_WHOLEGOOD_CARD_TITLE_LABEL = By.CssSelector("a[class='wholegood-models-card'] div[class='wholegood-models-card-inner'] label");
        private static By BY_WHOLEGOOD_CARDS = By.CssSelector("a[class='wholegood-models-card']");
        private static By BY_WHOLEGOOD_CARD_CHILD_LABEL = By.CssSelector("div[class='wholegood-models-card-inner'] label");
        private static string A_TAG_NAME = "a";
        private static string LABEL_TAG_NAME = "label";

        public BuildCategoryPage(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public void ClickOnIndianCategory(string category)
        {
            List<IWebElement> categories = Driver.FindElement(BY_MODELS_SECTION).FindElements(By.TagName(A_TAG_NAME)).ToList();
            foreach (var c in categories)
            {
                string currentCateogry = c.FindElement(By.TagName(LABEL_TAG_NAME)).Text;
                if (stringEqualsIgnoreCase(currentCateogry, category))
                {
                    c.Click();
                    break;
                }
            }

        }

        public void WaitForModelsDisplayed()
        {
            DriverActions.waitforStalenessOfelement(BY_MODEL);
        }

        public void WaitForCategoryPageToLoad()
        {
            DriverActions.waitForElementVisibleAndEnabled(BY_CATEGORY_PAGE_TITLE);
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

        public List<IWebElement> GetCategoryWholegoodCards()
        {
            List<IWebElement> wholegoodCards = Driver.FindElements(BY_WHOLEGOOD_CARDS).ToList();

            return wholegoodCards;
        }

        public string GetWholegoodcardLabelTitle(IWebElement element)
        {
            string label = element.FindElement(BY_WHOLEGOOD_CARD_CHILD_LABEL).Text;
            return label;
        }

        public void ClickCategoryWholegoodCard(IWebElement element)
        {
            string label = element.FindElement(BY_WHOLEGOOD_CARD_CHILD_LABEL).Text;
            DriverActions.clickElement(element);
        }
    }
}
