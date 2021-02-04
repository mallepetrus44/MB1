using Microsoft.EntityFrameworkCore;
using ModellenBureau.Main.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModellenBureau.API.Models
{
    public class MBDbContext : DbContext
    {
        public MBDbContext(DbContextOptions<MBDbContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<PhotoModel> PhotoModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
