﻿using Microsoft.EntityFrameworkCore;
using MiPrimerAPI.Models;
using System.Collections.Generic;

namespace MiPrimerAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }

        public DbSet<Product> Products { get; set; }
    }
}
