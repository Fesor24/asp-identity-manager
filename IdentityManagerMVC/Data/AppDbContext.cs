﻿using IdentityManagerMVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityManagerMVC.Data
{
    public class AppDbContext: IdentityDbContext
    {
        public AppDbContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<AppUser> AppUsers => Set<AppUser>();
    }
}
