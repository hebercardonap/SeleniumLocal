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

        protected IWebDriver driver
        {
            get
            {
                return _parallelConfig.Driver;
            }
            set { }
        }

        protected TPage GetInstance<TPage>() where TPage : BasePage, new()
        {
            TPage pageInstance = new TPage()
            {
                driver = _parallelConfig.Driver
            };

            return pageInstance;
        }

        public TPage As<TPage>() where TPage : BasePage
        {
            return (TPage)this;
        }

    }
}
