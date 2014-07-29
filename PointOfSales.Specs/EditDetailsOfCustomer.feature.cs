﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18444
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace PointOfSales.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class EditDetaisOfCustomerFeature : Xunit.IUseFixture<EditDetaisOfCustomerFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "EditDetailsOfCustomer.feature"
#line hidden
        
        public EditDetaisOfCustomerFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Edit detais of customer", "In order to keep data up-to date\nAs a salesman\nI want to be able to edit the deta" +
                    "ils of a customer", ProgrammingLanguage.CSharp, new string[] {
                        "customers"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void SetFixture(EditDetaisOfCustomerFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Edit detais of customer")]
        [Xunit.TraitAttribute("Description", "Edit customer")]
        public virtual void EditCustomer()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Edit customer", ((string[])(null)));
#line 7
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1.AddRow(new string[] {
                        "FirstName",
                        "John"});
            table1.AddRow(new string[] {
                        "LastName",
                        "Doe"});
            table1.AddRow(new string[] {
                        "MiddleName",
                        ""});
            table1.AddRow(new string[] {
                        "EmailAddress",
                        "john.doe@mail.com"});
            table1.AddRow(new string[] {
                        "City",
                        "Washington"});
            table1.AddRow(new string[] {
                        "Street",
                        "Pennsylvania Ave"});
            table1.AddRow(new string[] {
                        "HouseNumber",
                        "1600"});
            table1.AddRow(new string[] {
                        "PostalCode",
                        "20500"});
#line 8
 testRunner.Given("there is following customer in shop", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table2.AddRow(new string[] {
                        "FirstName",
                        "Jack"});
            table2.AddRow(new string[] {
                        "LastName",
                        "Finney"});
            table2.AddRow(new string[] {
                        "MiddleName",
                        ""});
            table2.AddRow(new string[] {
                        "EmailAddress",
                        "john.doe@mail.com"});
            table2.AddRow(new string[] {
                        "City",
                        "New York"});
            table2.AddRow(new string[] {
                        "Street",
                        "West 72nd Street"});
            table2.AddRow(new string[] {
                        "HouseNumber",
                        "1"});
            table2.AddRow(new string[] {
                        "PostalCode",
                        "10023"});
#line 18
 testRunner.When("I edit details of this customer", ((string)(null)), table2, "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table3.AddRow(new string[] {
                        "FirstName",
                        "Jack"});
            table3.AddRow(new string[] {
                        "LastName",
                        "Finney"});
            table3.AddRow(new string[] {
                        "MiddleName",
                        ""});
            table3.AddRow(new string[] {
                        "EmailAddress",
                        "john.doe@mail.com"});
            table3.AddRow(new string[] {
                        "City",
                        "New York"});
            table3.AddRow(new string[] {
                        "Street",
                        "West 72nd Street"});
            table3.AddRow(new string[] {
                        "HouseNumber",
                        "1"});
            table3.AddRow(new string[] {
                        "PostalCode",
                        "10023"});
#line 28
 testRunner.Then("I see updated details of this customer", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                EditDetaisOfCustomerFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                EditDetaisOfCustomerFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
