using AutomationFramework.Base;
using BuildConfigurator.Pages.v2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.TestBases.v2
{
    public class BuildQuoteTestBase : BuildQuotePage
    {
        public BuildQuoteTestBase(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public void FillQuoteFormDefaultData()
        {
            SetFirstName();
            SetLastName();
            SetEmail();
            SetPhoneNumber();
            SetPostalCode();
            WaitForDealerNameToBeDisplayed();
            ClickAgeCheckBox();
        }
    }
}
