using AutomationFramework.ApiUtils.ApiDataProvider;
using AutomationFramework.Helpers;
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
    public class SnowCheckBuildTests : TestBase
    {
        private static string YEAR = "2020";
        private static string DEALER = "02040900";
        ApiDataProvider ApiDataProvider { get { return new ApiDataProvider(); } }

        [Ignore("So we do not submit builds to prod")]
        [Test, Category(TestCategories.SNOWCHECK), RetryDynamic]
        public void VerifySnowCheckBuilds()
        {
            List<string> snowBuildUrls = ApiDataProvider.GetBuildUrls(Brand.SNO, YEAR, DEALER);

            var urls = string.Empty;
            foreach (var item in snowBuildUrls)
            {
                urls += item + "\n";
            }
            foreach (var buildUrl in snowBuildUrls)
            {
                CPQNavigate.GoToUrl(buildUrl);
                Colors.WaitForChooseColorTitleToDisplay();
                Colors.FooterModule.ClickFooterNextButton();
                Options.SelectRandomOptionsUntilAccessories();
                Accessories.ClikIamFinishedButton();
                Quote.FillQuoteFormDefaultData();
                Quote.ClickGetInternetPriceButton();
                Confirmation.WaitUntilConfirmationPageLoads();
                Assert.IsTrue(Confirmation.IsBuildSummaryHeaderDisplayed(), "Confrimation page header is not displayed");
                Assert.IsTrue(Confirmation.IsOptionsSectionDisplayed(), "Accessories/Options section is not displayed");
                Confirmation.VerifyConfirmationModelNameMatcUrlModel(buildUrl);
            }
        }
    }
}
