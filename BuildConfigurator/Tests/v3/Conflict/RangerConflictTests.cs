using AutomationFramework.DataProvider;
using AutomationFramework.Helpers;
using AutomationFramework.Utils;
using BuildConfigurator.Hooks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Tests.v3.Conflict
{
    [TestFixture]
    public class RangerConflictTests : TestBase
    {
        [Test, Category("Ranger"), Category("Conflicts"), CustomRetry(3)]
        public void VerifyConflictRuleIsTriggeredForRanger()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RAN, ModelPageUrl.RANGER_CREW_XP900_SAGE_GREEN_CONFLICT);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Utility");
            Accessories.ClickSubcategoryByName("Cargo & Bed Storage");
            Accessories.ClickAccessoryAddByProductName("Front Hood Storage Rack");
            Accessories.ClickCategoryByName("Cab Components");
            Accessories.ClickSubcategoryByName("Windshields");
            Accessories.ClickAccessoryAddByProductName("Flip-Down Full Windshield");
            Assert.IsTrue(Accessories.IsConflictContainerDisplayed());
        }

        [Test, Category("Ranger"), Category("Conflicts"), CustomRetry(3)]
        public void VerifyRemovedPartFromConflictInBuildSummary()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RAN, ModelPageUrl.RANGER_CREW_XP900_SAGE_GREEN_CONFLICT);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Utility");
            Accessories.ClickSubcategoryByName("Cargo & Bed Storage");
            Accessories.ClickAccessoryAddByProductName("Front Hood Storage Rack");
            Accessories.ClickCategoryByName("Cab Components");
            Accessories.ClickSubcategoryByName("Windshields");
            Accessories.ClickAccessoryAddByProductName("Flip-Down Full Windshield");
            Assert.IsTrue(Accessories.IsConflictContainerDisplayed());
            Accessories.ClickConflictingItemRemoveByDesc("Flip-Down Full Windshield");
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.FooterModule.OpenBuildSummary();
            Accessories.WaitUntilBuildSummaryIsDisplayed();
            Assert.IsFalse(Accessories.AreProductIdsAddedBuildSummary(new List<string>() { "2881919" }));
        }
    }
}
