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
    public class SaveBuildTests : TestBase
    {
        [Test, Category(TestCategories.SAVE_BUILD), Category(TestCategories.RZR), RetryDynamic]
        public void VerifyRzrSaveBuildFunctionality()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RZR, ModelPageUrl.RZR_XP_1000_EPS_BASE_TEST);
            BuildConfigurePage.WaitForBuildPageToLoad();
            BuildConfigurePage.ClickAccessoryCategory("Protection");
            BuildConfigurePage.ClickAccessorySubCategory("Mirrors");
            BuildConfigurePage.ClickSpecificAccessoryCardAddButton("Folding Side Mirrors");
            BuildConfigurePage.ClickSaveIcon();
            BuildConfigurePage.EnterBuildName();
            BuildConfigurePage.ClickSaveBuildModalSave();
            BuildConfigurePage.SignInModule.EnterEmailAndPasswordValue(UserAccountData.NON_EMPLOYEE_1);
            BuildConfigurePage.SignInModule.ClickLoginCTA();
            BuildConfigurePage.WaitForBuildPageToLoad();
            BuildConfigurePage.ClickLoadSavedBuildButton();
            Assert.IsTrue(BuildConfigurePage.VerifySavedBuildIsPresent());
        }
    }
}
