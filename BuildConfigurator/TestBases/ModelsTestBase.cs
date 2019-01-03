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
    }
}
