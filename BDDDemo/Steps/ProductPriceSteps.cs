using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace BDDDemo.Steps
{
    [Binding]
    public class ProductPriceSteps
    {
        private User _user;
        private int _result;
        [Given(@"the user is logged in")]
        public void GivenTheUserIsLoggedIn()
        {
            _user.LoggedIn = true;
        }
        
        [Given(@"user name is not empty")]
        public void GivenUserNameIsNotEmpty()
        {

            string.IsNullOrEmpty(_user.Name);
        }
        
        [When(@"the user name is (.*)")]
        public void WhenTheUserNameIsSupreet(string name)
        {
            ProductService productService = new ProductService();
            _user.LoggedIn = true;
            _user.Name = name;
            _result = productService.ShowPrice(_user);
        }
        
        [Then(@"the product price should be  (.*)")]
        public void ThenTheProductPriceShouldBe(int p0)
        {
            
           
            _result.Should().Be(p0);
        }
    }
}
