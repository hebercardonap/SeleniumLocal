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
    public class AccessoriesTestBase : AccessoriesPage
    {
        public AccessoriesTestBase(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public void VerifyIconsAndAdditionalNotesPresent()
        {
            Assert.IsTrue(IsSummarySaveIconDisplayed());
            Assert.IsTrue(IsSummaryEmailIconDisplayed());
            Assert.IsTrue(IsSummaryPrintIconDisplayed());
            Assert.IsTrue(IsSummaryAdditionalNotesDisplayed());
        }

        public void VerifyIconsAndAdditionalNotesNotPresent()
        {
            Assert.IsFalse(IsSummarySaveIconDisplayed());
            Assert.IsFalse(IsSummaryEmailIconDisplayed());
            Assert.IsFalse(IsSummaryPrintIconDisplayed());
        }

        public void VerifyToolbarIconsAreEnabled()
        {
            Assert.IsTrue(Toolbar.IsFullscreenIconEnabled());
            Assert.IsTrue(Toolbar.IsInteriorExteriorIconEnabled());
            Assert.IsTrue(Toolbar.IsSnapshotIconEnabled());
            Assert.IsTrue(Toolbar.IsEmailIconEnabled());
            Assert.IsTrue(Toolbar.IsPrintIconEnabled());
            Assert.IsTrue(Toolbar.IsRestartIconEnabled());
        }
    }
}
