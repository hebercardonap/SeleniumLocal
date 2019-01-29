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
        private static By BY_TOOLBAR_SAVE_ICON = By.CssSelector("div[class='icon__toolbar-save']");
        public Toolbar(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public bool IsToolbarDisplayed()
        {
            return DriverActions.IsElementPresent(BY_TOOLBAR_CONTAINER);
        }

        public bool IsFullscreenIconVisibleAndEnabled()
        {
            return DriverActions.IsElementPresent(BY_TOOLBAR_FULLSCREEN_ICON);
        }

        public bool IsSnapshotIconVisibleAndEnabled()
        {
            return DriverActions.IsElementPresent(BY_TOOLBAR_SNAPSHOT_ICON);
        }

        public bool IsEmailIconVisibleAndEnabled()
        {
            return DriverActions.IsElementPresent(BY_TOOLBAR_EMAIL_ICON);
        }

        public bool IsPrintIconVisibleAndEnabled()
        {
            return DriverActions.IsElementPresent(BY_TOOLBAR_PRINT_ICON);
        }

        public bool IsRestartIconVisibleAndEnabled()
        {
            return DriverActions.IsElementPresent(BY_TOOLBAR_RESTART_ICON);
        }

        public bool IsInteriorExteriorIconVisibleAndEnabled()
        {
            return DriverActions.IsElementPresent(BY_TOOLBAR_INTERIOR_EXT_ICON);
        }

        public bool IsSaveIconVisibleAndEnabled()
        {
            return DriverActions.IsElementPresent(BY_TOOLBAR_SAVE_ICON);
        }

        public void ClickToolbarRestartIcon()
        {
            DriverActions.clickElement(BY_TOOLBAR_RESTART_ICON);
        }

        public void ClickToolbarFullscreenIcon()
        {
            DriverActions.clickElement(BY_TOOLBAR_FULLSCREEN_ICON);
        }

        public void ClickToolbarSaveIcon()
        {
            DriverActions.clickElement(BY_TOOLBAR_SAVE_ICON);
        }
    }
}
