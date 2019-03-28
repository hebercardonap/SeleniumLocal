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

    public class CTAFunctionalityTests : TestBase
    {
        [Test, Category(TestCategories.UI_FEATURES), RetryDynamic]
        public void VerifyRestartBuildFunctionalityv2()
        {
            CPQNavigate.NavigateToCategoryPage(Brand.IND);
            BuildCategoryPage.WaitForCategoryPageToLoad();
            BuildCategoryPage.ClickOnIndianCategory("scout");
            BuildModelPage.ClickRandomModel();
            BuildColorPage.WaitForColorPageToLoad();
            BuildColorPage.ClickColor();
            BuildColorPage.ClickNextButton();
            BuildConfigurePage.WaitForBuildPageToLoad();
            BuildConfigurePage.ClickAccessoryCategory("Engine");
            BuildConfigurePage.ClickAccessorySubCategory("Intake");
            BuildConfigurePage.ClickSpecificAccessoryCardAddButton("Intake");
            BuildConfigurePage.VerifyItemsIdsPresentBuildSummary(new string[] { "2882519" });
            BuildConfigurePage.ClickBuildRestartButton();
            BuildConfigurePage.ClickConfirmationContinueButton();
            BuildConfigurePage.VerifyItemsIdsNotPresentBuildSummary(new string[] { "2882519" });
        }

        [Test, Category(TestCategories.UI_FEATURES), RetryDynamic]
        public void VerifyAccessoryImageOpensOverviewv2()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.IND, ModelPageUrl.INDIAN_SCOUT_ACCESSORIES_PAGE);
            BuildConfigurePage.WaitForBuildPageToLoad();
            BuildConfigurePage.ClickAccessoryCategory("Engine");
            BuildConfigurePage.ClickAccessorySubCategory("Intake");
            BuildConfigurePage.ClickSpecificAccessoryCardInfoButton("Intake");
            Assert.IsTrue(BuildConfigurePage.IsAccessoryOverViewDisplayed("Intake"));
        }
    }
}
