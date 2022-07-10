using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowProject1.Constant;

namespace SpecFlowProject1.Drivers
{
    public class PrepareDriver
    {
        private static IWebDriver _driver;

        public static IWebDriver GetDriver()
        {
            return _driver;
        }

        public static void CreateConditions()
        {
            var browser = TestContext.Parameters[Parameters.Browser];
            var url = TestContext.Parameters[Parameters.Url];
            _driver = (IWebDriver)SelectBrowser.GetBrowser(browser);
            _driver.Navigate().GoToUrl(url);
            _driver.Manage().Window.Maximize();
        }

        public static void QuitDriver()
        {
            _driver.Quit();
        }
    }
}
