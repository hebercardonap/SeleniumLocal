using AutomationFramework.Base;
using BuildConfigurator.Pages.v2;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.TestBases.v2
{
    public class BuildConfigureTestBase : BuildConfigurePage
    {
        public BuildConfigureTestBase(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public void VerifyConflictContainerDisplayed()
        {
            Assert.IsTrue(IsConflictContainerDisplayed(), "Conflict container is not displayed");
            Assert.IsTrue(IsConflictHeaderDisplayed(), "Conflict container title is not as expected");
        }

        public void AddRandomTiresAccessory()
        {
            ClickRangerTiresCategory();
            ClickRangerTrailSubcategory();
            ClickRandomAccessoryCardAddButton();
        }
    }
}
