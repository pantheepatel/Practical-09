using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Task3;
using Task3.Controllers;

namespace Task3.Tests.Controllers
{
    [TestClass] // Marks the class as a test class that contains unit tests.
    public class HomeControllerTest
    {
        [TestMethod] // Marks individual methods as test cases.
        public void Index()
        {
            // Arrange - Creates an instance of HomeController
            HomeController controller = new HomeController();

            // Act - Calls the Index() method and stores the result
            ViewResult result = controller.Index() as ViewResult;

            // Assert - Checks if the result is not null (i.e., a valid view is returned)
            Assert.IsNotNull(result); // to check result is not null
            Assert.AreEqual("Hello World!", result.ViewBag.Message); // checking if both strings are equal or not
        }
    }
}
