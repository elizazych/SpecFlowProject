using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SpecFlowProject1.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(ScenarioContext scenarioContext) : base(scenarioContext) { }

        private readonly By _userName = By.Id("user-name");
        private readonly By _password = By.Id("password");
        private readonly By _loginBtn = By.Id("login-button");

        public void InputUsername(string username)
        {
            SendText(_userName, username);
        }

        public void InputPassword(string password)
        {
            SendText(_password, password);
        }

        public void ClickOnLoginButton()
        {
            ClickOnElement(_loginBtn);
        }
    }
}
