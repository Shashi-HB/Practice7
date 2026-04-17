using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pra7.Base
{
    public class BasePage
    {
        protected IWebDriver driver;
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }   
        protected void Click(By locator) => driver.FindElement(locator).Click();
        /*
         * protected void Click(By locator)
         * {
         *      driver.FindElement(locator).Click();
         * }
         */

        protected void Type(By loactor,string text)
        {
            var element = driver.FindElement(loactor);
            element.Clear();
            element.SendKeys(text);
        }
        protected string GetText(By locator) => driver.FindElement(locator).Text;
    }
}
