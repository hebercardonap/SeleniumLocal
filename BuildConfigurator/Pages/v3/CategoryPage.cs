using AutomationFramework.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Pages.v3
{
    public class CategoryPage : BasePage
    {
        private static By BY_WHOLEGOOD_MODEL_CARDS = By.CssSelector("a[class='wholegood-models-card']");
        private static By BY_TITLE_HEADING = By.CssSelector("div[class~='title-heading']");

        private static Random rnd = new Random();
        public CategoryPage(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public void ClickRandomWholegoodModelCard()
        {
            List<IWebElement> wholegoodCards = Driver.FindElements(BY_WHOLEGOOD_MODEL_CARDS).ToList();
            DriverActions.clickElement(wholegoodCards[rnd.Next(0, wholegoodCards.Count)]);
        }

        public string GetCategoryPageTitleHeading()
        {
            return Driver.FindElement(BY_TITLE_HEADING).Text;
        }
    }
}
