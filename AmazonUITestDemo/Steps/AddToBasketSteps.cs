using System;
using TechTalk.SpecFlow;
using AmazonUITestDemo.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TechTalk.SpecFlow.Assist;
using System.Threading;
using NUnit.Framework;

namespace AmazonUITestDemo.Steps
{
    [Binding]
    public class AddToBasketSteps
    {
        MainPage mainPage = null;
        //sp-cc-accept accept the cookies
        [Given(@"I open the amazon main page")]
        public void GivenIOpenTheAmazonMainPage()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--disable-popup-blocking");
            options.AddArgument("start-maximized");
            IWebDriver webDriver = new ChromeDriver(options);
            webDriver.Navigate().GoToUrl("https://www.amazon.com.tr/ref=nav_logo");
            mainPage = new MainPage(webDriver);
        }

        [Given(@"Accept the all cookies")]
        public void GivenAcceptTheAllCookies()
        {
            Thread.Sleep(500);
            mainPage.ClickTheAcceptCookiesButton();
        }

        [Given(@"I given the searchtext to search box")]
        public void GivenIGivenTheSearchtextToSearchBox(Table table)
        {
            Thread.Sleep(500);
            dynamic data = table.CreateDynamicInstance();
            mainPage.EnterTheProductNameToSearchbox(Convert.ToString(data.SearchText));

        }
        
        [Given(@"I click the search button")]
        public void GivenIClickTheSearchButton()
        {
            Thread.Sleep(500);
            mainPage.ClickTheSearchButton();
        }
        
        [Given(@"I click the card of product")]
        public void GivenIClickTheCardOfProduct()
        {
            Thread.Sleep(500);
            mainPage.ClickTheProduct();
        }
        
        [Given(@"I click the addtobasket button")]
        public void GivenIClickTheAddtobasketButton()
        {
            Thread.Sleep(500);
            mainPage.ClickTheAddToBasketButton();
        }
        
        [Given(@"I click the shopping card button")]
        public void GivenIClickTheShoppingCardButton()
        {
            Thread.Sleep(500);
            mainPage.ClickTheShoppingCartButton();
        }
        
        [Then(@"I should see the number of one in count")]
        public void ThenIShouldSeeTheNumberOfOneİnCount()
        {
            Thread.Sleep(500);
            Assert.AreEqual(mainPage.IsCounterValueTrue(),true);
        }
    }
}
