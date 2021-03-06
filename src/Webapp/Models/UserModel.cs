﻿using GrainInterfaces;
using System.ComponentModel.DataAnnotations;

namespace Webapp.Models
{
    public class UserModel
    {
        [Required]
        public bool IsAuthenticated { get; set; }

        public string UserId { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
