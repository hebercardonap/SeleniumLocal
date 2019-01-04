using AutomationFramework.Base;
using AutomationFramework.Extensions;
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
    public class TrimsPage : BasePage
    {
        private static By BY_TRIM_CARDS = PolarisSeleniumAttribute.PolarisSeleniumSelector("trimModelsCard");

        public HeaderModule HeaderModule { get { return new HeaderModule(_parallelConfig); } }

        public CalculatorModule CalculatorModule { get { return new CalculatorModule(_parallelConfig); } }

        public FooterModule FooterModule { get { return new FooterModule(_parallelConfig); } }

        public NavigationBarModule NavigationBarModule { get { return new NavigationBarModule(_parallelConfig); } }

        private static Random rnd = new Random();

        public TrimsPage(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public void ClickRandomTrim()
        {
            List<IWebElement> modelTrims = Driver.FindElements(BY_TRIM_CARDS).ToList();
            int randomTrim = rnd.Next(0, modelTrims.Count);
            DriverActions.clickElement(modelTrims[randomTrim]);
        }

        public void WaitForTrimsPageToLoad()
        {
            WebDriverExtensions.WaitForPageLoaded(Driver);
            DriverActions.waitForElementVisibleAndEnabled(BY_TRIM_CARDS);
        }
    }
}
