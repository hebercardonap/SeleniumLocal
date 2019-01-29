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

        public void VerifyBuildSummaryIconsNotPresent()
        {
            Assert.IsFalse(IsSummarySaveIconDisplayed());
            Assert.IsFalse(IsSummaryEmailIconDisplayed());
            Assert.IsFalse(IsSummaryPrintIconDisplayed());
        }

        public void VerifyToolbarIconsAreEnabled()
        {
            Assert.IsTrue(Toolbar.IsFullscreenIconVisibleAndEnabled());
            Assert.IsTrue(Toolbar.IsInteriorExteriorIconVisibleAndEnabled());
            Assert.IsTrue(Toolbar.IsSnapshotIconVisibleAndEnabled());
            Assert.IsTrue(Toolbar.IsEmailIconVisibleAndEnabled());
            Assert.IsTrue(Toolbar.IsPrintIconVisibleAndEnabled());
            Assert.IsTrue(Toolbar.IsRestartIconVisibleAndEnabled());
            Assert.IsTrue(Toolbar.IsSaveIconVisibleAndEnabled());
        }

        public bool RemoveConlfictPartAndValidateInBuildSummary(string accessoryDesc)
        {
            ClickConflictingItemRemoveByDesc(accessoryDesc);
            WaitForAccessoriesPageToLoad();
            FooterModule.OpenBuildSummary();
            WaitUntilBuildSummaryIsDisplayed();
            return IsProductDescPresentBuildSummary(accessoryDesc);
        }

        public void VerifyItemsDescPresentBuildSummary(string [] itemDescriptions)
        {
            List<string> itemsMissing = new List<string>();

            foreach (var item in itemDescriptions)
            {
                if (!IsProductDescPresentBuildSummary(item))
                {
                    itemsMissing.Add(item);
                }
            }

            if (itemsMissing.Count > 0)
            {
                Assert.Fail("Item descriptions missing on build summary: {0}", string.Join("\n", itemsMissing.ToArray()));
            }
        }

        public void VerifyItemsDescNotPresentBuildSummary(string[] itemDescriptions)
        {
            List<string> itemsMissing = new List<string>();

            foreach (var item in itemDescriptions)
            {
                if (IsProductDescPresentBuildSummary(item))
                {
                    itemsMissing.Add(item);
                }
            }

            if (itemsMissing.Count > 0)
            {
                Assert.Fail("Item descriptions present on build summary: {0}", string.Join("\n", itemsMissing.ToArray()));
            }
        }

        public void VerifyItemsIdPresentBuildSummary(string[] itemId)
        {
            List<string> itemsMissing = new List<string>();

            foreach (var item in itemId)
            {
                if (!IsProductIdsAddedBuildSummary(item))
                {
                    itemsMissing.Add(item);
                }
            }

            if (itemsMissing.Count > 0)
            {
                Assert.Fail("Item ID missing on build summary: {0}", string.Join("\n", itemsMissing.ToArray()));
            }
        }
    }
}
