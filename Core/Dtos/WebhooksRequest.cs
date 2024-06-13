using Newtonsoft.Json;

namespace Core.Dtos
{
    public class WebhooksRequest
    {
        [JsonProperty("event")]
        public string Event { get; set; }
        [JsonProperty("data")]
        public RequestRef Data { get; set; }
    }

    public class RequestRef
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("tx_ref")]
        public string TxRef { get; set; }

    }
}
