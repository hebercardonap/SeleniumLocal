using AutomationFramework.ApiUtils.ApiDataProvider;
using AutomationFramework.Base;
using AutomationFramework.Utils;
using BuildConfigurator.Pages.v3;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.TestBases.v3
{
    public class OptionsTestBase : OptionsPage
    {
        private static string YEAR = "2020";
        private static string DEALER = "54321";

        ApiDataProvider ApiDataProvider { get { return new ApiDataProvider(); } }

        Random rnd = new Random();

        public OptionsTestBase(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public void VerifyDefaultSubstepOptionSelected(string option)
        {
            Assert.AreEqual(GetOptionCheckedSubstepOptions(option), 1, "{0} checked options are not as expected");
        }

        public string GetNonStockSnowcheckColorPage()
        {
            List<string> snowBuildUrls = ApiDataProvider.GetBuildUrls(Brand.SNO, YEAR, DEALER);
            string snowCheckUrl = snowBuildUrls[rnd.Next(snowBuildUrls.Count)];
            return snowCheckUrl;
        }

        public bool VerifyOptionPageTitleAsExpected(string title)
        {
            return stringContainsIgnoreCase(GetOptionsPageTitle(), title);
        }

        public bool VerifySubstepListOptionsNotDuplicate(string option)
        {
            bool areSubstepOptionsUnique = true;
            var duplicateItems = GetSubstepListOptionsTitle(option).GroupBy(x => x)
                .Where(group => group.Count() > 1)
                .Select(group => group.Key).ToList();

            if (duplicateItems.Count > 0)
            {
                areSubstepOptionsUnique = false;
                string duplicateValues = string.Empty;
                foreach (var item in duplicateItems)
                {
                    duplicateValues += item + "\n";
                }
                Assert.Fail("There are duplicate substep options \n{0}", duplicateValues);
            }
            return areSubstepOptionsUnique;
        }
    }
}
