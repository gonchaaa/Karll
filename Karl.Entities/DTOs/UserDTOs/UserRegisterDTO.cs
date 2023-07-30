using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karl.Entities.DTOs.UserDTOs
{
    public class UserRegisterDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordRepeat { get; set; }
        public string Address { get; set; }
    }
}
