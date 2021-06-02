using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace BDDNew.Steps
{
    [Binding]
    public class YoutubeSearchSteps
    {
        IWebDriver webdriver = new ChromeDriver();
        IWebElement webElement;

        [Given(@"User is at the youtube Home Page")]
        public void GivenUserIsAtTheYoutubeHomePage()
        {
            webdriver.Navigate().GoToUrl("https://www.youtube.com/");
        }
        
        [Given(@"user enters the search as ideasbysupreet")]
        public void GivenUserEntersTheSearchAsIdeasbysupreet()
        {
             webElement = webdriver.FindElement(By.Name("search_query"));
            webElement.SendKeys("ideasbysupreet");
        }
        
        [When(@"User clicks on search")]
        public void WhenUserClicksOnSearch()
        {
             webdriver.FindElement(By.Id("search-icon-legacy")).Click();
        }
        
        [Then(@"youtube channel name should be displayed")]
        public void ThenYoutubeChannelNameShouldBeDisplayed()
        {
            webdriver.Navigate().GoToUrl("https://www.youtube.com/results?search_query=ideasbysupreet");
            var actualResult = webdriver.FindElement(By.Id("subscribers")).Text;
            actualResult.Should().HaveLength(15);


        }
    }
}
