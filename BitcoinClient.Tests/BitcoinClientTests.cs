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

        [TestMethod]
        public void CanGetBlockChainInfo()
        {
            IBitcoinClient client = new BitcoinClient(ConfigUtility.GetConnectionInfo());
            IRpcResponse<BlockchainInfo> resp = client.GetBlockchainInfo();
            Assert.AreEqual("0", resp.Id);
            Assert.IsTrue(resp.Result.Blocks > 0);
            //Console.Write(resp.ToString());
        }

        [TestMethod]
        public void CanGetBlockCount()
        {
            IBitcoinClient client = new BitcoinClient(ConfigUtility.GetConnectionInfo());
            IRpcResponse<long> resp = client.GetBlockCount();
            Assert.AreEqual("0", resp.Id);
            Assert.IsTrue(resp.Result > 0);
            //Console.Write(resp.ToString());
        }
    }
}
