using AutomationFramework.Base;
using AutomationFramework.Config;
using AutomationFramework.Utils;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public HookInitialize(ParallelConfig parallelConfig, FeatureContext featureContext, ScenarioContext scenarioContext) : base(parallelConfig)
        {
            _parallelConfig = parallelConfig;
            _featureContext = featureContext;
            _scenarioContext = scenarioContext;
        }

        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentReports extent;
        private static KlovReporter klov;
        private static string _reportName = string.Format("{0:yyyymmddhhmmss}", DateTime.Now);
        private static Dictionary<string, ExtentTest> featureList = new Dictionary<string, ExtentTest>();

        [AfterStep]
        public void AfterEachStep()
        {
            var stepName = _scenarioContext.StepContext.StepInfo.Text;
            var featureName = _featureContext.FeatureInfo.Title;
            var scenarioName = _scenarioContext.ScenarioInfo.Title;

            var stepType = _scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();

            if (_scenarioContext.TestError == null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(_scenarioContext.StepContext.StepInfo.Text);
                else if (stepType == "When")
                    scenario.CreateNode<When>(_scenarioContext.StepContext.StepInfo.Text);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(_scenarioContext.StepContext.StepInfo.Text);
                else if (stepType == "And")
                    scenario.CreateNode<And>(_scenarioContext.StepContext.StepInfo.Text);
            }
            else if (_scenarioContext.TestError != null)
            {

                if (stepType == "Given")
                    scenario.CreateNode<Given>(_scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.Message).AddScreenCaptureFromPath(_takeScreenshot.Capture(_scenarioContext.ScenarioInfo.Title));
                else if (stepType == "When")
                    scenario.CreateNode<When>(_scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.Message).AddScreenCaptureFromPath(_takeScreenshot.Capture(_scenarioContext.ScenarioInfo.Title));
                else if (stepType == "And")
                    scenario.CreateNode<And>(_scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.Message).AddScreenCaptureFromPath(_takeScreenshot.Capture(_scenarioContext.ScenarioInfo.Title));
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(_scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.Message).AddScreenCaptureFromPath(_takeScreenshot.Capture(_scenarioContext.ScenarioInfo.Title));
                    
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
            InitializeSettings();

            string currentFeature = _featureContext.FeatureInfo.Title;

            if (!featureList.ContainsKey(currentFeature))
            {
                featureName = extent.CreateTest<Feature>(_featureContext.FeatureInfo.Title);
                featureList.Add(currentFeature, featureName);
            }
            else
            {
                featureName = featureList[currentFeature];
            }

            //Create dynamic scenario name
            scenario = featureName.CreateNode<Scenario>(_scenarioContext.ScenarioInfo.Title);
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

    }
}
