using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ARM_IV_Test;
using ARM_IV_Test.Controllers;

namespace ARM_IV_Test.Tests.Controllers
{
    [TestClass]
    public class CustomerPricingQueryControllerTest
    {
        [TestMethod]
        public void Create()
        {
            // Arrange
            CustomerPricingQueryController controller = new CustomerPricingQueryController();

            // Act
            ViewResult result = controller.Create() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

    
    }
}
