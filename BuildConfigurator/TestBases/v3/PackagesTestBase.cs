using AutomationFramework.Base;
using BuildConfigurator.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.TestBases
{
    public class PackagesTestBase : PackagesPage
    {
        private string ICON_NOT_EXPECTED_ERROR = "Icon {0} was not expected to be displayed";
        private string ICON__EXPECTED_ERROR = "Icon {0} was expected to be displayed";
        public PackagesTestBase(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public bool VerifyModelIdChangedAfterPackageAdd(string initialModel)
        {
            return GetWholegoodModelId() != initialModel;
        }

        public void VerifyToolbarIconsStatePackagesPage()
        {
            Assert.IsTrue(Toolbar.IsFullscreenIconVisibleAndEnabled(), string.Format(ICON__EXPECTED_ERROR, "full screen"));
            Assert.IsTrue(Toolbar.IsInteriorExteriorIconVisibleAndEnabled(), string.Format(ICON__EXPECTED_ERROR, "interior/exterior"));
            Assert.IsTrue(Toolbar.IsSnapshotIconVisibleAndEnabled(), string.Format(ICON__EXPECTED_ERROR, "snapshot"));
            Assert.IsFalse(Toolbar.IsEmailIconVisibleAndEnabled(), string.Format(ICON_NOT_EXPECTED_ERROR, "email"));
            Assert.IsFalse(Toolbar.IsPrintIconVisibleAndEnabled(), string.Format(ICON_NOT_EXPECTED_ERROR, "print"));
            Assert.IsFalse(Toolbar.IsRestartIconVisibleAndEnabled(), string.Format(ICON_NOT_EXPECTED_ERROR, "restart"));
            Assert.IsFalse(Toolbar.IsSaveIconVisibleAndEnabled(), string.Format(ICON_NOT_EXPECTED_ERROR, "save"));
        }
    }
}
