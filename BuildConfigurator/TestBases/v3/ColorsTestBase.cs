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
    public class ColorsTestBase : ColorsPage
    {
        public ColorsTestBase(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public void VerifyToolbarIconsStateColorPage()
        {
            Assert.IsTrue(Toolbar.IsFullscreenIconVisibleAndEnabled());
            Assert.IsTrue(Toolbar.IsSnapshotIconVisibleAndEnabled());
            Assert.IsFalse(Toolbar.IsEmailIconVisibleAndEnabled());
            Assert.IsFalse(Toolbar.IsPrintIconVisibleAndEnabled());
            Assert.IsFalse(Toolbar.IsRestartIconVisibleAndEnabled());
            Assert.IsFalse(Toolbar.IsSaveIconVisibleAndEnabled());
        }
    }
}
