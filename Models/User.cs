using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSD412_Group_Assignment.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
