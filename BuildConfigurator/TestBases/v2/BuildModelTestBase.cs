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
    public class BuildModelTestBase : BuildModelPage
    {
        private static string ONE = "one";
        private static string TWO = "two";
        private static string THREE = "three";
        private static string FOUR = "four";
        private static string SIX = "six";

        public BuildTrimPage BuildTrimPage { get { return new BuildTrimPage(_parallelConfig); } }
        public BuildModelTestBase(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public void SelectSeatOptionBySeatNumber(string seats)
        {
            if (stringEqualsIgnoreCase(seats, ONE))
                ClickOneSeat();
            else if (stringEqualsIgnoreCase(seats, TWO))
                ClickTwoSeat();
            else if (stringEqualsIgnoreCase(seats, THREE))
                ClickThreeSeat();
            else if (stringEqualsIgnoreCase(seats, FOUR))
                ClickFourSeat();
            else if (stringEqualsIgnoreCase(seats, SIX))
                ClickSixSeat();
            else
                Assert.Fail("Seat option {0} is not available", seats);
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

        public bool VerifyTrimsAreNotDuplicates()
        {
            bool areTrimsUnique = true;
            var duplicateItems = BuildTrimPage.GetTrimsCardTitleLabels().GroupBy(x => x)
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
            int categories = GetWholegoodsModelsCards().Count;
            Assert.Greater(categories, 0, "Wholegood cards collection is null");

            for (int i = 0; i < categories; i++)
            {
                DriverActions.clickElement(GetWholegoodsModelsCards()[i]);
                Assert.IsTrue(VerifyTrimsAreNotDuplicates());
                GoToPreviousPage();
                WaitForBuildModelPageToLoad();
            }
        }
    }
}
