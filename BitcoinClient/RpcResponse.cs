using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BitcoinClient
{
    public class RpcResponse<T> : IRpcResponse<T>
    {
        [JsonProperty("result")]
        public T Result { get; set; }

        [JsonProperty("error")]
        public RpcError Error { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        public override string ToString()
        {
            var json = JsonConvert.SerializeObject(this);
            return JToken.Parse(json).ToString(Formatting.Indented);
        }
    }
}
