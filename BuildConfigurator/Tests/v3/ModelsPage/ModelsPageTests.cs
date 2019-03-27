using AutomationFramework.Helpers;
using AutomationFramework.Utils;
using BuildConfigurator.Hooks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Tests.v3.ModelsPage
{
    [TestFixture]
    public class ModelsPageTests : TestBase
    {
        [Test, Category(TestCategories.RZR), Category(TestCategories.ACCESSORIES_PAGE), RetryDynamic]
        public void VerifyModelsNotDuplicateRzr()
        {
            CPQNavigate.NavigateToModelsPage(Brand.RZR);
            Models.ClickOneSeatModel();
            Assert.IsTrue(Models.VerifyModelsAreNotDuplicates());
            Models.NavigationBarModule.ClickModelsNavigation();
            Models.ClickTwoSeatModel();
            Assert.IsTrue(Models.VerifyModelsAreNotDuplicates());
            Models.NavigationBarModule.ClickModelsNavigation();
            Models.ClickFourSeatModel();
            Assert.IsTrue(Models.VerifyModelsAreNotDuplicates());
        }

        [Test, Category(TestCategories.RAN), Category(TestCategories.ACCESSORIES_PAGE), RetryDynamic]
        public void VerifyModelsNotDuplicateRan()
        {
            CPQNavigate.NavigateToModelsPage(Brand.RAN);
            Models.ClickTwoSeatModel();
            Assert.IsTrue(Models.VerifyModelsAreNotDuplicates());
            Models.NavigationBarModule.ClickModelsNavigation();
            Models.ClickThreeSeatModel();
            Assert.IsTrue(Models.VerifyModelsAreNotDuplicates());
            Models.NavigationBarModule.ClickModelsNavigation();
            Models.ClickFourSeatModel();
            Assert.IsTrue(Models.VerifyModelsAreNotDuplicates());
            Models.NavigationBarModule.ClickModelsNavigation();
            Models.ClickSixSeatModel();
            Assert.IsTrue(Models.VerifyModelsAreNotDuplicates());
        }

        [Test, Category(TestCategories.GEN), Category(TestCategories.ACCESSORIES_PAGE), RetryDynamic]
        public void VerifyModelsNotDuplicateGen()
        {
            CPQNavigate.NavigateToModelsPage(Brand.GEN);
            Models.ClickTwoSeatModel();
            Assert.IsTrue(Models.VerifyModelsAreNotDuplicates());
            Models.NavigationBarModule.ClickModelsNavigation();
            Models.ClickFourSeatModel();
            Assert.IsTrue(Models.VerifyModelsAreNotDuplicates());
        }

        [Test, Category(TestCategories.ACE), Category(TestCategories.ACCESSORIES_PAGE), RetryDynamic]
        public void VerifyModelsNotDuplicateAce()
        {
            CPQNavigate.NavigateToModelsPage(Brand.ACE);
            Assert.IsTrue(Models.VerifyModelsAreNotDuplicates());
        }

        [Test, Category(TestCategories.ATV), Category(TestCategories.ACCESSORIES_PAGE), RetryDynamic]
        public void VerifyModelsNotDuplicateAtv()
        {
            CPQNavigate.NavigateToModelsPage(Brand.ATV);
            Models.ClickOneSeatModel();
            Assert.IsTrue(Models.VerifyModelsAreNotDuplicates());
            Models.NavigationBarModule.ClickModelsNavigation();
            Models.ClickTwoSeatModel();
            Assert.IsTrue(Models.VerifyModelsAreNotDuplicates());
        }

        [Test, Category(TestCategories.GEM), Category(TestCategories.ACCESSORIES_PAGE), RetryDynamic]
        public void VerifyModelsNotDuplicateGem()
        {
            CPQNavigate.NavigateToModelsPage(Brand.GEM);
            Models.ClickGemPassengerModelsFamily();
            Assert.IsTrue(Models.VerifyModelsAreNotDuplicates());
            Models.NavigationBarModule.ClickModelsNavigation();
            Models.ClickGemUtilityModelsFamily();
            Assert.IsTrue(Models.VerifyModelsAreNotDuplicates());
        }
    }
}
