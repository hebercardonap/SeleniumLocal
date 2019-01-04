using AutomationFramework.Base;
using BuildConfigurator.Pages;
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
    }
}
