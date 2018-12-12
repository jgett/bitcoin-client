using Newtonsoft.Json;

namespace BitcoinClient
{
    public class SoftForkReject
    {
        [JsonProperty("status")]
        public bool Status { get; set; }
    }
}