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
    public class DealerExperienceUITests : TestBase
    {
        private static string DEALER_ID = "54321";

        [Test, Category(TestCategories.DEALER_EXPERIENCE), RetryDynamic]
        public void VerifyUIElementsHiddenDealerExpV2()
        {
            CPQNavigate.NavigateToBrandDealerExpAccessoriesPage(Brand.IND, ModelPageUrl.INDIAN_SPRINGFIELD_BASE_TEST, DEALER_ID);
            BuildConfigurePage.WaitForBuildPageToLoad();
            Assert.IsFalse(BuildConfigurePage.IsNavigationBarDisplayed());
            Assert.IsFalse(BuildConfigurePage.IsIconContainerDisplayed());
        }

        [Test, Category(TestCategories.DEALER_EXPERIENCE), RetryDynamic]
        public void VerifyVirtualKeyboardDealerExpV2()
        {
            CPQNavigate.NavigateToBrandDealerExpAccessoriesPage(Brand.IND, ModelPageUrl.INDIAN_SPRINGFIELD_BASE_TEST, DEALER_ID);
            BuildConfigurePage.WaitForBuildPageToLoad();
            BuildConfigurePage.ClickCalculatorIcon();
            BuildConfigurePage.CalculatorModule.ClickMsrpField();
            Assert.IsTrue(BuildConfigurePage.IsVirtualKeyboardDisplayed());
        }
    }
}
