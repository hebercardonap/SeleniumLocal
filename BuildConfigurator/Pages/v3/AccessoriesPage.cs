﻿using AutomationFramework.Base;
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

namespace BuildConfigurator.Pages.v3
{
    public class AccessoriesPage : BasePage
    {
        //private static By BY_ACCESSORIES_CATEGORIES = PolarisSeleniumAttribute.PolarisSeleniumSelector("buildAccessoriesCategories");
        private static By BY_ACCESSORIES_CATEGORIES = By.CssSelector("div[class~='build-accessories-category']");
        private static By BY_ACCESSORIES_SUBCATEGORIES = PolarisSeleniumAttribute.PolarisSeleniumSelector("buildAccessoriesSubCategories");
        private static By BY_ACCESORIES_PRODUCTS = PolarisSeleniumAttribute.PolarisSeleniumSelector("buildAccessoriesProducts");
        private static By BY_ACCESORIES_PRODUCT = PolarisSeleniumAttribute.PolarisSeleniumSelector("buildAccessoryProduct");
        private static By BY_PRODUCT_TITLE_LABEL = PolarisSeleniumAttribute.PolarisSeleniumSelector("productTitleLabel");
        private static By BY_CHILD_PRODUCT_TITLE_LABEL = By.XPath(".//div[data-slnm-attr='productTitleLabel']");
        private static By BY_BUILD_SUMMARY_DIALOG = By.XPath("//div[@id='build-summary-dialog']");
        private static By BY_IAM_FINISHED_BUTTON = By.CssSelector("div[class~='summary-accessory-quote']");
        private static By BY_ACCESSORY_PRODUCT_CTA = By.XPath(".//button[@data-slnm-attr='productCTA']");
        private static By BY_ACCESSORY_SUBCATEGORY = By.CssSelector("div[data-slnm-attr='buildAccessoriesSubCategories'] div[class~='build-accessories-subcategory']");
        private static By BY_BUILD_SAVE_NAME_TXT = By.Id("build-model-save-vehicle-name");
        private static By BY_SAVED_VEHICLE_TITLE = By.XPath("//div[contains(@class,'saved-vehicles')]//div[contains(@class,'saved-vehicle__title')]");
        private static By BY_BUILD_SAVE_LINK = By.CssSelector("div[class='save-actions'] div[class='save']");
        private static By BY_DELETE_SAVED_BUTTON = By.XPath("//button[contains(@class,'saved-vehicle__delete')]");
        private static By BY_PRP_CONTAINER = By.XPath("//div[@class='part-require-part-container']");
        private static By BY_PRP_PRIMARY_PART_REMOVE_LINK = By.CssSelector("div[class='part-require-part-primaryPart'] div[class~='summary-accessory-info-remove']");
        private static By BY_PRP_SECONDARY_PART_SELECT = By.CssSelector("div[class='part-require-part-secondaryParts'] div[class~='summary-accessory-info-remove']");
        private static By BY_PRP_SECONDARY_PART_DESC = By.CssSelector("div[class~='summary-accessory-info-text'] div:nth-child(1)");
        private static By BY_PRP_SECONDARY_PART_NUMBER = By.CssSelector("div[class~='summary-accessory-info-text'] div:nth-child(2)");
        private static By BY_PRP_SECONDARY_PARTS = PolarisSeleniumAttribute.PolarisSeleniumSelector("partRequirePartSecondaryPart");
        private static By BY_PRP_SECONDARY_SELECT_CHILD = By.XPath(".//div[contains(@class,'summary-accessory-info-remove')]");
        private static By BY_CONFLICT_CONTAINER = By.XPath("//div[@class='conflict-container']");
        private static By BY_CONFLICT_ITEMS = By.CssSelector("div[class='conflict-container'] div[class~='summary-accessory-info']");
        private static By BY_BUILD_SUMMARY_NOTES = By.XPath("//div[@class='summary-notes']");
        private static By BY_BUILD_SUMMARY_ACCESSORIES_DESC = By.CssSelector("div[data-slnm-attr='summaryAccessoryDescription']");
        private static By BY_BUILD_SUMMARY_ACCESORIES = By.CssSelector("div[class~='summary-accessory-info']");
        private static By BY_BUILD_SUMMARY_REMOVE_LINK = By.CssSelector("div[data-slnm-attr='summaryAccessoryCTA']");
        private static By BY_BUILD_SUMMARY_SAVE_ICON = By.CssSelector("button[class*='icon--save']");
        private static By BY_BUILD_SUMMARY_EMAIL_ICON = By.CssSelector("button[class*='icon--email']");
        private static By BY_BUILD_SUMMARY_PRINT_ICON = By.CssSelector("button[class*='icon--print']");
        private static By BY_CONFIRMATION_BUILD_CONTENT = By.XPath("//restart-build//div[@class='confirmation-build-content']");
        private static By BY_CONFIRMATION_BUILD_CONTINUE = By.CssSelector("button[class*='continue']");
        private static By BY_CONFIRMATION_BUILD_SAVE = By.XPath("//restart-build//button[contains(@class,'save')]");
        private static By BY_SUMMARY_ACCESSORY_CTA = By.CssSelector("div[data-slnm-attr='summaryAccessoryCTA']");
        private static By BY_KIT_PACKAGE_CARET = By.CssSelector("button[class='kit-package-item']");
        private static By BY_PRODUCT_DETAILS_LINK = By.CssSelector("button[data-slnm-attr='productDetailsLink']");
        private static By BY_PRODUCT_INFO_DESCRIPTION = By.CssSelector("div[class='build-accessories-product-info-description']");
        private static By BY_KIT_PACKAGE_SUMMARY_INFO = By.CssSelector("div[class='kit-package__header summary-accessory-info']");
        private static By BY_CHOOSE_ACCESSORIES_TITLE = PolarisSeleniumAttribute.PolarisSeleniumSelector("chooseAccessoriesTitle");
        private static By BY_SUBCATEGORY_TITLE = By.CssSelector("button[class='build-accessories-subcategory-title']");
        private static By BY_SUMMARY_NOTES_TEXTBOX = By.Id("summary-notes");
        private static By BY_SUMMARY_NOTES_VIRTUAL_KEYBOARD = By.Id("summary-notes_keyboard");
        

