﻿// <auto-generated />
using System;
using ASAPAirsoft.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASAPAirsoft.Migrations
{
    [DbContext(typeof(AirsoftDBContext))]
    partial class AirsoftDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ASAPAirsoft.Models.AirsoftAmmoMaterial", b =>
                {
                    b.Property<int>("AmmoMaterialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AmmoMaterialID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AmmoMaterialId"), 1L, 1);

                    b.Property<string>("Material")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.HasKey("AmmoMaterialId")
                        .HasName("PK__AirsoftA__DFF4609164916236");

                    b.ToTable("AirsoftAmmoMaterial", (string)null);
                });

            modelBuilder.Entity("ASAPAirsoft.Models.AirsoftAmmoType", b =>
                {
                    b.Property<int>("AmmoTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AmmoTypeID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AmmoTypeId"), 1L, 1);

                    b.Property<int?>("AmmoMaterialId")
                        .HasColumnType("int")
                        .HasColumnName("AmmoMaterialID");

                    b.Property<int?>("FpsRated")
                        .HasColumnType("int")
                        .HasColumnName("FPS_Rated");

                    b.Property<int?>("Fpsid")
                        .HasColumnType("int")
                        .HasColumnName("FPSID");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<int?>("Size")
                        .HasColumnType("int");

                    b.Property<int?>("Weight")
                        .HasColumnType("int");

                    b.HasKey("AmmoTypeId")
                        .HasName("PK__AirsoftA__CD77D62901F827AC");

                    b.HasIndex("AmmoMaterialId");

                    b.HasIndex("Fpsid");

                    b.ToTable("AirsoftAmmoType", (string)null);
                });

            modelBuilder.Entity("ASAPAirsoft.Models.AirsoftFp", b =>
                {
                    b.Property<int>("Fpsid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("FPSID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Fpsid"), 1L, 1);

                    b.Property<int?>("FpsStrength")
                        .HasColumnType("int")
                        .HasColumnName("FPS_Strength");

                    b.HasKey("Fpsid")
                        .HasName("PK__AirsoftF__3E860BFCA19A221E");

                    b.ToTable("AirsoftFPS", (string)null);
                });

            modelBuilder.Entity("ASAPAirsoft.Models.AirsoftGear", b =>
                {
                    b.Property<int>("GearId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("GearID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GearId"), 1L, 1);

                    b.Property<int?>("GearTypeId")
                        .HasColumnType("int")
                        .HasColumnName("GearTypeID");

                    b.HasKey("GearId")
                        .HasName("PK__AirsoftG__7117DD6C2E60863B");

                    b.HasIndex("GearTypeId");

                    b.ToTable("AirsoftGear", (string)null);
                });

            modelBuilder.Entity("ASAPAirsoft.Models.AirsoftGearType", b =>
                {
                    b.Property<int>("GearTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("GearTypeID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GearTypeId"), 1L, 1);

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.HasKey("GearTypeId")
                        .HasName("PK__AirsoftG__26A4FE5E06D746A0");

                    b.ToTable("AirsoftGearType", (string)null);
                });

            modelBuilder.Entity("ASAPAirsoft.Models.AirsoftGroup", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("GroupID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GroupId"), 1L, 1);

                    b.Property<int?>("GroupTypeId")
                        .HasColumnType("int")
                        .HasColumnName("GroupTypeID");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Size")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Url")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("URL");

                    b.HasKey("GroupId")
                        .HasName("PK__AirsoftG__149AF30A091ACF83");

                    b.HasIndex("GroupTypeId");

                    b.ToTable("AirsoftGroup", (string)null);
                });

            modelBuilder.Entity("ASAPAirsoft.Models.AirsoftGroupType", b =>
                {
                    b.Property<int>("GroupTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("GroupTypeID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GroupTypeId"), 1L, 1);

                    b.Property<string>("Type")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.HasKey("GroupTypeId")
                        .HasName("PK__AirsoftG__12195A4DAFAB0BB2");

                    b.ToTable("AirsoftGroupTypes");
                });

            modelBuilder.Entity("ASAPAirsoft.Models.AirsoftGunsOwned", b =>
                {
                    b.Property<int>("AirsoftGunsOwnedId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AirsoftGunsOwnedID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AirsoftGunsOwnedId"), 1L, 1);

                    b.Property<int?>("AirsoftGunTypeId")
                        .HasColumnType("int")
                        .HasColumnName("AirsoftGunTypeID");

                    b.Property<int?>("AmmoTypeId")
                        .HasColumnType("int")
                        .HasColumnName("AmmoTypeID");

                    b.Property<int?>("Fpsid")
                        .HasColumnType("int")
                        .HasColumnName("FPSID");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<int?>("PowerTypeId")
                        .HasColumnType("int")
                        .HasColumnName("PowerTypeID");

                    b.HasKey("AirsoftGunsOwnedId");

                    b.HasIndex("AirsoftGunTypeId");

                    b.HasIndex("AmmoTypeId");

                    b.HasIndex("Fpsid");

                    b.HasIndex("PowerTypeId");

                    b.ToTable("AirsoftGunsOwned", (string)null);
                });

            modelBuilder.Entity("ASAPAirsoft.Models.AirsoftGunType", b =>
                {
                    b.Property<int>("AirsoftGunTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AirsoftGunTypeID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AirsoftGunTypeId"), 1L, 1);

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.HasKey("AirsoftGunTypeId");

                    b.ToTable("AirsoftGunTypes");
                });

            modelBuilder.Entity("ASAPAirsoft.Models.AirsoftLocation", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("LocationID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocationId"), 1L, 1);

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("City")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("State")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ZipCode")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.HasKey("LocationId")
                        .HasName("PK__AirsoftL__E7FEA4775D9ACEAD");

                    b.ToTable("AirsoftLocations");
                });

            modelBuilder.Entity("ASAPAirsoft.Models.AirsoftLocationAndRule", b =>
                {
                    b.Property<int>("LocationRulesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("LocationRulesID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocationRulesId"), 1L, 1);

                    b.Property<int?>("LocationId")
                        .HasColumnType("int")
                        .HasColumnName("LocationID");

                    b.Property<int?>("RulesId")
                        .HasColumnType("int")
                        .HasColumnName("RulesID");

                    b.HasKey("LocationRulesId")
                        .HasName("PK__AirsoftL__CB282FF13A8C7043");

                    b.HasIndex("LocationId");

                    b.HasIndex("RulesId");

                    b.ToTable("AirsoftLocationAndRules");
                });

            modelBuilder.Entity("ASAPAirsoft.Models.AirsoftLocationRule", b =>
                {
                    b.Property<int>("RulesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("RulesID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RulesId"), 1L, 1);

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ShortName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("RulesId")
                        .HasName("PK__AirsoftL__73AFAB2C715ECAE7");

                    b.ToTable("AirsoftLocationRules");
                });

            modelBuilder.Entity("ASAPAirsoft.Models.AirsoftPowerType", b =>
                {
                    b.Property<int>("PowerTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PowerTypeID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PowerTypeId"), 1L, 1);

                    b.Property<string>("Name")
                        .HasMaxLength(244)
                        .IsUnicode(false)
                        .HasColumnType("varchar(244)");

                    b.HasKey("PowerTypeId")
                        .HasName("PK__AirsoftP__B3109347D6B1A21E");

                    b.ToTable("AirsoftPowerType", (string)null);
                });

            modelBuilder.Entity("ASAPAirsoft.Models.AirsoftAmmoType", b =>
                {
                    b.HasOne("ASAPAirsoft.Models.AirsoftAmmoMaterial", "AmmoMaterial")
                        .WithMany("AirsoftAmmoTypes")
                        .HasForeignKey("AmmoMaterialId")
                        .HasConstraintName("FK__AirsoftAm__AmmoM__4E88ABD4");

                    b.HasOne("ASAPAirsoft.Models.AirsoftFp", "Fps")
                        .WithMany("AirsoftAmmoTypes")
                        .HasForeignKey("Fpsid")
                        .HasConstraintName("FK__AirsoftAm__FPSID__4F7CD00D");

                    b.Navigation("AmmoMaterial");

                    b.Navigation("Fps");
                });

            modelBuilder.Entity("ASAPAirsoft.Models.AirsoftGear", b =>
                {
                    b.HasOne("ASAPAirsoft.Models.AirsoftGearType", "GearType")
                        .WithMany("AirsoftGears")
                        .HasForeignKey("GearTypeId")
                        .HasConstraintName("FK__AirsoftGe__GearT__398D8EEE");

                    b.Navigation("GearType");
                });

            modelBuilder.Entity("ASAPAirsoft.Models.AirsoftGroup", b =>
                {
                    b.HasOne("ASAPAirsoft.Models.AirsoftGroupType", "GroupType")
                        .WithMany("AirsoftGroups")
                        .HasForeignKey("GroupTypeId")
                        .HasConstraintName("FK__AirsoftGr__Group__45F365D3");

                    b.Navigation("GroupType");
                });

            modelBuilder.Entity("ASAPAirsoft.Models.AirsoftGunsOwned", b =>
                {
                    b.HasOne("ASAPAirsoft.Models.AirsoftGunType", "AirsoftGunType")
                        .WithMany("AirsoftGunsOwneds")
                        .HasForeignKey("AirsoftGunTypeId")
                        .HasConstraintName("FK__AirsoftGu__Airso__5441852A");

                    b.HasOne("ASAPAirsoft.Models.AirsoftAmmoType", "AmmoType")
                        .WithMany("AirsoftGunsOwneds")
                        .HasForeignKey("AmmoTypeId")
                        .HasConstraintName("FK__AirsoftGu__AmmoT__5629CD9C");

                    b.HasOne("ASAPAirsoft.Models.AirsoftFp", "Fps")
                        .WithMany("AirsoftGunsOwneds")
                        .HasForeignKey("Fpsid")
                        .HasConstraintName("FK__AirsoftGu__FPSID__5535A963");

                    b.HasOne("ASAPAirsoft.Models.AirsoftPowerType", "PowerType")
                        .WithMany("AirsoftGunsOwneds")
                        .HasForeignKey("PowerTypeId")
                        .HasConstraintName("FK__AirsoftGu__Power__571DF1D5");

                    b.Navigation("AirsoftGunType");

                    b.Navigation("AmmoType");

                    b.Navigation("Fps");

                    b.Navigation("PowerType");
                });

            modelBuilder.Entity("ASAPAirsoft.Models.AirsoftLocationAndRule", b =>
                {
                    b.HasOne("ASAPAirsoft.Models.AirsoftLocation", "Location")
                        .WithMany("AirsoftLocationAndRules")
                        .HasForeignKey("LocationId")
                        .HasConstraintName("FK__AirsoftLo__Locat__412EB0B6");

                    b.HasOne("ASAPAirsoft.Models.AirsoftLocationRule", "Rules")
                        .WithMany("AirsoftLocationAndRules")
                        .HasForeignKey("RulesId")
                        .HasConstraintName("FK__AirsoftLo__Rules__403A8C7D");

                    b.Navigation("Location");

                    b.Navigation("Rules");
                });

            modelBuilder.Entity("ASAPAirsoft.Models.AirsoftAmmoMaterial", b =>
                {
                    b.Navigation("AirsoftAmmoTypes");
                });

            modelBuilder.Entity("ASAPAirsoft.Models.AirsoftAmmoType", b =>
                {
                    b.Navigation("AirsoftGunsOwneds");
                });

            modelBuilder.Entity("ASAPAirsoft.Models.AirsoftFp", b =>
                {
                    b.Navigation("AirsoftAmmoTypes");

                    b.Navigation("AirsoftGunsOwneds");
                });

            modelBuilder.Entity("ASAPAirsoft.Models.AirsoftGearType", b =>
                {
                    b.Navigation("AirsoftGears");
                });

            modelBuilder.Entity("ASAPAirsoft.Models.AirsoftGroupType", b =>
                {
                    b.Navigation("AirsoftGroups");
                });

            modelBuilder.Entity("ASAPAirsoft.Models.AirsoftGunType", b =>
                {
                    b.Navigation("AirsoftGunsOwneds");
                });

            modelBuilder.Entity("ASAPAirsoft.Models.AirsoftLocation", b =>
                {
                    b.Navigation("AirsoftLocationAndRules");
                });

            modelBuilder.Entity("ASAPAirsoft.Models.AirsoftLocationRule", b =>
                {
                    b.Navigation("AirsoftLocationAndRules");
                });

            modelBuilder.Entity("ASAPAirsoft.Models.AirsoftPowerType", b =>
                {
                    b.Navigation("AirsoftGunsOwneds");
                });
#pragma warning restore 612, 618
        }
    }
}
