using AutomationFramework.Utils;
using BuildConfigurator.Hooks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Tests
{
    [TestFixture]
    public class PackageTests : TestBase
    {
        [Test, Category("Packages"), Category("Ranger")]
        public void VerifyPackageAddPersistUntilBuildSubmission()
        {
            CPQNavigate.NavigateToPackagesPage(Brand.RAN, "ranger-xp-1000-eps-steel-blue");
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