        private static string DATE_VALUE = string.Format("{0:yyyymmddhhmmss}", DateTime.Now);
        private static string BUILD_NAME = "TEST BUILD " + DATE_VALUE;

        public HeaderModule HeaderModule { get { return new HeaderModule(_parallelConfig); } }

        public CalculatorModule CalculatorModule { get { return new CalculatorModule(_parallelConfig); } }

        public FooterModule FooterModule { get { return new FooterModule(_parallelConfig); } }

        public NavigationBarModule NavigationBarModule { get { return new NavigationBarModule(_parallelConfig); } }

        public SignInModule SignInModule { get { return new SignInModule(_parallelConfig); } }

        public AccountModule AccountModule { get { return new AccountModule(_parallelConfig); } }

        public Toolbar Toolbar { get { return new Toolbar(_parallelConfig); } }

        private static By BY_BUTTON_TAG_NAME = By.TagName("button");
        public AccessoriesPage(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public void WaitForAccessoriesPageToLoad()
        {
            WebDriverExtensions.WaitForPageLoaded(Driver);
            DriverActions.waitForElementVisibleAndEnabled(BY_ACCESSORIES_CATEGORIES);
            DriverActions.WaitForCanvassToComplete();
        }

        public void ClickCategoryByName(string categoryName)
        {
            bool isFound = false;
            List<IWebElement> categories = Driver.FindElements(BY_ACCESSORIES_CATEGORIES).ToList();
            foreach (var category in categories)
            {
                string categoryText = category.FindElement(BY_BUTTON_TAG_NAME).Text;
                if (stringEqualsIgnoreCase(categoryText, categoryName)
                    || stringContainsIgnoreCase(categoryText, categoryName))
                {
                    isFound = true;
                    DriverActions.clickElement(category);
                    DriverActions.waitForAjaxRequestToComplete();
                    break;
                }
            }
            if (!isFound)
                throw new NoSuchElementException(string.Format("Category with name {0} was not found for model {1}"
                    , categoryName, Driver.Url));
        }

        public void ClickSubcategoryByName(string subCategoryName)
        {
            bool isFound = false;
            List<IWebElement> subCategories = Driver.FindElements(BY_SUBCATEGORY_TITLE).ToList();
            foreach (var subCategory in subCategories)
            {
                string subcategoryText = subCategory.Text;
                if ((subcategoryText.Length != 0) && (stringEqualsIgnoreCase(subcategoryText, subCategoryName)
                    || stringContainsIgnoreCase(subcategoryText, subCategoryName)))
                {
                    isFound = true;
                    DriverActions.clickElement(subCategory);
                    DriverActions.waitForAjaxRequestToComplete();
                    break;
                }
            }
            if (!isFound)
                throw new NoSuchElementException(string.Format("Sub category with name {0} was not found for model {1}"
                    , subCategoryName, Driver.Url));
        }

        public void ClickAccessoryAddByProductName(string productName)
        {
            bool isFound = false;
            List<IWebElement> products = Driver.FindElements(BY_ACCESORIES_PRODUCT).ToList();
            foreach (var product in products)
            {
                string productLabel = product.Text;
                if (stringEqualsIgnoreCase(productLabel, productName)
                    || stringContainsIgnoreCase(productLabel, productName))
                {
                    isFound = true;
                    IWebElement button = product.FindElement(BY_ACCESSORY_PRODUCT_CTA);
                    DriverActions.ScrollToElement(button);
                    DriverActions.clickElement(button);
                    DriverActions.waitForAjaxRequestToComplete();
                    break;
                }
            }
            if (!isFound)
                throw new NoSuchElementException(string.Format("Product with name {0} was not found for model {1}"
                    , productName, Driver.Url));
        }

        public void ClickProductDetailsLinkByDesc(string productName)
        {
            bool isFound = false;
            List<IWebElement> products = Driver.FindElements(BY_ACCESORIES_PRODUCT).ToList();
            foreach (var product in products)
            {
                string productLabel = product.Text;
                if (stringEqualsIgnoreCase(productLabel, productName)
                    || stringContainsIgnoreCase(productLabel, productName))
                {
                    isFound = true;
                    IWebElement detailsLinks = product.FindElement(BY_PRODUCT_DETAILS_LINK);
                    DriverActions.ScrollToElement(detailsLinks);
                    DriverActions.clickElement(detailsLinks);
                    break;
                }
            }
            if (!isFound)
                throw new NoSuchElementException(string.Format("Product with name {0} was not found for model {1}",
                    productName, Driver.Url));
        }

        public void WaitUntilBuildSummaryIsDisplayed()
        {
            WebDriverExtensions.WaitForPageLoaded(Driver);
            DriverActions.waitForElementVisibleAndEnabled(BY_BUILD_SUMMARY_DIALOG);
        }

        public void ClikIamFinishedButton()
        {
            DriverActions.clickElement(BY_IAM_FINISHED_BUTTON);
        }

        public void EnterBuildName()
        {
            Driver.FindElement(BY_BUILD_SAVE_NAME_TXT).SendKeys(BUILD_NAME);
        }

        public bool VerifySavedBuildIsPresent()
        {
            List<IWebElement> builds = Driver.FindElements(BY_SAVED_VEHICLE_TITLE).ToList();
            bool isFound = builds.Any(x => x.Text.Equals(BUILD_NAME));
            return isFound;
        }

        public void ClickSaveBuildModalSave()
        {
            DriverActions.clickElement(BY_BUILD_SAVE_LINK);
        }

        public void DeleteSavedVehicle()
        {
            DriverActions.clickElement(BY_DELETE_SAVED_BUTTON);
            DriverActions.waitForAjaxRequestToComplete();
        }

        public bool IsPrpContainerDisplayed()
        {
            WaitForPrpContainerToLoad();
            return DriverActions.IsElementPresent(BY_PRP_CONTAINER);
        }

        public void WaitForPrpContainerToLoad()
        {
            DriverActions.waitForElementVisibleAndEnabled(BY_PRP_CONTAINER);
        }

        public void ClickPrpPrimaryPartRemoveLink()
        {
            DriverActions.clickElement(BY_PRP_PRIMARY_PART_REMOVE_LINK);
        }

        public void ClickPrpSecondaryPartSelectByProductId(string productId)
        {
            List<IWebElement> secondaryParts = Driver.FindElements(BY_PRP_SECONDARY_PARTS).ToList();

            foreach (var part in secondaryParts)
            {
                string productString = part.FindElement(BY_PRP_SECONDARY_PART_NUMBER).Text;
                string product = productString.Substring(productString.LastIndexOf("#") + 1);

                if (stringEqualsIgnoreCase(product, productId) || stringContainsIgnoreCase(product, productId))
                {
                    IWebElement select = part.FindElement(BY_PRP_SECONDARY_SELECT_CHILD);
                    DriverActions.clickElement(select);
                    break;
                }
            }
        }

        public void ClickPrpSecondaryPartSelectByDesc(string productDesc)
        {
            List<IWebElement> secondaryParts = Driver.FindElements(BY_PRP_SECONDARY_PARTS).ToList();

            foreach (var part in secondaryParts)
            {
                string productString = part.FindElement(BY_PRP_SECONDARY_PART_DESC).Text;
                //string product = productString.Substring(productString.LastIndexOf("#") + 1);

                if (stringEqualsIgnoreCase(productString, productDesc) || stringContainsIgnoreCase(productString, productDesc))
                {
                    IWebElement select = part.FindElement(BY_PRP_SECONDARY_SELECT_CHILD);
                    DriverActions.clickElement(select);
                    break;
                }
            }
        }

        public bool AreProductIdsAddedBuildSummary(List<string> products)
        {
            bool isFound = false;
            List<IWebElement> summaryProductIds = Driver.FindElements(BY_PRP_SECONDARY_PART_NUMBER).ToList();
            foreach (var product in products)
            {
                foreach (var item in summaryProductIds)
                {
                    string productString = item.Text;
                    string id = productString.Substring(productString.LastIndexOf("#") + 1);

                    if (stringEqualsIgnoreCase(product, id))
                    {
                        isFound = true;
                        break;
                    }
                    else
                        isFound = false;
                }
            }
            return isFound;
        }

        public bool IsProductIdsAddedBuildSummary(string productId)
        {
            bool isFound = false;
            List<IWebElement> summaryProductIds = Driver.FindElements(BY_PRP_SECONDARY_PART_NUMBER).ToList();

            foreach (var item in summaryProductIds)
            {
                string productString = item.Text;
                string id = productString.Substring(productString.LastIndexOf("#") + 1);

                if (stringEqualsIgnoreCase(productId, id))
                {
                    isFound = true;
                    break;
                }
                else
                    isFound = false;
            }
            return isFound;
        }

        public bool IsConflictContainerDisplayed()
        {
            return DriverActions.IsElementPresent(BY_CONFLICT_CONTAINER);
        }

        public void ClickConflictingItemRemoveByDesc(string description)
        {
            bool isFound = false;
            List<IWebElement> items = Driver.FindElements(BY_CONFLICT_ITEMS).ToList();

            foreach (var item in items)
            {
                string itemDesc = item.FindElement(BY_PRP_SECONDARY_PART_DESC).Text;
                if (itemDesc.Length > 0 && stringContainsIgnoreCase(itemDesc, description))
                {
                    IWebElement remove = item.FindElement(BY_PRP_SECONDARY_SELECT_CHILD);
                    DriverActions.clickElement(remove);
                    isFound = true;
                    break;
                }
            }
            if (!isFound)
                Assert.Fail("Accessory passed {0} is not present on the conflict container", description);
        }

        public void WaitforConflictContainerToLoad()
        {
            DriverActions.waitForElementVisibleAndEnabled(BY_CONFLICT_CONTAINER);
        }

        public bool IsSummaryAdditionalNotesDisplayed()
        {
            return DriverActions.IsElementPresent(BY_BUILD_SUMMARY_NOTES);
        }

        public bool AreProductDescPresentBuildSummary(List<string> products)
        {
            bool isFound = false;
            List<IWebElement> summaryProductIds = Driver.FindElements(BY_PRP_SECONDARY_PART_DESC).ToList();
            foreach (var product in products)
            {
                foreach (var item in summaryProductIds)
                {
                    string productDesc = item.Text;

                    if (stringContainsIgnoreCase(productDesc, product))
                    {
                        isFound = true;
                        break;
                    }
                    else
                        isFound = false;
                }
            }
            return isFound;
        }

        public bool IsProductDescPresentBuildSummary(string productDesc)
        {
            bool isFound = false;
            List<IWebElement> summaryProductIds = Driver.FindElements(BY_PRP_SECONDARY_PART_DESC).ToList();

            foreach (var item in summaryProductIds)
            {
                string description = item.GetAttribute("innerHTML");

                if (description.Length > 0 && stringContainsIgnoreCase(description, productDesc))
                {
                    isFound = true;
                    break;
                }
                else
                    isFound = false;
            }
            return isFound;
        }

        public bool IsKitPackageDescPresentBuildSummary(string kitPackage)
        {
            bool isFound = false;
            List<IWebElement> summaryProductIds = Driver.FindElements(BY_KIT_PACKAGE_SUMMARY_INFO).ToList();

            foreach (var item in summaryProductIds)
            {
                string description = item.Text;

                if (description.Length > 0 && stringContainsIgnoreCase(description, kitPackage))
                {
                    isFound = true;
                    break;
                }
                else
                    isFound = false;
            }
            return isFound;
        }

        public void RemoveAccessoryFromSummaryByDesc(string description)
        {
            bool isFound = false;
            List<IWebElement> accessories = Driver.FindElements(BY_BUILD_SUMMARY_ACCESORIES).ToList();

            foreach (var item in accessories)
            {
                string desc = item.FindElement(BY_PRP_SECONDARY_PART_DESC).Text;
                if (stringContainsIgnoreCase(desc, description))
                {
                    IWebElement remove = item.FindElement(BY_BUILD_SUMMARY_REMOVE_LINK);
                    DriverActions.clickElement(remove);
                    isFound = true;
                    break;
                }
                else
                    isFound = false;
            }
            if(!isFound)
                Assert.Fail("Accessory passed {0} is not present on the build summary", description);
        }

        public bool IsSummarySaveIconDisplayed()
        {
            return DriverActions.IsElementPresent(BY_BUILD_SUMMARY_SAVE_ICON);
        }

        public bool IsSummaryEmailIconDisplayed()
        {
            return DriverActions.IsElementPresent(BY_BUILD_SUMMARY_EMAIL_ICON);
        }

        public bool IsSummaryPrintIconDisplayed()
        {
            return DriverActions.IsElementPresent(BY_BUILD_SUMMARY_PRINT_ICON);
        }

        public void WaitForConfirmationBuildToLoad()
        {
            DriverActions.waitForElementVisibleAndEnabled(BY_CONFIRMATION_BUILD_CONTENT);
        }

        public void ClickConfirmationBuildContinueButton()
        {
            WaitForConfirmationBuildToLoad();
            DriverActions.clickElement(BY_CONFIRMATION_BUILD_CONTINUE);
        }

        public void ClickKitPackageDropDown()
        {
            DriverActions.clickElement(BY_KIT_PACKAGE_CARET);
        }

        public bool IsProductInfoDescDisplayed()
        {
            return DriverActions.IsElementPresent(BY_PRODUCT_INFO_DESCRIPTION);
        }

        public bool IsChooseAccessoriesTitleDisplayed()
        {
            return DriverActions.IsElementPresent(BY_CHOOSE_ACCESSORIES_TITLE);
        }

        public void VerifyAccessoriesPageORVUIElements()
        {
            Assert.IsTrue(IsChooseAccessoriesTitleDisplayed(), "Accessories page title is not present");
            Assert.IsTrue(HeaderModule.IsNavigationBarBrandNameDisplayed(), "Navigation bar is not displayed");
            Assert.IsTrue(HeaderModule.IsHeaderSignInIconDisplayed(), "Header Sign in is not present");
            Assert.IsTrue(HeaderModule.IsAccountHeaderIconDisplayed(), "Account icon is not displayed");
            Assert.IsTrue(Toolbar.IsToolbarDisplayed(), "Toolbar is not displayed");
            Assert.IsTrue(FooterModule.IsNextOpenBuildSummaryDisplayed(), "Build Summary/Next button not displayed");
            Assert.IsTrue(FooterModule.IsPaymentCalculatorDisplayed(), "Payment calculator is not displayed");
            Assert.IsTrue(FooterModule.IsStartingPriceDisplayed(), "Starting price is not displayed");
        }

        public void VerifyAccessoriesPageGEMUIElements()
        {
            Assert.IsTrue(IsChooseAccessoriesTitleDisplayed(), "Accessories page title is not present");
            Assert.IsTrue(HeaderModule.IsNavigationBarBrandNameDisplayed(), "Navigation bar is not displayed");
            Assert.IsTrue(HeaderModule.IsHeaderSignInIconDisplayed(), "Header Sign in is not present");
            Assert.IsTrue(HeaderModule.IsAccountHeaderIconDisplayed(), "Account icon is not displayed");
            Assert.IsTrue(Toolbar.IsToolbarDisplayed(), "Toolbar is not displayed");
            Assert.IsTrue(FooterModule.IsNextOpenBuildSummaryDisplayed(), "Build Summary/Next button not displayed");
            Assert.IsTrue(FooterModule.IsStartingPriceDisplayed(), "Starting price is not displayed");
        }

        public void ClickSummaryNotesTextbox()
        {
            DriverActions.clickElement(BY_BUILD_SUMMARY_NOTES);
            DriverActions.waitForAjaxRequestToComplete();
        }

        public bool IsSummaryNotesVirtualKeyboardDisplayed()
        {
            return DriverActions.IsElementPresent(BY_SUMMARY_NOTES_VIRTUAL_KEYBOARD);
        }
    }
}
