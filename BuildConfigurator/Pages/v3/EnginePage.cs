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
    public class EnginePage : BasePage
    {
        private static By BY_WHOLEGOOD_ENGINE = PolarisSeleniumAttribute.PolarisSeleniumSelector("wholegoodColorItem");

        public HeaderModule HeaderModule { get { return new HeaderModule(_parallelConfig); } }

        public CalculatorModule CalculatorModule { get { return new CalculatorModule(_parallelConfig); } }

        public FooterModule FooterModule { get { return new FooterModule(_parallelConfig); } }

        public NavigationBarModule NavigationBarModule { get { return new NavigationBarModule(_parallelConfig); } }

        public Toolbar Toolbar { get { return new Toolbar(_parallelConfig); } }

        private static Random rnd = new Random();

        public EnginePage(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public void ClickRandomWholegoodEngine()
        {
            List<IWebElement> wholegoodColors = Driver.FindElements(BY_WHOLEGOOD_ENGINE).ToList();
            int randomColor = rnd.Next(0, wholegoodColors.Count);
            DriverActions.clickElement(wholegoodColors[randomColor]);
        }

        public void WaitForEnginePageToLoad()
        {
            WebDriverExtensions.WaitForPageLoaded(Driver);
            DriverActions.waitForElementVisibleAndEnabled(BY_WHOLEGOOD_ENGINE);
        }
    }
}
