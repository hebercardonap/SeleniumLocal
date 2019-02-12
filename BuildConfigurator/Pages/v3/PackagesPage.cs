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

namespace BuildConfigurator.Pages
{
    public class PackagesPage : BasePage
    {
        private static By BY_INTERIOR_LINK = PolarisSeleniumAttribute.PolarisSeleniumSelector("viewInteriorLink");
        private static By BY_EXTERIOR_LINK = PolarisSeleniumAttribute.PolarisSeleniumSelector("viewExteriorLink");
        private static By BY_PACKAGE_CATEGORY_CONTAINER = PolarisSeleniumAttribute.PolarisSeleniumSelector("buildAccessoriesCategory");
        private static By BY_ACCESSORIES_PACKAGES = PolarisSeleniumAttribute.PolarisSeleniumSelector("buildAccessoryProduct");
        private static By BY_CHILD_ADD_BUTTON = By.XPath(".//button[@data-slnm-attr='productCTA']");
        private static By BY_WHOLEGOOD_MODEL_ID = By.XPath("//div[@class='summary-vehicle-modelId']");
        private static By BY_PACKAGE_SUBPRODUCT_CARDS = By.CssSelector("div[class~='build-accessories-product-info-subproduct']");
        private static By BY_SUBPRODUCT_DETAILS_LINK = By.CssSelector("button[data-slnm-attr='packageSubProductDetailsLink']");
        private static By BY_SUBPRODUCT_INFO_DESCRIPTION = By.CssSelector("div[class='build-accessories-product-info-description']");
        private static By BY_ACCESSORY_SUBCATEGORY = By.CssSelector("div[data-slnm-attr='buildAccessoriesSubCategories'] div[class~='build-accessories-subcategory']");
        private static By BY_ACCESORIES_PRODUCT = PolarisSeleniumAttribute.PolarisSeleniumSelector("buildAccessoryProduct");
        private static By BY_PRODUCT_DETAILS_LINK = By.CssSelector("button[data-slnm-attr='productDetailsLink']");
        private static By BY_PACKAGE_INFO_DESCRIPTION = By.CssSelector("div[class='build-accessories-product-info-description']");
        private static By BY_BUTTON_TAG_NAME = By.TagName("button");

        private static Random rnd = new Random();
        public HeaderModule HeaderModule { get { return new HeaderModule(_parallelConfig); } }

        public CalculatorModule CalculatorModule { get { return new CalculatorModule(_parallelConfig); } }

        public FooterModule FooterModule { get { return new FooterModule(_parallelConfig); } }

        public Toolbar Toolbar { get { return new Toolbar(_parallelConfig); } }


        public PackagesPage(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public bool IsExteriorLinkDisplayed()
        {
            return DriverActions.IsElementPresent(BY_EXTERIOR_LINK);
        }

        public bool IsInteriorLinkDisplayed()
        {
            return DriverActions.IsElementPresent(BY_INTERIOR_LINK);
        }

        public void WaitForPackagesPageToLoad()
        {
            WebDriverExtensions.WaitForPageLoaded(Driver);
            DriverActions.waitForElementVisibleAndEnabled(BY_PACKAGE_CATEGORY_CONTAINER);
        }

        public void AddRandomAvailablePackage()
        {
            List<IWebElement> packages = Driver.FindElements(BY_ACCESSORIES_PACKAGES).ToList();
            IWebElement addButton = packages[rnd.Next(0, packages.Count)].FindElement(BY_CHILD_ADD_BUTTON);
            DriverActions.clickElement(addButton);
        }

        public string GetWholegoodModelId()
        {
            string model = Driver.FindElement(BY_WHOLEGOOD_MODEL_ID).GetAttribute("innerHTML").Trim();
            return model;
        }

        public void ClickSubProductDetailsLinkByDesc(string productName)
        {
            bool isFound = false;
            List<IWebElement> products = Driver.FindElements(BY_PACKAGE_SUBPRODUCT_CARDS).ToList();
            foreach (var product in products)
            {
                string productLabel = product.Text;
                if (stringEqualsIgnoreCase(productLabel, productName)
                    || stringContainsIgnoreCase(productLabel, productName))
                {
                    isFound = true;
                    IWebElement detailsLinks = product.FindElement(BY_SUBPRODUCT_DETAILS_LINK);
                    DriverActions.ScrollToElement(detailsLinks);
                    DriverActions.clickElement(detailsLinks);
                    break;
                }
            }
            if (!isFound)
                Assert.Fail("The product with name {0} is not present", productName);
        }

        public bool IsSubProductInfoDescDisplayed()
        {
            return DriverActions.IsElementPresent(BY_SUBPRODUCT_INFO_DESCRIPTION);
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

        public void ClickPackageDetailsLinkByDesc(string productName)
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
                Assert.Fail("The product with name {0} is not present", productName);
        }

        public bool IsPackageInfoDescDisplayed()
        {
            return DriverActions.IsElementPresent(BY_PACKAGE_INFO_DESCRIPTION);
        }
    }
}
