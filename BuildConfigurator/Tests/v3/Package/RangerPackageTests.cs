using AutomationFramework.DataProvider;
using AutomationFramework.Utils;
using BuildConfigurator.Hooks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Tests.v3.Package
{
    [TestFixture]
    public class RangerPackageTests : TestBase
    {
        [Test, Category("Packages"), Category("Ranger")]
        public void VerifyPackageAddPersistUntilBuildSubmission()
        {
            CPQNavigate.NavigateToPackagesPage(Brand.RAN, ModelPageUrl.RANGER_XP1000_EPS_STEEL_BLUE_PACKAGES);
            Packages.WaitForPackagesPageToLoad();
            string ModelId = Packages.GetWholegoodModelId();
            Packages.AddRandomAvailablePackage();
            Assert.IsTrue(Packages.VerifyModelIdChangedAfterPackageAdd(ModelId));
            ModelId = Packages.GetWholegoodModelId();
            Packages.FooterModule.ClickFooterNextButton();
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Wheel");
            Accessories.ClickSubcategoryByName("Trail");
            Accessories.ClickAccessoryAddByProductName("Buckle- Accent");
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Accessories.ClikIamFinishedButton();
            Quote.WaitForBuildQuotePageToLoad();
            Quote.FillQuoteFormDefaultData();
            Quote.ClickGetInternetPriceButton();
            Confirmation.WaitUntilConfirmationPageLoads();
            Assert.AreEqual(Confirmation.GetQuoteModelId(), ModelId);
        }
    }
}
