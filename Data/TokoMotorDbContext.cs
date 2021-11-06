using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TokoMotor.Controllers;
using TokoMotor.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace TokoMotor.Data
{
    public class TokoMotorDbContext : IdentityDbContext<User>
    {
        public TokoMotorDbContext(DbContextOptions<TokoMotorDbContext> options) : base(options)
        { }

        public DbSet<Motor> Motors { get; set; }
    }
}