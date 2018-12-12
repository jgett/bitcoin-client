namespace BitcoinClient
{
    public interface IRpcResponse<T>
    {
        T Result { get; set; }
        RpcError Error { get; set; }
        string Id { get; set; }
    }
}
