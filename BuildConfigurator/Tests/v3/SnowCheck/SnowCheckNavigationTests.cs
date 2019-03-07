using AutomationFramework.ApiUtils.ApiDataProvider;
using AutomationFramework.Utils;
using BuildConfigurator.Hooks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Tests.v3.SnowCheck
{
    [TestFixture]
    public class SnowCheckNavigationTests : TestBase
    {
        private static string YEAR = "2020";
        private static string DEALER = "54321";

        ApiDataProvider ApiDataProvider { get { return new ApiDataProvider(); } }

        Random rnd = new Random();

        [Test, Category(TestCategories.SNOWCHECK)]
        public void VerifySnowCheckOptionsNavigation()
        {
            List<string> snowBuildUrls = ApiDataProvider.GetBuildUrls(Brand.SNO, YEAR, DEALER);
            string snowCheckUrl = snowBuildUrls[rnd.Next(snowBuildUrls.Count)];

            CPQNavigate.GoToUrl(snowCheckUrl);
            Colors.WaitForChooseColorTitleToDisplay();

            while (Colors.IsStockModelInfoDisplayed())
            {
                snowCheckUrl = snowBuildUrls[rnd.Next(snowBuildUrls.Count)];
                CPQNavigate.GoToUrl(snowCheckUrl);
                Colors.WaitForChooseColorTitleToDisplay();
            }
            Colors.FooterModule.ClickFooterNextButton();
            Options.VerifyDefaultSubstepOptionSelected("Starter");
        }
    }
}
