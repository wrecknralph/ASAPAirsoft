using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASAPAirsoft.Migrations
{
    public partial class ASAPAirsoft : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AirsoftAmmoMaterial",
                columns: table => new
                {
                    AmmoMaterialID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Material = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AirsoftA__DFF4609164916236", x => x.AmmoMaterialID);
                });

            migrationBuilder.CreateTable(
                name: "AirsoftFPS",
                columns: table => new
                {
                    FPSID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FPS_Strength = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AirsoftF__3E860BFCA19A221E", x => x.FPSID);
                });

            migrationBuilder.CreateTable(
                name: "AirsoftGearType",
                columns: table => new
                {
                    GearTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AirsoftG__26A4FE5E06D746A0", x => x.GearTypeID);
                });

            migrationBuilder.CreateTable(
                name: "AirsoftGroupTypes",
                columns: table => new
                {
                    GroupTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AirsoftG__12195A4DAFAB0BB2", x => x.GroupTypeID);
                });

            migrationBuilder.CreateTable(
                name: "AirsoftGunTypes",
                columns: table => new
                {
                    AirsoftGunTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirsoftGunTypes", x => x.AirsoftGunTypeID);
                });

            migrationBuilder.CreateTable(
                name: "AirsoftLocationRules",
                columns: table => new
                {
                    RulesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShortName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AirsoftL__73AFAB2C715ECAE7", x => x.RulesID);
                });

            migrationBuilder.CreateTable(
                name: "AirsoftLocations",
                columns: table => new
                {
                    LocationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Address = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    City = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    State = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ZipCode = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AirsoftL__E7FEA4775D9ACEAD", x => x.LocationID);
                });

            migrationBuilder.CreateTable(
                name: "AirsoftPowerType",
                columns: table => new
                {
                    PowerTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(244)", unicode: false, maxLength: 244, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AirsoftP__B3109347D6B1A21E", x => x.PowerTypeID);
                });

            migrationBuilder.CreateTable(
                name: "AirsoftAmmoType",
                columns: table => new
                {
                    AmmoTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Size = table.Column<int>(type: "int", nullable: true),
                    Weight = table.Column<int>(type: "int", nullable: true),
                    AmmoMaterialID = table.Column<int>(type: "int", nullable: true),
                    FPS_Rated = table.Column<int>(type: "int", nullable: true),
                    FPSID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AirsoftA__CD77D62901F827AC", x => x.AmmoTypeID);
                    table.ForeignKey(
                        name: "FK__AirsoftAm__AmmoM__4E88ABD4",
                        column: x => x.AmmoMaterialID,
                        principalTable: "AirsoftAmmoMaterial",
                        principalColumn: "AmmoMaterialID");
                    table.ForeignKey(
                        name: "FK__AirsoftAm__FPSID__4F7CD00D",
                        column: x => x.FPSID,
                        principalTable: "AirsoftFPS",
                        principalColumn: "FPSID");
                });

            migrationBuilder.CreateTable(
                name: "AirsoftGear",
                columns: table => new
                {
                    GearID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GearTypeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AirsoftG__7117DD6C2E60863B", x => x.GearID);
                    table.ForeignKey(
                        name: "FK__AirsoftGe__GearT__398D8EEE",
                        column: x => x.GearTypeID,
                        principalTable: "AirsoftGearType",
                        principalColumn: "GearTypeID");
                });

            migrationBuilder.CreateTable(
                name: "AirsoftGroup",
                columns: table => new
                {
                    GroupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    URL = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Size = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    GroupTypeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AirsoftG__149AF30A091ACF83", x => x.GroupID);
                    table.ForeignKey(
                        name: "FK__AirsoftGr__Group__45F365D3",
                        column: x => x.GroupTypeID,
                        principalTable: "AirsoftGroupTypes",
                        principalColumn: "GroupTypeID");
                });

            migrationBuilder.CreateTable(
                name: "AirsoftLocationAndRules",
                columns: table => new
                {
                    LocationRulesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RulesID = table.Column<int>(type: "int", nullable: true),
                    LocationID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AirsoftL__CB282FF13A8C7043", x => x.LocationRulesID);
                    table.ForeignKey(
                        name: "FK__AirsoftLo__Locat__412EB0B6",
                        column: x => x.LocationID,
                        principalTable: "AirsoftLocations",
                        principalColumn: "LocationID");
                    table.ForeignKey(
                        name: "FK__AirsoftLo__Rules__403A8C7D",
                        column: x => x.RulesID,
                        principalTable: "AirsoftLocationRules",
                        principalColumn: "RulesID");
                });

            migrationBuilder.CreateTable(
                name: "AirsoftGunsOwned",
                columns: table => new
                {
                    AirsoftGunsOwnedID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    AirsoftGunTypeID = table.Column<int>(type: "int", nullable: true),
                    FPSID = table.Column<int>(type: "int", nullable: true),
                    AmmoTypeID = table.Column<int>(type: "int", nullable: true),
                    PowerTypeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirsoftGunsOwned", x => x.AirsoftGunsOwnedID);
                    table.ForeignKey(
                        name: "FK__AirsoftGu__Airso__5441852A",
                        column: x => x.AirsoftGunTypeID,
                        principalTable: "AirsoftGunTypes",
                        principalColumn: "AirsoftGunTypeID");
                    table.ForeignKey(
                        name: "FK__AirsoftGu__AmmoT__5629CD9C",
                        column: x => x.AmmoTypeID,
                        principalTable: "AirsoftAmmoType",
                        principalColumn: "AmmoTypeID");
                    table.ForeignKey(
                        name: "FK__AirsoftGu__FPSID__5535A963",
                        column: x => x.FPSID,
                        principalTable: "AirsoftFPS",
                        principalColumn: "FPSID");
                    table.ForeignKey(
                        name: "FK__AirsoftGu__Power__571DF1D5",
                        column: x => x.PowerTypeID,
                        principalTable: "AirsoftPowerType",
                        principalColumn: "PowerTypeID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AirsoftAmmoType_AmmoMaterialID",
                table: "AirsoftAmmoType",
                column: "AmmoMaterialID");

            migrationBuilder.CreateIndex(
                name: "IX_AirsoftAmmoType_FPSID",
                table: "AirsoftAmmoType",
                column: "FPSID");

            migrationBuilder.CreateIndex(
                name: "IX_AirsoftGear_GearTypeID",
                table: "AirsoftGear",
                column: "GearTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_AirsoftGroup_GroupTypeID",
                table: "AirsoftGroup",
                column: "GroupTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_AirsoftGunsOwned_AirsoftGunTypeID",
                table: "AirsoftGunsOwned",
                column: "AirsoftGunTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_AirsoftGunsOwned_AmmoTypeID",
                table: "AirsoftGunsOwned",
                column: "AmmoTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_AirsoftGunsOwned_FPSID",
                table: "AirsoftGunsOwned",
                column: "FPSID");

            migrationBuilder.CreateIndex(
                name: "IX_AirsoftGunsOwned_PowerTypeID",
                table: "AirsoftGunsOwned",
                column: "PowerTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_AirsoftLocationAndRules_LocationID",
                table: "AirsoftLocationAndRules",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_AirsoftLocationAndRules_RulesID",
                table: "AirsoftLocationAndRules",
                column: "RulesID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AirsoftGear");

            migrationBuilder.DropTable(
                name: "AirsoftGroup");

            migrationBuilder.DropTable(
                name: "AirsoftGunsOwned");

            migrationBuilder.DropTable(
                name: "AirsoftLocationAndRules");

            migrationBuilder.DropTable(
                name: "AirsoftGearType");

            migrationBuilder.DropTable(
                name: "AirsoftGroupTypes");

            migrationBuilder.DropTable(
                name: "AirsoftGunTypes");

            migrationBuilder.DropTable(
                name: "AirsoftAmmoType");

            migrationBuilder.DropTable(
                name: "AirsoftPowerType");

            migrationBuilder.DropTable(
                name: "AirsoftLocations");

            migrationBuilder.DropTable(
                name: "AirsoftLocationRules");

            migrationBuilder.DropTable(
                name: "AirsoftAmmoMaterial");

            migrationBuilder.DropTable(
                name: "AirsoftFPS");
        }
    }
}
