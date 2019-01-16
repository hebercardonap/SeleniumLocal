using AutomationFramework.Base;
using BuildConfigurator.Modules;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Pages.v2
{
    public class BuildPackagePage : BasePage
    {
        private static By BY_FULL_SCREEN_BUTTON = By.Id("build-variant__fullscreen");
        private static By BY_FLICKITY_SLIDER_BUTTON = By.CssSelector("div[class='flickity-slider']>button");
        public HeaderModule HeaderModule { get { return new HeaderModule(_parallelConfig); } }

        public FooterModule FooterModule { get { return new FooterModule(_parallelConfig); } }

        public BuildPackagePage(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public void WaitForBuildPageToLoad()
        {
            DriverActions.waitForElementVisibleAndEnabled(BY_FULL_SCREEN_BUTTON);
            DriverActions.waitForElementVisibleAndEnabled(BY_FLICKITY_SLIDER_BUTTON);
        }
    }
}
