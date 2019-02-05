using AutomationFramework.Base;
using AutomationFramework.Reporting;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using BuildConfigurator.TestBases;
using BuildConfigurator.TestBases.v2;
using BuildConfigurator.TestBases.v3;
using log4net;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Hooks
{
    public class TestBase : TestInitializeHook
    {

        private static string _reportName = string.Format("{0:yyyymmddhhmmss}", DateTime.Now);
        ILog log;

        [SetUp]
        public void Initialize()
        {
            ReportTestManager.CreateTest(TestContext.CurrentContext.Test.Name);
            InitializeSettings();
        }

        [TearDown]
        public void CleanUp()
        {
            ReportTestManager.FinalizeTest();
            _parallelConfig.Driver.Close();
            _parallelConfig.Driver.Quit();
        }

        [OneTimeSetUp]
        public void ReportInitialize()
        {
            SetFrameworkSettings();
            ReportTestManager.CreateParentTest(GetType().Name);
        }

        [OneTimeTearDown]
        public void ReportTearDown()
        {
            ReportingManager.Instance.Flush();
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
