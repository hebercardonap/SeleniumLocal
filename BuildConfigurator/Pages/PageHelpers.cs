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
    public class PageHelpers : BasePage
    {
        private static string TITLE_ATTRIBUTE = "title";

        public PageHelpers(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        /// <summary>
        /// Method to find webelement based on webelement title attribute text
        /// </summary>
        /// <param name="elements">List<IWebElements></param>
        /// <param name="elementText">string to be found</param>
        public void FindMatchElementAndClick(List<IWebElement> elements, string elementTitleText)
        {
            bool isFound = false;

            foreach (var subcategory in elements)
            {
                string subCategoryName = subcategory.GetAttribute(TITLE_ATTRIBUTE);
                if (stringContainsIgnoreCase(subCategoryName, elementTitleText) 
                    || stringEqualsIgnoreCase(subCategoryName, elementTitleText))
                {
                    WebElementExtensions.clickElement(subcategory);
                    isFound = true;
                    break;
                }
            }
            if (!isFound)
                Assert.Fail("The category with name {0} is not present", elementTitleText);
        }
    }
}
