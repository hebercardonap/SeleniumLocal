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

        public readonly ParallelConfig _parallelConfig;

        public Base(ParallelConfig parallelConfig)
        {
            _parallelConfig = parallelConfig;
        }

        protected IWebDriver Driver
        {
            get
            {
                return _parallelConfig.Driver;
            }
        }

        public BasePage CurrentPage
        {
            get
            {
                return _parallelConfig.CurrentPage;
            }
            set
            {
                _parallelConfig.CurrentPage = value;
            }
        }

        public TPage As<TPage>() where TPage : BasePage
        {
            return (TPage)this;
        }

        public void GoToUrl(string url)
        {
            Driver.Url = url;
        }

        public string GetCurrentUrl()
        {
            return Driver.Url;
        }

    }
}
