using Data;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Core.Dtos
{
    public class GenerateInvoiceDto
    {
        public ICollection<ProductDTO> Products { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;

        //[JsonIgnore]
        public string? Issuer { get; set; }

        public string? Tag { get; set; }
        public string? StoreName { get; set; }

        [EmailAddress]
        public string? Buyer { get; set; }
        public decimal Total { get; set; }
        public decimal EscFee { get; set; }
        public decimal SubTotal { get; set; }
        public bool Status { get; set; }
    }


}
