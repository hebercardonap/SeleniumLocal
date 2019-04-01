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
    public class SlgAcctMgmtTests : TestBase
    {
        [Test, Category(TestCategories.SLG), Category(TestCategories.ACCOUNT_MGMT), RetryDynamic]
        public void VerifySaveBuildFunctionalitySlg()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.SLG, ModelPageUrl.SLG_S_BASE_TEST);
            Accessories.WaitForAccessoriesPageToLoad();
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
    }
}
