using AutomationFramework.Base;
using AutomationFramework.Extensions;
using NUnit.Framework;
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
        private static By BY_SUBCATEGORY_OPTIONS = By.XPath("//div[@id='build-subCategory']//div[@class='flickity-slider']//button");
        private static By BY_CONFLICT_CONTAINER = By.XPath("//div[@class='conflict']");
        private static By BY_ACCESORY_CARD_TITLE = By.XPath(".//label[contains(@class, 'card-title')]");
        private static By BY_CONFLICT_HEADER = By.XPath("//div[contains(@class, 'conflict-header')]");
        private static By BY_PART_REQUIRE_PART_CONTAINER = By.XPath("//div[@class='part-require-part']");
        private static By BY_PART_REQUIRE_PART_HEADER = By.XPath("//div[contains(@class, 'part-require-part-heading')]");
        private static By BY_SECONDARY_ACCESSORY_SELECT_BTN = By.XPath("//div[@class='part-require-part-secondaryParts']//div[@role='button']");
        private static By BY_NEXT_STEPS_CONTAINER = By.XPath("//div[@class='build-next-steps build-header__choice pull-right']");
        private static By BY_BUILD_SUMMARY_CONTAINER = By.XPath("//div[@class='summary']");
        private static By BY_NEXT_STEPS_FINISHED_BUTTON = By.XPath("//div[contains(@class, 'build-next-steps')]//button[contains(@class, 'btn-primary')]");
        private static By BY_BUILD_SUMMARY_BUTTON = By.XPath("//button[@class='btn-next']");
        private static By BY_PRODUCT_ID_BUILD_SUMMARY = By.XPath("//div[@class='summary-scroll']//div[contains(@class, 'product-id')]");
        private static By BY_ACC_REQUIRED_PRODUCT_ID = By.XPath("//div[@class='part-require-part-secondaryParts']//div[contains(@class,'product-id')]");
        private static By BY_SECONDARY_ACC_CHILD_SELECT_BUTTON = By.XPath(".//div[@role='button']");
        private static By BY_SUMMARY_ACCESSORY_INFO = By.XPath("//div[@class='part-require-part-secondaryParts']//div[@class='summary-accessory-info']");
        private static By BY_SUMMARY_CHILD_PRODUCT_ID = By.XPath(".//div[contains(@class,'product-id')]");
        private static By BY_OLD_SECONDARY_ACC_CHILD_SELECT_BUTTON = By.XPath(".//div[@ng-if='showCtaLink']");
        private static By BY_BUILD_SUMMARY_REMOVE_LINK = By.XPath(".//div[@ng-if='showCtaLink']");
        private static By BY_BUILD_SUMMARY_ACC_CONTAINER = By.XPath("//div[@class='summary-scroll']//div[@class='summary-accessory']");



        private static Random rnd = new Random();
        private static IWebElement SelectedAccessoryCard;
        private static string BUTTON_TAG = "button";
        private static string ADD_TEXT = "ADD";
        private static string TITLE_ATTRIBUTE = "title";

        PageHelpers _pageHelpers;

        public BuildConfigurePage(ParallelConfig parallelConfig) : base(parallelConfig)
        {
            _pageHelpers = new PageHelpers(parallelConfig);
        }

        public void clickProtectionCategory()
        {
            DriverActions.clickElement(BY_PROTECTION_CATEGORY);
        }

        public void clickRoofSubcategory()
        {
            DriverActions.clickElement(BY_ROOFS_SUBCATEGORY);
        }

        public void clickWindShieldsSubcategory()
        {
            DriverActions.clickElement(BY_WINDSHIELDS_SUBCATEGORY);
        }

        private void getRandomAccessoryCard()
        {
            List<IWebElement> accessoryCards;
            accessoryCards = Driver.FindElements(BY_ACCESSORY_CARD).ToList();
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
            DriverActions.waitForElementToBeEnabled(BY_FINISHED_BUTTON);
            DriverActions.clickElement(BY_FINISHED_BUTTON);
        }

        public void clickIamFiniShedButtonNextSteps()
        {
            DriverActions.waitForElementToBeEnabled(BY_NEXT_STEPS_FINISHED_BUTTON);
            DriverActions.clickElement(BY_NEXT_STEPS_FINISHED_BUTTON);
        }

        public void clickIamFinishedButtonOld()
        {
            DriverActions.waitForElementToBeEnabled(BY_FINISHED_OLD_BUTTON);
            DriverActions.clickElement(BY_FINISHED_OLD_BUTTON);
        }

        public void clickRangerTiresCategory()
        {
            DriverActions.clickElement(BY_RAN_TIRES_CATEGORY);
        }

        public void clickRangerTrailSubcategory()
        {
            DriverActions.clickElement(BY_RAN_TRAIL_SUBCATEGORY);
        }

        public void clickRandomAccessoryCategory()
        {
            List<IWebElement> categories = Driver.FindElements(BY_BUILD_CATEGORIES).ToList();
            WebElementExtensions.clickElement(categories[rnd.Next(0, categories.Count)]);
        }

        public void clickRandomAccessorySubcategory()
        {
            List<IWebElement> subcategories = Driver.FindElements(BY_BUILD_SUBCATEGORIES).ToList();
            WebElementExtensions.clickElement(subcategories[rnd.Next(0, subcategories.Count)]);
        }

        public void clickRandomAccessoryAvoidPRP()
        {
            addRandomAccessory();
            while (true)
            {

                if (DriverActions.IsElementPresent(BY_PRP_CONTAINER))
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
                DriverActions.clickElement(By_REMOVE_LINK_PRP);
            }
            catch (Exception)
            {

                DriverActions.clickElement(By_REMOVE_LINK_OLD_PRP);
            }
            
        }

        public void clickAccessoryCategory(string accessoryCategory)
        {
            List<IWebElement> categories = Driver.FindElements(BY_BUILD_CATEGORIES).ToList();
            _pageHelpers.FindMatchElementAndClick(categories, accessoryCategory);
            DriverActions.waitForAjaxRequestToComplete();
        }

        public void clickAccessorySubCategory(string accessoryCategory)
        {
            List<IWebElement> subCategoryButtons = Driver.FindElements(BY_SUBCATEGORY_OPTIONS).ToList();
            _pageHelpers.FindMatchElementAndClick(subCategoryButtons, accessoryCategory);
            DriverActions.waitForAjaxRequestToComplete();
        }

        public void clickSpecificAccessoryCardAddButton(string accessoryTitle)
        {

            bool isFound = false;
            List<IWebElement> accessoryCards = Driver.FindElements(BY_ACCESSORY_CARD).ToList();

            foreach (var accessoryCard in accessoryCards)
            {
                string title = accessoryCard.FindElement(BY_ACCESORY_CARD_TITLE).Text;
                
                if (stringContainsIgnoreCase(title, accessoryTitle) || stringEqualsIgnoreCase(title, accessoryTitle))
                {
                    isFound = true;
                    List<IWebElement> buttons = accessoryCard.FindElements(By.TagName(BUTTON_TAG)).ToList();
                    foreach (var button in buttons.Where(button => string.Equals(button.Text, ADD_TEXT, StringComparison.OrdinalIgnoreCase)))
                    {
                        WebElementExtensions.clickElement(button);
                        break;
                    }
                    break;
                }
            }
            if (!isFound)
                Assert.Fail("Accessory with description {0} was not found", accessoryTitle);

        }

        public bool isConflictContainerDisplayed()
        {
            return DriverActions.IsElementPresent(BY_CONFLICT_CONTAINER);
        }

        public bool isConflictHeaderDisplayed()
        {
            return DriverActions.IsElementPresent(BY_CONFLICT_HEADER);
        }

        public bool isPRPHeaderDisplayed()
        {
            return DriverActions.IsElementPresent(BY_PART_REQUIRE_PART_HEADER);
        }

        public void clickRandomSecondaryAccessory()
        {
            List<IWebElement> accessories = Driver.FindElements(BY_SECONDARY_ACCESSORY_SELECT_BTN).ToList();
            WebElementExtensions.clickElement(accessories[rnd.Next(0, accessories.Count)]);
        }

        public void clickSecondaryAccessoryByProductId(string id)
        {
            bool isFound = false;
            List<IWebElement> productIds = Driver.FindElements(BY_SUMMARY_ACCESSORY_INFO).ToList();

            foreach (var productId in productIds)
            {
                string currentId = productId.FindElement(BY_SUMMARY_CHILD_PRODUCT_ID).Text;
                if (currentId.Equals(id))
                {
                    isFound = true;
                    WebElementExtensions.clickElement(productId.FindElement(BY_SECONDARY_ACC_CHILD_SELECT_BUTTON));
                    break;
                }
            }
            if (!isFound)
            {
                Assert.Fail("Product id {0} not available for this model", id);
            }
        }

        public void clickOldSecondaryAccessoryByProductId(string id)
        {
            bool isFound = false;
            List<IWebElement> productIds = Driver.FindElements(BY_SUMMARY_ACCESSORY_INFO).ToList();

            foreach (var productId in productIds)
            {
                string currentId = productId.FindElement(BY_SUMMARY_CHILD_PRODUCT_ID).Text;
                if (currentId.Equals(id))
                {
                    isFound = true;
                    WebElementExtensions.clickElement(productId.FindElement(BY_OLD_SECONDARY_ACC_CHILD_SELECT_BUTTON));
                    break;
                }
            }
            if (!isFound)
            {
                Assert.Fail("Product id {0} not available for this model", id);
            }
        }

        public void clickRemoveLinkByProductId(string id)
        {
            bool isFound = false;
            List<IWebElement> productIds = Driver.FindElements(BY_BUILD_SUMMARY_ACC_CONTAINER).ToList();

            foreach (var productId in productIds)
            {
                string currentId = productId.FindElement(BY_SUMMARY_CHILD_PRODUCT_ID).Text;
                if (currentId.Equals(id))
                {
                    isFound = true;
                    WebElementExtensions.clickElement(productId.FindElement(BY_BUILD_SUMMARY_REMOVE_LINK));
                    break;
                }
            }
            if (!isFound)
            {
                Assert.Fail("Product id {0} not available for this model", id);
            }
        }

        public void clickBuildSummaryButton()
        {
            DriverActions.waitForElementToBeEnabled(BY_BUILD_SUMMARY_BUTTON);
            DriverActions.clickElement(BY_BUILD_SUMMARY_BUTTON);
        }

        public void verifyAccesoriesOnBuildSummary(string[] values)
        {
            
            List<IWebElement> ids = Driver.FindElements(BY_PRODUCT_ID_BUILD_SUMMARY).ToList();

            foreach (var value in values)
            {
                bool isFound = false;

                foreach (var id in ids)
                {
                    if (value.Trim().Equals(id.Text))
                    {
                        isFound = true;
                    }
                }
                if (!isFound)
                {
                    Assert.Fail("Product ID: {0} not present in build summary", value);
                }
            }
        }
    }
}
