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
        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentReports extent;
        private static KlovReporter klov;
        private static string _reportName = string.Format("{0:yyyymmddhhmmss}", DateTime.Now);

        [AfterStep]
        public void AfterEachStep()
        {
            var stepName = ScenarioContext.Current.StepContext.StepInfo.Text;
            var featureName = FeatureContext.Current.FeatureInfo.Title;
            var scenarioName = ScenarioContext.Current.ScenarioInfo.Title;

            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();

            if (ScenarioContext.Current.TestError == null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "And")
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
            }
            else if (ScenarioContext.Current.TestError != null)
            {

                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message).AddScreenCaptureFromPath(TakeScreenshot.Capture(ScenarioContext.Current.ScenarioInfo.Title));
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message).AddScreenCaptureFromPath(TakeScreenshot.Capture(ScenarioContext.Current.ScenarioInfo.Title));
                else if (stepType == "And")
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message).AddScreenCaptureFromPath(TakeScreenshot.Capture(ScenarioContext.Current.ScenarioInfo.Title));
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message).AddScreenCaptureFromPath(TakeScreenshot.Capture(ScenarioContext.Current.ScenarioInfo.Title));
                    
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
            //Create dynamic scenario name
            scenario = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
        }

        [AfterScenario]
        public void TestCleanUp()
        {
            DriverContext.Driver.Close();
            DriverContext.Driver.Quit();
            extent.Flush();
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            //Create dynamic feature name
            featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
        }

        private void logFailureAndTakeScreenshot()
        {

            if (ScenarioContext.Current.TestError != null)
            {
                string screenShotName = ScenarioContext.Current.ScenarioInfo.Title;
                TakeScreenshot.Capture(screenShotName);
            }
        }

    }
}
