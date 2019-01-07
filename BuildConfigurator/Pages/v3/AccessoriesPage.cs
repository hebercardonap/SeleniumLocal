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


        private static string DATE_VALUE = string.Format("{0:yyyymmddhhmmss}", DateTime.Now);
        private static string BUILD_NAME = "TEST BUILD " + DATE_VALUE;

        public HeaderModule HeaderModule { get { return new HeaderModule(_parallelConfig); } }

        public CalculatorModule CalculatorModule { get { return new CalculatorModule(_parallelConfig); } }

        public FooterModule FooterModule { get { return new FooterModule(_parallelConfig); } }

        public NavigationBarModule NavigationBarModule { get { return new NavigationBarModule(_parallelConfig); } }

        public SignInModule SignInModule { get { return new SignInModule(_parallelConfig); } }

        public AccountModule AccountModule { get { return new AccountModule(_parallelConfig); } }

        private static By BY_BUTTON_TAG_NAME = By.TagName("button");
        public AccessoriesPage(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public void WaitForAccessoriesPageToLoad()
        {
            WebDriverExtensions.WaitForPageLoaded(Driver);
            DriverActions.waitForElementVisibleAndEnabled(BY_ACCESSORIES_CATEGORIES);
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
                    break;
                }
            }
            if (!isFound)
                Assert.Fail("The category with name {0} is not present", categoryName);
        }

        public void ClickSubcategoryByName(string subCategoryName)
        {
            bool isFound = false;
            List<IWebElement> subCategories = Driver.FindElements(BY_ACCESSORY_SUBCATEGORY).ToList();
            foreach (var subCategory in subCategories)
            {
                string subcategoryText = subCategory.FindElement(BY_BUTTON_TAG_NAME).Text.Trim();
                if ((subcategoryText.Length != 0) && (stringEqualsIgnoreCase(subcategoryText, subCategoryName)
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
                    break;
                }
            }
            if (!isFound)
                Assert.Fail("The product with name {0} is not present", productName);
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

    }
}
