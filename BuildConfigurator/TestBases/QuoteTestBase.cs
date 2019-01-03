using AutomationFramework.Base;
using BuildConfigurator.Pages.v3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.TestBases
{
    public class QuoteTestBase : QuotePage
    {
        public QuoteTestBase(ParallelConfig parallelConfig) : base(parallelConfig)
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
