using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonUITestDemo.Pages
{
    class MainPage
    {
        public IWebDriver WebDriver { get; }
        public MainPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        public IWebElement SearchBox => WebDriver.FindElement(By.Id("twotabsearchtextbox"));
        public IWebElement CookiesButton => WebDriver.FindElement(By.Id("sp-cc-accept"));
        public IWebElement SearchButton => WebDriver.FindElement(By.Id("nav-search-submit-button"));
        public IWebElement ProductCard => WebDriver.FindElement(By.CssSelector("h2.a-size-mini>a>span"));
        public IWebElement AddToBasketButton => WebDriver.FindElement(By.Id("add-to-cart-button"));
        public IWebElement ShoppingCartButton => WebDriver.FindElement(By.Id("nav-cart"));
        public IWebElement CounterNumber => WebDriver.FindElement(By.ClassName("a-dropdown-prompt"));
        
        public void ClickTheAcceptCookiesButton() => CookiesButton.Click();

        public void EnterTheProductNameToSearchbox(string ProductName) => SearchBox.SendKeys(ProductName);

        public void ClickTheSearchButton() => SearchButton.Click();

        public void ClickTheProduct() => ProductCard.Click();

        public void ClickTheAddToBasketButton() => AddToBasketButton.Click();

        public void ClickTheShoppingCartButton() => ShoppingCartButton.Click();

        public bool IsCounterValueTrue() 
        {
            if (CounterNumber.Text == "1")
                return true;
            return false;
        }
       

    }
}
