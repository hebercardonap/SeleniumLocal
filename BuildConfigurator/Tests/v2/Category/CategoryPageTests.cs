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

        [Test, Category(TestCategories.IND), Category(TestCategories.CATEGORY_PAGE), CustomRetry(1)]
        public void VerifyDuplicateCategoryInd()
        {
            CPQNavigate.NavigateToCategoryPage(Brand.IND);
            Assert.IsTrue(BuildCategoryPage.VerifyModelsAreNotDuplicates());
        }

        [Test, Category(TestCategories.IND), Category(TestCategories.CATEGORY_PAGE), CustomRetry(1)]
        public void VerifyCategoryModelsInd()
        {
            CPQNavigate.NavigateToCategoryPage(Brand.IND);
            BuildCategoryPage.ClickCategoryAndValidateModels();
        }

        [Test, Category(TestCategories.IND), Category(TestCategories.CATEGORY_PAGE), CustomRetry(1)]
        public void VerifyCategoryModelsUniqueInd()
        {
            CPQNavigate.NavigateToCategoryPage(Brand.IND);
            BuildCategoryPage.ClickCategoryAndVerifyModelsAreNotDuplicate();
        }

        private void VerifyCategoryModelsAreUnique()
        {
            int categories = BuildCategoryPage.GetCategoryWholegoodCards().Count;
            for (int i = 0; i < categories; i++)
            {
                BuildCategoryPage.DriverActions.clickElement(BuildCategoryPage.GetCategoryWholegoodCards()[i]);
                Assert.IsTrue(BuildModelPage.VerifyModelsAreNotDuplicates());
                BuildModelPage.GoToPreviousPage();
                BuildCategoryPage.WaitForCategoryPageToLoad();
            }
        }

       
    }
}
