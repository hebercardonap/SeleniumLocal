﻿using AutomationFramework.Base;
using AutomationFramework.UrlBuilderSites;
using AutomationFramework.Utils;
using BuildConfigurator.Hooks;
using BuildConfigurator.TestBases;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BuildConfigurator.Tests
{
    [TestFixture]
    public class NavigationBarTests : TestBase
    {

        [Test, Category("Ranger"), Category("Navigation")]
        public void VerifyBackNavigationBar()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.RAN, "ranger-500-sage-green");
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.NavigationBarModule.WaitForNavigationBarToLoad();
            Accessories.NavigationBarModule.ClickColorNavigation();
            Colors.NavigationBarModule.ClickTrimNavigation();
            Trims.NavigationBarModule.ClickModelsNavigation();
            Assert.IsTrue(Models.IsChooseModelTitleDisplayed());
        }
    }
}
