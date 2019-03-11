using AutomationFramework.Base;
using BuildConfigurator.Pages.v3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.TestBases.v3
{
    public class CategoryTestBase : CategoryPage
    {
        public CategoryTestBase(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public bool VerifyTitleHeadingAsExpected(string title)
        {
            bool isFound = false;
            if (GetCategoryPageTitleHeading().Length > 0 && stringContainsIgnoreCase(GetCategoryPageTitleHeading(), title))
                isFound = true;

            return isFound;
        }
    }
}
