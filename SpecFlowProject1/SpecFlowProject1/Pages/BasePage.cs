using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpecFlowProject1.Drivers;

namespace SpecFlowProject1.Pages
{
    public class BasePage
    {

        private IWebDriver _webDriver;
        private ScenarioContext _scenarioContext;

        public BasePage(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _webDriver = PrepareDriver.GetDriver();
        }

        public void SendText(By element, string text)
        {
            _webDriver.FindElement(element).SendKeys(text);
        }

        public void ClearInput(By element)
        {
            _webDriver.FindElement(element).Clear();
        }

        public string GetText(By element)
        {
            return _webDriver.FindElement(element).Text;
        }

        public void ClickOnElement(By element, int time = 20)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(time));
                wait.Until(el => el.FindElement(element).Enabled && el.FindElement(element).Displayed);
                _webDriver.FindElement(element).Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
