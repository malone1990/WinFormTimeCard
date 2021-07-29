using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormTimeCard.Models
{
    public class UserInfo
    {
        public int UserId { get; set; }

        public string Name { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public bool IsAdmin { get; set; }

    }
}
