using AutomationFramework.Base;
using AutomationFramework.DataProvider;
using BuildConfigurator.Modules;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.TestBases
{
    public class AccountMgmtTestBase : AccountModule
    {
        private string ORDERS = "Orders";
        private string SAVED_VEHICLES = "Saved Vehicles";
        private string ADDRESSES = "Addresses";
        private string ACCOUNT_INFORMATION = "Account Information";
        private string LOGOUT = "Logout";
        private static string ORDERS_URL_PART = "/account/orderhistory";
        private static string SAVED_VEHICLES_URL_PART = "/account/savedvehicles";
        private static string ADDRESSES_URL_PART = "/account/manageaddresses";
        private static string ACCOUNT_INFO_URL_PART = "/account";
        public SignInModule SignInModule { get { return new SignInModule(_parallelConfig); } }

        public HeaderModule HeaderModule { get { return new HeaderModule(_parallelConfig); } }

        public AccountMgmtTestBase(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public void Login(UserAccountData userData)
        {
            SignInModule.EnterEmailAndPasswordValue(userData);
            SignInModule.ClickLoginCTA();
        }

        public void ClickMenuFromAccountMenu(string menu)
        {
            if (stringEqualsIgnoreCase(menu, ORDERS))
            {
                HeaderModule.ClickAccountHeaderIcon();
                ClickAcctModalOrders();
            }
            else if (stringEqualsIgnoreCase(menu, SAVED_VEHICLES))
            {
                HeaderModule.ClickAccountHeaderIcon();
                ClickAcctModalSavedVehicles();
            }
            else if (stringEqualsIgnoreCase(menu, ADDRESSES))
            {
                HeaderModule.ClickAccountHeaderIcon();
                ClickAcctModalAddresses();
            }
            else if (stringEqualsIgnoreCase(menu, ACCOUNT_INFORMATION))
            {
                HeaderModule.ClickAccountHeaderIcon();
                ClickAcctModalAcctInfo();
            }
            else if (stringEqualsIgnoreCase(menu, LOGOUT))
            {
                HeaderModule.ClickAccountHeaderIcon();
                ClickAcctModalLogOut();
            }
            else
                Assert.Fail("Menu {0} is not present on account modal", menu);
        }

        public bool VerifyExpectedPageIsDisplayed(string page)
        {
            if (stringEqualsIgnoreCase(page, ORDERS))
                return stringContainsIgnoreCase(Driver.Url, ORDERS_URL_PART);
            else if (stringEqualsIgnoreCase(page, SAVED_VEHICLES))
                return stringContainsIgnoreCase(Driver.Url, SAVED_VEHICLES_URL_PART);
            else if (stringEqualsIgnoreCase(page, ADDRESSES))
                return stringContainsIgnoreCase(Driver.Url, ADDRESSES_URL_PART);
            else if (stringEqualsIgnoreCase(page, ACCOUNT_INFORMATION))
                return stringContainsIgnoreCase(Driver.Url, ACCOUNT_INFO_URL_PART);
            else if (stringEqualsIgnoreCase(page, LOGOUT))
                return IsUserLoggedOut();
            else
                return false;
        }

        public void ClickMenuOptionAndValidateExpectedPage(string menu)
        {
            ClickMenuFromAccountMenu(menu);
            Assert.IsTrue(VerifyExpectedPageIsDisplayed(menu), "URL for {0} menu option is not as expected", menu);
        }

    }
}
