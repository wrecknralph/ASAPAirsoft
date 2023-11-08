using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ASAPAirsoft.Models
{
    public partial class AirsoftDBContext : DbContext
    {
        public AirsoftDBContext()
        {
        }

        public AirsoftDBContext(DbContextOptions<AirsoftDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AirsoftGearModel> AirsoftGearModel { get; set; } = null!;
        public virtual DbSet<AirsoftGunModel> AirsoftGunModel { get; set; } = null!;
        public virtual DbSet<AirsoftLocationModel> AirsoftLocationModel { get; set; } = null!;
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ASAPAirsoft;Trusted_Connection=True;MultipleActiveResultSets=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
