using AutomationFramework.Base;
using AutomationFramework.Extensions;
using BuildConfigurator.Pages.v3;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.TestBases
{
    public class TrimsTestBase : TrimsPage
    {

        public ModelsPage ModelsPage { get { return new ModelsPage(_parallelConfig); } }
        public TrimsTestBase(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public bool VerifyTrimsAreNotDuplicates()
        {
            bool areTrimsUnique = true;
            var duplicateItems = GetTrimsCardTitleLabels().GroupBy(x => x)
                .Where(group => group.Count() > 1)
                .Select(group => group.Key).ToList();

            if (duplicateItems.Count > 0)
            {
                areTrimsUnique = false;
                string duplicateValues = string.Empty;
                foreach (var item in duplicateItems)
                {
                    duplicateValues += item + "\n";
                }
                Assert.Fail("There are duplicate models \n{0}", duplicateValues);
            }
            return areTrimsUnique;
        }

        public void ClickEachModelAndVerifyTrimsAreNotDuplicate()
        {
            int categories = ModelsPage.GetWholegoodsModelsCards().Count;
            Assert.Greater(categories, 0, "Wholegood cards collection is null");

            for (int i = 0; i < categories; i++)
            {
                DriverActions.clickElement(ModelsPage.GetWholegoodsModelsCards()[i]);
                Assert.IsTrue(VerifyTrimsAreNotDuplicates());
                GoToPreviousPage();
                WebDriverExtensions.WaitForPageLoaded(Driver);
            }
        }
    }
}
