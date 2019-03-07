using AutomationFramework.Base;
using BuildConfigurator.Pages.v3;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.TestBases.v3
{
    public class OptionsTestBase : OptionsPage
    {
        public OptionsTestBase(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public void VerifyDefaultSubstepOptionSelected(string option)
        {
            Assert.AreEqual(GetOptionCheckedSubstepOptions(option), 1, "{0} checked options are not as expected");
        }
    }
}
