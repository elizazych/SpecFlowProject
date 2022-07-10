﻿using OpenQA.Selenium;
using SpecFlowProject1.Drivers;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        private readonly IWebDriver _driver;

        public Hooks()
        {
            _driver = PrepareDriver.GetDriver();
        }

        [Before]
        public void BeforeAllTests() => PrepareDriver.CreateConditions();


        //[BeforeScenario("@tag1")]
        //public void BeforeScenarioWithTag()
        //{
        //    // Example of filtering hooks using tags. (in this case, this 'before scenario' hook will execute if the feature/scenario contains the tag '@tag1')
        //    // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=hooks#tag-scoping

        //    //TODO: implement logic that has to run before executing each scenario
        //}

        //[BeforeScenario(Order = 1)]
        //public void FirstBeforeScenario()
        //{
        //    // Example of ordering the execution of hooks
        //    // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=order#hook-execution-order

        //    //TODO: implement logic that has to run before executing each scenario
        //}

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
            PrepareDriver.QuitDriver();
        }
    }
}