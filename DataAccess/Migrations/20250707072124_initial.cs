using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ReallyDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ReallyDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    UseForPersonel = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordBackUp = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Id = table.Column<uint>(type: "int unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BranchName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BranchDetay = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsWork = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ReallyDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifiedUserName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastBackUpId = table.Column<int>(type: "int", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreateUser = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EmployeeWork",
                columns: table => new
                {
                    Id = table.Column<uint>(type: "int unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WorkName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WorkDetay = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsWork = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ReallyDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifiedUserName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastBackUpId = table.Column<int>(type: "int", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreateUser = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeWork", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OtomaticSystemCodes",
                columns: table => new
                {
                    Id = table.Column<uint>(type: "int unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ManuelId = table.Column<uint>(type: "int unsigned", nullable: false),
                    Title = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HashValue = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value1 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value2 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsWork = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ReallyDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifiedUserName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastBackUpId = table.Column<int>(type: "int", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreateUser = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtomaticSystemCodes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ShipYards",
                columns: table => new
                {
                    Id = table.Column<uint>(type: "int unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ShipYardName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsWork = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ReallyDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifiedUserName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastBackUpId = table.Column<int>(type: "int", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreateUser = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipYards", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    Id = table.Column<uint>(type: "int unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    No = table.Column<uint>(type: "int unsigned", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Content = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Amount = table.Column<ushort>(type: "smallint unsigned", nullable: false),
                    Price = table.Column<float>(type: "float", nullable: false),
                    EntryTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ExitTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    SenderName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ForProjectId = table.Column<uint>(type: "int unsigned", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsWork = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ReallyDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifiedUserName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastBackUpId = table.Column<int>(type: "int", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreateUser = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<uint>(type: "int unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SgkRegistrationNumber = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TcNumber = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BirthDay = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Gender = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Phone = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Picture = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WorkStartDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    BranchId = table.Column<uint>(type: "int unsigned", nullable: false),
                    EmployeeWorkId = table.Column<uint>(type: "int unsigned", nullable: false),
                    ShipYardId = table.Column<uint>(type: "int unsigned", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsWork = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ReallyDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifiedUserName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastBackUpId = table.Column<int>(type: "int", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreateUser = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_EmployeeWork_EmployeeWorkId",
                        column: x => x.EmployeeWorkId,
                        principalTable: "EmployeeWork",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_ShipYards_ShipYardId",
                        column: x => x.ShipYardId,
                        principalTable: "ShipYards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EmployeeExits",
                columns: table => new
                {
                    Id = table.Column<uint>(type: "int unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EmployeeId = table.Column<uint>(type: "int unsigned", nullable: false),
                    TeamWorkAveragePoint = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    JabTrackingAveragePoint = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    ContinuityAveragePoint = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    AveragePoint = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    WorkStartDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    WorkFinishDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ExitNote = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmployeeProjects = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsWork = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ReallyDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifiedUserName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastBackUpId = table.Column<int>(type: "int", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreateUser = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeExits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeExits_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EmployeePoints",
                columns: table => new
                {
                    Id = table.Column<uint>(type: "int unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EmployeeId = table.Column<uint>(type: "int unsigned", nullable: false),
                    TeamWorkPoint = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    JabTrackingPoint = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    ContinuityPoint = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    AveragePoint = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    GiveDateStart = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    GiveDateFinish = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserNameGivePoint = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsWork = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ReallyDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePoints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeePoints_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EmployeeUsers",
                columns: table => new
                {
                    Id = table.Column<uint>(type: "int unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmployeeId = table.Column<uint>(type: "int unsigned", nullable: false),
                    BranchId = table.Column<uint>(type: "int unsigned", nullable: false),
                    EmployeeWorkId = table.Column<uint>(type: "int unsigned", nullable: false),
                    Linkedin = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Picture = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsWork = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ReallyDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifiedUserName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastBackUpId = table.Column<int>(type: "int", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreateUser = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeUsers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeUsers_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeUsers_EmployeeWork_EmployeeWorkId",
                        column: x => x.EmployeeWorkId,
                        principalTable: "EmployeeWork",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeUsers_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ScoreCard",
                columns: table => new
                {
                    Id = table.Column<uint>(type: "int unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Day = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Status = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    ShiftHour = table.Column<ushort>(type: "smallint unsigned", nullable: false),
                    EmployeeId = table.Column<uint>(type: "int unsigned", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsWork = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ReallyDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifiedUserName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastBackUpId = table.Column<int>(type: "int", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreateUser = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScoreCard", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScoreCard_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<uint>(type: "int unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ShipYardId = table.Column<uint>(type: "int unsigned", nullable: false),
                    ProjectStartTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ProjectFinishTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ProjectName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProjectManagerId = table.Column<uint>(type: "int unsigned", maxLength: 50, nullable: false),
                    TotalSpoolCount = table.Column<uint>(type: "int unsigned", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsWork = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ReallyDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifiedUserName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastBackUpId = table.Column<int>(type: "int", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreateUser = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_EmployeeUsers_ProjectManagerId",
                        column: x => x.ProjectManagerId,
                        principalTable: "EmployeeUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Projects_ShipYards_ShipYardId",
                        column: x => x.ShipYardId,
                        principalTable: "ShipYards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CircutSystems",
                columns: table => new
                {
                    Id = table.Column<uint>(type: "int unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SystemName = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProjectId = table.Column<uint>(type: "int unsigned", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsWork = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ReallyDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CircutSystems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CircutSystems_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EmployeeProjects",
                columns: table => new
                {
                    Id = table.Column<uint>(type: "int unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EmployeeId = table.Column<uint>(type: "int unsigned", nullable: false),
                    BranchId = table.Column<uint>(type: "int unsigned", nullable: false),
                    EmployeeWorkId = table.Column<uint>(type: "int unsigned", nullable: false),
                    ProjectId = table.Column<uint>(type: "int unsigned", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ManagerUserId = table.Column<uint>(type: "int unsigned", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsWork = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ReallyDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeProjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeProjects_Branches_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeProjects_EmployeeUsers_ManagerUserId",
                        column: x => x.ManagerUserId,
                        principalTable: "EmployeeUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeProjects_EmployeeWork_EmployeeWorkId",
                        column: x => x.EmployeeWorkId,
                        principalTable: "EmployeeWork",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeProjects_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeProjects_Projects_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Spools",
                columns: table => new
                {
                    Id = table.Column<uint>(type: "int unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    No = table.Column<ushort>(type: "smallint unsigned", nullable: false),
                    SpoolName = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    spoolStatus = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    SendingLocation = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    Diameter = table.Column<ushort>(type: "smallint unsigned", nullable: false),
                    TotalKg = table.Column<float>(type: "float", nullable: false),
                    Note = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AssemblyOur = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    WorkPlaceOur = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CircutSystemId = table.Column<uint>(type: "int unsigned", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsWork = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ReallyDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spools", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Spools_CircutSystems_CircutSystemId",
                        column: x => x.CircutSystemId,
                        principalTable: "CircutSystems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SpoolAssemblies",
                columns: table => new
                {
                    Id = table.Column<uint>(type: "int unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AssemblyTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    AssemblyEmployeeId = table.Column<uint>(type: "int unsigned", nullable: false),
                    AssemblyKg = table.Column<ushort>(type: "smallint unsigned", nullable: false),
                    SpoolId = table.Column<uint>(type: "int unsigned", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsWork = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ReallyDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpoolAssemblies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpoolAssemblies_Employees_AssemblyEmployeeId",
                        column: x => x.AssemblyEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpoolAssemblies_Spools_SpoolId",
                        column: x => x.SpoolId,
                        principalTable: "Spools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SpoolWorkShopAssembly",
                columns: table => new
                {
                    Id = table.Column<uint>(type: "int unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AssemblyTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    AssemblyEmployeeId = table.Column<uint>(type: "int unsigned", nullable: false),
                    AssemblyKg = table.Column<ushort>(type: "smallint unsigned", nullable: false),
                    SpoolId = table.Column<uint>(type: "int unsigned", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsWork = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ReallyDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpoolWorkShopAssembly", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpoolWorkShopAssembly_Employees_AssemblyEmployeeId",
                        column: x => x.AssemblyEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpoolWorkShopAssembly_Spools_SpoolId",
                        column: x => x.SpoolId,
                        principalTable: "Spools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SpoolWorkShopWelding",
                columns: table => new
                {
                    Id = table.Column<uint>(type: "int unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WeldingTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    WeldingEmployeeId = table.Column<uint>(type: "int unsigned", nullable: false),
                    QualityTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    SendTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    SpoolId = table.Column<uint>(type: "int unsigned", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsWork = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ReallyDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpoolWorkShopWelding", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpoolWorkShopWelding_Employees_WeldingEmployeeId",
                        column: x => x.WeldingEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpoolWorkShopWelding_Spools_SpoolId",
                        column: x => x.SpoolId,
                        principalTable: "Spools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SpoolNavigators",
                columns: table => new
                {
                    Id = table.Column<uint>(type: "int unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProjectId = table.Column<uint>(type: "int unsigned", nullable: false),
                    CircutSystemId = table.Column<uint>(type: "int unsigned", nullable: false),
                    SpoolId = table.Column<uint>(type: "int unsigned", nullable: false),
                    SpoolAssemblyId = table.Column<uint>(type: "int unsigned", nullable: false),
                    SpoolWorkShopAssemblyId = table.Column<uint>(type: "int unsigned", nullable: false),
                    SpoolWorkShopWeldingId = table.Column<uint>(type: "int unsigned", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsWork = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ReallyDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpoolNavigators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpoolNavigators_CircutSystems_CircutSystemId",
                        column: x => x.CircutSystemId,
                        principalTable: "CircutSystems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpoolNavigators_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpoolNavigators_SpoolAssemblies_SpoolAssemblyId",
                        column: x => x.SpoolAssemblyId,
                        principalTable: "SpoolAssemblies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpoolNavigators_SpoolWorkShopAssembly_SpoolWorkShopAssemblyId",
                        column: x => x.SpoolWorkShopAssemblyId,
                        principalTable: "SpoolWorkShopAssembly",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpoolNavigators_SpoolWorkShopWelding_SpoolWorkShopWeldingId",
                        column: x => x.SpoolWorkShopWeldingId,
                        principalTable: "SpoolWorkShopWelding",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpoolNavigators_Spools_SpoolId",
                        column: x => x.SpoolId,
                        principalTable: "Spools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName", "ReallyDeleted" },
                values: new object[,]
                {
                    { "1", "b6e988d4-fe11-4a49-b12a-c68d08519820", "Admin", "ADMIN", false },
                    { "2", "86a7fe02-8d6f-4dc8-81aa-4ef16c3b2544", "Manager", "MANAGER", false },
                    { "3", "3e463592-c373-4295-8d8b-84f4cfcd0171", "WorkShopManager", "WORKSHOPMANAGER", false },
                    { "4", "0d31271f-c49b-44f3-8cbf-1a8488dcb653", "WorkShopEmployee", "WORKSHOPEMPLOYEE", false },
                    { "5", "84779cec-0485-4e09-9b6a-d00e6eacb4e5", "TallyClerk", "TALLYCLERK", false },
                    { "6", "b062f90a-f3cc-4cfd-9b73-1c89e4015df6", "ChefEngineer", "CHEFENGINEERR", false },
                    { "7", "a1553b67-5ff0-46a9-950f-372045dcfdd0", "Engineer", "ENGINEER", false },
                    { "8", "26ebfcf8-8713-4567-8c56-7b73178319a6", "Stock", "STOCK", false },
                    { "9", "6cd5298e-e963-49f6-8cfd-d4890e8a48fd", "TrackingUser", "TRACKİNGUSER", false }
                });

            migrationBuilder.InsertData(
                table: "EmployeeWork",
                columns: new[] { "Id", "CreateTime", "CreateUser", "IsDelete", "IsWork", "LastBackUpId", "ModifiedTime", "ModifiedUserName", "ReallyDeleted", "WorkDetay", "WorkName" },
                values: new object[,]
                {
                    { 1u, new DateTime(2025, 7, 7, 10, 21, 23, 724, DateTimeKind.Local).AddTicks(7947), "System", false, true, null, new DateTime(2025, 7, 7, 10, 21, 23, 724, DateTimeKind.Local).AddTicks(7940), "System", false, "Atolyede ön imalat yapan usta", "İmalat Ustası" },
                    { 2u, new DateTime(2025, 7, 7, 10, 21, 23, 724, DateTimeKind.Local).AddTicks(7951), "System", false, true, null, new DateTime(2025, 7, 7, 10, 21, 23, 724, DateTimeKind.Local).AddTicks(7951), "System", false, "Atolyede ön imalat yapan ustanın yardımcısı", "İmalat Ustası Yardımcısı" },
                    { 3u, new DateTime(2025, 7, 7, 10, 21, 23, 724, DateTimeKind.Local).AddTicks(7954), "System", false, true, null, new DateTime(2025, 7, 7, 10, 21, 23, 724, DateTimeKind.Local).AddTicks(7953), "System", false, "Atolyede Kaynak yapan usta", "Kaynakçı " },
                    { 4u, new DateTime(2025, 7, 7, 10, 21, 23, 724, DateTimeKind.Local).AddTicks(7956), "System", false, true, null, new DateTime(2025, 7, 7, 10, 21, 23, 724, DateTimeKind.Local).AddTicks(7955), "System", false, "Gemiye Montaj yapan usta", "Montaj Ustası " }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

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
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CircutSystems_ProjectId",
                table: "CircutSystems",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeExits_EmployeeId",
                table: "EmployeeExits",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePoints_EmployeeId",
                table: "EmployeePoints",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProjects_EmployeeId",
                table: "EmployeeProjects",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProjects_EmployeeWorkId",
                table: "EmployeeProjects",
                column: "EmployeeWorkId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProjects_ManagerUserId",
                table: "EmployeeProjects",
                column: "ManagerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_BranchId",
                table: "Employees",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeWorkId",
                table: "Employees",
                column: "EmployeeWorkId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ShipYardId",
                table: "Employees",
                column: "ShipYardId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeUsers_BranchId",
                table: "EmployeeUsers",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeUsers_EmployeeId",
                table: "EmployeeUsers",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeUsers_EmployeeWorkId",
                table: "EmployeeUsers",
                column: "EmployeeWorkId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeUsers_UserId",
                table: "EmployeeUsers",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProjectManagerId",
                table: "Projects",
                column: "ProjectManagerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ShipYardId",
                table: "Projects",
                column: "ShipYardId");

            migrationBuilder.CreateIndex(
                name: "IX_ScoreCard_EmployeeId",
                table: "ScoreCard",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_SpoolAssemblies_AssemblyEmployeeId",
                table: "SpoolAssemblies",
                column: "AssemblyEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_SpoolAssemblies_SpoolId",
                table: "SpoolAssemblies",
                column: "SpoolId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SpoolNavigators_CircutSystemId",
                table: "SpoolNavigators",
                column: "CircutSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_SpoolNavigators_ProjectId",
                table: "SpoolNavigators",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_SpoolNavigators_SpoolAssemblyId",
                table: "SpoolNavigators",
                column: "SpoolAssemblyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SpoolNavigators_SpoolId",
                table: "SpoolNavigators",
                column: "SpoolId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SpoolNavigators_SpoolWorkShopAssemblyId",
                table: "SpoolNavigators",
                column: "SpoolWorkShopAssemblyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SpoolNavigators_SpoolWorkShopWeldingId",
                table: "SpoolNavigators",
                column: "SpoolWorkShopWeldingId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Spools_CircutSystemId",
                table: "Spools",
                column: "CircutSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_SpoolWorkShopAssembly_AssemblyEmployeeId",
                table: "SpoolWorkShopAssembly",
                column: "AssemblyEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_SpoolWorkShopAssembly_SpoolId",
                table: "SpoolWorkShopAssembly",
                column: "SpoolId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SpoolWorkShopWelding_SpoolId",
                table: "SpoolWorkShopWelding",
                column: "SpoolId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SpoolWorkShopWelding_WeldingEmployeeId",
                table: "SpoolWorkShopWelding",
                column: "WeldingEmployeeId");
        }

        /// <inheritdoc />
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
                name: "EmployeeExits");

            migrationBuilder.DropTable(
                name: "EmployeePoints");

            migrationBuilder.DropTable(
                name: "EmployeeProjects");

            migrationBuilder.DropTable(
                name: "OtomaticSystemCodes");

            migrationBuilder.DropTable(
                name: "ScoreCard");

            migrationBuilder.DropTable(
                name: "SpoolNavigators");

            migrationBuilder.DropTable(
                name: "Stock");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "SpoolAssemblies");

            migrationBuilder.DropTable(
                name: "SpoolWorkShopAssembly");

            migrationBuilder.DropTable(
                name: "SpoolWorkShopWelding");

            migrationBuilder.DropTable(
                name: "Spools");

            migrationBuilder.DropTable(
                name: "CircutSystems");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "EmployeeUsers");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "EmployeeWork");

            migrationBuilder.DropTable(
                name: "ShipYards");
        }
    }
}
