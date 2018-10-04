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
        private static By BY_TRIM_SECTION_OLD = By.XPath("//div[@class='trim-container']");
        private static string A_TAG_NAME = "a";
        private static string LABEL_TAG_NAME = "label";
        private static string GENERAL_COLOR_OPTION = "Deluxe";
        private static Random rnd = new Random();
        private static string[] RANGER_PACKAGE_TRIM = new[] { "1000 EPS Premium", "1000 EPS NorthStar Edition" };

        public void clickRandomTrim()
        {
            List<IWebElement> trims = driver.FindElement(BY_TRIM_SECTION).FindElements(By.TagName(A_TAG_NAME)).ToList();
            int trim = rnd.Next(0, trims.Count);
            trims[trim].Click();
        }

        public void clickRandomTrimOldVersion()
        {
            List<IWebElement> trims = driver.FindElement(BY_TRIM_SECTION_OLD).FindElements(By.TagName(A_TAG_NAME)).ToList();
            int trim = rnd.Next(0, trims.Count);
            trims[trim].Click();
        }

        public void clickRangerNonPackageTrim()
        {
            List<IWebElement> trims = driver.FindElement(BY_TRIM_SECTION).FindElements(By.TagName(A_TAG_NAME)).ToList();
            while (true)
            {
                bool isFound = false;
                int trim = rnd.Next(0, trims.Count);
                string modelName = trims[trim].FindElement(By.TagName(LABEL_TAG_NAME)).Text;
                foreach (var ranger in RANGER_PACKAGE_TRIM)
                {
                    if (modelName.Contains(ranger))
                    {
                        isFound = true;
                        break;
                    }
                }
                if (!isFound)
                {
                    trims[trim].Click();
                    break;
                }
            }
        }

        public void clickRangerModelWithColorOption()
        {
            List<IWebElement> models = driver.FindElement(BY_TRIM_SECTION).FindElements(By.TagName(A_TAG_NAME)).ToList();

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
    }
}
