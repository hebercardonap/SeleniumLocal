using AutomationFramework.Base;
using BuildConfigurator.Pages.v2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.TestBases.v2
{
    public class BuildTrimTestBase : BuildTrimPage
    {
        public BuildTrimTestBase(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }
    }
}
