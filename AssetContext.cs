using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assets_Management_System
{
    class AssetContext: DbContext
    {
        public DbSet<LaptopComputer> LaptopComputers { get; set; }
        public DbSet<MobilePhone> MobilePhones { get; set; }
        public DbSet<Office> Offices { get; set; }

        public DbSet<ExchangeRate> ExchangeRates { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-KF048ET;Initial Catalog=AssetTracking;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
