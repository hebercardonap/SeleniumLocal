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
        private static string DEALER_PART_ID = "?dealerid=02040900";
        private static string BUILD_QUOTE_URL_PART = "/rzr-s-900-white/build-quote/";
        private static string BUILD_TRIM_URL_PART = "/build-trim/";
        private static string BUILD_COLOR_URL_PART = "/build-color/";
        private static string BUILD_PACKAGE_PAGE = "/build-package/";

        public ExtendedSteps(ParallelConfig parallelConfig) : base(parallelConfig)
        {
            
        }

        [Given(@"I have navigated to (.*) build model page")]
        public void GivenIHaveNavigatedToBrandBuildModelPage(string brandName)
        {
            if (stringEqualsIgnoreCase(brandName, Brand.RZR))
            {
                GoToUrl(UrlBuilder.getRzrBuildModelUrl());
                _parallelConfig.CurrentPage = new BuildModelPage(_parallelConfig);
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.RAN))
            {
                GoToUrl(UrlBuilder.getRangerBuildModelUrl());
                _parallelConfig.CurrentPage = new BuildModelPage(_parallelConfig);
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.ACE))
            {
                GoToUrl(UrlBuilder.getAceBuildModelUrl());
                _parallelConfig.CurrentPage = new BuildModelPage(_parallelConfig);
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.GEN))
            {
                GoToUrl(UrlBuilder.getGeneralBuildModelUrl());
                _parallelConfig.CurrentPage = new BuildModelPage(_parallelConfig);
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.IND))
            {
                GoToUrl(UrlBuilder.getIndianBuildModelUrl());
                _parallelConfig.CurrentPage = new BuildModelPage(_parallelConfig);
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.SLG))
            {
                GoToUrl(UrlBuilder.getSlingshotBuildModelUrl());
                _parallelConfig.CurrentPage = new BuildModelPage(_parallelConfig);
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.SNO))
            {
                GoToUrl(UrlBuilder.getSnowBuildModelUrl());
                _parallelConfig.CurrentPage = new BuildModelPage(_parallelConfig);
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.GEM))
            {
                GoToUrl(UrlBuilder.getGemBuildModelUrl());
                _parallelConfig.CurrentPage = new BuildModelPage(_parallelConfig);
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.ATV))
            {
                GoToUrl(UrlBuilder.getSportsmanBuildModelUrl());
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
                string buildUrl = string.Concat(UrlBuilder.getIndianLandingPageURL(), modelName, BUILD_URL_PART);
                GoToUrl(buildUrl);
                _parallelConfig.CurrentPage = new BuildConfigurePage(_parallelConfig);
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.ATV))
            {
                string buildUrl = string.Concat(UrlBuilder.getSportsmanLandingPageURL(), modelName, BUILD_URL_PART);
                GoToUrl(buildUrl);
                _parallelConfig.CurrentPage = new BuildConfigurePage(_parallelConfig);
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.SLG))
            {
                string buildUrl = string.Concat(UrlBuilder.getSlgLandingPageURL(), modelName, BUILD_URL_PART);
                GoToUrl(buildUrl);
                _parallelConfig.CurrentPage = new BuildConfigurePage(_parallelConfig);
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.GEN))
            {
                string buildUrl = string.Concat(UrlBuilder.getGeneralLandingPageURL(), modelName, BUILD_URL_PART);
                GoToUrl(buildUrl);
                _parallelConfig.CurrentPage = new BuildConfigurePage(_parallelConfig);
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.ACE))
            {
                string buildUrl = string.Concat(UrlBuilder.getAceLandingPageURL(), modelName, BUILD_URL_PART);
                GoToUrl(buildUrl);
                _parallelConfig.CurrentPage = new BuildConfigurePage(_parallelConfig);
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.RZR))
            {
                string buildUrl = string.Concat(UrlBuilder.getRzrLandingPageURL(), modelName, BUILD_URL_PART);
                GoToUrl(buildUrl);
                _parallelConfig.CurrentPage = new BuildConfigurePage(_parallelConfig);
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.SNO))
            {
                string buildUrl = string.Concat(UrlBuilder.getSnoLandingPageURL(), modelName, BUILD_URL_PART);
                GoToUrl(buildUrl);
                _parallelConfig.CurrentPage = new BuildConfigurePage(_parallelConfig);
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.RAN))
            {
                string buildUrl = string.Concat(UrlBuilder.getRangerLandingPageURL(), modelName, BUILD_URL_PART);
                GoToUrl(buildUrl);
                _parallelConfig.CurrentPage = new BuildConfigurePage(_parallelConfig);
            }
            else if (stringEqualsIgnoreCase(brandName, Brand.GEM))
            {
                string buildUrl = string.Concat(UrlBuilder.getGemLandingPageURL(), modelName, BUILD_URL_PART);
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
            else if (stringEqualsIgnoreCase(buttonName, "confirmation continue"))
                _parallelConfig.CurrentPage.As<BuildConfigurePage>().ClickConfirmationContinueButton();
            else if (stringEqualsIgnoreCase(buttonName, "build restart"))
                _parallelConfig.CurrentPage.As<BuildConfigurePage>().ClickBuildRestartButton();
            else if (stringEqualsIgnoreCase(buttonName, "continue"))
                _parallelConfig.CurrentPage.As<BuildConfigurePage>().ClickConfirmationContinueButton();
            else if (stringEqualsIgnoreCase(buttonName, "Load Saved Build"))
                _parallelConfig.CurrentPage.As<BuildConfigurePage>().ClickLoadSavedBuildButton();
            else if (stringEqualsIgnoreCase(buttonName, "save"))
                _parallelConfig.CurrentPage.As<BuildConfigurePage>().ClickSaveBuildModalSave();
            else if (stringEqualsIgnoreCase(buttonName, "cancel"))
                _parallelConfig.CurrentPage.As<BuildConfigurePage>().ClickSaveBuildModalCancel();
            else if (stringEqualsIgnoreCase(buttonName, "footer next"))
                _parallelConfig.CurrentPage.As<BuildColorPage>().FooterModule.ClickFooterNextButton();
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

        [Given(@"I have navigated to (.*) (.*) build DEX page")]
        public void GivenIHaveNavigatedToRZRRzr_Xp_Eps_Ride_Command_Edition_Black_PearlBuildDEXPage(string brandName, string modelName)
        {
            if (stringEqualsIgnoreCase(brandName, Brand.RZR))
            {
                string buildUrl = string.Concat(UrlBuilder.getRzrLandingPageURL(), modelName, BUILD_URL_PART, DEALER_PART_ID);
                GoToUrl(buildUrl);
                _parallelConfig.CurrentPage = new BuildConfigurePage(_parallelConfig);
            }
            else
                Assert.Fail("Brand {0} not supported", brandName);
        }

        [When(@"I click (.*) icon")]
        public void WhenIClickIcon(string iconName)
        {
            if (stringEqualsIgnoreCase(iconName, "calculator"))
                _parallelConfig.CurrentPage.As<BuildConfigurePage>().ClickCalculatorIcon();
            else if (stringEqualsIgnoreCase(iconName, "save"))
                _parallelConfig.CurrentPage.As<BuildConfigurePage>().ClickSaveIcon();
            else if (stringEqualsIgnoreCase(iconName, "close"))
                _parallelConfig.CurrentPage.As<BuildModelPage>().HeaderModule.ClickHeaderCloseIcon();
            else
                Assert.Fail("Icon {0} is not present", iconName);
        }

        [When(@"I click (.*) form field")]
        public void WhenIClickFormField(string formField)
        {
            if (stringEqualsIgnoreCase(formField, "msrp"))
                _parallelConfig.CurrentPage.As<BuildConfigurePage>().CalculatorModule.ClickMsrpField();
            else
                Assert.Fail("Form field {0} is not present", formField);
        }

        [Given(@"I have navigated to build quote page")]
        public void GivenIHaveNavigatedToBuildQuote()
        {
            string buildQuoteUrl = string.Concat(UrlBuilder.getRzrLandingPageURL(), BUILD_QUOTE_URL_PART);
            GoToUrl(buildQuoteUrl);
            _parallelConfig.CurrentPage = new BuildQuotePage(_parallelConfig);
        }

        [Then(@"(.*) brand home page is displayed")]
        public void ThenRZRBrandHomePageIsDisplayed(string brand)
        {
            if (stringEqualsIgnoreCase(Brand.RAN, brand))
                Assert.AreEqual(Driver.Url, UrlBuilder.GetRangerBrandHomePage());
            else
                Assert.Fail("Band {0} is not supported", brand);
        }

        [Given(@"I have navigated to (.*) (.*) build trim page")]
        public void GivenIHaveNavigatedToBuildTrimPage(string brand, string model)
        {
            if (stringEqualsIgnoreCase(Brand.RAN, brand))
            {
                string url = string.Concat(UrlBuilder.getRangerLandingPageURL(), model, BUILD_TRIM_URL_PART);
                GoToUrl(url);
                _parallelConfig.CurrentPage = new BuildTrimPage(_parallelConfig); 
            }
            else
                Assert.Fail("Band {0} or model {1} is not supported", brand, model);
        }

        [Given(@"I have navigated to (.*) (.*) build color page")]
        public void GivenIHaveNavigatedToBuildColorPage(string brand, string model)
        {
            if (stringEqualsIgnoreCase(Brand.RAN, brand))
            {
                string url = string.Concat(UrlBuilder.getRangerLandingPageURL(), model, BUILD_COLOR_URL_PART);
                GoToUrl(url);
                _parallelConfig.CurrentPage = new BuildColorPage(_parallelConfig);
            }
            else
                Assert.Fail("Band {0} or model {1} is not supported", brand, model);
        }

        [Given(@"I have navigated to (.*) (.*) build package page")]
        public void GivenIHaveNavigatedToBuildPackagePage(string brand, string model)
        {
            if (stringEqualsIgnoreCase(Brand.RAN, brand))
            {
                string url = string.Concat(UrlBuilder.getRangerLandingPageURL(), model, BUILD_PACKAGE_PAGE);
                GoToUrl(url);
                _parallelConfig.CurrentPage = new BuildPackagePage(_parallelConfig);
            }
            else
                Assert.Fail("Band {0} or model {1} is not supported", brand, model);
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
