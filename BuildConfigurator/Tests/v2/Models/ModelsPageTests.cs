using AutomationFramework.Helpers;
using AutomationFramework.Utils;
using BuildConfigurator.Hooks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Tests.v2.Models
{
    [TestFixture]
    public class ModelsPageTests : TestBase
    {
        [Test, Category(TestCategories.IND), Category(TestCategories.MODELS_PAGE), CustomRetry(1)]
        public void VerifyDuplicateModelsInd()
        {
            CPQNavigate.NavigateToModelsPage(Brand.IND);
            Assert.IsTrue(BuildModelPage.VerifyModelsAreNotDuplicates());
        }
    }
}
