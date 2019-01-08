using AutomationFramework.Utils;
using BuildConfigurator.Hooks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Tests
{
    [TestFixture]
    public class ConflictTests : TestBase
    {
        [Test, Category("Ranger"), Category("Conflicts")]
        public void VerifyConflictRuleIsTriggeredForRanger()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RAN, "ranger-crew-xp-900-sage-green");
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.ClickCategoryByName("Utility");
            Accessories.ClickSubcategoryByName("Cargo & Bed Storage");
            Accessories.ClickAccessoryAddByProductName("Front Hood Storage Rack");
            Accessories.ClickCategoryByName("Cab Components");
            Accessories.ClickSubcategoryByName("Windshields");
            Accessories.ClickAccessoryAddByProductName("Flip-Down Full Windshield");
        }
    }
}
