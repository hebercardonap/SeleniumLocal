using AutomationFramework.Utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITests.Tests
{
    [TestFixture]

    public class DealerExperienceTests : DealerExperienceTestBase
    {
        private static readonly string TEST_DEALER = "02040900";
        private static readonly string INVALID_DEALER = "123456";
        private static readonly int INVALID_REQUEST_STATUS_CODE = 204;
        private static readonly int VALID_REQUEST_STATUS_CODE = 200;

        private static readonly Dictionary<string, string> BRAND_INVALID_YEAR_AFTER_CURRENT = new Dictionary<string, string> { { Brand.RZR, "2021"},
            { Brand.RAN, "2021" }, { Brand.GEN, "2021"}, { Brand.ATV, "2021"}, { Brand.ACE, "2021"}};
        private static readonly Dictionary<string, string> BRAND_INVALID_YEAR_BEFORE_CURRENT = new Dictionary<string, string> { { Brand.RZR, "2021"},
            { Brand.RAN, "2021" }, { Brand.GEN, "2021"}, { Brand.ATV, "2021"}, { Brand.ACE, "2021"}};
        private static readonly Dictionary<string, string> BRAND_VALID_YEAR = new Dictionary<string, string> { { Brand.RZR, "2019"},
            { Brand.RAN, "2019" }, { Brand.GEN, "2019"}, { Brand.ATV, "2019"}, { Brand.ACE, "2019"}};

        [Test, Category(TestCategories.DEALER_EXPERIENCE)]
        public void VerifyInvalidYearResponse()
        {
            foreach (KeyValuePair<string, string> value in BRAND_INVALID_YEAR_AFTER_CURRENT)
            {
                SetDealerExperienceBrandUrl(value.Key, value.Value, TEST_DEALER);
                CreateGetRequest();
                Assert.AreEqual(INVALID_REQUEST_STATUS_CODE, GetResponseStatusCode(), 
                    "Response not as expected for {0} brand and {1} year", value.Key, value.Value);
            }
        }

        [Test, Category(TestCategories.DEALER_EXPERIENCE)]
        public void VerifyInvalidYearResponseBeforeCurrentYear()
        {
            foreach (KeyValuePair<string, string> value in BRAND_INVALID_YEAR_BEFORE_CURRENT)
            {
                SetDealerExperienceBrandUrl(value.Key, value.Value, TEST_DEALER);
                CreateGetRequest();
                Assert.AreEqual(INVALID_REQUEST_STATUS_CODE, GetResponseStatusCode(),
                    "Response not as expected for {0} brand and {1} year", value.Key, value.Value);
            }
        }

        [Test, Category(TestCategories.DEALER_EXPERIENCE)]
        public void VerifyInvalidDealerId()
        {
            foreach (KeyValuePair<string, string> value in BRAND_VALID_YEAR)
            {
                SetDealerExperienceBrandUrl(value.Key, value.Value, INVALID_DEALER);
                CreateGetRequest();
                Assert.AreEqual(INVALID_REQUEST_STATUS_CODE, GetResponseStatusCode(),
                    "Response not as expected for {0} brand and {1} year", value.Key, value.Value);
            }
        }

        [Test, Category(TestCategories.DEALER_EXPERIENCE)]
        public void VerifyValidRequest()
        {
            foreach (KeyValuePair<string, string> value in BRAND_VALID_YEAR)
            {
                SetDealerExperienceBrandUrl(value.Key, value.Value, TEST_DEALER);
                CreateGetRequest();
                Assert.AreEqual(VALID_REQUEST_STATUS_CODE, GetResponseStatusCode(),
                    "Response not as expected for {0} brand and {1} year", value.Key, value.Value);
            }
        }

        [Test, Category(TestCategories.DEALER_EXPERIENCE)]
        public void VerifyValidRequestRepsonseProperties()
        {
            foreach (KeyValuePair<string, string> value in BRAND_VALID_YEAR)
            {
                SetDealerExperienceBrandUrl(value.Key, value.Value, TEST_DEALER);
                CreateGetRequest();
                Assert.AreEqual(VALID_REQUEST_STATUS_CODE, GetResponseStatusCode(),
                    "Response not as expected for {0} brand and {1} year", value.Key, value.Value);
                ResponsePropertyValuesAsExpected(value.Key);
            }
        }
    }
}
