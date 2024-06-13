﻿namespace LOH_UserManagement.Entities
{
    public class Buyer: BaseEntity
    {
        public string UserId { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public virtual User User { get; set; }
    }
}
