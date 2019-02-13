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
            Assert.IsTrue(GetAddedAccessoriesCount() > 0, "Accessories not present on build confirmation");
        }

        public void VerifyNewBuildConfirmationAsExpected()
        {
            Assert.IsTrue(IsTotalPriceDisplayed(), "Total price was not displayed");
            Assert.IsTrue(IsConfirmWholegoodNameDisplayed(), "Wholegood name not displayed on build confirmation");
            Assert.IsTrue(IsWholegoodImgDisplayed(), "Wholegood image not displayed on build confirmation");
            Assert.IsTrue(GetAddedAccessoryCountNewConfirmation() > 0, "Accessories not present on build confirmation");
        }
    }
}
