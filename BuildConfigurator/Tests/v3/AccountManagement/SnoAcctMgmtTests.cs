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

namespace BuildConfigurator.Tests.v3.AccountManagement
{
    [TestFixture]
    public class SnoAcctMgmtTests : TestBase
    {
        [Test, Category(TestCategories.SNO), Category(TestCategories.ACCOUNT_MGMT), RetryDynamic]
        public void VerifySaveBuildFunctionalitySno()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.SNO, ModelPageUrl.SNO_SWITCHBACK_600_BASE_TEST);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Protection");
            Accessories.ClickSubcategoryByName("Covers");
            Accessories.ClickAccessoryAddByProductName("Cover - Black");
            Accessories.Toolbar.ClickToolbarSaveIcon();
            Accessories.EnterBuildName();
            Accessories.ClickSaveBuildModalSave();
            AccountMgmt.Login(UserAccountData.NON_EMPLOYEE_1);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.AccountModule.ClickAcctLoggedInIcon();
            Accessories.AccountModule.ClickAcctModalSavedVehicles();
            Assert.IsTrue(Accessories.VerifySavedBuildIsPresent());
            Accessories.DeleteSavedVehicle();
        }

        [Test, Category(TestCategories.SNO), Category(TestCategories.ACCOUNT_MGMT), RetryDynamic]
        public void VerifyAccountMenuNavigationSno()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.SNO, ModelPageUrl.SNO_SWITCHBACK_600_BASE_TEST);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.HeaderModule.ClickSignInHeaderIcon();
            AccountMgmt.Login(UserAccountData.NON_EMPLOYEE_1);
            Accessories.WaitForAccessoriesPageToLoad();
            AccountMgmt.ClickMenuOptionAndValidateExpectedPage("Orders");
            CPQNavigate.GoToPreviousPage();
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.WaitForAccessoriesPageToLoad();
            AccountMgmt.ClickMenuOptionAndValidateExpectedPage("Addresses");
            CPQNavigate.GoToPreviousPage();
            Accessories.WaitForAccessoriesPageToLoad();
            AccountMgmt.ClickMenuOptionAndValidateExpectedPage("Account Information");
            CPQNavigate.GoToPreviousPage();
            Accessories.WaitForAccessoriesPageToLoad();
            AccountMgmt.ClickMenuFromAccountMenu("Logout");
            Assert.IsTrue(AccountMgmt.IsUserLoggedOut());
        }
    }
}
