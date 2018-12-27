using AutomationFramework.Base;
using BuildConfigurator.Pages.v3;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BuildConfigurator.Steps.v3
{
    [Binding]
    public class ModelsPageSteps : BasePage
    {

        private static string ONE = "one";
        private static string TWO = "two";
        private static string THREE = "three";
        private static string FOUR = "four";
        private static string SIX = "six";

        public ModelsPageSteps(ParallelConfig parallelConfig) : base(parallelConfig)
        {
            _parallelConfig.CurrentPage = new ModelsPage(_parallelConfig);
        }

        [When(@"I select (.*) seat model new version")]
        public void WhenISelectSeatModels(string numberOfSeats)
        {
            if (stringEqualsIgnoreCase(numberOfSeats, ONE))
                _parallelConfig.CurrentPage.As<ModelsPage>().ClickOneSeatModel();
            else if (stringEqualsIgnoreCase(numberOfSeats, TWO))
                _parallelConfig.CurrentPage.As<ModelsPage>().ClickTwoSeatModel();
            else if (stringEqualsIgnoreCase(numberOfSeats, THREE))
                _parallelConfig.CurrentPage.As<ModelsPage>().ClickThreeSeatModel();
            else if (stringEqualsIgnoreCase(numberOfSeats, FOUR))
                _parallelConfig.CurrentPage.As<ModelsPage>().ClickFourSeatModel();
            else if (stringEqualsIgnoreCase(numberOfSeats, SIX))
                _parallelConfig.CurrentPage.As<ModelsPage>().ClickSixSeatModel();
            else
                Assert.Fail("Seat option {0} is not available", numberOfSeats);
        }

        [When(@"I select random model new version")]
        public void WhenISelectRandomModelNewVersion()
        {
            _parallelConfig.CurrentPage.As<ModelsPage>().ClickRandomModelVersion();
        }


    }
}
