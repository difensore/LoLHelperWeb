using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class AddIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

           /* migrationBuilder.CreateTable(
                name: "Champ",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Q = table.Column<string>(type: "text", nullable: false),
                    W = table.Column<string>(type: "text", nullable: false),
                    E = table.Column<string>(type: "text", nullable: false),
                    R = table.Column<string>(type: "text", nullable: false),
                    Passive = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Champ", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExtraRunes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtraRunes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainRunes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainRunes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Spell",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Cooldown = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spell", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });*/

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

           /* migrationBuilder.CreateTable(
                name: "Runes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    MainRune = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Runes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Runes_MainRunes",
                        column: x => x.MainRune,
                        principalTable: "MainRunes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RunesBuild",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    MainrRune = table.Column<int>(type: "int", nullable: false),
                    FirstRune = table.Column<int>(type: "int", nullable: false),
                    SecondRune = table.Column<int>(type: "int", nullable: false),
                    ThirdRune = table.Column<int>(type: "int", nullable: false),
                    FourthRune = table.Column<int>(type: "int", nullable: false),
                    SecondMainRune = table.Column<int>(type: "int", nullable: false),
                    FirstRuneS = table.Column<int>(type: "int", nullable: false),
                    SecondRuneS = table.Column<int>(type: "int", nullable: false),
                    FirstExtraRune = table.Column<int>(type: "int", nullable: false),
                    SecondExtraRune = table.Column<int>(type: "int", nullable: false),
                    ThirdExtraRune = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RunesBuild", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RunesBuild_ExtraRunes",
                        column: x => x.FirstExtraRune,
                        principalTable: "ExtraRunes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RunesBuild_ExtraRunes1",
                        column: x => x.SecondExtraRune,
                        principalTable: "ExtraRunes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RunesBuild_ExtraRunes2",
                        column: x => x.ThirdExtraRune,
                        principalTable: "ExtraRunes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RunesBuild_MainRunes",
                        column: x => x.MainrRune,
                        principalTable: "MainRunes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RunesBuild_MainRunes1",
                        column: x => x.SecondMainRune,
                        principalTable: "MainRunes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RunesBuild_Runes",
                        column: x => x.FirstRune,
                        principalTable: "Runes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RunesBuild_Runes1",
                        column: x => x.SecondRune,
                        principalTable: "Runes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RunesBuild_Runes2",
                        column: x => x.ThirdRune,
                        principalTable: "Runes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RunesBuild_Runes3",
                        column: x => x.FourthRune,
                        principalTable: "Runes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RunesBuild_Runes4",
                        column: x => x.FirstRuneS,
                        principalTable: "Runes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RunesBuild_Runes5",
                        column: x => x.SecondRuneS,
                        principalTable: "Runes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Pick",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Position = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Champ = table.Column<int>(type: "int", nullable: false),
                    FirstSpell = table.Column<int>(type: "int", nullable: false),
                    SecondSpell = table.Column<int>(type: "int", nullable: false),
                    RunesBuild = table.Column<int>(type: "int", nullable: false),
                    FirstStartedItem = table.Column<int>(type: "int", nullable: false),
                    SecondStartedItem = table.Column<int>(type: "int", nullable: false),
                    ThirdStartedItem = table.Column<int>(type: "int", nullable: true),
                    FirstMainItem = table.Column<int>(type: "int", nullable: false),
                    SecondMainItem = table.Column<int>(type: "int", nullable: false),
                    ThirdMainItem = table.Column<int>(type: "int", nullable: false),
                    FivthMainItem = table.Column<int>(type: "int", nullable: false),
                    UserBuild = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pick", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pick_Champ",
                        column: x => x.Champ,
                        principalTable: "Champ",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pick_Item",
                        column: x => x.FirstStartedItem,
                        principalTable: "Item",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pick_Item1",
                        column: x => x.SecondStartedItem,
                        principalTable: "Item",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pick_Item2",
                        column: x => x.ThirdStartedItem,
                        principalTable: "Item",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pick_Item3",
                        column: x => x.FirstMainItem,
                        principalTable: "Item",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pick_Item4",
                        column: x => x.SecondMainItem,
                        principalTable: "Item",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pick_Item5",
                        column: x => x.ThirdMainItem,
                        principalTable: "Item",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pick_RunesBuild",
                        column: x => x.RunesBuild,
                        principalTable: "RunesBuild",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pick_Spell",
                        column: x => x.SecondSpell,
                        principalTable: "Spell",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pick_Spell1",
                        column: x => x.FirstSpell,
                        principalTable: "Spell",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Contr",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Champ = table.Column<int>(type: "int", nullable: false),
                    Contr1 = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contr", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contr_Champ",
                        column: x => x.Champ,
                        principalTable: "Champ",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Contr_Pick",
                        column: x => x.Contr1,
                        principalTable: "Pick",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UsersBuilds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BuildId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersBuilds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsersBuilds_Pick",
                        column: x => x.BuildId,
                        principalTable: "Pick",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UsersBuilds_Users",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });*/

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Contr_Champ",
                table: "Contr",
                column: "Champ");

            migrationBuilder.CreateIndex(
                name: "IX_Contr_Contr1",
                table: "Contr",
                column: "Contr1");

            migrationBuilder.CreateIndex(
                name: "IX_Pick_Champ",
                table: "Pick",
                column: "Champ");

            migrationBuilder.CreateIndex(
                name: "IX_Pick_FirstMainItem",
                table: "Pick",
                column: "FirstMainItem");

            migrationBuilder.CreateIndex(
                name: "IX_Pick_FirstSpell",
                table: "Pick",
                column: "FirstSpell");

            migrationBuilder.CreateIndex(
                name: "IX_Pick_FirstStartedItem",
                table: "Pick",
                column: "FirstStartedItem");

            migrationBuilder.CreateIndex(
                name: "IX_Pick_RunesBuild",
                table: "Pick",
                column: "RunesBuild");

            migrationBuilder.CreateIndex(
                name: "IX_Pick_SecondMainItem",
                table: "Pick",
                column: "SecondMainItem");

            migrationBuilder.CreateIndex(
                name: "IX_Pick_SecondSpell",
                table: "Pick",
                column: "SecondSpell");

            migrationBuilder.CreateIndex(
                name: "IX_Pick_SecondStartedItem",
                table: "Pick",
                column: "SecondStartedItem");

            migrationBuilder.CreateIndex(
                name: "IX_Pick_ThirdMainItem",
                table: "Pick",
                column: "ThirdMainItem");

            migrationBuilder.CreateIndex(
                name: "IX_Pick_ThirdStartedItem",
                table: "Pick",
                column: "ThirdStartedItem");

            migrationBuilder.CreateIndex(
                name: "IX_Runes_MainRune",
                table: "Runes",
                column: "MainRune");

            migrationBuilder.CreateIndex(
                name: "IX_RunesBuild_FirstExtraRune",
                table: "RunesBuild",
                column: "FirstExtraRune");

            migrationBuilder.CreateIndex(
                name: "IX_RunesBuild_FirstRune",
                table: "RunesBuild",
                column: "FirstRune");

            migrationBuilder.CreateIndex(
                name: "IX_RunesBuild_FirstRuneS",
                table: "RunesBuild",
                column: "FirstRuneS");

            migrationBuilder.CreateIndex(
                name: "IX_RunesBuild_FourthRune",
                table: "RunesBuild",
                column: "FourthRune");

            migrationBuilder.CreateIndex(
                name: "IX_RunesBuild_MainrRune",
                table: "RunesBuild",
                column: "MainrRune");

            migrationBuilder.CreateIndex(
                name: "IX_RunesBuild_SecondExtraRune",
                table: "RunesBuild",
                column: "SecondExtraRune");

            migrationBuilder.CreateIndex(
                name: "IX_RunesBuild_SecondMainRune",
                table: "RunesBuild",
                column: "SecondMainRune");

            migrationBuilder.CreateIndex(
                name: "IX_RunesBuild_SecondRune",
                table: "RunesBuild",
                column: "SecondRune");

            migrationBuilder.CreateIndex(
                name: "IX_RunesBuild_SecondRuneS",
                table: "RunesBuild",
                column: "SecondRuneS");

            migrationBuilder.CreateIndex(
                name: "IX_RunesBuild_ThirdExtraRune",
                table: "RunesBuild",
                column: "ThirdExtraRune");

            migrationBuilder.CreateIndex(
                name: "IX_RunesBuild_ThirdRune",
                table: "RunesBuild",
                column: "ThirdRune");            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Contr");

            migrationBuilder.DropTable(
                name: "UsersBuilds");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Pick");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Champ");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "RunesBuild");

            migrationBuilder.DropTable(
                name: "Spell");

            migrationBuilder.DropTable(
                name: "ExtraRunes");

            migrationBuilder.DropTable(
                name: "Runes");

            migrationBuilder.DropTable(
                name: "MainRunes");
        }
    }
}
