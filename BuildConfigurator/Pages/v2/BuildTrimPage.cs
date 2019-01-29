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
    public class BuildTrimPage : BasePage
    {

        private static By BY_TRIM_SECTION = By.XPath("//section[@class='trim-models']");
        private static By BY_TRIM_SECTION_OLD = By.XPath("//div[@class='trim-container']");
        private static string A_TAG_NAME = "a";
        private static string LABEL_TAG_NAME = "label";
        private static string GENERAL_COLOR_OPTION = "Deluxe";
        private static Random rnd = new Random();
        private static string[] RANGER_PACKAGE_TRIM = new[] { "1000 EPS Premium", "1000 EPS NorthStar Edition" };
        private static By BY_TRIM_PAGE_TITLE = By.XPath("//section[@class='cpq-title-nav']");
        private static By BY_TRIMS_CARDS_TITLE_LABELS = By.CssSelector("a[class='trim-models-card'] div[class='trim-models-card-inner'] label");
        private static By BY_SEE_SPECS_LINKS = By.CssSelector("div[class~='trim-models-card-fullSpec']");
        private static By BY_SEE_SPECS_MODAL = By.CssSelector("div[class='modal__body'] div[class~='heading']");

        public HeaderModule HeaderModule { get { return new HeaderModule(_parallelConfig); } }

        public BuildTrimPage(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public void ClickRandomTrim()
        {
            List<IWebElement> trims = Driver.FindElement(BY_TRIM_SECTION).FindElements(By.TagName(A_TAG_NAME)).ToList();
            int trim = rnd.Next(0, trims.Count);
            trims[trim].Click();
        }

        public void ClickRandomTrimOldVersion()
        {
            List<IWebElement> trims = Driver.FindElement(BY_TRIM_SECTION_OLD).FindElements(By.TagName(A_TAG_NAME)).ToList();
            int trim = rnd.Next(0, trims.Count);
            trims[trim].Click();
        }

        public void ClickRangerNonPackageTrim()
        {
            List<IWebElement> trims = Driver.FindElement(BY_TRIM_SECTION).FindElements(By.TagName(A_TAG_NAME)).ToList();
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

        public void ClickRangerModelWithColorOption()
        {
            List<IWebElement> models = Driver.FindElement(BY_TRIM_SECTION).FindElements(By.TagName(A_TAG_NAME)).ToList();

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

        public void WaitForTrimPageToLoad()
        {
            DriverActions.waitForElementVisibleAndEnabled(BY_TRIM_PAGE_TITLE);
        }

        public List<string> GetTrimsCardTitleLabels()
        {
            List<string> trimsTitleLabels = new List<string>();
            List<IWebElement> trimCards = Driver.FindElements(BY_TRIMS_CARDS_TITLE_LABELS).ToList();

            foreach (var trim in trimCards)
            {
                trimsTitleLabels.Add(trim.Text);
            }
            return trimsTitleLabels;
        }

        public void ClickRandomSeeSpecsLink()
        {
            List<IWebElement> specsLinks = Driver.FindElements(BY_SEE_SPECS_LINKS).ToList();
            DriverActions.clickElement(specsLinks[rnd.Next(0, specsLinks.Count)]);
        }

        public bool IsSeeSpecsModalDisplayed()
        {
            return DriverActions.IsElementPresent(BY_SEE_SPECS_MODAL);
        }
    }
}
