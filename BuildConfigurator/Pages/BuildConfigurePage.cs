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
        //private static By BY_ACCESSORY_CARD = By.CssSelector("div[class='flickity-slider'] div[ng-repeat^='product']");
        private static By BY_ACCESSORY_CARD = By.CssSelector("div[id = 'accessory'] div[class='flickity-slider'] div[class*='build-accessory-card'][style]");
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
        private static By BY_SECONDARY_ACC_CHILD_SELECT_BUTTON = By.XPath(".//div[contains(@class,'btn-primary')]");
        private static By BY_SUMMARY_ACCESSORY_INFO = By.XPath("//div[@class='part-require-part-secondaryParts']//div[@class='summary-accessory-info']");
        private static By BY_SUMMARY_CHILD_PRODUCT_ID = By.XPath(".//div[contains(@class,'product-id')]");
        private static By BY_OLD_SECONDARY_ACC_CHILD_SELECT_BUTTON = By.XPath(".//div[@ng-if='showCtaLink']");
        private static By BY_BUILD_SUMMARY_REMOVE_LINK = By.XPath(".//div[contains(@class,'info-remove')]");
        private static By BY_BUILD_SUMMARY_ACC_CONTAINER = By.XPath("//div[@class='summary-scroll']//div[@class='summary-accessory']");
        private static By BY_ADD_BUTTON = By.CssSelector("button:nth-child(2)");
        private static By BY_INFO_BUTTON = By.CssSelector("button:nth-child(1)");
        private static By BY_REMOVE_BUTTON = By.CssSelector("button:nth-child(3)");
        private static By BY_ACCESSORY_IMAGE = By.XPath(".//img");
        private static By BY_ACCESSORY_OVERVIEW_HEADER = By.XPath("//div[@class='modal__content']//div[@class='title2']");
        private static By BY_RESTART_BUILD_BUTTON = By.XPath("//div[@title='Restart Build']");
        private static By BY_CONF_CONTINUE_BUTTON = By.XPath("//button[contains(@class,'confirmation-build-continue')]");
        private static By BY_CONF_SAVE_BUTTON = By.XPath("//button[contains(@class,'confirmation-build-save')]");
        private static By BY_CONF_CANCEL_BUTTON = By.CssSelector("div[class*='confirmation-build-cancel'][data-dismiss='modal']");
        private static By BY_SAVE_ICON = By.XPath("//div[@class='summary-accessory-social']//button[contains(@class,'icon--save')]");
        private static By BY_BUILD_SAVE_NAME_TXT = By.Id("build-model-save-vehicle-name");
        private static By BY_BUILD_SAVE_LINK = By.CssSelector("div[class='save-actions'] div[class='save']");
        private static By BY_LOAD_SAVED_BUTTON = By.XPath("//div[contains(@class,'build-variant')]//button[contains(@class,'savedBuild')]");
        private static By BY_SAVED_VEHICLE_TITLE = By.XPath("//div[@class='saved-vehicles']//div[contains(@class,'saved-vehicle__title')]");
        private static By BY_DELETE_SAVED_BUTTON = By.XPath("//button[contains(@class,'saved-vehicle__delete')]");
        private static By BY_FULL_SCREEN_BUTTON = By.Id("build-variant__fullscreen");
        private static By BY_FLICKITY_SLIDER_BUTTON = By.CssSelector("div[class='flickity-slider']>button");
        private static By BY_NAVIGATION_BAR = By.XPath("//section[contains(@class,'navigation')]");
        private static By BY_SOCIAL_MEDIA_ICON_CONTAINER = By.XPath("//div[@class='build-header__icon-container']");
        private static By BY_SUMMARY_ACCESSORY_SOCIAL = By.XPath("//div[@class='summary-accessory-social']");
        private static By BY_CALCULATOR_ICON = By.XPath("//i[@class='icon icon__calculator']");
        private static By BY_MSRP_FIELD = By.XPath("//input[@id='txtMsrp']");
        private static By BY_VIRTUAL_KYB = By.XPath("//div[contains(@class,'ui-keyboard')]//button[@data-value='7']");
        private static By BY_PYMNT_CALC_HEADER = By.XPath("//div[contains(@class,'payment-calculator')]//h2");
        private static By BY_NAVIGATION_COLOR = By.XPath("//a[contains(@title,'Color')]");
        private static By BY_NAVIGATION_TRIM = By.XPath("//a[contains(@title,'Trim')]");
        private static By BY_NAVIGATION_MODELS = By.XPath("//a[contains(@title,'Models')]");
        private static By BY_CONFLICT_CONTAINER_ITEMS = By.XPath("//div[@class='conflict']//div[@class='summary-accessory']");
        private static By BY_CONFLICT_REMOVE_CTA = By.XPath(".//div[@class='summary-accessory-info-remove ']");



        private static Random rnd = new Random();
        private static IWebElement SelectedAccessoryCard;
        private static string BUTTON_TAG = "button";
        private static string ADD_TEXT = "ADD";
        private static string TITLE_ATTRIBUTE = "title";
        private static string DATE_VALUE = string.Format("{0:yyyymmddhhmmss}", DateTime.Now);
        private static string BUILD_NAME = "TEST BUILD " + DATE_VALUE;

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
            IWebElement addButton = SelectedAccessoryCard.FindElement(BY_ADD_BUTTON);
            WebElementExtensions.clickElement(addButton);
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
                    IWebElement button = accessoryCard.FindElement(BY_ADD_BUTTON);
                    WebElementExtensions.clickElement(button);
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

        public void clickRemoveLinkByProductIdConflictContainer(string id)
        {
            bool isFound = false;
            List<IWebElement> productIds = Driver.FindElements(BY_CONFLICT_CONTAINER_ITEMS).ToList();

            foreach (var productId in productIds)
            {
                string currentId = productId.FindElement(BY_SUMMARY_CHILD_PRODUCT_ID).Text;
                if (currentId.Equals(id))
                {
                    isFound = true;
                    WebElementExtensions.clickElement(productId.FindElement(BY_CONFLICT_REMOVE_CTA));
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

        public bool verifyAccesoriesOnBuildSummary(string[] values)
        {
            bool isFound = false;

            List<IWebElement> ids = Driver.FindElements(BY_PRODUCT_ID_BUILD_SUMMARY).ToList();

            foreach (var value in values)
            {

                foreach (var id in ids)
                {
                    if (value.Trim().Equals(id.Text))
                    {
                        isFound = true;
                        break;
                    }
                    else
                    {
                        isFound = false;
                    }
                }
            }
            return isFound;
        }

        private IWebElement clickAddAccessoryByDesc(string accessoryTitle)
        {

            bool isFound = false;
            IWebElement element = null;
            List<IWebElement> accessoryCards = Driver.FindElements(BY_ACCESSORY_CARD).ToList();

            foreach (var accessoryCard in accessoryCards)
            {
                string title = accessoryCard.FindElement(BY_ACCESORY_CARD_TITLE).Text;

                if (stringContainsIgnoreCase(title, accessoryTitle) || stringEqualsIgnoreCase(title, accessoryTitle))
                {
                    isFound = true;
                    element = accessoryCard;
                    IWebElement button = accessoryCard.FindElement(BY_ADD_BUTTON);
                    WebElementExtensions.clickElement(button);
                    DriverActions.waitForAjaxRequestToComplete();
                    break;
                }
            }
            if (!isFound)
                Assert.Fail("Accessory with description {0} was not found", accessoryTitle);

            return element;

        }

        public bool AddAccessoryAndVerifyRemoveButtonDisplayed(string accessoryDescription)
        {
            IWebElement element = clickAddAccessoryByDesc(accessoryDescription);
            return DriverActions.IsElementPresent(element.FindElement(BY_REMOVE_BUTTON));
        }

        public bool IsRemoveButtonDisplayedForAccessoryDesc(string accessoryDescription)
        {
            bool isFound = false;
            IWebElement element = null;
            List<IWebElement> accessoryCards = Driver.FindElements(BY_ACCESSORY_CARD).ToList();

            foreach (var accessoryCard in accessoryCards)
            {
                string title = accessoryCard.FindElement(BY_ACCESORY_CARD_TITLE).Text;

                if (stringContainsIgnoreCase(title, accessoryDescription) || stringEqualsIgnoreCase(title, accessoryDescription))
                {
                    isFound = true;
                    element = accessoryCard;
                    break;
                }
            }
            if (!isFound)
            {
                Assert.Fail("Accesory with description: {0} is not present");
            }
            return DriverActions.IsElementPresent(element.FindElement(BY_REMOVE_BUTTON));
        }

        public void clickSpecificAccessoryCardInfoButton(string accessoryTitle)
        {

            bool isFound = false;
            List<IWebElement> accessoryCards = Driver.FindElements(BY_ACCESSORY_CARD).ToList();

            foreach (var accessoryCard in accessoryCards)
            {
                string title = accessoryCard.FindElement(BY_ACCESORY_CARD_TITLE).Text;

                if (stringContainsIgnoreCase(title, accessoryTitle) || stringEqualsIgnoreCase(title, accessoryTitle))
                {
                    isFound = true;
                    IWebElement button = accessoryCard.FindElement(BY_INFO_BUTTON);
                    WebElementExtensions.clickElement(button);
                    break;
                }
            }
            if (!isFound)
                Assert.Fail("Accessory with description {0} was not found", accessoryTitle);

        }

        public void clickSpecificAccessoryCardImage(string accessoryTitle)
        {

            bool isFound = false;
            List<IWebElement> accessoryCards = Driver.FindElements(BY_ACCESSORY_CARD).ToList();

            foreach (var accessoryCard in accessoryCards)
            {
                string title = accessoryCard.FindElement(BY_ACCESORY_CARD_TITLE).Text;

                if (stringContainsIgnoreCase(title, accessoryTitle) || stringEqualsIgnoreCase(title, accessoryTitle))
                {
                    isFound = true;
                    IWebElement button = accessoryCard.FindElement(BY_ACCESSORY_IMAGE);
                    WebElementExtensions.clickElement(button);
                    break;
                }
            }
            if (!isFound)
                Assert.Fail("Accessory with description {0} was not found", accessoryTitle);

        }

        public bool IsAccessoryOverViewDisplayed(string accessoryDescription)
        {
            string header = string.Empty;
            if (DriverActions.IsElementPresent(BY_ACCESSORY_OVERVIEW_HEADER))
            {
                header = Driver.FindElement(BY_ACCESSORY_OVERVIEW_HEADER).Text;
            }

            return stringContainsIgnoreCase(header, accessoryDescription);
        }

        public void ClickBuildRestartButton()
        {
            DriverActions.clickElement(BY_RESTART_BUILD_BUTTON);
            DriverActions.waitForAjaxRequestToComplete();
        }

        public void ClickConfirmationContinueButton()
        {
            DriverActions.clickElement(BY_CONF_CONTINUE_BUTTON);
            DriverActions.waitForAjaxRequestToComplete();
            WebDriverExtensions.WaitForPageLoaded(Driver);
        }

        public void ClickSaveIcon()
        {
            DriverActions.clickElement(BY_SAVE_ICON);
            DriverActions.waitForAjaxRequestToComplete();
        }

        public void EnterBuildName()
        {
            Driver.FindElement(BY_BUILD_SAVE_NAME_TXT).SendKeys(BUILD_NAME);
        }

        public void ClickLoadSavedBuildButton()
        {
            DriverActions.waitForElementVisibleAndEnabled(BY_LOAD_SAVED_BUTTON);
            DriverActions.waitForElementToBeEnabled(BY_LOAD_SAVED_BUTTON);
            DriverActions.clickElement(BY_LOAD_SAVED_BUTTON);
        }

        public bool VerifySavedBuildIsPresent()
        {
            List<IWebElement> builds = Driver.FindElements(BY_SAVED_VEHICLE_TITLE).ToList();
            bool isFound = builds.Any(x => x.Text.Equals(BUILD_NAME));
            return isFound;
        }

        public void DeleteSavedVehicle()
        {
            DriverActions.clickElement(BY_DELETE_SAVED_BUTTON);
        }

        public void ClickSaveLink()
        {
            DriverActions.clickElement(BY_BUILD_SAVE_LINK);
        }

        public void GetToBuildPage()
        {
            DriverActions.waitForElementVisibleAndEnabled(BY_FULL_SCREEN_BUTTON);
            DriverActions.waitForElementVisibleAndEnabled(BY_FLICKITY_SLIDER_BUTTON);
            Assert.IsTrue((Driver.Url).Contains("build"));
        }

        public bool IsNavigationBarDisplayed()
        {
            return DriverActions.IsElementPresent(BY_NAVIGATION_BAR);
        }

        public bool IsIconContainerDisplayed()
        {
            return DriverActions.IsElementPresent(BY_SOCIAL_MEDIA_ICON_CONTAINER);
        }

        public bool IsSummaryAccessorySocialDisplayed()
        {
            return DriverActions.IsElementPresent(BY_SUMMARY_ACCESSORY_SOCIAL);
        }

        public void ClickCalculatorIcon()
        {
            DriverActions.clickElement(BY_CALCULATOR_ICON);
            DriverActions.waitForAjaxRequestToComplete();
        }

        public void ClickMsrpField()
        {
            ClickPaymentCalculatorHeader();
            DriverActions.clickElement(BY_MSRP_FIELD);
            DriverActions.waitForAjaxRequestToComplete();
        }

        public bool IsVirtualKeyboardDisplayed()
        {
            return DriverActions.IsElementPresent(BY_VIRTUAL_KYB);
        }

        public void ClickPaymentCalculatorHeader()
        {
            DriverActions.clickElement(BY_PYMNT_CALC_HEADER);
        }

        public void ClickColorFromNavigationBar()
        {
            DriverActions.waitForElementVisibleAndEnabled(BY_NAVIGATION_COLOR);
            DriverActions.clickElement(BY_NAVIGATION_COLOR);
        }

        public void ClickTrimFromNavigationBar()
        {
            DriverActions.waitForElementVisibleAndEnabled(BY_NAVIGATION_TRIM);
            DriverActions.clickElement(BY_NAVIGATION_TRIM);
        }

        public void ClickModelsFromNavigationBar()
        {
            DriverActions.waitForElementVisibleAndEnabled(BY_NAVIGATION_MODELS);
            DriverActions.clickElement(BY_NAVIGATION_MODELS);
        }
    }
}
