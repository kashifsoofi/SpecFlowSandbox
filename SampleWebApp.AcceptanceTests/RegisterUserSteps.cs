using NUnit.Framework;
using SampleWebApp.Controllers;
using System;
using System.Web.Mvc;
using TechTalk.SpecFlow;

namespace SampleWebApp.Specs
{
    [Binding]
    public class RegisterUserSteps
    {
        ActionResult result;
        AccountController controller;

        [When(@"the user goes to the register user screen")]
        public void WhenTheUserGoesToTheRegisterUserScreen()
        {
            controller = new AccountController();
            result = controller.Register();
        }
        
        [Then(@"the register user view should be displayed")]
        public void ThenTheRegisterUserViewShouldBeDisplayed()
        {
            Assert.IsInstanceOf<ViewResult>(result);
            Assert.IsEmpty(((ViewResult)result).ViewName);
            Assert.AreEqual("Register",
                controller.ViewData["Title"],
                "Page title is wrong");
        }
    }
}
