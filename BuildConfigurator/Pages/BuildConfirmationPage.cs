﻿using AutomationFramework.Base;
using AutomationFramework.Extensions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Pages
{
    class BuildConfirmationPage : BasePage
    {
        private static By BY_THANK_YOU_MESSAGE = By.CssSelector("div[class*='form-confirmation'] span");
        private static By BY_PRINT_LINK = By.XPath("//button[@title='Print Detailed Summary']");
        private static By BY_TOTAL_PRICE = By.CssSelector("div.total-price");
        private static By BY_ADDED_ACCESSORY = By.XPath("//div[contains(@class,'product border-bottom')]");
        private static By BY_ADDED_ACCESSORY_CONTAINER = By.CssSelector("div[class='added-products']");
        private static By BY_SHOPPING_TOOLS = By.XPath("//div[contains(@class,'layout__container')]//section[@id='shopping-tools']");

        public void waitForBuildConfirmationPageToLoad()
        {
            WebDriverExtensions.waitForElementPresent(BY_THANK_YOU_MESSAGE);
        }

        public bool isTotalPriceDisplayed()
        {
            return WebElementExtensions.IsElementPresent(BY_TOTAL_PRICE);
        }

        public int getAddedAccessoriesCount()
        {
            List<IWebElement> addedAccessories = driver.FindElements(BY_ADDED_ACCESSORY).ToList();
            return addedAccessories.Count;
        }


    }
}
