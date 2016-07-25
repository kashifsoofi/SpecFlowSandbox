using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.PhantomJS;
using System;
using TechTalk.SpecFlow;

namespace Search.Specs
{
    [Binding]
    public class SearchSteps
    {
        private IWebDriver driver;
        private string searchText { get; set; }

        [Given(@"I navigate to page ""(.*)""")]
        public void GivenINavigateToPage(string url)
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(url);
        }
        
        [Given(@"Page is loaded")]
        public void GivenPageIsLoaded()
        {
            Assert.That(driver.Title, Is.EqualTo("Google"));
        }
        
        [When(@"I enter search term in Search text box")]
        public void WhenIEnterSearchTermInSearchTextBox(Table table)
        {
            searchText = table.Rows[0]["term"].ToString();
            driver.FindElement(By.Name("q")).SendKeys(searchText);
        }
        
        [When(@"I click on Search button")]
        public void WhenIClickOnSearchButton()
        {
            driver.FindElement(By.Name("btnG")).Click();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
        }
        
        [Then(@"Search items shows the items related to term")]
        public void ThenSearchItemsShowsTheItemsRelatedToTerm()
        {
            Assert.That(driver.FindElement(By.XPath("//h3//a")).Text, Is.EqualTo("SpecFlow - Cucumber for .NET"));
            driver.Close();
        }
    }
}
