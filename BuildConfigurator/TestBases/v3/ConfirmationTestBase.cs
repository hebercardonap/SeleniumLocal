using AutomationFramework.Base;
using BuildConfigurator.Pages.v3;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.TestBases
{
    public class ConfirmationTestBase : ConfirmationPage
    {
        public ConfirmationTestBase(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public void ConfirmationPageElementsAreAsExpected()
        {
            Assert.Greater(AccessoryAddedCount(), 0);
            Assert.IsTrue(IsBuildSummaryHeaderDisplayed());
        }

        public void VerifyPkgSubproductsPresentConfirmation(string[] itemDescriptions)
        {
            List<string> itemsMissing = new List<string>();

            foreach (var item in itemDescriptions)
            {
                if (!IsProductDescPresentBuildConfirmation(item))
                {
                    itemsMissing.Add(item);
                }
            }

            if (itemsMissing.Count > 0)
            {
                Assert.Fail("Item descriptions missing on build confirmation: \n{0}", string.Join("\n", itemsMissing.ToArray()));
            }
        }

        public void VerifyPackageDescPresentConfirmation(string[] itemDescriptions)
        {
            List<string> itemsMissing = new List<string>();

            foreach (var item in itemDescriptions)
            {
                if (!IsPackagePresentConfirmation(item))
                {
                    itemsMissing.Add(item);
                }
            }

            if (itemsMissing.Count > 0)
            {
                Assert.Fail("Package descriptions missing on build confirmation: \n{0}", string.Join("\n", itemsMissing.ToArray()));
            }
        }
    }
}
