using AutomationFramework.Config;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Reporting
{
    public class ReportingManager
    {
        private static ExtentReports extent;

        public static ExtentHtmlReporter htmlReporter;

        private static string _reportName = string.Format("{0:yyyymmddhhmmss}", DateTime.Now);

        private static string dir = @"P:\IS\ALL_IS\App Groups\Web\QA\CPQ\Reports";

        private ExtentTest _test;

        static ReportingManager() { }
        public ReportingManager() {
            SetExtentReport();
        }

        public static void SetExtentReport()
        {
            if (extent == null)
            {
                htmlReporter = new ExtentHtmlReporter(dir + "\\" + _reportName + "_ExtentReport.html");
                htmlReporter.Configuration().DocumentTitle = "CPQ Tests";
                htmlReporter.Configuration().ReportName = "CPQ Tests";
                extent = new ExtentReports();
                extent.AttachReporter(htmlReporter);
                extent.AddSystemInfo("OS","Windows");
                extent.AddSystemInfo("Browser", Settings.Browser);
                extent.AddSystemInfo("Environment", Settings.Environment);
            }
        }

        public static ExtentReports Instance
        {
            get
            {
                SetExtentReport();
                return extent;
            }
        }

        public void InitializeTest()
        {
            _test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
        }

        public void FinalizeTest()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stacktrace = string.IsNullOrEmpty(TestContext.CurrentContext.Result.StackTrace)
                ? ""
                : string.Format("<pre>{0}</pre>", TestContext.CurrentContext.Result.Message);

            ExtentTest logStatus;

            switch (status)
            {
                case TestStatus.Failed:
                    logStatus = _test.Log(Status.Fail, "fail");
                    break;
                case TestStatus.Inconclusive:
                    logStatus = _test.Log(Status.Warning, "warning");
                    break;
                case TestStatus.Skipped:
                    logStatus = _test.Log(Status.Skip, "skip");
                    break;
                default:
                    logStatus = _test.Log(Status.Pass, "pass");
                    break;
            }
            _test.Log(_test.Status, "Test ended with " + logStatus + stacktrace);
            //_test.Log(_test.Status);
            //extent.RemoveTest(_test);
            extent.Flush();
        }
    }
}
