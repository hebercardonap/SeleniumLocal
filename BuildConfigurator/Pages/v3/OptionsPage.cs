using AutomationFramework.Base;
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
    }
}
