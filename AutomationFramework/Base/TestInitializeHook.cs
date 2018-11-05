using AutomationFramework.Config;
using AutomationFramework.Helpers;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Base
{
    public class TestInitializeHook
    {
        public readonly ParallelConfig _parallelConfig;

        public TestInitializeHook(ParallelConfig parallelConfig)
        {
            _parallelConfig = parallelConfig;
        }

        public void InitializeSettings()
        {
            ConfigReader.setFrameworkSettings();
            //LogHelpers.CreateLogFile();

            OpenBrowser(Settings.BrowserType);

            //LogHelpers.Write("Initialized Framework");
        }

        private void TurnOnWait()
        {
            _parallelConfig.Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            //_parallelConfig.Driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(60);
            _parallelConfig.Driver.Manage().Cookies.DeleteAllCookies();
            _parallelConfig.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _parallelConfig.Driver.Manage().Window.Maximize();
        }

        private void OpenBrowser(BrowserType browserType = BrowserType.Chrome)
        {
            switch (browserType)
            {
                case BrowserType.InternetExplorer:
                    _parallelConfig.Driver = new InternetExplorerDriver();
                    TurnOnWait();
                    break;
                case BrowserType.FireFox:
                    _parallelConfig.Driver = new FirefoxDriver();
                    TurnOnWait();
                    break;
                case BrowserType.Chrome:
                    ChromeOptions chromeoptions = new ChromeOptions();
                    chromeoptions.AddArgument("no-sandbox");
                    _parallelConfig.Driver = new ChromeDriver(chromeoptions);
                    TurnOnWait();
                    break;
            }
        }
    }
}
