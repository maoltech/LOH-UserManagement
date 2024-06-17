

namespace LOH_UserManagement.Entities
{
    public class LOHUser: BaseEntity
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsBuyer { get; set; }
        public bool IsSeller { get; set; }
        public bool IsEmailVerified { get; set; }
        public virtual Seller Seller { get; set; }
        public virtual Buyer Buyer { get; set; }
        public virtual Wallet Wallet { get; set; }
    }
}
