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
    }
}
