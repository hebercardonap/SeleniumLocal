using AutomationFramework.Base;
using AutomationFramework.UrlBuilderSites;
using AutomationFramework.Utils;
using BuildConfigurator.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BuildConfigurator.Steps
{
    [Binding]
    internal class ExtendedSteps : BasePage
    {

        [Given(@"I have navigated to (.*) build model page")]
        public void GivenIHaveNavigatedToBrandBuildModelPage(string brandName)
        {
            if (stringEqualsIgnoreCase(brandName, Brand.RZR))
            {
                DriverContext.Browser.GoToUrl(UrlBuilder.getRzrBuildModelUrl());
                CurrentPage = GetInstance<BuildModelPage>();
            }
            if (stringEqualsIgnoreCase(brandName, Brand.RAN))
            {
                DriverContext.Browser.GoToUrl(UrlBuilder.getRangerBuildModelUrl());
                CurrentPage = GetInstance<BuildModelPage>();
            }
        }

        [When(@"I select (.*) seat option")]
        public void WhenISelectSeatOption(string numberOfSeats)
        {
            if (numberOfSeats.Equals("one"))
                CurrentPage.As<BuildModelPage>().clickOneSeat();
            if (numberOfSeats.Equals("two"))
                CurrentPage.As<BuildModelPage>().clickTwoSeat();
            if (numberOfSeats.Equals("three"))
                CurrentPage.As<BuildModelPage>().clickThreeSeat();
            if (numberOfSeats.Equals("four"))
                CurrentPage.As<BuildModelPage>().clickFourSeat();
            if (numberOfSeats.Equals("six"))
                CurrentPage.As<BuildModelPage>().clickSixSeat();
            else
                Assert.Fail("Seat option {0} is not available", numberOfSeats);
        }


        [When(@"I click (.*) button")]
        public void WhenIClickButton(string buttonName)
        {
            if (buttonName.Equals("next"))
                CurrentPage.As<BuildColorPage>().clickNextButton();
            if (buttonName.Equals("finished"))
                CurrentPage.As<BuildConfigurePage>().clickIamFinishedButton();
            if (buttonName.Equals("getinternetprice"))
                CurrentPage.As<BuildQuotePage>().clickGetInternetPriceButton();
        }
    }
}
