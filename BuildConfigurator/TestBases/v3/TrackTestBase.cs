using AutomationFramework.Base;
using BuildConfigurator.Pages.v3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.TestBases.v3
{
    public class TrackTestBase : TrackPage
    {
        public TrackTestBase(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }
    }
}
