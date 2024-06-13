namespace LOH_UserManagement.Entities
{
    public class Wallet: BaseEntity
    {
        public string UserId { get; set; }
        public decimal Balance { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string Bank { get; set; }
        public virtual User User { get; set; }
    }
}
