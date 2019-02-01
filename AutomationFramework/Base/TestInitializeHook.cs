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
        protected ParallelConfig _parallelConfig = new ParallelConfig();
        
        public void InitializeSettings()
        {
            //ConfigReader.setFrameworkSettings();
            OpenBrowser(Settings.BrowserType);
        }

        public void SetFrameworkSettings()
        {
            ConfigReader.setFrameworkSettings();
        }

        private void TurnOnWait()
        {
            _parallelConfig.Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(120);
            _parallelConfig.Driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(20);
            _parallelConfig.Driver.Manage().Cookies.DeleteAllCookies();
            _parallelConfig.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _parallelConfig.Driver.Manage().Window.Maximize();
        }

        private void OpenBrowser(BrowserType browserType = BrowserType.Chrome)
        {
            switch (browserType)
            {
                case BrowserType.InternetExplorer:
                    var options = new InternetExplorerOptions();
                    options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                    _parallelConfig.Driver = new InternetExplorerDriver(options);
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
