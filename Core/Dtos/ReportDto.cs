
namespace Core.Dtos
{
    public class ReportDto
    {

        public string Fullname { get; set; }
        public string? Subject { get; set; }
        public string? Issuer { get; set; }
        public Boolean? ReportBusiness { get; set; }

        public string[]? Image {  get; set; }

        public String? StoreName { get; set; }
        public String? StoreId { get; set; }

        public string? BuyerId { get; set; }

        public String? BuyerNumber { get; set; }
        public String Comment { get; set; }


    }
}
