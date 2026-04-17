using OpenQA.Selenium;
using Pra7.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pra7.Pages
{
    //LoginPage inherits everything from BasePage
    public class LoginPage : BasePage
    {
        //1.You create object: 2.Constructor runs: 3.base(driver) calls BasePage constructor:
        public LoginPage(IWebDriver driver) : base(driver) { }
        private By username = By.Id("user-name");
        private By password = By.Id("password");
        private By loginBtn = By.Id("login-button");

        public void Login(string user, string pass)
        {
            Type(username, user);
            Type(password, pass);
            Click(loginBtn);
        }

    }
}
