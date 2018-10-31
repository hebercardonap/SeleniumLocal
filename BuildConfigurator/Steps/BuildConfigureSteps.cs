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
    class BuildConfigureSteps : BasePage
    {
        public BuildConfigureSteps(ParallelConfig parallelConfig) : base(parallelConfig)
        {
           _parallelConfig.CurrentPage = new BuildConfigurePage(_parallelConfig);
        }
        [When(@"I add random accessory")]
        public void ThenIAddRandomAccessory()
        {
            _parallelConfig.CurrentPage.As<BuildConfigurePage>().clickProtectionCategory();
            _parallelConfig.CurrentPage.As<BuildConfigurePage>().clickRoofSubcategory();
            _parallelConfig.CurrentPage.As<BuildConfigurePage>().clickRandomAccessoryCardAddButton();
        }

        [When(@"I add widshield accessory")]
        public void WhenIAddWidshieldAccessory()
        {
            _parallelConfig.CurrentPage.As<BuildConfigurePage>().clickProtectionCategory();
            _parallelConfig.CurrentPage.As<BuildConfigurePage>().clickWindShieldsSubcategory();
            _parallelConfig.CurrentPage.As<BuildConfigurePage>().clickRandomAccessoryCardAddButton();
        }

        [When(@"I add random ranger tires accessory")]
        public void WhenIAddRandomRangerTiresAccessory()
        {
            _parallelConfig.CurrentPage.As<BuildConfigurePage>().clickRangerTiresCategory();
            _parallelConfig.CurrentPage.As<BuildConfigurePage>().clickRangerTrailSubcategory();
            _parallelConfig.CurrentPage.As<BuildConfigurePage>().clickRandomAccessoryCardAddButton();
        }

        [When(@"I add random accessory avoid PRP")]
        public void WhenIAddRandomAccessoryAvoidPRP()
        {
            _parallelConfig.CurrentPage.As<BuildConfigurePage>().clickRandomAccessoryAvoidPRP();
        }

        [When(@"I click (.*) accessory category")]
        public void WhenIClickAccessoryCategory(string accessoryCategory)
        {
            _parallelConfig.CurrentPage.As<BuildConfigurePage>().clickAccessoryCategory(accessoryCategory);
            DriverActions.waitForAjaxRequestToComplete();
        }

        [When(@"I click (.*) accessory subcategory")]
        public void WhenIClickAccessorySubcategory(string accessorySubcategory)
        {
            _parallelConfig.CurrentPage.As<BuildConfigurePage>().clickAccessorySubCategory(accessorySubcategory);
            DriverActions.waitForAjaxRequestToComplete();
        }

        [When(@"I add random available accessory")]
        public void WhenIAddRandomAvailableAccessory()
        {
            _parallelConfig.CurrentPage.As<BuildConfigurePage>().clickRandomAccessoryCardAddButton();
        }

        [When(@"I add specific (.*) accessory")]
        public void WhenIAddSpecificAccessory(string accesoryName)
        {
            _parallelConfig.CurrentPage.As<BuildConfigurePage>().clickSpecificAccessoryCardAddButton(accesoryName);
            DriverActions.waitForAjaxRequestToComplete();
        }

        [Then(@"Conflict container is displayed")]
        public void ThenConflictContainerIsDisplayed()
        {
            Assert.IsTrue(_parallelConfig.CurrentPage.As<BuildConfigurePage>().isConflictContainerDisplayed());
            Assert.IsTrue(_parallelConfig.CurrentPage.As<BuildConfigurePage>().isConflictHeaderDisplayed());
        }

        [When(@"I select random secondary accessory")]
        public void WhenISelectRandomSecondaryAccessory()
        {
            _parallelConfig.CurrentPage.As<BuildConfigurePage>().clickRandomSecondaryAccessory();
        }

        [When(@"PRP container is displayed")]
        [Then(@"PRP container is displayed")]
        public void WhenPRPContainerIsDisplayed()
        {
            Assert.IsTrue(_parallelConfig.CurrentPage.As<BuildConfigurePage>().isPRPHeaderDisplayed());
        }

        [When(@"Accessories '(.*)' are displayed in build summary")]
        [Then(@"Accessories '(.*)' are displayed in build summary")]
        public void ThenAccessoriesAreDisplayedInBuildSummary(string[] values)
        {
            Assert.IsTrue(_parallelConfig.CurrentPage.As<BuildConfigurePage>().verifyAccesoriesOnBuildSummary(values),
                "ID passed is not present on the build summary container");
        }

        [Then(@"Accessories '(.*)' is not displayed in build summary")]
        public void ThenAccessoriesIsNotDisplayedInBuildSummary(string[] values)
        {
            Assert.IsFalse(_parallelConfig.CurrentPage.As<BuildConfigurePage>().verifyAccesoriesOnBuildSummary(values),
                "Product ID is still present on the build summary container");
        }


        [When(@"I select accessory by product ID (.*)")]
        public void WhenISelectAccessoryByProductID(string id)
        {
            _parallelConfig.CurrentPage.As<BuildConfigurePage>().clickSecondaryAccessoryByProductId(id);
        }

        [When(@"I select accessory old version by product ID (.*)")]
        public void WhenISelectAccessoryOldVersionByProductID(string id)
        {
            _parallelConfig.CurrentPage.As<BuildConfigurePage>().clickOldSecondaryAccessoryByProductId(id);
        }

        [When(@"I remove product id (.*) from build summary")]
        public void WhenIRemoveProductIdFromBuildSummary(string id)
        {
            _parallelConfig.CurrentPage.As<BuildConfigurePage>().clickRemoveLinkByProductId(id);
        }

        [Then(@"After adding (.*) remove button is displayed")]
        public void ThenAfterAddingWinchCoverKitRemoveButtonIsDisplayed(string accessoryAdded)
        {
            Assert.IsTrue(_parallelConfig.CurrentPage.As<BuildConfigurePage>().AddAccessoryAndVerifyRemoveButtonDisplayed(accessoryAdded));
        }

        [Then(@"After removing (.*) remove button is hidden")]
        public void ThenAfterRemovingSportRoofRemoveButtonIsDisplayed(string accessoryRemoved)
        {
            Assert.IsFalse(_parallelConfig.CurrentPage.As<BuildConfigurePage>().IsRemoveButtonDisplayedForAccessoryDesc(accessoryRemoved));
        }


        [When(@"I click info button for (.*) accessory")]
        public void WhenIClickInfoButtonForAccesAccessory(string accessoryDescription)
        {
            _parallelConfig.CurrentPage.As<BuildConfigurePage>().clickSpecificAccessoryCardInfoButton(accessoryDescription);

        }

        [When(@"I click image with description (.*)")]
        public void WhenIClickImageWithDescription(string accessoryDescription)
        {
            _parallelConfig.CurrentPage.As<BuildConfigurePage>().clickSpecificAccessoryCardImage(accessoryDescription);
        }

        [Then(@"Accessory (.*) overview opens up")]
        public void ThenAccessoryOverviewOpensUp(string accessoryDescription)
        {
            Assert.IsTrue(_parallelConfig.CurrentPage.As<BuildConfigurePage>().IsAccessoryOverViewDisplayed(accessoryDescription));
        }

        [When(@"I click Save icon")]
        public void WhenIClickSaveIcon()
        {
            _parallelConfig.CurrentPage.As<BuildConfigurePage>().ClickSaveIcon();
        }

        [When(@"I enter build name")]
        public void WhenIEnterBuildName()
        {
            _parallelConfig.CurrentPage.As<BuildConfigurePage>().EnterBuildName();
        }

        [Then(@"Newly saved build is loaded")]
        public void ThenNewlySavedBuildIsLoaded()
        {
            Assert.IsTrue(_parallelConfig.CurrentPage.As<BuildConfigurePage>().VerifySavedBuildIsPresent());
            _parallelConfig.CurrentPage.As<BuildConfigurePage>().DeleteSavedVehicle();
        }

        [When(@"I get to build page")]
        public void ThenIGetToBuildPage()
        {
            _parallelConfig.CurrentPage.As<BuildConfigurePage>().GetToBuildPage();
        }

        [When(@"DEX build page specific elements are hidden")]
        public void ThenDEXBuildPageSpecificElementsAreHidden()
        {
            Assert.IsFalse(_parallelConfig.CurrentPage.As<BuildConfigurePage>().IsNavigationBarDisplayed());
            Assert.IsFalse(_parallelConfig.CurrentPage.As<BuildConfigurePage>().IsIconContainerDisplayed());
        }

        [Then(@"summary accessory social icons are not displayed")]
        public void ThenSummaryAccessorySocialIconsAreNotDisplayed()
        {
            Assert.IsFalse(_parallelConfig.CurrentPage.As<BuildConfigurePage>().IsSummaryAccessorySocialDisplayed());
        }



    }
}
