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
    public class TestBase : TestInitializeHook
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

        public TrimsTestBase Trims
        {
            get { return new TrimsTestBase(_parallelConfig); }
        }

        public ColorsTestBase Colors
        {
            get { return new ColorsTestBase(_parallelConfig); }
        }

        public AccessoriesTestBase Accessories
        {
            get { return new AccessoriesTestBase(_parallelConfig); }
        }

        public QuoteTestBase Quote
        {
            get { return new QuoteTestBase(_parallelConfig); }
        }

        public ConfirmationTestBase Confirmation
        {
            get { return new ConfirmationTestBase(_parallelConfig); }
        }

        public PackagesTestBase Packages
        {
            get { return new PackagesTestBase(_parallelConfig); }
        }

    }
}
