using AutomationFramework.Base;
using BuildConfigurator.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BuildConfigurator.Steps
{
    [Binding]
    class BuildConfigureSteps : BaseStep
    {
        public BuildConfigureSteps()
        {
            CurrentPage = GetInstance<BuildConfigurePage>();
        }
        [When(@"I add random accessory")]
        public void ThenIAddRandomAccessory()
        {
            CurrentPage.As<BuildConfigurePage>().clickProtectionCategory();
            CurrentPage.As<BuildConfigurePage>().clickRoofSubcategory();
            CurrentPage.As<BuildConfigurePage>().clickRandomAccessoryCardAddButton();
        }

        [When(@"I add widshield accessory")]
        public void WhenIAddWidshieldAccessory()
        {
            CurrentPage.As<BuildConfigurePage>().clickProtectionCategory();
            CurrentPage.As<BuildConfigurePage>().clickWindShieldsSubcategory();
            CurrentPage.As<BuildConfigurePage>().clickRandomAccessoryCardAddButton();
        }

        [When(@"I add random ranger tires accessory")]
        public void WhenIAddRandomRangerTiresAccessory()
        {
            CurrentPage.As<BuildConfigurePage>().clickRangerTiresCategory();
            CurrentPage.As<BuildConfigurePage>().clickRangerTrailSubcategory();
            CurrentPage.As<BuildConfigurePage>().clickRandomAccessoryCardAddButton();
        }

        [When(@"I add random accessory avoid PRP")]
        public void WhenIAddRandomAccessoryAvoidPRP()
        {
            CurrentPage.As<BuildConfigurePage>().clickRandomAccessoryAvoidPRP();
        }

        [When(@"I click (.*) accessory category")]
        public void WhenIClickAccessoryCategory(string accessoryCategory)
        {
            CurrentPage.As<BuildConfigurePage>().clickAccessoryCategory(accessoryCategory);
        }

        [When(@"I click (.*) accessory subcategory")]
        public void WhenIClickAccessorySubcategory(string accessorySubcategory)
        {
            CurrentPage.As<BuildConfigurePage>().clickAccessorySubCategory(accessorySubcategory);
        }

        [When(@"I add random available accessory")]
        public void WhenIAddRandomAvailableAccessory()
        {
            CurrentPage.As<BuildConfigurePage>().clickRandomAccessoryCardAddButton();
        }

        [When(@"I add specific (.*) accessory")]
        public void WhenIAddSpecificAccessory(string accesoryName)
        {
            CurrentPage.As<BuildConfigurePage>().clickSpecificAccessoryCardAddButton(accesoryName);
        }

        [Then(@"Conflict container is displayed")]
        public void ThenConflictContainerIsDisplayed()
        {
            Assert.IsTrue(CurrentPage.As<BuildConfigurePage>().isConflictContainerDisplayed());
            Assert.IsTrue(CurrentPage.As<BuildConfigurePage>().isConflictHeaderDisplayed());
        }

    }
}
