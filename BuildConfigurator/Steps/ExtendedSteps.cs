using AutomationFramework.Base;
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
    internal class ExtendedSteps : BasePage
    {
        /// <summary>
        /// Method to select the number of seats on the build model page
        /// </summary>
        /// <param name="numberOfSeats">one, two, three...</param>
        //[Given(@"I select (.*) seat option")]
        //public void GivenISelectSeatOption(string numberOfSeats)
        //{
        //    if(numberOfSeats.Equals("one"))
        //        CurrentPage.As<BuildModelPage>().clickOneSeat();
        //    if (numberOfSeats.Equals("two"))
        //        CurrentPage.As<BuildModelPage>().clickOneSeat();
        //    if (numberOfSeats.Equals("three"))
        //        CurrentPage.As<BuildModelPage>().clickOneSeat();
        //    if (numberOfSeats.Equals("four"))
        //        CurrentPage.As<BuildModelPage>().clickOneSeat();
        //    if (numberOfSeats.Equals("six"))
        //        CurrentPage.As<BuildModelPage>().clickOneSeat();
        //}

        [When(@"I select (.*) seat option")]
        public void WhenISelectOneSeatOption(string numberOfSeats)
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
        }


        [When(@"I click (.*) button")]
        public void WhenIClickNextButton(string buttonName)
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
