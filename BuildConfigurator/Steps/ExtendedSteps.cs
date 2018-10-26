using AutomationFramework.Base;
using AutomationFramework.UrlBuilderSites;
using AutomationFramework.Utils;
using BuildConfigurator.Pages;
using NUnit.Framework;
using System;
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
        private static string SLASH_CHARACTER = "/";
        private static string BUILD_URL_PART = "/build";

        public ExtendedSteps(ParallelConfig parallelConfig) : base(parallelConfig)
        {
            
        }

        [Given(@"I have navigated to (.*) build model page")]
        public void GivenIHaveNavigatedToBrandBuildModelPage(string brandName)
        {
            if (stringEqualsIgnoreCase(brandName, Brand.RZR))
            {
                Driver.Navigate().GoToUrl(UrlBuilder.getRzrBuildModelUrl());
                _parallelConfig.CurrentPage = new BuildModelPage(_parallelConfig);
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.RAN))
            {
                Driver.Navigate().GoToUrl(UrlBuilder.getRangerBuildModelUrl());
                _parallelConfig.CurrentPage = new BuildModelPage(_parallelConfig);
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.ACE))
            {
                Driver.Navigate().GoToUrl(UrlBuilder.getAceBuildModelUrl());
                _parallelConfig.CurrentPage = new BuildModelPage(_parallelConfig);
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.GEN))
            {
                Driver.Navigate().GoToUrl(UrlBuilder.getGeneralBuildModelUrl());
                _parallelConfig.CurrentPage = new BuildModelPage(_parallelConfig);
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.IND))
            {
                Driver.Navigate().GoToUrl(UrlBuilder.getIndianBuildModelUrl());
                _parallelConfig.CurrentPage = new BuildModelPage(_parallelConfig);
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.SLG))
            {
                Driver.Navigate().GoToUrl(UrlBuilder.getSlingshotBuildModelUrl());
                _parallelConfig.CurrentPage = new BuildModelPage(_parallelConfig);
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.SNO))
            {
                Driver.Navigate().GoToUrl(UrlBuilder.getSnowBuildModelUrl());
                _parallelConfig.CurrentPage = new BuildModelPage(_parallelConfig);
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.GEM))
            {
                Driver.Navigate().GoToUrl(UrlBuilder.getGemBuildModelUrl());
                _parallelConfig.CurrentPage = new BuildModelPage(_parallelConfig);
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.ATV))
            {
                Driver.Navigate().GoToUrl(UrlBuilder.getSportsmanBuildModelUrl());
                _parallelConfig.CurrentPage = new BuildModelPage(_parallelConfig);
            }
            else
                Assert.Fail("Brand {0} not supported", brandName);
        }

        [Given(@"I have navigated to (.*) (.*) build page")]
        public void GivenIHaveNavigatedToModelBuildPage(string brandName, string modelName)
        {
            if (stringEqualsIgnoreCase(brandName, Brand.IND))
            {
                string buildUrl = string.Concat(UrlBuilder.getIndianLandingPageURL(), SLASH_CHARACTER, modelName, BUILD_URL_PART);
                GoToUrl(buildUrl);
                _parallelConfig.CurrentPage = new BuildConfigurePage(_parallelConfig);
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.ATV))
            {
                string buildUrl = string.Concat(UrlBuilder.getSportsmanLandingPageURL(), SLASH_CHARACTER, modelName, BUILD_URL_PART);
                GoToUrl(buildUrl);
                _parallelConfig.CurrentPage = new BuildConfigurePage(_parallelConfig);
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.SLG))
            {
                string buildUrl = string.Concat(UrlBuilder.getSlgLandingPageURL(), SLASH_CHARACTER, modelName, BUILD_URL_PART);
                GoToUrl(buildUrl);
                _parallelConfig.CurrentPage = new BuildConfigurePage(_parallelConfig);
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.GEN))
            {
                string buildUrl = string.Concat(UrlBuilder.getGeneralLandingPageURL(), SLASH_CHARACTER, modelName, BUILD_URL_PART);
                GoToUrl(buildUrl);
                _parallelConfig.CurrentPage = new BuildConfigurePage(_parallelConfig);
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.ACE))
            {
                string buildUrl = string.Concat(UrlBuilder.getAceLandingPageURL(), SLASH_CHARACTER, modelName, BUILD_URL_PART);
                GoToUrl(buildUrl);
                _parallelConfig.CurrentPage = new BuildConfigurePage(_parallelConfig);
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.RZR))
            {
                string buildUrl = string.Concat(UrlBuilder.getRzrLandingPageURL(), SLASH_CHARACTER, modelName, BUILD_URL_PART);
                GoToUrl(buildUrl);
                _parallelConfig.CurrentPage = new BuildConfigurePage(_parallelConfig);
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.SNO))
            {
                string buildUrl = string.Concat(UrlBuilder.getSnoLandingPageURL(), SLASH_CHARACTER, modelName, BUILD_URL_PART);
                GoToUrl(buildUrl);
                _parallelConfig.CurrentPage = new BuildConfigurePage(_parallelConfig);
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.RAN))
            {
                string buildUrl = string.Concat(UrlBuilder.getRangerLandingPageURL(), SLASH_CHARACTER, modelName, BUILD_URL_PART);
                GoToUrl(buildUrl);
                _parallelConfig.CurrentPage = new BuildConfigurePage(_parallelConfig);
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.GEM))
            {
                string buildUrl = string.Concat(UrlBuilder.getGemLandingPageURL(), SLASH_CHARACTER, modelName, BUILD_URL_PART);
                GoToUrl(buildUrl);
                _parallelConfig.CurrentPage = new BuildConfigurePage(_parallelConfig);
            }
            else
                Assert.Fail("Brand {0} not supported", brandName);
        }


        [When(@"I select (.*) seat option")]
        public void WhenISelectSeatOption(string numberOfSeats)
        {
            if (stringEqualsIgnoreCase(numberOfSeats, ONE))
                _parallelConfig.CurrentPage.As<BuildModelPage>().clickOneSeat();
            else if (stringEqualsIgnoreCase(numberOfSeats, TWO))
                _parallelConfig.CurrentPage.As<BuildModelPage>().clickTwoSeat();
            else if (stringEqualsIgnoreCase(numberOfSeats, THREE))
                _parallelConfig.CurrentPage.As<BuildModelPage>().clickThreeSeat();
            else if (stringEqualsIgnoreCase(numberOfSeats, FOUR))
                _parallelConfig.CurrentPage.As<BuildModelPage>().clickFourSeat();
            else if (stringEqualsIgnoreCase(numberOfSeats, SIX))
                _parallelConfig.CurrentPage.As<BuildModelPage>().clickSixSeat();
            else
                Assert.Fail("Seat option {0} is not available", numberOfSeats);
        }


        [When(@"I click (.*) button")]
        public void WhenIClickButton(string buttonName)
        {
            if (stringEqualsIgnoreCase(buttonName, "next"))
                _parallelConfig.CurrentPage.As<BuildColorPage>().clickNextButton();
            else if (stringEqualsIgnoreCase(buttonName, "finished"))
                _parallelConfig.CurrentPage.As<BuildConfigurePage>().clickIamFinishedButton();
            else if (stringEqualsIgnoreCase(buttonName, "getinternetprice"))
                _parallelConfig.CurrentPage.As<BuildQuotePage>().clickGetInternetPriceButton();
            else if (stringEqualsIgnoreCase(buttonName, "buildsummary"))
                _parallelConfig.CurrentPage.As<BuildConfigurePage>().clickBuildSummaryButton();
            else
                Assert.Fail("Button with name {0} is not present", buttonName);

            DriverActions.waitForAjaxRequestToComplete();
        }

        [When(@"I click (.*) button old version")]
        public void WhenIClickButtonOldVersion(string buttonName)
        {
            if (stringEqualsIgnoreCase(buttonName, "finished"))
                _parallelConfig.CurrentPage.As<BuildConfigurePage>().clickIamFinishedButtonOld();
            else
                Assert.Fail("Button with name {0} is not present", buttonName);

            DriverActions.waitForAjaxRequestToComplete();
        }

        [When(@"I click finished button from next steps container")]
        public void WhenIClickFinishedButtonFromNextStepsContainer()
        {
            _parallelConfig.CurrentPage.As<BuildConfigurePage>().clickIamFiniShedButtonNextSteps();
            DriverActions.waitForAjaxRequestToComplete();
        }

        [StepArgumentTransformation]
        public string[] TransformToArrayOfStrings(string commaSeparatedStepArgumentValues)
        {
            string sourceString = commaSeparatedStepArgumentValues;
            string[] stringSeparators = new string[] { "," };
            return sourceString.Split(stringSeparators, StringSplitOptions.None);
        }
    }
}
