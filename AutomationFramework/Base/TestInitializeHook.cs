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

        public void TurnOnWait()
        {
            _parallelConfig.Driver.Manage().Window.Maximize();
            _parallelConfig.Driver.Manage().Cookies.DeleteAllCookies();
            _parallelConfig.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            _parallelConfig.Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(35);
        }

        private void OpenBrowser(BrowserType browserType = BrowserType.Chrome)
        {
            switch (browserType)
            {
                case BrowserType.InternetExplorer:
                    _parallelConfig.Driver = new InternetExplorerDriver();
                    TurnOnWait();
                    //DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.FireFox:
                    _parallelConfig.Driver = new FirefoxDriver();
                    TurnOnWait();
                    //DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.Chrome:
                    //ChromeOptions options = new ChromeOptions();
                    //options.AddAdditionalCapability(CapabilityType.BrowserName, "chrome");
                    //_parallelConfig.Driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), options);
                    _parallelConfig.Driver = new ChromeDriver();
                    TurnOnWait();
                    //DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
            }
        }
    }
}
