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
        private static By BY_BUILD_SUMMARY_DIALOG = By.XPath("//div[id='build-summary-dialog']");
        private static By BY_IAM_FINISHED_BUTTON = By.CssSelector("div[class~='summary-accessory-quote']");
        private static By BY_ACCESSORY_PRODUCT_CTA = By.XPath(".//button[@data-slnm-attr='productCTA']");

        public HeaderModule HeaderModule { get { return new HeaderModule(_parallelConfig); } }

        public CalculatorModule CalculatorModule { get { return new CalculatorModule(_parallelConfig); } }

        public FooterModule FooterModule { get { return new FooterModule(_parallelConfig); } }

        private static By BY_BUTTON_TAG_NAME = By.TagName("button");
        public AccessoriesPage(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public void WaitForColorsPageToLoad()
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
            List<IWebElement> subCategories = Driver.FindElements(BY_ACCESSORIES_SUBCATEGORIES).ToList();
            foreach (var subCategory in subCategories)
            {
                string subcategoryText = subCategory.FindElement(BY_BUTTON_TAG_NAME).Text;
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

    }
}
