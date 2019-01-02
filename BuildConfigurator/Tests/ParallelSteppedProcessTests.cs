using AutomationFramework.Base;
using AutomationFramework.Utils;
using BuildConfigurator.Hooks;
using BuildConfigurator.TestBases;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BuildConfigurator.Tests
{
    [TestFixture]
    public class ParallelSteppedProcessTests : NUnitInitialize
    {

        [Test]
        public void SampleNUnitTest()
        {
            CPQNavigate.NavigateToModelsPage(Brand.RAN);
            Models.ClickFourSeatModel();
            Thread.Sleep(5000);
        }
    }
}
