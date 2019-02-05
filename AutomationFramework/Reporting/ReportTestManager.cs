using AutomationFramework.Extensions;
using AventStack.ExtentReports;
using log4net;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AutomationFramework.Reporting
{
    public class ReportTestManager
    {
        private static Dictionary<string, ExtentTest> testList = new Dictionary<string, ExtentTest>();
        ILog log;

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
            var message = string.Empty;
            var stacktrace = string.Empty;
            if (!string.IsNullOrEmpty(TestContext.CurrentContext.Result.StackTrace))
            {
                message = string.Format("<pre>{0}</pre>", TestContext.CurrentContext.Result.Message);
                stacktrace = TestContext.CurrentContext.Result.StackTrace;
            }

            //var stacktrace = string.IsNullOrEmpty(TestContext.CurrentContext.Result.StackTrace)
            //    ? ""
            //    : string.Format("<pre>{0}</pre>", TestContext.CurrentContext.Result.Message);

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
            GetTest().Log(logStatus, "Test ended with " + logStatus + message + stacktrace);
        }
    }
}
