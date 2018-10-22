﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BuildConfigurator.Features.PartRequiresPart
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("PRPTests")]
    public partial class PRPTestsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PRPTests.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PRPTests", "\tVerify PRP rule is triggered\r\n\twhen applicable for a particular brand", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify PRP is triggered for RZR brand")]
        [NUnit.Framework.CategoryAttribute("PRP")]
        public virtual void VerifyPRPIsTriggeredForRZRBrand()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify PRP is triggered for RZR brand", null, new string[] {
                        "PRP"});
#line 6
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
 testRunner.Given("I have navigated to RZR rzr-xp-1000-eps-ride-command-edition-black-pearl build pa" +
                    "ge", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.When("I get to build page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
 testRunner.And("I click Utility & Performance accessory category", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.And("I click Winches accessory subcategory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.And("I add specific Winch Cover Kit accessory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.And("PRP container is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.And("I select accessory by product ID 2882240", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.And("I click buildsummarybutton button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.Then("Accessories \'2884118,2882240\' are displayed in build summary", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify PRP is triggered for RAN brand")]
        [NUnit.Framework.CategoryAttribute("PRP")]
        public virtual void VerifyPRPIsTriggeredForRANBrand()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify PRP is triggered for RAN brand", null, new string[] {
                        "PRP"});
#line 18
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 19
 testRunner.Given("I have navigated to RAN ranger-crew-570-4-sage-green build page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 20
 testRunner.When("I get to build page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
 testRunner.And("I click Utility accessory category", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.And("I click Cargo & Bed Storage accessory subcategory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
 testRunner.And("I add specific XL Transport accessory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.And("PRP container is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.And("I select accessory by product ID 2884106", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.And("I click buildsummarybutton button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.Then("Accessories \'2882430,2884106\' are displayed in build summary", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify PRP is triggered for GEN brand")]
        [NUnit.Framework.CategoryAttribute("PRP")]
        public virtual void VerifyPRPIsTriggeredForGENBrand()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify PRP is triggered for GEN brand", null, new string[] {
                        "PRP"});
#line 30
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 31
 testRunner.Given("I have navigated to GEN general-1000-eps-deluxe-orange-rust build page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 32
 testRunner.When("I get to build page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 33
 testRunner.And("I click Cab Components accessory category", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.And("I click Windshields accessory subcategory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.And("I add specific Windshield Wiper Kit accessory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.And("PRP container is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.And("I select accessory by product ID 2881108", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.And("I click buildsummarybutton button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.Then("Accessories \'2881090,2881108\' are displayed in build summary", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify PRP is triggered for ACE brand")]
        [NUnit.Framework.CategoryAttribute("PRP")]
        public virtual void VerifyPRPIsTriggeredForACEBrand()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify PRP is triggered for ACE brand", null, new string[] {
                        "PRP"});
#line 42
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 43
 testRunner.Given("I have navigated to ACE ace-570-eps-ghost-gray build page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 44
 testRunner.When("I get to build page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 45
 testRunner.And("I click Utility accessory category", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
 testRunner.And("I click Ligthing accessory subcategory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
 testRunner.And("I add specific Dual Row LED Light Bar accessory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
 testRunner.And("PRP container is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
 testRunner.And("I select accessory by product ID 2881147", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
 testRunner.And("I click buildsummarybutton button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.Then("Accessories \'2883107,2881147\' are displayed in build summary", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify PRP is triggered for ATV brand")]
        [NUnit.Framework.CategoryAttribute("PRP")]
        public virtual void VerifyPRPIsTriggeredForATVBrand()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify PRP is triggered for ATV brand", null, new string[] {
                        "PRP"});
#line 54
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 55
 testRunner.Given("I have navigated to ATV sportsman-450-ho-utility-edition-ghost-gray build page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 56
 testRunner.When("I get to build page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 57
 testRunner.And("I click Utility accessory category", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
 testRunner.And("I click Storage accessory subcategory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
 testRunner.And("I add specific Gun Boot accessory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
 testRunner.Then("PRP container is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify PRP is triggered for SLG brand")]
        [NUnit.Framework.CategoryAttribute("PRP")]
        public virtual void VerifyPRPIsTriggeredForSLGBrand()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify PRP is triggered for SLG brand", null, new string[] {
                        "PRP"});
#line 63
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 64
 testRunner.Given("I have navigated to SLG slingshot-s-white-lightning build page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 65
 testRunner.When("I get to build page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 66
 testRunner.And("I click Style accessory category", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
 testRunner.And("I click Wide Fenders accessory subcategory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
 testRunner.And("I add specific Ghost Gray accessory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
 testRunner.Then("PRP container is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify PRP is triggered for IND brand")]
        [NUnit.Framework.CategoryAttribute("PRP")]
        public virtual void VerifyPRPIsTriggeredForINDBrand()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify PRP is triggered for IND brand", null, new string[] {
                        "PRP"});
#line 72
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 73
 testRunner.Given("I have navigated to IND springfield-thunder-black build page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 74
 testRunner.When("I get to build page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 75
 testRunner.And("I click Storage & Luggage accessory category", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
 testRunner.And("I click Touring Essentials accessory subcategory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
 testRunner.And("I add specific Pinnacle Conchos accessory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
 testRunner.And("PRP container is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
 testRunner.And("I select accessory by product ID 2879667-05", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
 testRunner.And("I click buildsummarybutton button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
 testRunner.Then("Accessories \'2879674-266,2879667-05\' are displayed in build summary", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify PRP is triggered for SNO brand")]
        [NUnit.Framework.CategoryAttribute("PRP")]
        public virtual void VerifyPRPIsTriggeredForSNOBrand()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify PRP is triggered for SNO brand", null, new string[] {
                        "PRP"});
#line 84
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 85
 testRunner.Given("I have navigated to SNO switchback/600-switchback-sp-144-es build page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 86
 testRunner.When("I get to build page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 87
 testRunner.And("I click Storage & Racks accessory category", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
 testRunner.And("I click Cargo Rack Bags accessory subcategory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
 testRunner.And("I add specific Under Rack Bag accessory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
 testRunner.Then("PRP container is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify PRP is triggered for GEM brand")]
        [NUnit.Framework.CategoryAttribute("PRP")]
        public virtual void VerifyPRPIsTriggeredForGEMBrand()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify PRP is triggered for GEM brand", null, new string[] {
                        "PRP"});
#line 93
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 94
 testRunner.Given("I have navigated to GEM el-xd build page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 95
 testRunner.When("I get to build page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 96
 testRunner.And("I click Exterior accessory category", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
 testRunner.And("I click Roof accessory subcategory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 98
 testRunner.And("I add specific Solar Panel accessory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
 testRunner.Then("PRP container is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify PRP is displayed when secondary accessory is removed")]
        [NUnit.Framework.CategoryAttribute("PRP")]
        public virtual void VerifyPRPIsDisplayedWhenSecondaryAccessoryIsRemoved()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify PRP is displayed when secondary accessory is removed", null, new string[] {
                        "PRP"});
#line 102
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 103
 testRunner.Given("I have navigated to RZR rzr-xp-1000-eps-ride-command-edition-black-pearl build pa" +
                    "ge", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 104
 testRunner.When("I get to build page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 105
 testRunner.And("I click Utility & Performance accessory category", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 106
 testRunner.And("I click Winches accessory subcategory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 107
 testRunner.And("I add specific Winch Cover Kit accessory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 108
 testRunner.And("PRP container is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 109
 testRunner.And("I select accessory by product ID 2882240", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 110
 testRunner.And("I click buildsummarybutton button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 111
 testRunner.And("I remove product id 2882240 from build summary", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 112
 testRunner.Then("PRP container is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify primary accessory is not removed when removing secondary acceossory")]
        [NUnit.Framework.CategoryAttribute("PRP")]
        public virtual void VerifyPrimaryAccessoryIsNotRemovedWhenRemovingSecondaryAcceossory()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify primary accessory is not removed when removing secondary acceossory", null, new string[] {
                        "PRP"});
#line 115
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 116
 testRunner.Given("I have navigated to RZR rzr-xp-1000-eps-ride-command-edition-black-pearl build pa" +
                    "ge", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 117
 testRunner.When("I get to build page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 118
 testRunner.And("I click Audio & Lighting accessory category", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 119
 testRunner.And("I click Lighting accessory subcategory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 120
 testRunner.And("I add specific LED Spot Light accessory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 121
 testRunner.And("PRP container is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 122
 testRunner.And("I select accessory by product ID 2884019-293", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 123
 testRunner.And("I click buildsummarybutton button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 124
 testRunner.And("I remove product id 2882076 from build summary", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 125
 testRunner.Then("Accessories \'2884019-293\' are displayed in build summary", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion