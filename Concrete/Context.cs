using System;
using Kariyer_net.Models;
using Microsoft.EntityFrameworkCore;

namespace Kariyer_net.Concrete
{
	public class Context:DbContext
	{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=localhost;Database=Kariyet_net;Uid=SA;Password=reallyStrongPwd123;TrustServerCertificate=True;MultiSubnetFailover=True");

        }


        public DbSet<Carousel> Carousels { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Firma> Firmas { get; set; }
        public DbSet<Ilan> Ilans { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Referance> Referances { get; set; }


    }
}

