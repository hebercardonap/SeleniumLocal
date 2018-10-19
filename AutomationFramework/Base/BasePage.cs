using AutomationFramework.Extensions;
using AutomationFramework.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Base
{
    public class BasePage : Base
    {
        public BasePage(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public bool stringEqualsIgnoreCase(string a, string b)
        {
            return string.Equals(a, b, StringComparison.OrdinalIgnoreCase);
        }

        public bool stringContainsIgnoreCase(string a, string b)
        {
            return a.IndexOf(b, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        public DriverActions DriverActions
        {
            get
            {
                return new DriverActions(_parallelConfig);
            }
        }

    }
}
