using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BitcoinClient.Tests
{
    [TestClass]
    public class BitcoinClientTests
    {
        [TestMethod]
        public void CanCreateInstance()
        {
            IBitcoinClient client = new BitcoinClient(ConfigUtility.GetConnectionInfo());
            Assert.IsNotNull(client);
        }
    }
}
