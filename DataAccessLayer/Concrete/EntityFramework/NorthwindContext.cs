﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=IAGUY47;Database=Northwind;Trusted_Connection=true");
        }
        public DbSet <Urun> Urunler { get; set; }

        public DbSet <Musteri> Musteriler { get; set; }
        public DbSet <Kategori> Kategoriler { get; set; }
        public DbSet <Satis> Satislar { get; set; }
    }
}
