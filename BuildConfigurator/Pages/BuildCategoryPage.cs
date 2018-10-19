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
    public class BuildCategoryPage : BasePage
    {
        private static By BY_MODELS_SECTION = By.XPath("//section[@class='wholegood-models']");
        private static By BY_MODEL = By.XPath("//section[@class='wholegood-models-section']//a");
        private static string A_TAG_NAME = "a";
        private static string LABEL_TAG_NAME = "label";

        public BuildCategoryPage(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public void ClickOnIndianCategory(string category)
        {
            List<IWebElement> categories = driver.FindElement(BY_MODELS_SECTION).FindElements(By.TagName(A_TAG_NAME)).ToList();
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

        public void waitForModelsDisplayed()
        {
            DriverActions.waitforStalenessOfelement(BY_MODEL);
        }
    }
}
