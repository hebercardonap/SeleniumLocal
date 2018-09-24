using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.DataProvider
{
    public class AccountDetails
    {
        public static readonly AccountDetails TEST_USER_1 = new AccountDetails("Peter", "Griffin", "testenUsExternal@polaris.com", "7895412365", "55057", "123 Fake St", "Thank you, Peter");
        public static readonly AccountDetails TEST_USER_2 = new AccountDetails("Stan", "Smith", "testenUsExternal@polaris.com", "7412589632", "30328", "123 Fake St", "Thank you, Stan");
        public static readonly AccountDetails TEST_USER_3 = new AccountDetails("Homer", "Simpson", "testenUsExternal@polaris.com", "3216549874", "85001", "123 Fake St", "Thank you, Homer");
        public static readonly AccountDetails TEST_USER_4 = new AccountDetails("Marge", "Simpson", "testenUsExternal@polaris.com", "6541748528", "70112", "123 Fake St", "Thank you, Marge");
        public static readonly AccountDetails TEST_USER_5 = new AccountDetails("Bart", "Simpson", "testenUsExternal@polaris.com", "6587412547", "27565", "332 Hillsboro St", "Thank you, Bart");
        public static readonly AccountDetails TEST_USER_6 = new AccountDetails("Lisa", "Simpson", "testenUsExternal@polaris.com", "8547856985", "25813", "123 Fake St", "Thank you, Lisa");
        public static readonly AccountDetails TEST_USER_7 = new AccountDetails("Maggie", "Simpson", "testenUsExternal@polaris.com", "1254785456", "63101", "123 Fake St", "Thank you, Maggie");
        public static readonly AccountDetails TEST_USER_8 = new AccountDetails("Rogger", "Smith", "testenUsExternal@polaris.com", "8521478569", "24517", "123 Fake St", "Thank you, Rogger");
        public static readonly AccountDetails TEST_USER_9 = new AccountDetails("Stewie", "Griffin", "testenUsExternal@polaris.com", "8523654178", "29020", "123 Fake St", "Thank you, Stewie");
        public static readonly AccountDetails TEST_USER_10 = new AccountDetails("Franscine", "Smith", "testenUsExternal@polaris.com", "9632587412", "59044", "123 Fake St", "Thank you, Franscine");
        public static readonly AccountDetails TEST_USER_11 = new AccountDetails("Steve", "Smith", "testenUsExternal@polaris.com", "9632584712", "72201", "123 Fake St", "Thank you, Steve");

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }
        public string ZipCode { get; private set; }
        public string StreetAddress { get; private set; }
        public string RequestMessage { get; private set; }

        AccountDetails(string firstName, string lastName, string email, string phoneNumber, string zipCode,
            string streetAddress, string requestMessage)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            ZipCode = zipCode;
            StreetAddress = streetAddress;
            RequestMessage = requestMessage;
        }
    }
}