﻿using AutomationFramework.Base;
using AutomationFramework.Extensions;
using AutomationFramework.Utils;
using BuildConfigurator.Modules;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Pages.v3
{
    public class ModelsPage : BasePage
    {

        private static By BY_ONE_SEAT_MODEL = PolarisSeleniumAttribute.PolarisSeleniumSelector("1-Seat");
        private static By BY_TWO_SEAT_MODEL = PolarisSeleniumAttribute.PolarisSeleniumSelector("2-Seat");
        private static By BY_THREE_SEAT_MODEL = PolarisSeleniumAttribute.PolarisSeleniumSelector("3-Seat");
        private static By BY_FOUR_SEAT_MODEL = PolarisSeleniumAttribute.PolarisSeleniumSelector("4-Seat");
        private static By BY_SIX_SEAT_MODEL = PolarisSeleniumAttribute.PolarisSeleniumSelector("6-Seat");
        private static By BY_MODELS_CARDS = PolarisSeleniumAttribute.PolarisSeleniumSelector("wholegoodModelsCard");
        private static By BY_MODELS_SEAT_CARDS = PolarisSeleniumAttribute.PolarisSeleniumSelector("wholegoodSeatsCard");
        

        public HeaderModule HeaderModule { get { return new HeaderModule(_parallelConfig); } }

        public CalculatorModule CalculatorModule { get { return new CalculatorModule(_parallelConfig); } }

        public FooterModule FooterModule { get { return new FooterModule(_parallelConfig); } }

        private static Random rnd = new Random();
        public ModelsPage(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public void ClickOneSeatModel()
        {
            DriverActions.clickElement(BY_ONE_SEAT_MODEL);
        }

        public void ClickTwoSeatModel()
        {
            DriverActions.clickElement(BY_TWO_SEAT_MODEL);
        }

        public void ClickThreeSeatModel()
        {
            DriverActions.clickElement(BY_THREE_SEAT_MODEL);
        }

        public void ClickFourSeatModel()
        {
            DriverActions.clickElement(BY_FOUR_SEAT_MODEL);
        }

        public void ClickSixSeatModel()
        {
            DriverActions.clickElement(BY_SIX_SEAT_MODEL);
        }

        public void ClickRandomModelVersion()
        {
            List<IWebElement> modelVersions = Driver.FindElements(BY_MODELS_CARDS).ToList();
            int randomModel = rnd.Next(0, modelVersions.Count);
            DriverActions.clickElement(modelVersions[randomModel]);
        }

        public void WaitForModelsToLoad()
        {
            WebDriverExtensions.WaitForPageLoaded(Driver);
            DriverActions.waitForElementVisibleAndEnabled(BY_MODELS_CARDS);
        }

        public void WaitForModelsPageToLoad()
        {
            WebDriverExtensions.WaitForPageLoaded(Driver);
            DriverActions.waitForElementVisibleAndEnabled(BY_MODELS_SEAT_CARDS);
        }


    }
}
