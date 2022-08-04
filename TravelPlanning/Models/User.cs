using System;
using System.Collections.Generic;

namespace TravelPlanning.Models
{
    public partial class User
    {
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Country { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
    }
}
