using AutomationFramework.Base;
using BuildConfigurator.Pages.v3;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.TestBases
{
    public class ModelsTestBase : ModelsPage
    {
        private static string ONE = "one";
        private static string TWO = "two";
        private static string THREE = "three";
        private static string FOUR = "four";
        private static string SIX = "six";
        public ModelsTestBase(ParallelConfig parallelConfig) : base(parallelConfig)
        {
            _parallelConfig.CurrentPage = new ModelsPage(_parallelConfig);
        }

        public void SelectModelBySeatNumber(string numberOfSeats)
        {
            if (stringEqualsIgnoreCase(numberOfSeats, ONE))
                ClickOneSeatModel();
            else if (stringEqualsIgnoreCase(numberOfSeats, TWO))
                ClickTwoSeatModel();
            else if (stringEqualsIgnoreCase(numberOfSeats, THREE))
                ClickThreeSeatModel();
            else if (stringEqualsIgnoreCase(numberOfSeats, FOUR))
                ClickFourSeatModel();
            else if (stringEqualsIgnoreCase(numberOfSeats, SIX))
                ClickSixSeatModel();
            else
                Assert.Fail("Seat option {0} is not available", numberOfSeats);
        }

        public void SelectRandomModelVersion()
        {
            ClickRandomModelVersion();
        }

        public void VerifySeatSelectionIsDisplayed()
        {
            Assert.Greater(GetSeatSelectionCards(), 0, "Seat selection cards are not present");
        }

        public void VerifySnowFamilyCardsDisplayed()
        {
            Assert.Greater(GetSnowFamilyCardsCount(), 0);
        }

        public void SelectSnowCardByFamily(string family)
        {
            if (stringEqualsIgnoreCase(family, "rush"))
            {
                ClickSnoRushFamilyCard();
            }
            else if (stringEqualsIgnoreCase(family, "switchback"))
            {
                ClickSnoSwitchbackFamilyCard();
            }
            else if (stringEqualsIgnoreCase(family, "rmk"))
            {
                ClickSnoRmkFamilyCard();
            }
            else if (stringEqualsIgnoreCase(family, "indy"))
            {
                ClickSnoIndyFamilyCard();
            }
            else if (stringEqualsIgnoreCase(family, "voyageur"))
            {
                ClickSnoVoyageurFamilyCard();
            }
            else if (stringEqualsIgnoreCase(family, "titan"))
            {
                ClickSnoTitanFamilyCard();
            }
            else
                Assert.Fail("SNO family {0} not available", family);
        }

    }
}
