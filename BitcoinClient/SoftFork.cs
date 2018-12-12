using Newtonsoft.Json;

namespace BitcoinClient
{
    public class SoftFork
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("reject")]
        public SoftForkReject Reject { get; set; }
    }
}