using System;
using NUnit.Framework;
using SpecFlowProject1.Features;
using SpecFlowProject1.Pages;
using SpecFlowProject1.Pages.BasketFeature;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class BasketStepDefinitions
    {
        private LoginPage _loginPage;
        private Basket _basket;
        private ScenarioContext _scenarioContext;

        public BasketStepDefinitions(LoginPage loginPage, ScenarioContext scenarioContext, Basket basket)
        {
            _loginPage = loginPage;
            _basket = basket;
            _scenarioContext = scenarioContext;
        }


        [Given(@"User is logged in as (.*) with (.*)")]
        public void GivenUserIsLoggedInAsStandard_UserWithSecret_Sauce(string username, string password)
        {
            _loginPage.InputUsername(username);
            _loginPage.InputPassword(password);
            _loginPage.ClickOnLoginButton();
        }

        [Given(@"Backpack item is clicked")]
        public void GivenBackpackItemIsClicked()
        {
            _basket.ClickBackpackButton();
        }

        [When(@"Add to cart button is clicked")]
        public void WhenAddToCartButtonIsClicked()
        {
            _basket.ClickAddToCartButton();
        }

        [When(@"Basket button is clicked")]
        public void WhenBasketButtonIsClicked()
        {
            _basket.ClickBasketButton();
        }

        [Then(@"Backpack item is visible in the basket")]
        public void ThenBackpackItemIsVisibleInTheBasket()
        {
            Assert.IsTrue(_basket.GetNameOfItem() == "Sauce Labs Backpack");
            Assert.IsTrue(_basket.GetNumberOfItems() == "1");
        }
    }
}
