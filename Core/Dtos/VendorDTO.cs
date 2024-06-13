namespace Core.Dtos
{
    public class VendorDTO
    {
        public string UserId { get; set; }
        public string Email { get; set; }
        public string CategoryId { get; set; }
        public string? Image { get; set; }
        public string StoreName { get; set; }
        public string StoreDescription { get; set; }
        public string StoreAbbrevation { get; set; }
        public string StoreAddress { get; set; }
        public string BankName { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
    }

    public class UpdateVendorDTO
    {
        public string? CategoryId { get; set; }
        public string? Image { get; set; }
        public string? StoreName { get; set; }
        public string? StoreDescription { get; set; }
        public string? StoreAbbrevation { get; set; }
        public string? StoreAddress { get; set; }
        public string? BankName { get; set; }
        public string? AccountName { get; set; }
        public string? AccountNumber { get; set; }
    }
}
