﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace RLLPROJ.ContextDbConfig
{
    public class FoodDBContext:IdentityDbContext<IdentityUser>
    {
        public FoodDBContext(DbContextOptions<FoodDBContext> options) : base(options) 
        {
        
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
