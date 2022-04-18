using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonUITestDemo.Pages
{
    class LoginPage
    {
        public IWebDriver WebDriver { get; }
        public LoginPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        public IWebElement AllowCookiesButton => WebDriver.FindElement(By.Id("sp-cc-accept"));
        public IWebElement TxtEmail => WebDriver.FindElement(By.Id("ap_email"));
        public IWebElement ContinueButton => WebDriver.FindElement(By.Id("continue"));
        public IWebElement TxtPassword => WebDriver.FindElement(By.Id("ap_password"));
        public IWebElement LoginButton => WebDriver.FindElement(By.Id("signInSubmit"));
        public IWebElement VerificationName => WebDriver.FindElement(By.Id("nav-link-accountList-nav-line-1"));

        public void ClickTheAllowCookiesButton() => AllowCookiesButton.Click();

        public void FillTheEmailArea(string email) 
        {
            TxtEmail.SendKeys(email);
        }

        public void FillThePasswordArea(string password) 
        {
            TxtPassword.SendKeys(password);
        }

        public void ClickTheContinueButton() => ContinueButton.Click();
        public void ClickTheLoginButton() => LoginButton.Click();
        public bool IsVerificationNameExist() => VerificationName.Displayed;
    }
}
