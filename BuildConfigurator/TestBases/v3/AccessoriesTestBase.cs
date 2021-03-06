﻿using AutomationFramework.Base;
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
        private string ICON_NOT_EXPECTED_ERROR = "Icon {0} was not expected to be displayed";
        private string ICON__EXPECTED_ERROR = "Icon {0} was expected to be displayed";
        
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
            Assert.IsFalse(IsSummarySaveIconDisplayed(), string.Format(ICON_NOT_EXPECTED_ERROR, "save"));
            Assert.IsFalse(IsSummaryEmailIconDisplayed(), string.Format(ICON_NOT_EXPECTED_ERROR, "email"));
            Assert.IsFalse(IsSummaryPrintIconDisplayed(), string.Format(ICON_NOT_EXPECTED_ERROR, "print"));
        }

        public void VerifyBuildSummaryIconsNotPresent()
        {
            Assert.IsFalse(IsSummarySaveIconDisplayed(), string.Format(ICON_NOT_EXPECTED_ERROR, "save"));
            Assert.IsFalse(IsSummaryEmailIconDisplayed(), string.Format(ICON_NOT_EXPECTED_ERROR, "email"));
            Assert.IsFalse(IsSummaryPrintIconDisplayed(), string.Format(ICON_NOT_EXPECTED_ERROR, "print"));
        }

        public void VerifyToolbarIconsAreEnabled()
        {
            Assert.IsTrue(Toolbar.IsFullscreenIconVisibleAndEnabled(), string.Format(ICON__EXPECTED_ERROR, "full screen"));
            Assert.IsTrue(Toolbar.IsInteriorExteriorIconVisibleAndEnabled(), string.Format(ICON__EXPECTED_ERROR, "interior/exterior"));
            Assert.IsTrue(Toolbar.IsSnapshotIconVisibleAndEnabled(), string.Format(ICON__EXPECTED_ERROR, "sanpshot"));
            Assert.IsTrue(Toolbar.IsEmailIconVisibleAndEnabled(), string.Format(ICON__EXPECTED_ERROR, "email"));
            Assert.IsTrue(Toolbar.IsPrintIconVisibleAndEnabled(), string.Format(ICON__EXPECTED_ERROR, "print"));
            Assert.IsTrue(Toolbar.IsRestartIconVisibleAndEnabled(), string.Format(ICON__EXPECTED_ERROR, "restart"));
            Assert.IsTrue(Toolbar.IsSaveIconVisibleAndEnabled(), string.Format(ICON__EXPECTED_ERROR, "save"));
        }

        public void VerifyHeaderItemsForDealerExp()
        {
            Assert.IsFalse(HeaderModule.IsHeaderCloseIconDisplayed(), string.Format(ICON_NOT_EXPECTED_ERROR, "close"));
            Assert.IsFalse(HeaderModule.IsHeaderSignInIconDisplayed(), string.Format(ICON_NOT_EXPECTED_ERROR, "sign in"));
            Assert.IsFalse(HeaderModule.IsAccountHeaderIconDisplayed(), string.Format(ICON_NOT_EXPECTED_ERROR, "account"));
        }

        public void VerifyToolBarItemsForDealerExp()
        {
            Assert.IsTrue(Toolbar.IsFullscreenIconVisibleAndEnabled(), string.Format(ICON__EXPECTED_ERROR, "full screen"));
            Assert.IsTrue(Toolbar.IsInteriorExteriorIconVisibleAndEnabled(), string.Format(ICON__EXPECTED_ERROR, "interior/exterior"));
            Assert.IsFalse(Toolbar.IsSaveIconVisibleAndEnabled(), string.Format(ICON_NOT_EXPECTED_ERROR, "save"));
            Assert.IsFalse(Toolbar.IsEmailIconVisibleAndEnabled(), string.Format(ICON_NOT_EXPECTED_ERROR, "email"));
            Assert.IsFalse(Toolbar.IsPrintIconVisibleAndEnabled(), string.Format(ICON_NOT_EXPECTED_ERROR, "print"));
            Assert.IsFalse(Toolbar.IsSnapshotIconVisibleAndEnabled(), string.Format(ICON_NOT_EXPECTED_ERROR, "snapshot"));
            Assert.IsFalse(Toolbar.IsRestartIconVisibleAndEnabled(), string.Format(ICON_NOT_EXPECTED_ERROR, "restart"));
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
                Assert.Fail("Item descriptions missing on build summary: \n{0}", string.Join("\n", itemsMissing.ToArray()));
            }
        }

        public void VerifyKitPackageDescPresentBuildSummary(string[] itemDescriptions)
        {
            List<string> itemsMissing = new List<string>();

            foreach (var item in itemDescriptions)
            {
                if (!IsKitPackageDescPresentBuildSummary(item))
                {
                    itemsMissing.Add(item);
                }
            }

            if (itemsMissing.Count > 0)
            {
                Assert.Fail("Kit/Package descriptions missing on build summary: \n{0}", string.Join("\n", itemsMissing.ToArray()));
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
                Assert.Fail("Item descriptions present on build summary: \n{0}", string.Join("\n", itemsMissing.ToArray()));
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
                Assert.Fail("Item ID missing on build summary: \n{0}", string.Join("\n", itemsMissing.ToArray()));
            }
        }

        public void OpenSavedBuildAndDelete()
        {
            AccountModule.ClickAcctLoggedInIcon();
            AccountModule.ClickAcctModalSavedVehicles();
            Assert.IsTrue(VerifySavedBuildIsPresent());
            DeleteSavedVehicle();
        }
    }
}
