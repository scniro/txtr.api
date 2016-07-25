using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using txtr.core;

namespace txtr.test
{
    [TestClass]
    public class TxtrHttpClientTest
    {
        [TestMethod]
        public void TestGet()
        {
            var client = new Mock<ITxtrHttpClient>();
            client.Setup(x => x.GetResponseString("http://api.yomomma.info/")).ReturnsAsync("your mom goes to college");
            var result = client.Object.GetResponseString("http://api.yomomma.info/");
            Assert.AreEqual(result.Result, "your mom goes to college");
        }
    }
}
