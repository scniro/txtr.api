using System;
using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using txtr.api.Controllers;
using txtr.core;

namespace txtr.test.Controllers
{
    [TestClass]
    public class TextControllerTest
    {
        [TestMethod]
        public void EnsureControllerInit()
        {
            var client = new Mock<IYoMamaClient>();
            var twilio = new Mock<ITwilioClient>();
            var controller = new TextController(client.Object, twilio.Object);

            var result = controller.Ping();

            Assert.IsInstanceOfType(result, typeof(OkNegotiatedContentResult<String>));
        }
    }
}
