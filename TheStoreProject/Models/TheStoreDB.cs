﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheStoreProject.Models
{
    public class TheStoreDB : DbContext 
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Vendor> Vendors { get; set; }

        public TheStoreDB(DbContextOptions options) : base(options)
        {

        }

    }
}
