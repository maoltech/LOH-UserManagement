namespace Core.Dtos
{
    public class WithdrawFundDto
    {
        public decimal Amount { get; set; }

        public string Email { get; set; }

        public string AccountNumber { get; set; }

        public string BankName { get; set; }
        
    }
}
