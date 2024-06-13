using Data;

namespace Core.Dtos
{
    public class ProductsDTO 
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public string? Color { get; set; }
        public List<string> Tags { get; set; }
        public string ImageUrl { get; set; }    
        //public List<string> Colors { get; set; }
        //public List<string> Sizes { get; set; }

    }
}
