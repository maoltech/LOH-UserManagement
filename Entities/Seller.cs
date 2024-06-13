namespace LOH_UserManagement.Entities
{
    public class Seller: BaseEntity
    {
        public string UserId { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public bool IsBVNVerified { get; set; }
        public bool IsIdVerified { get; set; }
        public virtual User User { get; set; }
    }
}
