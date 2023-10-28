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

        public virtual DbSet<AirsoftAmmoMaterial> AirsoftAmmoMaterials { get; set; } = null!;
        public virtual DbSet<AirsoftAmmoType> AirsoftAmmoTypes { get; set; } = null!;
        public virtual DbSet<AirsoftFp> AirsoftFps { get; set; } = null!;
        public virtual DbSet<AirsoftGear> AirsoftGears { get; set; } = null!;
        public virtual DbSet<AirsoftGearType> AirsoftGearTypes { get; set; } = null!;
        public virtual DbSet<AirsoftGroup> AirsoftGroups { get; set; } = null!;
        public virtual DbSet<AirsoftGroupType> AirsoftGroupTypes { get; set; } = null!;
        public virtual DbSet<AirsoftGunType> AirsoftGunTypes { get; set; } = null!;
        public virtual DbSet<AirsoftGunsOwned> AirsoftGunsOwneds { get; set; } = null!;
        public virtual DbSet<AirsoftLocation> AirsoftLocations { get; set; } = null!;
        public virtual DbSet<AirsoftLocationAndRule> AirsoftLocationAndRules { get; set; } = null!;
        public virtual DbSet<AirsoftLocationRule> AirsoftLocationRules { get; set; } = null!;
        public virtual DbSet<AirsoftPowerType> AirsoftPowerTypes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ASAPAirsoft;Trusted_Connection=True;MultipleActiveResultSets=true;");            
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AirsoftAmmoMaterial>(entity =>
            {
                entity.HasKey(e => e.AmmoMaterialId)
                    .HasName("PK__AirsoftA__DFF4609164916236");

                entity.ToTable("AirsoftAmmoMaterial");

                entity.Property(e => e.AmmoMaterialId).HasColumnName("AmmoMaterialID");

                entity.Property(e => e.Material)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AirsoftAmmoType>(entity =>
            {
                entity.HasKey(e => e.AmmoTypeId)
                    .HasName("PK__AirsoftA__CD77D62901F827AC");

                entity.ToTable("AirsoftAmmoType");

                entity.Property(e => e.AmmoTypeId).HasColumnName("AmmoTypeID");

                entity.Property(e => e.AmmoMaterialId).HasColumnName("AmmoMaterialID");

                entity.Property(e => e.FpsRated).HasColumnName("FPS_Rated");

                entity.Property(e => e.Fpsid).HasColumnName("FPSID");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.AmmoMaterial)
                    .WithMany(p => p.AirsoftAmmoTypes)
                    .HasForeignKey(d => d.AmmoMaterialId)
                    .HasConstraintName("FK__AirsoftAm__AmmoM__4E88ABD4");

                entity.HasOne(d => d.Fps)
                    .WithMany(p => p.AirsoftAmmoTypes)
                    .HasForeignKey(d => d.Fpsid)
                    .HasConstraintName("FK__AirsoftAm__FPSID__4F7CD00D");
            });

            modelBuilder.Entity<AirsoftFp>(entity =>
            {
                entity.HasKey(e => e.Fpsid)
                    .HasName("PK__AirsoftF__3E860BFCA19A221E");

                entity.ToTable("AirsoftFPS");

                entity.Property(e => e.Fpsid).HasColumnName("FPSID");

                entity.Property(e => e.FpsStrength).HasColumnName("FPS_Strength");
            });

            modelBuilder.Entity<AirsoftGear>(entity =>
            {
                entity.HasKey(e => e.GearId)
                    .HasName("PK__AirsoftG__7117DD6C2E60863B");

                entity.ToTable("AirsoftGear");

                entity.Property(e => e.GearId).HasColumnName("GearID");

                entity.Property(e => e.GearTypeId).HasColumnName("GearTypeID");

                entity.HasOne(d => d.GearType)
                    .WithMany(p => p.AirsoftGears)
                    .HasForeignKey(d => d.GearTypeId)
                    .HasConstraintName("FK__AirsoftGe__GearT__398D8EEE");
            });

            modelBuilder.Entity<AirsoftGearType>(entity =>
            {
                entity.HasKey(e => e.GearTypeId)
                    .HasName("PK__AirsoftG__26A4FE5E06D746A0");

                entity.ToTable("AirsoftGearType");

                entity.Property(e => e.GearTypeId).HasColumnName("GearTypeID");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AirsoftGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId)
                    .HasName("PK__AirsoftG__149AF30A091ACF83");

                entity.ToTable("AirsoftGroup");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.GroupTypeId).HasColumnName("GroupTypeID");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Size)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("URL");

                entity.HasOne(d => d.GroupType)
                    .WithMany(p => p.AirsoftGroups)
                    .HasForeignKey(d => d.GroupTypeId)
                    .HasConstraintName("FK__AirsoftGr__Group__45F365D3");
            });

            modelBuilder.Entity<AirsoftGroupType>(entity =>
            {
                entity.HasKey(e => e.GroupTypeId)
                    .HasName("PK__AirsoftG__12195A4DAFAB0BB2");

                entity.Property(e => e.GroupTypeId).HasColumnName("GroupTypeID");

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AirsoftGunType>(entity =>
            {
                entity.Property(e => e.AirsoftGunTypeId).HasColumnName("AirsoftGunTypeID");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AirsoftGunsOwned>(entity =>
            {
                entity.ToTable("AirsoftGunsOwned");

                entity.Property(e => e.AirsoftGunsOwnedId).HasColumnName("AirsoftGunsOwnedID");

                entity.Property(e => e.AirsoftGunTypeId).HasColumnName("AirsoftGunTypeID");

                entity.Property(e => e.AmmoTypeId).HasColumnName("AmmoTypeID");

                entity.Property(e => e.Fpsid).HasColumnName("FPSID");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PowerTypeId).HasColumnName("PowerTypeID");

                entity.HasOne(d => d.AirsoftGunType)
                    .WithMany(p => p.AirsoftGunsOwneds)
                    .HasForeignKey(d => d.AirsoftGunTypeId)
                    .HasConstraintName("FK__AirsoftGu__Airso__5441852A");

                entity.HasOne(d => d.AmmoType)
                    .WithMany(p => p.AirsoftGunsOwneds)
                    .HasForeignKey(d => d.AmmoTypeId)
                    .HasConstraintName("FK__AirsoftGu__AmmoT__5629CD9C");

                entity.HasOne(d => d.Fps)
                    .WithMany(p => p.AirsoftGunsOwneds)
                    .HasForeignKey(d => d.Fpsid)
                    .HasConstraintName("FK__AirsoftGu__FPSID__5535A963");

                entity.HasOne(d => d.PowerType)
                    .WithMany(p => p.AirsoftGunsOwneds)
                    .HasForeignKey(d => d.PowerTypeId)
                    .HasConstraintName("FK__AirsoftGu__Power__571DF1D5");
            });

            modelBuilder.Entity<AirsoftLocation>(entity =>
            {
                entity.HasKey(e => e.LocationId)
                    .HasName("PK__AirsoftL__E7FEA4775D9ACEAD");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AirsoftLocationAndRule>(entity =>
            {
                entity.HasKey(e => e.LocationRulesId)
                    .HasName("PK__AirsoftL__CB282FF13A8C7043");

                entity.Property(e => e.LocationRulesId).HasColumnName("LocationRulesID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.RulesId).HasColumnName("RulesID");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.AirsoftLocationAndRules)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK__AirsoftLo__Locat__412EB0B6");

                entity.HasOne(d => d.Rules)
                    .WithMany(p => p.AirsoftLocationAndRules)
                    .HasForeignKey(d => d.RulesId)
                    .HasConstraintName("FK__AirsoftLo__Rules__403A8C7D");
            });

            modelBuilder.Entity<AirsoftLocationRule>(entity =>
            {
                entity.HasKey(e => e.RulesId)
                    .HasName("PK__AirsoftL__73AFAB2C715ECAE7");

                entity.Property(e => e.RulesId).HasColumnName("RulesID");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AirsoftPowerType>(entity =>
            {
                entity.HasKey(e => e.PowerTypeId)
                    .HasName("PK__AirsoftP__B3109347D6B1A21E");

                entity.ToTable("AirsoftPowerType");

                entity.Property(e => e.PowerTypeId).HasColumnName("PowerTypeID");

                entity.Property(e => e.Name)
                    .HasMaxLength(244)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
