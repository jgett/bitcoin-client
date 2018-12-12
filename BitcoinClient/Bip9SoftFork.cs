using Newtonsoft.Json;

namespace BitcoinClient
{
    public class Bip9SoftFork
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("startTime")]
        public long StartTime { get; set; }

        [JsonProperty("timeout")]
        public long Timeout { get; set; }

        [JsonProperty("since")]
        public int Since { get; set; }
    }
}