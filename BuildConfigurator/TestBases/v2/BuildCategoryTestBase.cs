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
    public class BuildCategoryTestBase : BuildCategoryPage
    {
        public BuildCategoryTestBase(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public bool VerifyModelsAreNotDuplicates()
        {
            bool areModelsUnique = true;
            var duplicateItems = GetWholegoodCardTitleLabels().GroupBy(x => x)
                .Where(group => group.Count() > 1)
                .Select(group => group.Key).ToList();

            if (duplicateItems.Count > 0)
            {
                areModelsUnique = false;
                string duplicateValues = string.Empty;
                foreach (var item in duplicateItems)
                {
                    duplicateValues += item + "\n";
                }
                Assert.Fail("There are duplicate models \n{0}", duplicateValues);
            }
            return areModelsUnique;
        }

        public void ClickByCategoryAndValidateSubModels()
        {
            int wholegoodCards = GetCategoryWholegoodCards().Count;
            Assert.Greater(wholegoodCards, 0, "Wholegood cards collection is null");

            for (int i = 0; i < wholegoodCards; i++)
            {
                string category = GetWholegoodcardLabelTitle(GetCategoryWholegoodCards()[i]);
                ClickCategoryWholegoodCard(GetCategoryWholegoodCards()[i]);
            }
        }

        public void ClickCategoryAndValidateModels()
        {
            int wholegoodCards = GetCategoryWholegoodCards().Count;
            Assert.Greater(wholegoodCards, 0, "Wholegood cards collection is null");

            for (int i = 0; i < wholegoodCards; i++)
            {
                string categoryLabel = GetWholegoodcardLabelTitle(GetCategoryWholegoodCards()[i]);
                ClickCategoryWholegoodCard(GetCategoryWholegoodCards()[i]);

                List<string> categoryModels = GetWholegoodCardTitleLabels();
                Assert.Greater(categoryModels.Count, 0, "No category models were displayed");

                foreach (var model in categoryModels)
                {
                    Assert.IsTrue(stringContainsIgnoreCase(model, categoryLabel),
                        "Model {0} might not be part of category {1}", model, categoryLabel);
                }

                GoToPreviousPage();
                WaitForCategoryPageToLoad();
            }
        }

        public void ClickCategoryAndVerifyModelsAreNotDuplicate()
        {
            int categories = GetCategoryWholegoodCards().Count;
            Assert.Greater(categories, 0, "Wholegood cards collection is null");

            for (int i = 0; i < categories; i++)
            {
                DriverActions.clickElement(GetCategoryWholegoodCards()[i]);
                Assert.IsTrue(VerifyModelsAreNotDuplicates());
                GoToPreviousPage();
                WaitForCategoryPageToLoad();
            }
        }
    }
}
