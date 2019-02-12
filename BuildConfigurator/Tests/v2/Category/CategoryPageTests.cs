using AutomationFramework.Helpers;
using AutomationFramework.Utils;
using BuildConfigurator.Hooks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Tests.v2.Category
{
    [TestFixture]
    public class CategoryPageTests : TestBase
    {

        [Test, Category(TestCategories.IND), Category(TestCategories.CATEGORY_PAGE), RetryDynamic]
        public void VerifyDuplicateCategoryInd()
        {
            CPQNavigate.NavigateToCategoryPage(Brand.IND);
            Assert.IsTrue(BuildCategoryPage.VerifyModelsAreNotDuplicates());
        }

        [Test, Category(TestCategories.IND), Category(TestCategories.CATEGORY_PAGE), RetryDynamic]
        public void VerifyCategoryModelsInd()
        {
            CPQNavigate.NavigateToCategoryPage(Brand.IND);
            BuildCategoryPage.ClickCategoryAndValidateModels();
        }

        [Test, Category(TestCategories.IND), Category(TestCategories.CATEGORY_PAGE), RetryDynamic]
        public void VerifyCategoryModelsUniqueInd()
        {
            CPQNavigate.NavigateToCategoryPage(Brand.IND);
            BuildCategoryPage.ClickCategoryAndVerifyModelsAreNotDuplicate();
        }

    }
}
