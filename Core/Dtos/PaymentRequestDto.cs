using Newtonsoft.Json;

namespace Core.Dtos
{
    public class PaymentRequestDto
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("amount")]
        public int AmountInKobo { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("callback_url")]
        public string CallbackUrl { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; } = "NGN";
    }
}
