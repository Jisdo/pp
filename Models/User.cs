using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace TokoMotor.Models
{
    public class User : IdentityUser
    {
        public string Nama { get; set; }
        public string Avatar { get; set; }
    }
}