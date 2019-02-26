﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YeniEmlak.Models
{
    public class YeniEmlakDbContext:IdentityDbContext<AppUser>
    {
        public YeniEmlakDbContext(DbContextOptions<YeniEmlakDbContext> dbContextOptions):base(dbContextOptions)
        {

        }
        public DbSet<Advertisement> Advertisements { get; set; }
        public DbSet<Estate> Estates { get; set; }
    }
}
