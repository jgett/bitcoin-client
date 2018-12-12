using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;
using System.Net;

namespace BitcoinClient
{
    public class BitcoinClient : IBitcoinClient
    {
        private readonly IRestClient _client;

        private int _id = 0;

        public BitcoinClient(ConnectionInfo connInfo)
        {
            HttpBasicAuthenticator auth = new HttpBasicAuthenticator(connInfo.Username, connInfo.Password);
            _client = new RestClient(connInfo.Url) { Authenticator = auth };
        }

        public IRpcResponse<BlockchainInfo> GetBlockchainInfo()
        {
            var req = CreateRequest("getblockchaininfo");
            var resp = _client.Execute<RpcResponse<BlockchainInfo>>(req);
            return HandleResponse(resp);
        }

        public IRpcResponse<long> GetBlockCount()
        {
            var req = CreateRequest("getblockcount");
            var resp = _client.Execute<RpcResponse<long>>(req);
            return HandleResponse(resp);
        }

        private T HandleResponse<T>(IRestResponse<T> resp)
        {
            if (resp.StatusCode == HttpStatusCode.OK)
                return resp.Data;
            else
                throw new RpcException(resp);
        }

        private IRestRequest CreateRequest(string method)
        {
            IRestRequest req = new RestRequest(string.Empty, Method.POST);
            req.AddHeader("Content-Type", "application/json-rpc");
            req.AddJsonBody(new { jsonrpc = "1.0", id = _id.ToString(), method });
            _id += 1;
            return req;
        }
    }
}
