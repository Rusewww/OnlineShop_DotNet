﻿using Microsoft.EntityFrameworkCore;
using OnlineShop_DotNet.Data.Models;

namespace OnlineShop_DotNet.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options) {

        }

        public DbSet<СomputerСomponent> ComputerСomponents { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}