﻿using AutomationFramework.DataProvider;
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
    public class RangerAcctMgmtTests : TestBase
    {
        [Test, Category(TestCategories.RAN), Category(TestCategories.ACCOUNT_MGMT), RetryDynamic]
        public void VerifySaveBuildFunctionalityRan()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RAN, ModelPageUrl.RANGER_500_SAGE_GREEN_ACCESSORIES);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Wheel");
            Accessories.ClickSubcategoryByName("Trail");
            Accessories.ClickAccessoryAddByProductName("Buckle- Accent");
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

        [Test, Category(TestCategories.RAN), Category(TestCategories.ACCOUNT_MGMT), RetryDynamic]
        public void VerifyAccountMenuNavigationRan()
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
