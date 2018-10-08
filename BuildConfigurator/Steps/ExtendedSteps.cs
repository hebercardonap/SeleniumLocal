using AutomationFramework.Base;
using AutomationFramework.UrlBuilderSites;
using AutomationFramework.Utils;
using BuildConfigurator.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace BuildConfigurator.Steps
{
    [Binding]
    internal class ExtendedSteps : BasePage
    {
        private static string ONE = "one";
        private static string TWO = "two";
        private static string THREE = "three";
        private static string FOUR = "four";
        private static string SIX = "six";

        [Given(@"I have navigated to (.*) build model page")]
        public void GivenIHaveNavigatedToBrandBuildModelPage(string brandName)
        {
            if (stringEqualsIgnoreCase(brandName, Brand.RZR))
            {
                DriverContext.Browser.GoToUrl(UrlBuilder.getRzrBuildModelUrl());
                CurrentPage = GetInstance<BuildModelPage>();
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.RAN))
            {
                DriverContext.Browser.GoToUrl(UrlBuilder.getRangerBuildModelUrl());
                CurrentPage = GetInstance<BuildModelPage>();
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.ACE))
            {
                DriverContext.Browser.GoToUrl(UrlBuilder.getAceBuildModelUrl());
                CurrentPage = GetInstance<BuildModelPage>();
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.GEN))
            {
                DriverContext.Browser.GoToUrl(UrlBuilder.getGeneralBuildModelUrl());
                CurrentPage = GetInstance<BuildModelPage>();
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.IND))
            {
                DriverContext.Browser.GoToUrl(UrlBuilder.getIndianBuildModelUrl());
                CurrentPage = GetInstance<BuildModelPage>();
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.SLG))
            {
                DriverContext.Browser.GoToUrl(UrlBuilder.getSlingshotBuildModelUrl());
                CurrentPage = GetInstance<BuildModelPage>();
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.SNO))
            {
                DriverContext.Browser.GoToUrl(UrlBuilder.getSnowBuildModelUrl());
                CurrentPage = GetInstance<BuildModelPage>();
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.GEM))
            {
                DriverContext.Browser.GoToUrl(UrlBuilder.getGemBuildModelUrl());
                CurrentPage = GetInstance<BuildModelPage>();
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.ATV))
            {
                DriverContext.Browser.GoToUrl(UrlBuilder.getSportsmanBuildModelUrl());
                CurrentPage = GetInstance<BuildModelPage>();
            }
            else
                Assert.Fail("Brand {0} not supported", brandName);
        }

        [When(@"I select (.*) seat option")]
        public void WhenISelectSeatOption(string numberOfSeats)
        {
            if (stringEqualsIgnoreCase(numberOfSeats, ONE))
                CurrentPage.As<BuildModelPage>().clickOneSeat();
            else if (stringEqualsIgnoreCase(numberOfSeats, TWO))
                CurrentPage.As<BuildModelPage>().clickTwoSeat();
            else if (stringEqualsIgnoreCase(numberOfSeats, THREE))
                CurrentPage.As<BuildModelPage>().clickThreeSeat();
            else if (stringEqualsIgnoreCase(numberOfSeats, FOUR))
                CurrentPage.As<BuildModelPage>().clickFourSeat();
            else if (stringEqualsIgnoreCase(numberOfSeats, SIX))
                CurrentPage.As<BuildModelPage>().clickSixSeat();
            else
                Assert.Fail("Seat option {0} is not available", numberOfSeats);
        }


        [When(@"I click (.*) button")]
        public void WhenIClickButton(string buttonName)
        {
            if (stringEqualsIgnoreCase(buttonName, "next"))
                CurrentPage.As<BuildColorPage>().clickNextButton();
            else if (stringEqualsIgnoreCase(buttonName, "finished"))
                CurrentPage.As<BuildConfigurePage>().clickIamFinishedButton();
            else if (stringEqualsIgnoreCase(buttonName, "getinternetprice"))
                CurrentPage.As<BuildQuotePage>().clickGetInternetPriceButton();
            else
                Assert.Fail("Button with name {0} is not present", buttonName);
        }

        [When(@"I click (.*) button old version")]
        public void WhenIClickButtonOldVersion(string buttonName)
        {
            if (stringEqualsIgnoreCase(buttonName, "finished"))
                CurrentPage.As<BuildConfigurePage>().clickIamFinishedButtonOld();
            else
                Assert.Fail("Button with name {0} is not present", buttonName);
        }

    }
}
