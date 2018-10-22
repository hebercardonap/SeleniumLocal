using AutomationFramework.Base;
using AutomationFramework.UrlBuilderSites;
using BuildConfigurator.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BuildConfigurator.Steps
{
    [Binding]
    class BuildCategorySteps : BasePage
    {
        public BuildCategorySteps(ParallelConfig parallelConfig) : base(parallelConfig)
        {
            CurrentPage = new BuildCategoryPage(_parallelConfig);
        }

        [Given(@"I have navigated to IND build category page")]
        public void GivenIHaveNavigatedToINDBuildCategoryPage()
        {
            Driver.Navigate().GoToUrl(UrlBuilder.getIndianBuildCategoryUrl());
        }

        [When(@"I select (.*) category")]
        public void WhenISelectIndianCategory(string category)
        {
            CurrentPage.As<BuildCategoryPage>().ClickOnIndianCategory(category);
        }

        [When(@"Category models are displayed")]
        public void WhenCategoryModelsAreDisplayed()
        {
            CurrentPage.As<BuildCategoryPage>().waitForModelsDisplayed();
        }


    }
}
