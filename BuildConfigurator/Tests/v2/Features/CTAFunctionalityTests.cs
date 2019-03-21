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

namespace BuildConfigurator.Tests.v2.Features
{
    [TestFixture]
    [Ignore("Brand running CPQ v3 version")]
    public class CTAFunctionalityTests : TestBase
    {
        [Test, Category(TestCategories.UI_FEATURES), RetryDynamic]
        public void VerifyRzrRestartBuildFunctionality()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RZR, ModelPageUrl.RZR_XP_1000_EPS_BASE_TEST);
            BuildConfigurePage.WaitForBuildPageToLoad();
            BuildConfigurePage.ClickAccessoryCategory("Protection");
            BuildConfigurePage.ClickAccessorySubCategory("Mirrors");
            BuildConfigurePage.ClickSpecificAccessoryCardAddButton("Folding Side Mirrors");
            BuildConfigurePage.VerifyItemsIdsPresentBuildSummary(new string[] { "2881198" });
            BuildConfigurePage.ClickBuildRestartButton();
            BuildConfigurePage.ClickConfirmationContinueButton();
            BuildConfigurePage.VerifyItemsIdsNotPresentBuildSummary(new string[] { "2881198" });
        }

        [Test, Category(TestCategories.UI_FEATURES), RetryDynamic]
        public void VerifyAccessoryImageOpensOverview()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RZR, ModelPageUrl.RZR_XP_1000_EPS_BASE_TEST);
            BuildConfigurePage.WaitForBuildPageToLoad();
            BuildConfigurePage.ClickAccessoryCategory("Protection");
            BuildConfigurePage.ClickAccessorySubCategory("Mirrors");
            BuildConfigurePage.ClickSpecificAccessoryCardImage("Folding Side Mirrors");
            Assert.IsTrue(BuildConfigurePage.IsAccessoryOverViewDisplayed("Folding Side Mirrors"));
        }
    }
}
