﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPOS.Model.Models
{
    public class UserProfileModel
    {
        public string? UserId { get; set; } 
        public string? FullName { get; set; }
        public string? Email { get; set; }

        public string? PhoneNum { get; set; }
        public string? Address { get; set; }
    }
}