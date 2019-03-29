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
            ClickQuoteCommentsAndEnterText();
            ClickAgeCheckBox();
        }

        public void FillDealerExpQuoteFormDefaultData()
        {
            SetFirstName();
            ClickAwayForFocusQuotePage();
            SetLastName();
            ClickAwayForFocusQuotePage();
            SetEmail();
            ClickAwayForFocusQuotePage();
            SetPhoneNumber();
            ClickAwayForFocusQuotePage();
            ClickAgeCheckBox();
        }

        public void ClickQuoteCommentsAndEnterText()
        {
            ClickQuoteCommentsPlusSign();
            DriverActions.waitForAjaxRequestToComplete();
            EnterQuoteComments();
        }

        public void VerifyQuotePageDealerExpUI()
        {
            Assert.IsTrue(stringContainsIgnoreCase(GetQuotePageHeaderTitle(), "Dealer Quote")
                , "Dealer Quote title is not present");
            Assert.IsFalse(IsQuotePageHeaderMenuDisplayed(), "Header Menu is displayed and was not expected");
            Assert.IsFalse(IsQuotePagePrivacyTermsDisplayed(), "Privacy Terms was displayed and was not expected");
            Assert.IsFalse(IsQuotePageGlobalFooterDisplayed(), "Global Footer is displayed and was not expected");
        }
    }
}
