using AutomationFramework.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.TestBases
{
    public class TestBase : BasePage
    {
        public TestBase(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public CpqUrlTestBase CPQNavigate
        {
            get { return new CpqUrlTestBase(_parallelConfig); }
        }

        public ModelsTestBase Models
        {
            get { return new ModelsTestBase(_parallelConfig); }
        }
    }
}
