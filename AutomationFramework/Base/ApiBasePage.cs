using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Base
{
    public class ApiBasePage
    {
        public bool stringEqualsIgnoreCase(string a, string b)
        {
            return string.Equals(a, b, StringComparison.OrdinalIgnoreCase);
        }

        public bool stringContainsIgnoreCase(string a, string b)
        {
            return a.IndexOf(b, StringComparison.OrdinalIgnoreCase) >= 0;
        }
    }
}
