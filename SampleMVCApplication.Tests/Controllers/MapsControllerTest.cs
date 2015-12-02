using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using SampleMVCApplication;
using SampleMVCApplication.Controllers;

namespace SampleMVCApplication.Tests.Controllers
{
    [TestClass]
    public class MapsControllerTest
    {
        [TestMethod]
        public void ViewMaps()
        {
            // Arrange
            MapsController controller = new MapsController();

            // Act
            ViewResult result = controller.ViewMaps() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
