using AutomationFramework.Config;
using System;

namespace AutomationFramework.DataProvider
{
    class UserAccountData
    {
        public static readonly UserAccountData NON_EMPLOYEE_1 = new UserAccountData(QaUserAccounts.NON_EMPLOYEE_1, ProdUserAccounts.NON_EMPLOYEE_1);
        public static readonly UserAccountData NON_EMPLOYEE_2 = new UserAccountData(QaUserAccounts.NON_EMPLOYEE_2, ProdUserAccounts.NON_EMPLOYEE_2);
        public static readonly UserAccountData EMPLOYEE_1 = new UserAccountData(QaUserAccounts.EMPLOYEE_1, ProdUserAccounts.EMPLOYEE_1);
        public static readonly UserAccountData EMPLOYEE_2 = new UserAccountData(QaUserAccounts.EMPLOYEE_2, ProdUserAccounts.EMPLOYEE_2);

        private string userName;
        private string password;

        public string UserName { get; private set; }
        public string Password { get; private set; }
        UserAccountData(QaUserAccounts qaAccounts, ProdUserAccounts prodAccounts)
        {
            UserName = string.Equals(Settings.Environment, "QA", StringComparison.OrdinalIgnoreCase) ? qaAccounts.Username : prodAccounts.Username;
            Password = string.Equals(Settings.Environment, "QA", StringComparison.OrdinalIgnoreCase) ? qaAccounts.Password : prodAccounts.Password;
        }
    }

    class QaUserAccounts
    {
        public static readonly QaUserAccounts NON_EMPLOYEE_1 = new QaUserAccounts("polarisnonemp@gmail.com", "Polaris2015");
        public static readonly QaUserAccounts NON_EMPLOYEE_2 = new QaUserAccounts("polarisnon1emp@gmail.com", "Polaris2015");
        public static readonly QaUserAccounts NON_EMPLOYEE_3 = new QaUserAccounts("polarisind.test@gmail.com", "th3w@y0ut");
        public static readonly QaUserAccounts EMPLOYEE_1 = new QaUserAccounts("Emp.polaris@gmail.com", "Polaris2015");
        public static readonly QaUserAccounts EMPLOYEE_2 = new QaUserAccounts("Emp1.polaris@gmail.com", "Polaris2015");

        public string Username { get; private set; }
        public string Password { get; private set; }
        QaUserAccounts(string userName, string password)
        {
            Username = userName;
            Password = password;
        }
    }

    class ProdUserAccounts
    {
        public static readonly ProdUserAccounts NON_EMPLOYEE_1 = new ProdUserAccounts("testenUsInternal@polaris.com", "Polaris2014");
        public static readonly ProdUserAccounts NON_EMPLOYEE_2 = new ProdUserAccounts("testenCAInternal@polaris.com", "Polaris2014");
        public static readonly ProdUserAccounts NON_EMPLOYEE_3 = new ProdUserAccounts("testesMXinternal@polaris.com", "Polaris2014");
        public static readonly ProdUserAccounts NON_EMPLOYEE_4 = new ProdUserAccounts("testfrCAInternal@polaris.com", "Polaris2014");
        public static readonly ProdUserAccounts EMPLOYEE_1 = new ProdUserAccounts("testenUsExternal@polaris.com", "Flowers2012");
        public static readonly ProdUserAccounts EMPLOYEE_2 = new ProdUserAccounts("testenUsExternal@polaris.com", "Polaris2014");
        public static readonly ProdUserAccounts EMPLOYEE_3 = new ProdUserAccounts("testenUsExternal@polaris.com", "Polaris2014");
        public static readonly ProdUserAccounts EMPLOYEE_4 = new ProdUserAccounts("testenUsExternal@polaris.com", "Polaris2014");

        public string Username { get; private set; }
        public string Password { get; private set; }
        ProdUserAccounts(string userName, string password)
        {
            Username = userName;
            Password = password;
        }
    }
}
