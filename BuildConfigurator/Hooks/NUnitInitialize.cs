using AutomationFramework.Base;
using BuildConfigurator.TestBases;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Hooks
{
    public class NUnitInitialize : TestInitializeHook
    {

        [SetUp]
        public void Initialize()
        {
            InitializeSettings();
        }

        [TearDown]
        public void CleanUp()
        {
            _parallelConfig.Driver.Close();
            _parallelConfig.Driver.Quit();
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
