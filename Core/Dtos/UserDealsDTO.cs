using Data;
using Data.Enums;

namespace Core.Dtos
{
    public class UserDealsDTO
    {
        public string Id { get; set; }
        public string? VendorId { get; set; }
        public string? BuyerId { get; set; }
        public DealStatusEnum DealStatusEnum { get; set; }
        public bool Status { get; set; }
        public string InvoiceId { get; set; }
        public ProductDetailsDTO Product { get; set; }
    }

    public class ProductDetailsDTO
    {
        public string ProductTag { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public OtherProductDetailsDTO OtherDetails { get; set; }
    }

    public class OtherProductDetailsDTO
    {
        public string Color { get; set; }
        public string ImageUrl { get; set; }
        // Other properties from MboxProducts if needed
    }
}
