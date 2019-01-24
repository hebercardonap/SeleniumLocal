using AutomationFramework.ApiUtils.ApiDataProvider;
using AutomationFramework.Base;
using AutomationFramework.Extensions;
using AutomationFramework.Utils;
using BuildConfigurator.Modules;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Pages.v2
{
    public class BuildConfigurePage : BasePage
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
        private static By BY_ACCESSORY_OVERVIEW_HEADER = By.Id("product-more-info-dialog-title");
        private static By BY_RESTART_BUILD_BUTTON = By.XPath("//div[@class='summary__header-restart']");
        private static By BY_CONF_CONTINUE_BUTTON = By.XPath("//button[contains(@class,'confirmation-build-continue')]");
        private static By BY_CONF_SAVE_BUTTON = By.XPath("//button[contains(@class,'confirmation-build-save')]");
        private static By BY_CONF_CANCEL_BUTTON = By.CssSelector("div[class*='confirmation-build-cancel'][data-dismiss='modal']");
        private static By BY_SAVE_ICON = By.XPath("//div[@class='summary-accessory-social']//button[contains(@class,'icon--save')]");
        private static By BY_BUILD_SAVE_NAME_TXT = By.Id("build-model-save-vehicle-name");
        private static By BY_BUILD_SAVE_LINK = By.CssSelector("div[class='save-actions'] div[class='save']");
        private static By BY_BUILD_CANCEL_LINK = By.CssSelector("div[class='save-actions'] div[class='cancel']");
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
        private static By BY_SAVE_BUILD_MODAL_TITLE = By.XPath("//div[@class='save-title']");

        // Accessories carousel v2
        private static By BY_ACCESORIES_HEADER = By.XPath("//div[@class='build-accessories-header']");
        private static By BY_BUILD_ACCESSORIES_CATEGORIES = By.XPath("//div[@class='build-accessories-category-header']");
        private static By BY_BUILD_ACCESSORIES_SUBCATEGORIES = By.XPath("//div[@class='build-accessories-subcategory-header']");
        private static By BY_BUILD_ACCESORIES_PRODUCTS = By.XPath("//div[@class='build-accessories-product']");
        private static By BY_BUILD_PRODUCT_LABEL = By.XPath("//div[@class='build-accessories-product-title']//label");
        private static By BY_BUILD_ACCEOSSORIES_PRODUCT_DETAILS = By.XPath(".//div[contains(@class,'build-accessories-product-details')]");
        private static By BY_BUILD_ACCESSORIES_PRODUCT_INFO = By.XPath("//div[@class='build-accessories-product-info']");
        private static By BY_BUILD_CAROUSEL_FIRST_ITEM = By.XPath("//div[@class='build-accessories-categories']//a[@class='build-accessories-category-title']");
        private static By BY_PAGE_TITLE = By.CssSelector("div[class='title']");
        private static By BY_CPQ_PAGE_HEADER = By.CssSelector("div[class='cpq-header']");
        private static By BY_CANVASS_VARIANT_DISPLAY = By.CssSelector("div[class='variant-display']");
        private static By BY_FLICKITY_SLIDER_FIRST_ITEM = By.CssSelector("div[class='flickity-slider'] button");


        private static Random rnd = new Random();
        private static IWebElement SelectedAccessoryCard;
        private static string BUTTON_TAG = "button";
        private static string ADD_TEXT = "ADD";
        private static string TITLE_ATTRIBUTE = "title";
        private static string DATE_VALUE = string.Format("{0:yyyymmddhhmmss}", DateTime.Now);
        private static string BUILD_NAME = "TEST BUILD " + DATE_VALUE;
        private static By BY_A_TAG_NAME = By.TagName("a");
        private static By BY_LABEL_TAG_NAME = By.TagName("label");
        private static By BY_BUTTON_TAG_NAME = By.TagName("button");
        private static string HTML_INNER_ATTRIBUTE = "innerHTML";

        PageHelpers _pageHelpers;
        public HeaderModule HeaderModule { get { return new HeaderModule(_parallelConfig); } }

        public CalculatorModule CalculatorModule { get { return new CalculatorModule(_parallelConfig); } }

        public FooterModule FooterModule { get { return new FooterModule(_parallelConfig); } }

        public SignInModule SignInModule { get { return new SignInModule(_parallelConfig); } }

        public AccountModule AccountModule { get { return new AccountModule(_parallelConfig); } }

        ApiDataProvider ApiDataProvider { get { return new ApiDataProvider(); } }

        public BuildConfigurePage(ParallelConfig parallelConfig) : base(parallelConfig)
        {
            _pageHelpers = new PageHelpers(parallelConfig);
        }

        public void ClickProtectionCategory()
        {
            DriverActions.clickElement(BY_PROTECTION_CATEGORY);
        }

        public void ClickRoofSubcategory()
        {
            DriverActions.clickElement(BY_ROOFS_SUBCATEGORY);
        }

        public void ClickWindShieldsSubcategory()
        {
            DriverActions.clickElement(BY_WINDSHIELDS_SUBCATEGORY);
        }

        private void GetRandomAccessoryCard()
        {
            List<IWebElement> accessoryCards;
            accessoryCards = Driver.FindElements(BY_ACCESSORY_CARD).ToList();
            SelectedAccessoryCard = accessoryCards[rnd.Next(0, accessoryCards.Count)];
        }

        public void ClickRandomAccessoryCardAddButton()
        {
            GetRandomAccessoryCard();
            IWebElement addButton = SelectedAccessoryCard.FindElement(BY_ADD_BUTTON);
            WebElementExtensions.clickElement(addButton);
        }

        public void ClickIamFinishedButton()
        {
            DriverActions.waitForElementToBeEnabled(BY_FINISHED_BUTTON);
            DriverActions.clickElement(BY_FINISHED_BUTTON);
        }

        public void ClickIamFiniShedButtonNextSteps()
        {
            DriverActions.waitForElementToBeEnabled(BY_NEXT_STEPS_FINISHED_BUTTON);
            DriverActions.clickElement(BY_NEXT_STEPS_FINISHED_BUTTON);
        }

        public void ClickIamFinishedButtonOld()
        {
            DriverActions.waitForElementToBeEnabled(BY_FINISHED_OLD_BUTTON);
            DriverActions.clickElement(BY_FINISHED_OLD_BUTTON);
        }

        public void ClickRangerTiresCategory()
        {
            DriverActions.clickElement(BY_RAN_TIRES_CATEGORY);
        }

        public void ClickRangerTrailSubcategory()
        {
            DriverActions.clickElement(BY_RAN_TRAIL_SUBCATEGORY);
        }

        public void ClickRandomAccessoryCategory()
        {
            List<IWebElement> categories = Driver.FindElements(BY_BUILD_CATEGORIES).ToList();
            WebElementExtensions.clickElement(categories[rnd.Next(0, categories.Count)]);
        }

        public void ClickRandomAccessorySubcategory()
        {
            List<IWebElement> subcategories = Driver.FindElements(BY_BUILD_SUBCATEGORIES).ToList();
            WebElementExtensions.clickElement(subcategories[rnd.Next(0, subcategories.Count)]);
        }

        public void ClickRandomAccessoryAvoidPRP()
        {
            AddRandomAccessory();
            while (true)
            {

                if (DriverActions.IsElementPresent(BY_PRP_CONTAINER))
                {
                    ClickRemoveLinkPRP();
                    AddRandomAccessory();
                }
                else
                 break;
            }
        }

        public void AddRandomAccessory()
        {
            ClickRandomAccessoryCategory();
            ClickRandomAccessorySubcategory();
            ClickRandomAccessoryCardAddButton();
        }

        public void ClickRemoveLinkPRP()
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

        public void ClickAccessoryCategory(string accessoryCategory)
        {
            List<IWebElement> categories = Driver.FindElements(BY_BUILD_CATEGORIES).ToList();
            _pageHelpers.FindMatchElementAndClick(categories, accessoryCategory);
            DriverActions.waitForAjaxRequestToComplete();
        }

        public void ClickAccessorySubCategory(string accessoryCategory)
        {
            List<IWebElement> subCategoryButtons = Driver.FindElements(BY_SUBCATEGORY_OPTIONS).ToList();
            _pageHelpers.FindMatchElementAndClick(subCategoryButtons, accessoryCategory);
            DriverActions.waitForAjaxRequestToComplete();
        }

        public void ClickSpecificAccessoryCardAddButton(string accessoryTitle)
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

        public bool IsConflictContainerDisplayed()
        {
            return DriverActions.IsElementPresent(BY_CONFLICT_CONTAINER);
        }

        public bool IsConflictHeaderDisplayed()
        {
            return DriverActions.IsElementPresent(BY_CONFLICT_HEADER);
        }

        public bool IsPRPHeaderDisplayed()
        {
            return DriverActions.IsElementPresent(BY_PART_REQUIRE_PART_HEADER);
        }

        public void ClickRandomSecondaryAccessory()
        {
            List<IWebElement> accessories = Driver.FindElements(BY_SECONDARY_ACCESSORY_SELECT_BTN).ToList();
            WebElementExtensions.clickElement(accessories[rnd.Next(0, accessories.Count)]);
        }

        public void ClickSecondaryAccessoryByProductId(string id)
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

        public void ClickOldSecondaryAccessoryByProductId(string id)
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

        public void ClickRemoveLinkByProductId(string id)
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

        public void ClickRemoveLinkByProductIdConflictContainer(string id)
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

        public void ClickBuildSummaryButton()
        {
            DriverActions.waitForElementToBeEnabled(BY_BUILD_SUMMARY_BUTTON);
            DriverActions.clickElement(BY_BUILD_SUMMARY_BUTTON);
        }

        public bool VerifyAccesoriesOnBuildSummary(string[] values)
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

        private IWebElement ClickAddAccessoryByDesc(string accessoryTitle)
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
            IWebElement element = ClickAddAccessoryByDesc(accessoryDescription);
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

        public void ClickSpecificAccessoryCardInfoButton(string accessoryTitle)
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

        public void ClickSpecificAccessoryCardImage(string accessoryTitle)
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
            DriverActions.WaitForCanvassToComplete();
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

        public void ClickSaveBuildModalSave()
        {
            DriverActions.clickElement(BY_BUILD_SAVE_LINK);
        }

        public void ClickSaveBuildModalCancel()
        {
            DriverActions.clickElement(BY_BUILD_CANCEL_LINK);
        }

        public void WaitForBuildPageToLoad()
        {
            WebDriverExtensions.WaitForPageLoaded(Driver);
            DriverActions.waitForElementVisibleAndEnabled(BY_FULL_SCREEN_BUTTON);
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
            DriverActions.waitForElementVisibleAndEnabled(BY_VIRTUAL_KYB);
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

        public bool VerifyDataPresentForCategories()
        {
            List<IWebElement> categories = Driver.FindElements(BY_BUILD_CATEGORIES).ToList();
            return categories.Count > 0;
        }

        public bool VerifyDataPresentForSubCategories()
        {
            bool isDataPresent = false;
            List<IWebElement> categories = Driver.FindElements(BY_BUILD_CATEGORIES).ToList();
            foreach (var category in categories)
            {
                isDataPresent = false;
                DriverActions.clickElement(category);
                List<IWebElement> subCategories = Driver.FindElements(BY_SUBCATEGORY_OPTIONS).ToList();
                isDataPresent = subCategories.Count > 0 ? true : false;
            }
            return isDataPresent;
        }

        public bool VerifyDataPresentForAccessoryCards()
        {
            bool isDataPresent = false;
            List<IWebElement> categories = Driver.FindElements(BY_BUILD_CATEGORIES).ToList();
            foreach (var category in categories)
            {
                DriverActions.clickElement(category);
                List<IWebElement> subCategories = Driver.FindElements(BY_SUBCATEGORY_OPTIONS).ToList();
                foreach (var subCategory in subCategories)
                {
                    isDataPresent = false;
                    DriverActions.clickElement(subCategory);
                    List<IWebElement> accessoryCards = Driver.FindElements(BY_ACCESSORY_CARD).ToList();
                    isDataPresent = subCategories.Count > 0 ? true : false;
                }
            }
            return isDataPresent;
        }

        public bool IsSaveBuildModalTitlePresent()
        {
            return DriverActions.IsElementPresent(BY_SAVE_BUILD_MODAL_TITLE);
        }

        public bool IsBuildSummaryContainerDisplayed()
        {
            return DriverActions.IsElementPresent(BY_BUILD_SUMMARY_CONTAINER);
        }


        // These methods are for the new carousel design on the build page
        public void ClickCategoryByName(string categoryName)
        {
            bool isFound = false;
            List<IWebElement> categories = Driver.FindElements(BY_BUILD_ACCESSORIES_CATEGORIES).ToList();
            foreach (var category in categories)
            {
                string categoryText = category.FindElement(BY_A_TAG_NAME).Text;
                if (stringEqualsIgnoreCase(categoryText, categoryName)
                    || stringContainsIgnoreCase(categoryText, categoryName))
                {
                    isFound = true;
                    DriverActions.clickElement(category);
                    break;
                }
            }
            if(!isFound)
                Assert.Fail("The category with name {0} is not present", categoryName);
        }

        public void ClickSubcategoryByName(string subCategoryName)
        {
            bool isFound = false;
            List<IWebElement> subCategories = Driver.FindElements(BY_BUILD_ACCESSORIES_SUBCATEGORIES).ToList();
            foreach (var subCategory in subCategories)
            {
                string subcategoryText = subCategory.FindElement(BY_A_TAG_NAME).Text;
                if ((subcategoryText.Length!=0) && (stringEqualsIgnoreCase(subcategoryText, subCategoryName)
                    || stringContainsIgnoreCase(subcategoryText, subCategoryName)))
                {
                    isFound = true;
                    DriverActions.clickElement(subCategory);
                    break;
                }
            }
            if (!isFound)
                Assert.Fail("The sub category with name {0} is not present", subCategoryName);
        }

        public void ClickAccessoryAddByProductName(string productName)
        {
            bool isFound = false;
            List<IWebElement> products = Driver.FindElements(BY_BUILD_ACCESORIES_PRODUCTS).ToList();
            foreach (var product in products)
            {
                string productLabel = product.FindElement(BY_LABEL_TAG_NAME).GetAttribute(HTML_INNER_ATTRIBUTE);
                if (stringEqualsIgnoreCase(productLabel, productName)
                    || stringContainsIgnoreCase(productLabel, productName))
                {
                    isFound = true;
                    IWebElement button = product.FindElement(BY_BUTTON_TAG_NAME);
                    DriverActions.ScrollToElement(button);
                    DriverActions.clickElement(button);
                    break;
                }
            }
            if (!isFound)
                Assert.Fail("The product with name {0} is not present", productName);
        }

        public void ClickSeeDetailsLinkByProductName(string productName)
        {
            bool isFound = false;
            List<IWebElement> products = Driver.FindElements(BY_BUILD_ACCESORIES_PRODUCTS).ToList();
            foreach (var product in products)
            {
                string productLabel = product.FindElement(BY_LABEL_TAG_NAME).GetAttribute(HTML_INNER_ATTRIBUTE);
                if (stringEqualsIgnoreCase(productLabel, productName)
                    || stringContainsIgnoreCase(productLabel, productName))
                {
                    isFound = true;
                    IWebElement link = product.FindElement(BY_BUILD_ACCEOSSORIES_PRODUCT_DETAILS);
                    DriverActions.clickElement(link);
                    break;
                }
            }
            if (!isFound)
                Assert.Fail("The product with name {0} is not present", productName);
        }

        public bool IsBuildAccessoriesProductInfoDisplayed()
        {
            return DriverActions.IsElementPresent(BY_BUILD_ACCESSORIES_PRODUCT_INFO);
        }

        public void CollapseCategoryByName(string categoryName)
        {
            bool isFound = false;
            List<IWebElement> categories = Driver.FindElements(BY_BUILD_ACCESSORIES_CATEGORIES).ToList();
            foreach (var category in categories)
            {
                if (stringEqualsIgnoreCase(categoryName, category.FindElement(BY_A_TAG_NAME).Text)
                    || stringContainsIgnoreCase(categoryName, category.FindElement(BY_A_TAG_NAME).Text))
                {
                    isFound = true;
                    DriverActions.ScrollToElement(category);
                    DriverActions.clickElement(category);
                    break;
                }
            }
            if (!isFound)
                Assert.Fail("The category with name {0} is not present", categoryName);
        }

        public void WaitforCarouselItemstoLoad()
        {
            DriverActions.waitForElementVisibleAndEnabled(BY_BUILD_CAROUSEL_FIRST_ITEM);
        }

        public string GetRandomModelColorFromApi(string brand, string year, string dealerid)
        {
            var allModels = ApiDataProvider.GetModelsColorByBrandYear(brand, year, dealerid);
            return allModels[rnd.Next(0, allModels.Count)];
        }

        public List<string> GetAllModelsColorsFromApi(string brand, string year, string dealerid)
        {
            List<string> allModelColors = ApiDataProvider.GetModelsColorByBrandYear(brand, year, dealerid);
            Assert.IsNotNull(allModelColors, "ModelColors collection is empty");

            return allModelColors;
        }

        public List<string> GetOneModelsColorsEachCategoryFromApi(string brand, string year, string dealerid)
        {
            List<string> allModelColors = ApiDataProvider.GetOneModelColorFromEachCategoryApi(brand, year, dealerid);
            Assert.IsNotNull(allModelColors, "ModelColors collection is empty");

            return allModelColors;
        }

        public List<string> Test(string brand, string year, string dealerid)
        {
            List<string> allModelColors = ApiDataProvider.BuildUrlPartial(brand, year, dealerid);
            Assert.IsNotNull(allModelColors, "ModelColors collection is empty");

            return allModelColors;
        }

        public bool IsBuildSummaryButtonDisplayed()
        {
            return DriverActions.IsElementPresent(BY_BUILD_SUMMARY_BUTTON);
        }

        public bool IsPageTitleDisplayed()
        {
            return DriverActions.IsElementPresent(BY_PAGE_TITLE);
        }

        public bool IsAccessorySectiondisplayed()
        {
            return DriverActions.IsElementPresent(BY_FLICKITY_SLIDER_FIRST_ITEM);
        }

        public bool IsCpqPageHeaderDisplayed()
        {
            return DriverActions.IsElementPresent(BY_CPQ_PAGE_HEADER);
        }

        public bool IsCanvassDisplayed()
        {
            return DriverActions.IsElementPresent(BY_CANVASS_VARIANT_DISPLAY);
        }
    }
}
