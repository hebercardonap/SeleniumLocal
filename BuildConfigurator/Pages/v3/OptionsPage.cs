using AutomationFramework.Base;
using AutomationFramework.Utils;
using BuildConfigurator.Modules;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Pages.v3
{
    public class OptionsPage : BasePage
    {
        private static By BY_SUBSTEP_INPUT = By.XPath("//section[@class='substep-options-title']//section[@class='substep-options-title-items-input']");
        private static By BY_OPTIONS_TITLE_HEADING = By.CssSelector("section[class='substep-options-title'] button[class='substep-options-title-heading']");
        private static By BY_SUBSTEP_OPTIONS = By.CssSelector("section[class='substep-options-title']");
        private static By BY_OPTION_HEADING = By.CssSelector("button[class='substep-options-title-heading'] span:nth-child(1)");
        private static By BY_SUBSTEP_OPTIONS_LIST = By.XPath("//section[@class='substep-options-title']//li");
        private static By BY_SUBSTEP_RADIO_BUTTON = By.CssSelector("input[class='radio']");
        private static By BY_OPTIONS_BUILD_SUMMARY_DIALOG = By.Id("build-summary-dialog");
        private static By BY_OPTION_PAGE_TITLE = PolarisSeleniumAttribute.PolarisSeleniumSelector("chooseOptionTitle");
        private static By BY_SUMMARY_ADD_ADDITIONAL_ACCESSORIES = By.CssSelector("div[class~='summary-accessory-add-additional'] a");

        private static By SPAN_TAG_NAME = By.TagName("span");

        public OptionsPage(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public HeaderModule HeaderModule { get { return new HeaderModule(_parallelConfig); } }

        public CalculatorModule CalculatorModule { get { return new CalculatorModule(_parallelConfig); } }

        public FooterModule FooterModule { get { return new FooterModule(_parallelConfig); } }

        public NavigationBarModule NavigationBarModule { get { return new NavigationBarModule(_parallelConfig); } }

        public Toolbar Toolbar { get { return new Toolbar(_parallelConfig); } }

        private static Random rnd = new Random();

        public bool IsSubstepInputDisplayed()
        {
            return DriverActions.IsElementPresent(BY_SUBSTEP_INPUT);
        }

        public void ClickRandomSubstepInput()
        {
            List<IWebElement> substeps = Driver.FindElements(BY_SUBSTEP_INPUT).ToList();
            List<IWebElement> enabledSubsteps = new List<IWebElement>();
            foreach (var item in substeps)
            {
                if (DriverActions.IsElementPresent(item))
                {
                    enabledSubsteps.Add(item);
                }
            }

            int randomInput = rnd.Next(0, enabledSubsteps.Count);
            DriverActions.clickElement(enabledSubsteps[randomInput]);
            DriverActions.waitForAjaxRequestToComplete();
        }

        public void SelectRandomOptionsUntilAccessories()
        {
            while (!FooterModule.IsNextOpenBuildSummaryDisplayed())
            {
                ClickRandomSubstepInput();
                FooterModule.ClickFooterNextButton();
            }
            FooterModule.OpenBuildSummary();
        }

        public bool IsOptionTitleHeadingDisplayed(string title)
        {
            bool isFound = false;
            List<IWebElement> options = Driver.FindElements(BY_OPTIONS_TITLE_HEADING).ToList();

            foreach (var item in options)
            {
                string optionTitle = item.Text;
                if (stringContainsIgnoreCase(optionTitle, title))
                {
                    isFound = true;
                    break;
                }
            }
            return isFound;
        }

        public bool ClickOptionHeadingByName(string option)
        {
            bool isFound = false;
            List<IWebElement> headings = Driver.FindElements(BY_SUBSTEP_OPTIONS).ToList();

            foreach (var item in headings)
            {
                string headingTxt = item.FindElement(BY_OPTION_HEADING).Text;
                if (stringContainsIgnoreCase(headingTxt, option))
                {
                    isFound = true;
                    DriverActions.clickElement(item);
                    break;
                }
            }
            return isFound;
        }

        public bool ClickSubstepOptionByTitle(string optionName)
        {
            bool isFound = false;
            List<IWebElement> substepOptions = Driver.FindElements(BY_SUBSTEP_OPTIONS_LIST).ToList();

            foreach (var item in substepOptions)
            {
                string substepOption = item.FindElement(SPAN_TAG_NAME).Text;
                if (substepOption.Length > 0 && stringContainsIgnoreCase(substepOption, optionName))
                {
                    isFound = true;
                    DriverActions.clickElement(item);
                    break;
                }
            }
            return isFound;
        }

        public int GetOptionCheckedSubstepOptions(string optionName)
        {
            int checkedItems = 0;
            List<IWebElement> substepOptions = Driver.FindElements(BY_SUBSTEP_OPTIONS).ToList();

            foreach (var item in substepOptions)
            {
                string substepOption = item.FindElement(BY_OPTION_HEADING).Text;
                if (substepOption.Length > 0 && stringContainsIgnoreCase(substepOption, optionName))
                {
                    List<IWebElement> radioButtons = item.FindElements(BY_SUBSTEP_RADIO_BUTTON).ToList();
                    foreach (var radio in radioButtons)
                    {
                        if (radio.Selected)
                            checkedItems++;
                    }
                    break;
                }
            }
            return checkedItems;
        }

        public bool IsOptionsBuildSummaryDialogDisplayed()
        {
            return DriverActions.IsElementPresent(BY_OPTIONS_BUILD_SUMMARY_DIALOG);
        }

        public string GetOptionsPageTitle()
        {
            return Driver.FindElement(BY_OPTION_PAGE_TITLE).Text;
        }

        public void ClickSummaryAddAdditionalAccessories()
        {
            DriverActions.clickElement(BY_SUMMARY_ADD_ADDITIONAL_ACCESSORIES);
        }
    }
}
