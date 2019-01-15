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

namespace BuildConfigurator.Tests
{
    [TestFixture]
    public class AccountManagementTests : TestBase
    {
        [Test, Category("Ranger"), Category("AccountManagement"), CustomRetry(3)]
        public void VerifySaveBuildFunctionality()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RAN, ModelPageUrl.RANGER_500_SAGE_GREEN_ACCESSORIES);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Wheel");
            Accessories.ClickSubcategoryByName("Trail");
            Accessories.ClickAccessoryAddByProductName("Buckle- Accent");
            Accessories.HeaderModule.ClickSaveHeaderIcon();
            Accessories.EnterBuildName();
            Accessories.ClickSaveBuildModalSave();
            AccountMgmt.Login(UserAccountData.NON_EMPLOYEE_1);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.AccountModule.ClickAcctLoggedInIcon();
            Accessories.AccountModule.ClickAcctModalSavedVehicles();
            Assert.IsTrue(Accessories.VerifySavedBuildIsPresent());
            Accessories.DeleteSavedVehicle();
        }

        [Test, Category("Ranger"), Category("AccountManagement"), CustomRetry(3)]
        public void VerifyAccountMenuNavigation()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RAN, ModelPageUrl.RANGER_500_SAGE_GREEN_ACCESSORIES);
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
