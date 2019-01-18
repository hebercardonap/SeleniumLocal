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
            Assert.IsTrue(Toolbar.IsFullscreenIconEnabled());
            Assert.IsFalse(Toolbar.IsSnapshotIconEnabled());
            Assert.IsFalse(Toolbar.IsEmailIconEnabled());
            Assert.IsFalse(Toolbar.IsPrintIconEnabled());
            Assert.IsFalse(Toolbar.IsRestartIconEnabled());
        }
    }
}
