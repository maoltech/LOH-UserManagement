using Newtonsoft.Json;
using System.Net;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Core.Dtos
{
    public class PaymentDto
    {        
        public decimal Amount { get; set; }
        public string? Email { get; set; }
        public string TransactionReference { get; set; } = Guid.NewGuid().ToString();
    }

    public class PskTransactions
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("transaction_date")]
        public DateTime TransactionDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("gateway_response")]
        public string GatewayResponse { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        [JsonProperty("authorization")]
        public Authorization Authorization { get; set; }
    }

    public class RecipientData
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("details")]
        public Details Details { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("recipient_code")]
        public string RecipientCode { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }
    }

    public class Details
    {

        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        [JsonProperty("account_name")]
        public object AccountName { get; set; }

        [JsonProperty("bank_code")]
        public string BankCode { get; set; }

        [JsonProperty("bank_name")]
        public string BankName { get; set; }
    }

    public class BanksResponse
    {

        [JsonProperty("status")]
        public bool Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IList<Datum> Data { get; set; }
    }

    public class Datum
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("longcode")]
        public string Longcode { get; set; }

        [JsonProperty("gateway")]
        public string Gateway { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("is_deleted")]
        public object IsDeleted { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }
    }

    public class TransferRequestDto
    {
        [JsonProperty("source")]
        public string Source { get; set; }
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("amount")]
        public int AmountInKobo { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; } = "NGN";
        [JsonProperty("reason")]
        public string Reason { get; set; }
        [JsonProperty("recipient")]
        public string Recipient { get; set; }
    }

    public class TransferData
    {
        [JsonProperty("recipient")]
        public string Recipient { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("source_details")]
        public object SourceDetails { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("failures")]
        public object Failures { get; set; }

        [JsonProperty("transfer_code")]
        public string TransferCode { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }
    }

    public class Payment
    {

        [JsonProperty("authorization_url")]
        public string AuthorizationUrl { get; set; }

        [JsonProperty("access_code")]
        public string AccessCode { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

    }
}
