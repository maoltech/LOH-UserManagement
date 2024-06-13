using System;
using Newtonsoft.Json;

namespace Core.Dtos
{
    public class PskResponse<T>
    {
        [JsonProperty("status")]
        public bool Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("data")]
        public T Data { get; set; }
    }



public class PskResponseDto
    {
        [JsonProperty("status")]
        public bool Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public PskDataDto Data { get; set; }
    }

    public class PskDataDto
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("receipt_number")]
        public object ReceiptNumber { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("message")]
        public object Message { get; set; }

        [JsonProperty("gateway_response")]
        public string GatewayResponse { get; set; }

        [JsonProperty("paid_at")]
        public DateTime PaidAt { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        [JsonProperty("metadata")]
        public string Metadata { get; set; }

        [JsonProperty("log")]
        public LogDto Log { get; set; }

        [JsonProperty("fees")]
        public int Fees { get; set; }

        [JsonProperty("fees_split")]
        public object FeesSplit { get; set; }

        [JsonProperty("authorization")]
        public AuthorizationDto Authorization { get; set; }

        [JsonProperty("customer")]
        public CustomerDto Customer { get; set; }

        // Add more properties as needed
    }

    public class LogDto
    {
        [JsonProperty("start_time")]
        public long StartTime { get; set; }

        [JsonProperty("time_spent")]
        public int TimeSpent { get; set; }

        [JsonProperty("attempts")]
        public int Attempts { get; set; }

        [JsonProperty("errors")]
        public int Errors { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("mobile")]
        public bool Mobile { get; set; }

        [JsonProperty("input")]
        public object[] Input { get; set; }

        [JsonProperty("history")]
        public HistoryDto[] History { get; set; }
    }

    public class HistoryDto
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("time")]
        public int Time { get; set; }
    }

    public class AuthorizationDto
    {
        [JsonProperty("authorization_code")]
        public string AuthorizationCode { get; set; }

        [JsonProperty("bin")]
        public string Bin { get; set; }

        [JsonProperty("last4")]
        public string Last4 { get; set; }

        [JsonProperty("exp_month")]
        public string ExpMonth { get; set; }

        [JsonProperty("exp_year")]
        public string ExpYear { get; set; }

        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("card_type")]
        public string CardType { get; set; }

        [JsonProperty("bank")]
        public string Bank { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("reusable")]
        public bool Reusable { get; set; }

        [JsonProperty("signature")]
        public string Signature { get; set; }

        [JsonProperty("account_name")]
        public object AccountName { get; set; }
    }

    public class CustomerDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("first_name")]
        public object FirstName { get; set; }

        [JsonProperty("last_name")]
        public object LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("customer_code")]
        public string CustomerCode { get; set; }

        [JsonProperty("phone")]
        public object Phone { get; set; }

        [JsonProperty("metadata")]
        public object Metadata { get; set; }

        [JsonProperty("risk_action")]
        public string RiskAction { get; set; }

        [JsonProperty("international_format_phone")]
        public object InternationalFormatPhone { get; set; }
    }

}
