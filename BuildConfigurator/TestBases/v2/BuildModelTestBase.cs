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
    }
}
