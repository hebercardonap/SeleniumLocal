using AutomationFramework.ApiUtils.ApiDataProvider;
using AutomationFramework.ApiUtils.Helpers;
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
    public class BuildTrimTestBase : BuildTrimPage
    {
        public BuildModelPage BuildModelPage { get { return new BuildModelPage(_parallelConfig); } }

        private static Random rnd = new Random();

        public BuildTrimTestBase(ParallelConfig parallelConfig) : base(parallelConfig)
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
            int categories = BuildModelPage.GetWholegoodsModelsCards().Count;
            Assert.Greater(categories, 0, "Wholegood cards collection is null");

            for (int i = 0; i < categories; i++)
            {
                DriverActions.clickElement(BuildModelPage.GetWholegoodsModelsCards()[i]);
                Assert.IsTrue(VerifyTrimsAreNotDuplicates());
                GoToPreviousPage();
                BuildModelPage.WaitForBuildModelPageToLoad();
            }
        }
    }
}
