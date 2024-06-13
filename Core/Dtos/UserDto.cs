using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos
{
    public class UserDto
    {
        public string Id { get; set; }

        public string? Fullname { get; set; }

        public string? Email { get; set; }

        public string? PhoneNumber { get; set; }

        public string? ProfilePicture { get; set; }

        public string? Gender { get; set; }

        public string? Role { get; set; }

    }

    public class ProfilePicutreDto
    {
        public string ProfilePicture { get; set; }
    }
}
