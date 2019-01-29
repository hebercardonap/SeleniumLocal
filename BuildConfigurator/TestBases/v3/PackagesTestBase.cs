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
        public PackagesTestBase(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public bool VerifyModelIdChangedAfterPackageAdd(string initialModel)
        {
            return GetWholegoodModelId() != initialModel;
        }

        public void VerifyToolbarIconsStatePackagesPage()
        {
            Assert.IsTrue(Toolbar.IsFullscreenIconVisibleAndEnabled());
            Assert.IsTrue(Toolbar.IsInteriorExteriorIconVisibleAndEnabled());
            Assert.IsTrue(Toolbar.IsSnapshotIconVisibleAndEnabled());
            Assert.IsFalse(Toolbar.IsEmailIconVisibleAndEnabled());
            Assert.IsFalse(Toolbar.IsPrintIconVisibleAndEnabled());
            Assert.IsFalse(Toolbar.IsRestartIconVisibleAndEnabled());
            Assert.IsFalse(Toolbar.IsSaveIconVisibleAndEnabled());
        }
    }
}
