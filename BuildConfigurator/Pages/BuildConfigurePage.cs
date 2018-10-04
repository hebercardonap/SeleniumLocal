using AutomationFramework.Base;
using AutomationFramework.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        private static By BY_RAN_TIRES_CATEGORY = By.XPath("//button[@title='View Wheel & Tire Sets']");


        // Accessory sub categories selectors
        private static By BY_ROOFS_SUBCATEGORY = By.XPath("//button[@title='View Roofs']");
        private static By BY_WINDSHIELDS_SUBCATEGORY = By.XPath("//button[@title='View Windshields']");
        private static By BY_RAN_TRAIL_SUBCATEGORY = By.XPath("//button[@title='View Trail']");

        // Accessory Cards selectors
        private static By BY_ACCESSORY_CARD = By.CssSelector("div[class='flickity-slider'] div[ng-repeat^='product']");
        private static By BY_BUILD_CATEGORIES = By.XPath("//div[@id='build-category']//div[@class='flickity-slider']//button");


        private static By BY_FINISHED_BUTTON = By.XPath("//div[@class='summary-accessory-quote btn btn-color-primary btn-md btn-square']");
        private static By BY_FINISHED_OLD_BUTTON = By.XPath("//button[@class='summary-accessory-quote btn btn-color-primary-light btn-md btn-square']");
        private static By BY_PRP_CONTAINER = By.XPath("//div[@class='part-require-part']");
        private static By BY_BUILD_SUBCATEGORIES = By.XPath("//div[@id='build-subCategory']//div[@class='flickity-slider']//button");
        private static By BY_BUILD_SUBCATEGORY = By.XPath("//div[@id='build-subCategory']//div[@class='flickity-slider']");
        private static By By_REMOVE_LINK_PRP = By.CssSelector("div[class='summary-accessory-info-remove '][role='button']");
        private static By By_REMOVE_LINK_OLD_PRP = By.XPath("//div[@class='part-require-part-primaryPart']//div[contains(@class,'summary-accessory-info-remove')][contains(text(),'Remove item')]");
        private static By BY_SUMMARY_HEADER = By.XPath("//div[@class='summary__header']");
        private static string BY_CATEGORY_TITLE_GENERIC = "//button[contains(@title, '{0}')]";
        private static string BY_SUBCATEGORY_TITLE_GENERIC = ".//button[contains(@title, '{0}')]";


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

        public void clickWindShieldsSubcategory()
        {
            WebElementExtensions.clickElement(BY_WINDSHIELDS_SUBCATEGORY);
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

        public void clickIamFinishedButtonOld()
        {
            WebElementExtensions.clickElement(BY_FINISHED_OLD_BUTTON);
        }

        public void clickRangerTiresCategory()
        {
            WebElementExtensions.clickElement(BY_RAN_TIRES_CATEGORY);
        }

        public void clickRangerTrailSubcategory()
        {
            WebElementExtensions.clickElement(BY_RAN_TRAIL_SUBCATEGORY);
        }

        public void clickRandomAccessoryCategory()
        {
            List<IWebElement> categories = driver.FindElements(BY_BUILD_CATEGORIES).ToList();
            WebElementExtensions.clickElement(categories[rnd.Next(0, categories.Count)]);
        }

        public void clickRandomAccessorySubcategory()
        {
            List<IWebElement> subcategories = driver.FindElements(BY_BUILD_SUBCATEGORIES).ToList();
            WebElementExtensions.clickElement(subcategories[rnd.Next(0, subcategories.Count)]);
        }

        public void clickRandomAccessoryAvoidPRP()
        {
            addRandomAccessory();
            while (true)
            {

                if (WebElementExtensions.IsElementPresent(BY_PRP_CONTAINER))
                {
                    clickRemoveLinkPRP();
                    addRandomAccessory();
                }
                else
                 break;
            }
        }

        public void addRandomAccessory()
        {
            clickRandomAccessoryCategory();
            clickRandomAccessorySubcategory();
            clickRandomAccessoryCardAddButton();
        }

        public void clickRemoveLinkPRP()
        {
            try
            {
                WebElementExtensions.clickElement(By_REMOVE_LINK_PRP);
            }
            catch (Exception)
            {

                WebElementExtensions.clickElement(By_REMOVE_LINK_OLD_PRP);
            }
            
        }

        public void clickAccessoryCategory(string accessoryCategory)
        {
            bool isFound = false;
            List<IWebElement> categories = driver.FindElements(BY_BUILD_CATEGORIES).ToList();
            foreach (var category in categories)
            {
                if (stringEqualsIgnoreCase(category.Text, accessoryCategory))
                {
                    WebElementExtensions.clickElement(category);
                    isFound = true;
                    break;
                }
            }
            if (!isFound)
                Assert.Inconclusive("The category with name {0} is not present", accessoryCategory);
        }

        public void clickAccessorySubCategory(string accessoryCategory)
        {
            string xpathString = string.Format(BY_SUBCATEGORY_TITLE_GENERIC, accessoryCategory);
            IWebElement subcategory = driver.FindElement(BY_BUILD_SUBCATEGORY).FindElement(By.XPath(xpathString));
            WebElementExtensions.clickElement(subcategory);
        }

    }
}
