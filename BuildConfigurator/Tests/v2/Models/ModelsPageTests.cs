using AutomationFramework.Helpers;
using AutomationFramework.Utils;
using BuildConfigurator.Hooks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Tests.v2.Models
{
    [TestFixture]
    public class ModelsPageTests : TestBase
    {
        [Test, Category(TestCategories.IND), Category(TestCategories.MODELS_PAGE), CustomRetry(3)]
        public void VerifyNotDuplicateModelsInd()
        {
            CPQNavigate.NavigateToModelsPage(Brand.IND);
            Assert.IsTrue(BuildModelPage.VerifyModelsAreNotDuplicates());
        }

        [Test, Category(TestCategories.RZR), Category(TestCategories.MODELS_PAGE), CustomRetry(3)]
        public void VerifyNotDuplicateModelsRzr()
        {
            CPQNavigate.NavigateToModelsPage(Brand.RZR);
            BuildModelPage.ClickOneSeat();
            Assert.IsTrue(BuildModelPage.VerifyModelsAreNotDuplicates());
            BuildModelPage.ClickSelectSeatsDropdown();
            BuildModelPage.ClickTwoSeat();
            Assert.IsTrue(BuildModelPage.VerifyModelsAreNotDuplicates());
            BuildModelPage.ClickSelectSeatsDropdown();
            BuildModelPage.ClickFourSeat();
            Assert.IsTrue(BuildModelPage.VerifyModelsAreNotDuplicates());
        }

        [Test, Category(TestCategories.ATV), Category(TestCategories.MODELS_PAGE), CustomRetry(3)]
        public void VerifyNotDuplicateModelsAtv()
        {
            CPQNavigate.NavigateToModelsPage(Brand.ATV);
            BuildModelPage.ClickOneSeat();
            Assert.IsTrue(BuildModelPage.VerifyModelsAreNotDuplicates());
            BuildModelPage.ClickSelectSeatsDropdown();
            BuildModelPage.ClickTwoSeat();
            Assert.IsTrue(BuildModelPage.VerifyModelsAreNotDuplicates());
        }

        [Test, Category(TestCategories.ACE), Category(TestCategories.MODELS_PAGE), CustomRetry(3)]
        public void VerifyNotDuplicateModelsAce()
        {
            CPQNavigate.NavigateToModelsPage(Brand.ACE);
            Assert.IsTrue(BuildModelPage.VerifyModelsAreNotDuplicates());
        }

        [Test, Category(TestCategories.GEN), Category(TestCategories.MODELS_PAGE), CustomRetry(3)]
        public void VerifyNotDuplicateModelsGen()
        {
            CPQNavigate.NavigateToModelsPage(Brand.GEN);
            BuildModelPage.ClickTwoSeat();
            Assert.IsTrue(BuildModelPage.VerifyModelsAreNotDuplicates());
            BuildModelPage.ClickSelectSeatsDropdown();
            BuildModelPage.ClickFourSeat();
            Assert.IsTrue(BuildModelPage.VerifyModelsAreNotDuplicates());
        }
    }
}
