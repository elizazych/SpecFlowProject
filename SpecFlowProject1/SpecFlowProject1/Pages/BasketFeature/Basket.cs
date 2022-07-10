using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SpecFlowProject1.Pages.BasketFeature
{
    public class Basket : BasePage
    {
        public Basket(ScenarioContext scenarioContext) : base(scenarioContext) { }

        private readonly By _backpackBtn = By.Id("item_4_title_link");
        private readonly By _addToCartBtn = By.Id("add-to-cart-sauce-labs-backpack");
        private readonly By _basketBtn = By.Id("shopping_cart_container");
        private readonly By _number = By.CssSelector(".cart_quantity");

        public void ClickBackpackButton()
        {
            ClickOnElement(_backpackBtn);
        }

        public void ClickAddToCartButton()
        {
            ClickOnElement(_addToCartBtn); 
        }

        public void ClickBasketButton()
        {
            ClickOnElement(_basketBtn);
        }

        public string GetNameOfItem()
        {
            return GetText(_backpackBtn);
        }

        public string GetNumberOfItems()
        {
            return GetText(_number);
        }
    }
}
