namespace BitcoinClient
{
    public interface IBitcoinClient
    {
        IRpcResponse<BlockchainInfo> GetBlockchainInfo();
        IRpcResponse<long> GetBlockCount();
    }
}
