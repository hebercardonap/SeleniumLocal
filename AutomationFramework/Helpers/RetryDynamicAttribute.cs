using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Helpers
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class RetryDynamicAttribute : CustomRetry
    {
        public RetryDynamicAttribute() :
        base(numberOfRetries.Value)
        {
        }

        private const int DEFAULT_TRIES = 1;
        static Lazy<int> numberOfRetries = new Lazy<int>(() => {
            int count = 0;
            return int.TryParse(ConfigurationManager.AppSettings["retryCount"], out count) ? count : DEFAULT_TRIES;
        });

    }
}
