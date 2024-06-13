using Microsoft.AspNetCore.Http;

namespace LOH_UserManagement.Core.Helper
{
    public class MailRequest
    {
        public string? RecipientMail { get; set; }
        public string? Subject { get; set; }
        public string? Body { get; set; }
        public List<IFormFile> Attachments { get; set; }
        public string? VendorEmail { get; set; }
        public string? InvoiceId { get; set; }
    }
}
