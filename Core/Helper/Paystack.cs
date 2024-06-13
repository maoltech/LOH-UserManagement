using Core.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;


namespace LOH_UserManagement.Core.Helper
{
    public class Paystack
    {
        private readonly IConfiguration _configuration;
        private readonly string token;
        private readonly string url;
        private readonly string frontEndURL;
        public Paystack(IConfiguration configuration)
        {
            _configuration = configuration;
            token = _configuration["Payment:PaystackSK"];
            url = _configuration["PaymentUrl:Paystack"];
            frontEndURL = _configuration["FrontEndUrl"];
        }

        public async Task<PskResponse<Payment>> InitiatePayment(PaymentDto dto, HttpContext context)
        {
            PaymentRequestDto request = new()
            {
                AmountInKobo = (int)dto.Amount * 100,
                Email = dto.Email,
                Reference = dto.TransactionReference,
                Currency = "NGN",
                CallbackUrl = frontEndURL + "/fundwallet?reference=" + dto.TransactionReference
                //CallbackUrl = UrlHelper.BaseAddress(context) + "/Wallet/VerifyPaystackTransaction?reference=" + dto.TransactionReference
            };

            var response = await HttpHelper.PostContentAsync<PaymentRequestDto>(url, request, token, "transaction/initialize");
            var result = await response.Item2.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<PskResponse<Payment>>(result);

        }

        //public async Task<PskResponse<PskTransactions>> VerifyPayment(string reference)
        public async Task<PskResponseDto> VerifyPayment(string reference)
        {

            var response = await HttpHelper.GetContentAsync(url, token, $"transaction/verify/{reference}");

            if (response.Item2.IsSuccessStatusCode)
            {
                var result = await response.Item2.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<PskResponseDto>(result);
                //return JsonConvert.DeserializeObject<PskResponse<PskTransactions>>(result);
            }
            return null;
        }

        public async Task<PskResponse<RecipientData>> CreateTransferRecipient(RecipientDto dto)
        {
            RecipientRequestDto request = new()
            {
                AccountNumber = dto.AccountNumber,
                BankCode = dto.BankCode,
                Description = "Funds transferred from MBOX",
                Name = dto.Name,
            };

            var response = await HttpHelper.PostContentAsync<RecipientRequestDto>(url, request, token, "transferrecipient");

            if (response.Item2.IsSuccessStatusCode)
            {
                var result = await response.Item2.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<PskResponse<RecipientData>>(result);
            }
            return null;
        }

        public async Task<PskResponse<AccountData>> ResolveAccountNumber(string accountNumber, string bankCode)
        {
            var response = await HttpHelper.GetContentAsync(url, token, $"bank/resolve?account_number={accountNumber}&bank_code={bankCode}");

            if (response.Item2.IsSuccessStatusCode)
            {
                var result = await response.Item2.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<PskResponse<AccountData>>(result);
            }
            return null;
        }

        public async Task<BanksResponse> ListBanks()
        {
            var response = await HttpHelper.GetContentAsync(url, token, "bank");

            if (response.Item2.IsSuccessStatusCode)
            {
                var result = await response.Item2.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<BanksResponse>(result);
            }
            return null;
        }

        public async Task<PskResponse<TransferData>> InitiateTransfer(decimal amount, string recipient, string reference)
        {
            TransferRequestDto request = new()
            {
                Source = "balance",
                Currency = "NGN",
                Reason = "Payment From Mbox",
                AmountInKobo = (int)amount * 100,
                Recipient = recipient,
                Reference = reference
            };
            var response = await HttpHelper.PostContentAsync<TransferRequestDto>(url, request, token, "transfer");

            var result = await response.Item2.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<PskResponse<TransferData>>(result);
        }

    }
}
