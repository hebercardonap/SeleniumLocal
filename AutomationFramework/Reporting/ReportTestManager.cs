using AventStack.ExtentReports;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Reporting
{
    public class ReportTestManager
    {
        private static Dictionary<string, ExtentTest> testList = new Dictionary<string, ExtentTest>();

        [ThreadStatic]
        private static ExtentTest _parentTest;

        [ThreadStatic]
        private static ExtentTest _childTest;

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static ExtentTest CreateParentTest(string testName, string description = null)
        {
            _parentTest = ReportingManager.Instance.CreateTest(testName, description);
            return _parentTest;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static ExtentTest CreateTest(string testName, string description = null)
        {
            _childTest = _parentTest.CreateNode(testName, description);
            return _childTest;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static ExtentTest CreateTest(string testName)
        {
            if (!testList.ContainsKey(testName))
            {
                _childTest = _parentTest.CreateNode(testName);
                testList.Add(testName, _childTest);
            }
            else
            {
                _childTest = testList[testName];
            }
            return _childTest;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static ExtentTest GetTest()
        {
            return _childTest;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static void FinalizeTest()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stacktrace = string.IsNullOrEmpty(TestContext.CurrentContext.Result.StackTrace)
                ? ""
                : string.Format("<pre>{0}</pre>", TestContext.CurrentContext.Result.Message);

            Status logStatus;

            switch (status)
            {
                case TestStatus.Failed:
                    logStatus = Status.Fail;
                    break;
                case TestStatus.Inconclusive:
                    logStatus = Status.Warning;
                    break;
                case TestStatus.Skipped:
                    logStatus = Status.Skip;
                    break;
                default:
                    logStatus = Status.Pass;
                    break;
            }
            GetTest().Log(logStatus, "Test ended with " + logStatus + stacktrace);
        }
    }
}
