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
using System.Reflection;
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

        public OptionsTestBase Options
        {
            get { return new OptionsTestBase(_parallelConfig); }
        }

        private void GetTestNames()
        {
            // Load the assembly containing your fixtures
            Assembly a = Assembly.LoadFrom(@"C:\Users\hcardo\Selenium\CPQ\SeleniumFramework\BuildConfigurator\bin\Debug\BuildConfigurator.dll");
            var testNames = string.Empty;
            // Foreach public class that is a TestFixture and not Ignored
            foreach (var c in a.GetTypes()
                               .Where(x => x.IsPublic
                               && (x.GetCustomAttributes(typeof(TestFixtureAttribute)).Count() > 0)
                               && (x.GetCustomAttributes(typeof(IgnoreAttribute)).Count() == 0)))
            {

                // For each public method that is a Test and not Ignored
                foreach (var m in c.GetMethods()
                               .Where(x => x.IsPublic
                               && (x.GetCustomAttributes(typeof(TestAttribute)).Count() > 0)
                               && (x.GetCustomAttributes(typeof(IgnoreAttribute)).Count() == 0)
                               || (x.GetCustomAttributes(typeof(TestCaseAttribute)).Count() > 0)
                               || (x.GetCustomAttributes(typeof(TestCaseSourceAttribute)).Count() > 0)))
                {
                    var testAttributes = m.GetCustomAttributes(typeof(TestAttribute)) as IEnumerable<TestAttribute>;
                    var caseAttributes = m.GetCustomAttributes(typeof(TestCaseAttribute)) as IEnumerable<TestCaseAttribute>;
                    var caseSourceAttributes = m.GetCustomAttributes(typeof(TestCaseSourceAttribute)) as IEnumerable<TestCaseSourceAttribute>;

                    if (caseAttributes.Count() > 0)
                    {
                        foreach (var testCase in caseAttributes)
                        {
                            if (!string.IsNullOrEmpty(testCase.TestName))
                            {
                                testNames += string.Format("{0}, {1}\n", c.ToString(), testCase.TestName);
                            }
                            else
                            {
                                testNames += string.Format("{0}, {1}\n", c.ToString(), m.Name);
                            }
                        }
                    }
                    // Print out the test name
                    testNames += string.Format("{0}.{1}\n", c.ToString(), m.Name);
                }
            }


            var testList = testNames;
        }


    }
}
