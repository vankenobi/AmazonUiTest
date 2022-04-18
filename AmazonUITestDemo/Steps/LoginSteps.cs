using AmazonUITestDemo.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace AmazonUITestDemo.Steps
{
    [Binding]
    public class LoginSteps
    {
        // Step definitions
        LoginPage LoginPage = null;
        

        [Given(@"I open the amazon login page")]
        public void GivenIOpenTheAmazonWebsite()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--disable-popup-blocking");
            options.AddArgument("start-maximized");
            IWebDriver webDriver = new ChromeDriver(options);
            webDriver.Navigate().GoToUrl("https://www.amazon.com.tr/ap/signin?openid.pape.max_auth_age=0&openid.return_to=https%3A%2F%2Fwww.amazon.com.tr%2F%3Fref_%3Dnav_signin&openid.identity=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.assoc_handle=trflex&openid.mode=checkid_setup&openid.claimed_id=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.ns=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0&");
            LoginPage = new LoginPage(webDriver);
        }

        [Given(@"I enter the email")]
        public void GivenIEnterTheEmail(Table table)
        {
            Thread.Sleep(1000);
            dynamic data = table.CreateDynamicInstance();
            LoginPage.FillTheEmailArea(data.Email);
        }
        
        [Given(@"I click the continue button")]
        public void GivenIClickTheContinueButton()
        {
            Thread.Sleep(1000);
            LoginPage.ClickTheContinueButton();
        }
        
        [Given(@"I enter the password")]
        public void GivenIEnterThePassword(Table table)
        {
            Thread.Sleep(1000);
            dynamic data = table.CreateDynamicInstance();
            LoginPage.FillThePasswordArea(Convert.ToString(data.Password));
        }

        [Given(@"I click the login button")]
        public void GivenIClickTheLoginButton()
        {
            LoginPage.ClickTheLoginButton();
        }

        [Then(@"I should see the my name")]
        public void ThenIShouldSeeTheMyName()
        {
            Assert.AreEqual(true, LoginPage.IsVerificationNameExist());
        }
    }
}
