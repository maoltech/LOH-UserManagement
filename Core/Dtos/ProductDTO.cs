using Data;
namespace Core.Dtos
{
    public class ProductDTO
    {
        public string Tag { get; set; }
        public string? ProductDescription { get; set; }
        public decimal? Price { get; set; }
        public int Quantity { get; set; }

        public List<InvoiceProductImage>? Images { get; set; }
    }

}
