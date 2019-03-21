using AutomationFramework.DataProvider;
using AutomationFramework.Helpers;
using AutomationFramework.Utils;
using BuildConfigurator.Hooks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Tests.v2.DealerExperience
{
    [TestFixture]
    [Ignore("Brand running CPQ v3 version")]
    public class DealerExperienceUITests : TestBase
    {
        private static string DEALER_ID = "02040900";

        [Test, Category(TestCategories.DEALER_EXPERIENCE), RetryDynamic]
        public void VerifyUIElementsHiddenDealerExp()
        {
            CPQNavigate.NavigateToBrandDealerExpAccessoriesPage(Brand.RZR, ModelPageUrl.RZR_XP_1000_EPS_BASE_TEST, DEALER_ID);
            BuildConfigurePage.WaitForBuildPageToLoad();
            Assert.IsFalse(BuildConfigurePage.IsNavigationBarDisplayed());
            Assert.IsFalse(BuildConfigurePage.IsIconContainerDisplayed());
        }

        [Test, Category(TestCategories.DEALER_EXPERIENCE), RetryDynamic]
        public void VerifyVirtualKeyboardDealerExp()
        {
            CPQNavigate.NavigateToBrandDealerExpAccessoriesPage(Brand.RZR, ModelPageUrl.RZR_XP_1000_EPS_BASE_TEST, DEALER_ID);
            BuildConfigurePage.WaitForBuildPageToLoad();
            BuildConfigurePage.ClickCalculatorIcon();
            BuildConfigurePage.CalculatorModule.ClickMsrpField();
            Assert.IsTrue(BuildConfigurePage.IsVirtualKeyboardDisplayed());
        }
    }
}
