using AutomationFramework.Helpers;
using AutomationFramework.Utils;
using BuildConfigurator.Hooks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Tests.v3.TrimsPage
{
    [TestFixture]
    public class TrimsPageTests : TestBase
    {
        [Test, Category(TestCategories.RZR), Category(TestCategories.TRIMS_PAGE), RetryDynamic]
        public void VerifyTrimsNotDuplicateRzr()
        {
            CPQNavigate.NavigateToModelsPage(Brand.RZR);
            Models.ClickOneSeatModel();
            Trims.ClickEachModelAndVerifyTrimsAreNotDuplicate();
            Trims.NavigationBarModule.ClickModelsNavigation();
            Models.ClickTwoSeatModel();
            Trims.ClickEachModelAndVerifyTrimsAreNotDuplicate();
            Trims.NavigationBarModule.ClickModelsNavigation();
            Models.ClickFourSeatModel();
            Trims.ClickEachModelAndVerifyTrimsAreNotDuplicate();
        }

        [Test, Category(TestCategories.RAN), Category(TestCategories.TRIMS_PAGE), RetryDynamic]
        public void VerifyTrimsNotDuplicateRan()
        {
            CPQNavigate.NavigateToModelsPage(Brand.RAN);
            Models.ClickTwoSeatModel();
            Trims.ClickEachModelAndVerifyTrimsAreNotDuplicate();
            Trims.NavigationBarModule.ClickModelsNavigation();
            Models.ClickThreeSeatModel();
            Trims.ClickEachModelAndVerifyTrimsAreNotDuplicate();
            Trims.NavigationBarModule.ClickModelsNavigation();
            Models.ClickFourSeatModel();
            Trims.ClickEachModelAndVerifyTrimsAreNotDuplicate();
            Trims.NavigationBarModule.ClickModelsNavigation();
            Models.ClickSixSeatModel();
            Trims.ClickEachModelAndVerifyTrimsAreNotDuplicate();
        }

        [Test, Category(TestCategories.GEN), Category(TestCategories.TRIMS_PAGE), RetryDynamic]
        public void VerifyTrimsNotDuplicateGen()
        {
            CPQNavigate.NavigateToModelsPage(Brand.GEN);
            Models.ClickTwoSeatModel();
            Trims.ClickEachModelAndVerifyTrimsAreNotDuplicate();
            Trims.NavigationBarModule.ClickModelsNavigation();
            Models.ClickFourSeatModel();
            Trims.ClickEachModelAndVerifyTrimsAreNotDuplicate();
        }

        [Test, Category(TestCategories.ATV), Category(TestCategories.TRIMS_PAGE), RetryDynamic]
        public void VerifyTrimsNotDuplicateAtv()
        {
            CPQNavigate.NavigateToModelsPage(Brand.ATV);
            Models.ClickOneSeatModel();
            Trims.ClickEachModelAndVerifyTrimsAreNotDuplicate();
            Trims.NavigationBarModule.ClickModelsNavigation();
            Models.ClickTwoSeatModel();
            Trims.ClickEachModelAndVerifyTrimsAreNotDuplicate();
        }
    }
}
