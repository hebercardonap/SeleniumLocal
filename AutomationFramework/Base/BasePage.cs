using AutomationFramework.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Base
{
    public abstract class BasePage : Base
    {
        public static bool stringEqualsIgnoreCase(string a, string b)
        {
            return string.Equals(a, b, StringComparison.OrdinalIgnoreCase);
        }

        public static bool stringContainsIgnoreCase(string a, string b)
        {
            return a.IndexOf(b, StringComparison.OrdinalIgnoreCase) >= 0;
        }

    }
}
