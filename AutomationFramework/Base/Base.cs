using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AutomationFramework.Base
{
    public class Base
    {

        public BasePage CurrentPage
        {
            get => (BasePage)ScenarioContext.Current["currentPage"];
            set => ScenarioContext.Current["currentPage"] = value;
        }

        protected IWebDriver driver { get; set; }

        protected TPage GetInstance<TPage>() where TPage : BasePage, new()
        {
            TPage pageInstance = new TPage()
            {
                driver = DriverContext.Driver
            };

            return pageInstance;
        }

        public TPage As<TPage>() where TPage : BasePage
        {
            return (TPage)this;
        }

    }
}
