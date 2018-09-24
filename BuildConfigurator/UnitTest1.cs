using System;
using AutomationFramework.Base;
using AutomationFramework.Extensions;
using AutomationFramework.UrlBuilderSites;
using BuildConfigurator.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace BuildConfigurator
{
    [TestClass]
    public class UnitTest1 : HookInitialize
    {

        string url = "https://rzr.polaris.com/en-us/build-model/";


        [TestMethod]
        public void TestMethod1()
        {
            DriverContext.Browser.GoToUrl(UrlBuilder.getRzrBuildModelUrl());
            CurrentPage = GetInstance<BuildModelPage>();
            WebDriverExtensions.WaitForPageLoaded(DriverContext.Driver);
            CurrentPage.As<BuildModelPage>().clickOneSeat();
            CurrentPage.As<BuildModelPage>().clickRandomModel();
        }
    }
}
