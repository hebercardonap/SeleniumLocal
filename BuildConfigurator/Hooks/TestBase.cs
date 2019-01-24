using AutomationFramework.Base;
using BuildConfigurator.TestBases;
using BuildConfigurator.TestBases.v2;
using BuildConfigurator.TestBases.v3;
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

        public AccountMgmtTestBase AccountMgmt
        {
            get { return new AccountMgmtTestBase(_parallelConfig); }
        }

        public BuildCategoryTestBase BuildCategoryPage
        {
            get { return new BuildCategoryTestBase(_parallelConfig); }
        }

        public BuildColorTestBase BuildColorPage
        {
            get { return new BuildColorTestBase(_parallelConfig); }
        }

        public BuildConfigureTestBase BuildConfigurePage
        {
            get { return new BuildConfigureTestBase(_parallelConfig); }
        }

        public BuildConfirmationTestBase BuildConfirmationPage
        {
            get { return new BuildConfirmationTestBase(_parallelConfig); }
        }

        public BuildInfoModalTestBase BuildInfoModalPage
        {
            get { return new BuildInfoModalTestBase(_parallelConfig); }
        }

        public BuildLoginTestBase BuildLoginPage
        {
            get { return new BuildLoginTestBase(_parallelConfig); }
        }

        public BuildModelTestBase BuildModelPage
        {
            get { return new BuildModelTestBase(_parallelConfig); }
        }

        public BuildPackageTestBase BuildPackagePage
        {
            get { return new BuildPackageTestBase(_parallelConfig); }
        }

        public BuildQuoteTestBase BuildQuotePage
        {
            get { return new BuildQuoteTestBase(_parallelConfig); }
        }

        public BuildTrimTestBase BuildTrimPage
        {
            get { return new BuildTrimTestBase(_parallelConfig); }
        }

        public TrackTestBase Track
        {
            get { return new TrackTestBase(_parallelConfig); }
        }

        public EngineTestBase Engine
        {
            get { return new EngineTestBase(_parallelConfig); }
        }

    }
}
