using Newtonsoft.Json;
using System.Collections.Generic;

namespace BitcoinClient
{
    public class BlockchainInfo
    {
        [JsonProperty("chain")]
        public string Chain { get; set; }

        [JsonProperty("blocks")]
        public long Blocks { get; set; }

        [JsonProperty("headers")]
        public long Headers { get; set; }

        [JsonProperty("bestblockhash")]
        public string BestBlockHash { get; set; }

        [JsonProperty("difficulty")]
        public double Difficulty { get; set; }

        [JsonProperty("mediantime")]
        public long MedianTime { get; set; }

        [JsonProperty("verificationprogress")]
        public double VerificationProgress { get; set; }

        [JsonProperty("InitialBlockDownload")]
        public bool initialblockdownload { get; set; }

        [JsonProperty("chainwork")]
        public string ChainWork { get; set; }

        [JsonProperty("size_on_disk")]
        public long SizeOnDisk { get; set; }

        [JsonProperty("pruned")]
        public bool Pruned { get; set; }

        [JsonProperty("softforks")]
        public IEnumerable<SoftFork> SoftForks { get; set; }

        [JsonProperty("bip9_softforks")]
        public IDictionary<string, Bip9SoftFork> Bip9SoftForks { get; set; }

        [JsonProperty("warnings")]
        public string Warnings { get; set; }
    }
}