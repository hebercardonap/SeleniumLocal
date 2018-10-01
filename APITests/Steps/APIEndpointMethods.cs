using APITests.Endpoints;
using APITests.Helpers;
using AutomationFramework.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace APITests.Steps
{
    [Binding]
    public class APIEndpointMethods : BasePage
    {
        [Given(@"I have DEX endpoint with year (.*) and dealer (.*)")]
        public void GivenIHaveEndpoint(string year, string dealerid)
        {
            RestAPIHelper.SetUrl(string.Format(EndpointString.DEALER_EXPERIENCE_ENDPOINT, year, dealerid));
        }

        [Given(@"I have base URL")]
        public void GivenIHaveBaseURL()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I call GET method")]
        public void WhenICallGETMethod()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"API response is as expected")]
        public void ThenAPIResponseIsAsExpected()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
