using AutomationFramework.Base;
using AutomationFramework.Extensions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Pages
{
    internal class BuildConfigurePage : BasePage
    {
        // Accessory categories selectors
        private static By BY_PROTECTION_CATEGORY = By.XPath("//button[@title='View Protection']");


        // Accessory sub categories selectors
        private static By BY_ROOFS_SUBCATEGORY = By.XPath("//button[@title='View Roofs']");

        // Accessory Cards selectors
        private static By BY_ACCESSORY_CARD = By.CssSelector("div[class='flickity-slider'] div[ng-repeat^='product']");
        private static By BY_BUILD_CATEGORIES = By.XPath("//div[@id='build-category']//div[@class='flickity-slider']//button");


        private static By BY_FINISHED_BUTTON = By.XPath("//div[@class='summary-accessory-quote btn btn-color-primary btn-md btn-square']");

        private static Random rnd = new Random();
        private static IWebElement SelectedAccessoryCard;
        private static string BUTTON_TAG = "button";
        private static string ADD_TEXT = "ADD";

        public void clickProtectionCategory()
        {
            WebElementExtensions.clickElement(BY_PROTECTION_CATEGORY);
        }

        public void clickRoofSubcategory()
        {
            WebElementExtensions.clickElement(BY_ROOFS_SUBCATEGORY);
        }

        private void getRandomAccessoryCard()
        {
            List<IWebElement> accessoryCards;
            accessoryCards = driver.FindElements(BY_ACCESSORY_CARD).ToList();
            SelectedAccessoryCard = accessoryCards[rnd.Next(0, accessoryCards.Count)];
        }

        public void clickRandomAccessoryCardAddButton()
        {
            getRandomAccessoryCard();
            List<IWebElement> buttons = SelectedAccessoryCard.FindElements(By.TagName(BUTTON_TAG)).ToList();
            foreach (var button in buttons.Where(button => string.Equals(button.Text, ADD_TEXT, StringComparison.OrdinalIgnoreCase)))
            {
                button.Click();
                break;
            }

        }

        public void clickIamFinishedButton()
        {
            WebElementExtensions.clickElement(BY_FINISHED_BUTTON);
        }

    }
}
