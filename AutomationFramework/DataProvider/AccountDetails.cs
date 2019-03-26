using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.DataProvider
{
    public class AccountDetails
    {
        public static readonly AccountDetails TEST_USER_1 = new AccountDetails("Heber", "Test", "testenUsExternal@polaris.com", "7895412365", "55057", "A1A 1A1", "123 Fake St", "This is a test build submitted by Polaris QA tester");
        public static readonly AccountDetails TEST_USER_2 = new AccountDetails("Heber", "Test", "testenUsExternal@polaris.com", "7412589632", "30328", "A1A 1A1", "123 Fake St", "This is a test build submitted by Polaris QA tester");
        public static readonly AccountDetails TEST_USER_3 = new AccountDetails("Heber", "Test", "testenUsExternal@polaris.com", "3216549874", "85001", "A1A 1A1", "123 Fake St", "This is a test build submitted by Polaris QA tester");
        public static readonly AccountDetails TEST_USER_4 = new AccountDetails("Heber", "Test", "testenUsExternal@polaris.com", "6541748528", "70112", "A1A 1A1", "123 Fake St", "This is a test build submitted by Polaris QA tester");
        public static readonly AccountDetails TEST_USER_5 = new AccountDetails("Heber", "Test", "testenUsExternal@polaris.com", "6587412547", "27565", "A1A 1A1", "332 Hillsboro St", "This is a test build submitted by Polaris QA tester");
        public static readonly AccountDetails TEST_USER_6 = new AccountDetails("Heber", "Test", "testenUsExternal@polaris.com", "8547856985", "25813", "A1A 1A1", "123 Fake St", "This is a test build submitted by Polaris QA tester");
        public static readonly AccountDetails TEST_USER_7 = new AccountDetails("Heber", "Test", "testenUsExternal@polaris.com", "1254785456", "63101", "A1A 1A1", "123 Fake St", "This is a test build submitted by Polaris QA tester");
        public static readonly AccountDetails TEST_USER_8 = new AccountDetails("Heber", "Test", "testenUsExternal@polaris.com", "8521478569", "24517", "A1A 1A1", "123 Fake St", "This is a test build submitted by Polaris QA tester");
        public static readonly AccountDetails TEST_USER_9 = new AccountDetails("Heber", "Test", "testenUsExternal@polaris.com", "8523654178", "29020", "A1A 1A1", "123 Fake St", "This is a test build submitted by Polaris QA tester");
        public static readonly AccountDetails TEST_USER_10 = new AccountDetails("Heber", "Test", "testenUsExternal@polaris.com", "9632587412", "59044", "A1A 1A1", "123 Fake St", "This is a test build submitted by Polaris QA tester");
        public static readonly AccountDetails TEST_USER_11 = new AccountDetails("Heber", "Test", "testenUsExternal@polaris.com", "9632584712", "72201", "A1A 1A1", "123 Fake St", "This is a test build submitted by Polaris QA tester");

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }
        public string ZipCode { get; private set; }
        public string CaZipCode { get; private set; }
        public string StreetAddress { get; private set; }
        public string Comments { get; private set; }

        AccountDetails(string firstName, string lastName, string email, string phoneNumber, string usZipCode, string caZipCode,
            string streetAddress, string comments)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            ZipCode = ConfigurationManager.AppSettings["locale"].ToString() == "en-us" ? usZipCode : caZipCode ?? usZipCode;
            StreetAddress = streetAddress;
            Comments = comments;
        }
    }
}