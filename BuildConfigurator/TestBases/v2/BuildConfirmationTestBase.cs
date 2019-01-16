using AutomationFramework.Base;
using BuildConfigurator.Pages.v2;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.TestBases.v2
{
    public class BuildConfirmationTestBase : BuildConfirmationPage
    {
        public BuildConfirmationTestBase(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public void VerifyBuildconfirmationPageIsAsExpected()
        {
            Assert.IsTrue(IsTotalPriceDisplayed());
            Assert.IsTrue(GetAddedAccessoriesCount() > 0);
        }
    }
}
