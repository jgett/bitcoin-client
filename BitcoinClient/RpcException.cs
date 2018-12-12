using Newtonsoft.Json;
using RestSharp;
using System;
using System.Net;

namespace BitcoinClient
{
    [Serializable]
    public class RpcException : Exception
    {
        public Uri Uri { get; }
        public HttpStatusCode StatusCode { get; }
        public RpcResponse<object> Response { get; }

        public RpcException(IRestResponse resp)
        {
            Uri = resp.ResponseUri;
            StatusCode = resp.StatusCode;

            if (!string.IsNullOrEmpty(resp.Content))
                Response = JsonConvert.DeserializeObject<RpcResponse<object>>(resp.Content);
            else
                Response = null;
        }

        private string GetMessage()
        {
            if (Response == null)
                return $"[{(int)StatusCode} {StatusCode}] {Uri}";
            else
                return Response.Error.Message;
        }

        public override string Message => GetMessage();
    }
}