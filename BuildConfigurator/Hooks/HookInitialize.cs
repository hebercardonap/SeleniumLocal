using AutomationFramework.Base;
using AutomationFramework.Utils;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using TechTalk.SpecFlow;

namespace BuildConfigurator
{
    [Binding]
    public class HookInitialize : TestInitializeHook
    {
        private readonly ParallelConfig _parallelConfig;
        private readonly FeatureContext _featureContext;
        private readonly ScenarioContext _scenarioContext;
        private readonly TakeScreenshot _takeScreenshot;

        public HookInitialize(ParallelConfig parallelConfig, FeatureContext featureContext, ScenarioContext scenarioContext, TakeScreenshot takeScreenshot)
        {
            _parallelConfig = parallelConfig;
            _featureContext = featureContext;
            _scenarioContext = scenarioContext;
            _takeScreenshot = takeScreenshot;
        }

        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentReports extent;
        private static string _reportName = string.Format("{0:yyyymmddhhmmss}", DateTime.Now);
        private static Dictionary<string, ExtentTest> featureList = new Dictionary<string, ExtentTest>();
        private static Dictionary<string, ExtentTest> testList = new Dictionary<string, ExtentTest>();

        [AfterStep]
        public void AfterEachStep()
        {
            var stepName = _scenarioContext.StepContext.StepInfo.Text;
            //var featureName = _featureContext.FeatureInfo.Title;
            var scenarioName = _scenarioContext.ScenarioInfo.Title;

            var stepType = _scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();

            if (_scenarioContext.TestError == null)
            {
                if (stepType == "Given")
                    testList[scenarioName].CreateNode<Given>(_scenarioContext.StepContext.StepInfo.Text);
                else if (stepType == "When")
                    testList[scenarioName].CreateNode<When>(_scenarioContext.StepContext.StepInfo.Text);
                else if (stepType == "Then")
                    testList[scenarioName].CreateNode<Then>(_scenarioContext.StepContext.StepInfo.Text);
                else if (stepType == "And")
                    testList[scenarioName].CreateNode<And>(_scenarioContext.StepContext.StepInfo.Text);
            }
            else if (_scenarioContext.TestError != null)
            {

                if (stepType == "Given")
                    testList[scenarioName].CreateNode<Given>(_scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.Message).AddScreenCaptureFromPath(_takeScreenshot.Capture(_scenarioContext.ScenarioInfo.Title));
                else if (stepType == "When")
                    testList[scenarioName].CreateNode<When>(_scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.Message).AddScreenCaptureFromPath(_takeScreenshot.Capture(_scenarioContext.ScenarioInfo.Title));
                else if (stepType == "And")
                    testList[scenarioName].CreateNode<And>(_scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.Message).AddScreenCaptureFromPath(_takeScreenshot.Capture(_scenarioContext.ScenarioInfo.Title));
                else if (stepType == "Then")
                    testList[scenarioName].CreateNode<Then>(_scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.Message).AddScreenCaptureFromPath(_takeScreenshot.Capture(_scenarioContext.ScenarioInfo.Title));

            }
        }

        [BeforeTestRun]
        public static void TestInitalize()
        {

            //Initialize Extent report before test starts
            ExtentHtmlReporter htmlReporter;
            string dir = @"P:\IS\ALL_IS\App Groups\Web\QA\CPQ\Reports";
            if (Directory.Exists(dir))
            {
                htmlReporter = new ExtentHtmlReporter(dir + "\\" + _reportName + "ExtentReport.html");
            }
            else
            {
                Directory.CreateDirectory(dir);
                htmlReporter = new ExtentHtmlReporter(dir + "\\" + _reportName + "ExtentReport.html");
            }

            htmlReporter.Configuration().Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            //Attach report to reporter
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);

        }

        [BeforeScenario]
        public void Initialize()
        {
            GetTestNames();
            InitializeSettings();

            string currentFeature = _featureContext.FeatureInfo.Title;

            if (!featureList.ContainsKey(currentFeature))
            {
                featureName = extent.CreateTest<Feature>(_featureContext.FeatureInfo.Title);
                //featureName = ExtentTestManager.CreateParentTest(_featureContext.FeatureInfo.Title);
                featureList.Add(currentFeature, featureName);
            }
            else
            {
                featureName = featureList[currentFeature];
            }

            //Create dynamic scenario name
            scenario = featureName.CreateNode<Scenario>(_scenarioContext.ScenarioInfo.Title);

            if (!testList.ContainsKey(_scenarioContext.ScenarioInfo.Title))
            {
                testList.Add(_scenarioContext.ScenarioInfo.Title, scenario);
            }

        }

        [AfterScenario]
        public void TestCleanUp()
        {
            _parallelConfig.Driver.Close();
            _parallelConfig.Driver.Quit();
            extent.Flush();
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            //Create dynamic feature name
            //string currentFeature = FeatureContext.Current.FeatureInfo.Title;
            
            //if (!featureList.ContainsKey(currentFeature))
            //{
            //    featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
            //    featureList.Add(currentFeature, featureName);
            //}
            //else
            //{
            //    featureName = featureList[currentFeature];
            //}
        }

        private void logFailureAndTakeScreenshot()
        {

            if (_scenarioContext.TestError != null)
            {
                string screenShotName = _scenarioContext.ScenarioInfo.Title;
                _takeScreenshot.Capture(screenShotName);
            }
        }

        private void GetTestNames()
        {
            // Load the assembly containing your fixtures
            Assembly a = Assembly.LoadFrom(@"C: \Users\hcardo\Selenium\CPQ\SeleniumFramework\APITests\bin\Debug\APITests.dll");
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
                    testNames += string.Format("{0}, {1}\n", c.ToString(), m.Name);
                    }
            }
                    
            
            var testList = testNames;
        }

    }
}
