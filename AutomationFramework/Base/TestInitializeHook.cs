using AutomationFramework.Config;
using AutomationFramework.Helpers;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Base
{
    public abstract class TestInitializeHook : Base
    {
        public readonly BrowserType Browser;

        public static void InitializeSettings()
        {
            ConfigReader.setFrameworkSettings();
            LogHelpers.CreateLogFile();

            OpenBrowser(Settings.BrowserType);

            LogHelpers.Write("Initialized Framework");
        }

        public static void TurnOnWait()
        {
            DriverContext.Driver.Manage().Window.Maximize();
            DriverContext.Driver.Manage().Cookies.DeleteAllCookies();
            DriverContext.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(25);
            DriverContext.Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(25);
        }

        private static void OpenBrowser(BrowserType browserType = BrowserType.Chrome)
        {
            switch (browserType)
            {
                case BrowserType.InternetExplorer:
                    DriverContext.Driver = new InternetExplorerDriver();
                    TurnOnWait();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.FireFox:
                    DriverContext.Driver = new FirefoxDriver();
                    TurnOnWait();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.Chrome:
                    DriverContext.Driver = new ChromeDriver();
                    TurnOnWait();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
            }
        }
    }
}
