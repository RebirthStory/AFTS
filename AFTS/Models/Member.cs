using System;
using System.Collections.Generic;

namespace AFTS.Models
{
    public partial class Member
    {
        public int MemberId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Nickname { get; set; }
        public DateTime Dob { get; set; }
        public Role RoleId { get; set; }
        public string Gender { get; set; }
        public string Biography { get; set; }

    }
}
