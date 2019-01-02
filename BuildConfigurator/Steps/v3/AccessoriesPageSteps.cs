using AutomationFramework.Base;
using BuildConfigurator.Pages.v3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BuildConfigurator.Steps.v3
{
    [Binding]
    public class AccessoriesPageSteps : BasePage
    {
        public AccessoriesPageSteps(ParallelConfig parallelConfig) : base(parallelConfig)
        {
            _parallelConfig.CurrentPage = new AccessoriesPage(_parallelConfig);
        }

        [When(@"I wait until accessories page loads")]
        public void WhenIWaitUntilAccessoriesPageLoads()
        {
            _parallelConfig.CurrentPage.As<AccessoriesPage>().WaitForColorsPageToLoad();
        }

        [When(@"I select (.*) from category carousel")]
        public void WhenISelectAccessoryFromCategoryCarousel(string category)
        {
            _parallelConfig.CurrentPage.As<AccessoriesPage>().ClickCategoryByName(category);
        }

        [When(@"I select (.*) from subcategory carousel")]
        public void WhenISelectRoofsFromSubcategoryCarousel(string subcategory)
        {
            _parallelConfig.CurrentPage.As<AccessoriesPage>().ClickSubcategoryByName(subcategory);
        }


        [When(@"I Add (.*) from products")]
        public void WhenIAddAluminumRoof_BlackFromProducts(string product)
        {
            _parallelConfig.CurrentPage.As<AccessoriesPage>().ClickAccessoryAddByProductName(product);
        }

        [When(@"I click next button from accessories page")]
        public void WhenIClickNextButtonFromAccessoriesPage()
        {
            _parallelConfig.CurrentPage.As<AccessoriesPage>().FooterModule.ClickFooterNextButton();
        }

        [When(@"I wait until build summary is displayed")]
        public void WhenIWaitUntilBuildSummaryIsDisplayed()
        {
            _parallelConfig.CurrentPage.As<AccessoriesPage>().WaitUntilBuildSummaryIsDisplayed();
        }

        [When(@"I click finished button from build summary")]
        public void WhenIClickFinishedButtonFromBuildSummary()
        {
            _parallelConfig.CurrentPage.As<AccessoriesPage>().ClikIamFinishedButton();
        }

        [When(@"I click Next to open build summary")]
        public void WhenIClickNextToOpenBuildSummary()
        {
            _parallelConfig.CurrentPage.As<AccessoriesPage>().FooterModule.OpenBuildSummary();
        }

    }
}
