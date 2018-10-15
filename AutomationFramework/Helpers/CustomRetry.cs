using System;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using NUnit.Framework.Internal.Commands;

namespace AutomationFramework.Helpers
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class CustomRetry : PropertyAttribute, IWrapSetUpTearDown
    {
        private int _count;

        public CustomRetry(int count) : base(count) { _count = count; }

        #region IWrapSetUpTearDown

        public TestCommand Wrap(TestCommand command) { return new CustomRetryCommand(command, _count); }

        #endregion

        #region Nested CustomRetry Class

        public class CustomRetryCommand : DelegatingTestCommand
        {
            private int _retryCount;

            public CustomRetryCommand(TestCommand innerCommand, int retryCount) : base(innerCommand) { _retryCount = retryCount; }

            public override TestResult Execute(TestExecutionContext context)
            { int count = _retryCount; while (count-- > 0)
                { context.CurrentResult = innerCommand.Execute(context);
                    var results = context.CurrentResult.ResultState;
                    if (results != ResultState.Error && results != ResultState.Failure && results != ResultState.SetUpError && results != ResultState.SetUpFailure && results != ResultState.TearDownError && results != ResultState.ChildFailure)
                    { break; }
                } return context.CurrentResult; }
        }
    }
    #endregion
}

