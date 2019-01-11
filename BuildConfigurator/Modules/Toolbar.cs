using AutomationFramework.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Modules
{
    public class Toolbar : BasePage
    {
        private static By BY_TOOLBAR_CONTAINER = By.XPath("//div[@class='variant-display--container']");
        private static By BY_TOOLBAR_FULLSCREEN_ICON = By.Id("build-variant__fullscreen");
        private static By BY_TOOLBAR_SNAPSHOT_ICON = By.CssSelector("button[title*='Snapshot']");
        private static By BY_TOOLBAR_EMAIL_ICON = By.CssSelector("button[title*='Email Build']");
        private static By BY_TOOLBAR_PRINT_ICON = By.CssSelector("button[title*='Print your build']");
        private static By BY_TOOLBAR_RESTART_ICON = By.CssSelector("button[title*='Restart Build']");
        private static By BY_TOOLBAR_INTERIOR_EXT_ICON = By.CssSelector("button[title*='interior']");
        public Toolbar(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public bool IsToolbarDisplayed()
        {
            return DriverActions.IsElementPresent(BY_TOOLBAR_CONTAINER);
        }

        public bool IsFullscreenIconEnabled()
        {
            return Driver.FindElement(BY_TOOLBAR_FULLSCREEN_ICON).Enabled;
        }

        public bool IsSnapshotIconEnabled()
        {
            return Driver.FindElement(BY_TOOLBAR_SNAPSHOT_ICON).Enabled;
        }

        public bool IsEmailIconEnabled()
        {
            return Driver.FindElement(BY_TOOLBAR_EMAIL_ICON).Enabled;
        }

        public bool IsPrintIconEnabled()
        {
            return Driver.FindElement(BY_TOOLBAR_PRINT_ICON).Enabled;
        }

        public bool IsRestartIconEnabled()
        {
            return Driver.FindElement(BY_TOOLBAR_RESTART_ICON).Enabled;
        }

        public bool IsInteriorExteriorIconEnabled()
        {
            return Driver.FindElement(BY_TOOLBAR_INTERIOR_EXT_ICON).Enabled;
        }

        public void ClickToolbarRestartIcon()
        {
            DriverActions.clickElement(BY_TOOLBAR_RESTART_ICON);
        }

        public void ClickToolbarFullscreenIcon()
        {
            DriverActions.clickElement(BY_TOOLBAR_FULLSCREEN_ICON);
        }

    }
}
