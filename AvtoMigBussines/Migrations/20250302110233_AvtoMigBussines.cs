using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AvtoMigBussines.Migrations
{
    public partial class AvtoMigBussines : Migration
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
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientOrganizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    OrganizationId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DateOfCreated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientOrganizations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TelegramUserId = table.Column<long>(type: "bigint", nullable: false),
                    CarNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizationId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DateOfRegister = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ForgotPasswordCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<double>(type: "float", maxLength: 4, nullable: true),
                    DateOfCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateOfEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForgotPasswordCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NotifiactionTokens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    AspNetUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrganizationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotifiactionTokens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NotificationCenters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AspNetUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrganizationId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DateOfCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActionId = table.Column<int>(type: "int", nullable: true),
                    ActionType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationCenters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeOfOrganizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfOrganizations", x => x.Id);
                });

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
                name: "ModelCars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    CarId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelCars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModelCars_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateOfCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Password = table.Column<double>(type: "float", nullable: false),
                    TypeOfOrganizationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Organizations_TypeOfOrganizations_TypeOfOrganizationId",
                        column: x => x.TypeOfOrganizationId,
                        principalTable: "TypeOfOrganizations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrganizationId = table.Column<int>(type: "int", nullable: true),
                    IndividualNumber = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizationId = table.Column<int>(type: "int", nullable: true),
                    DateOfCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateOfStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateOfEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    IsReturn = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subscriptions_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id");
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

            migrationBuilder.CreateTable(
                name: "DetailingOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AspNetUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    OrganizationId = table.Column<int>(type: "int", nullable: true),
                    EndOfOrderAspNetUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prepayment = table.Column<double>(type: "float", nullable: true),
                    DateOfCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CarId = table.Column<int>(type: "int", nullable: true),
                    ModelCarId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    IsReturn = table.Column<bool>(type: "bit", nullable: true),
                    IsOvered = table.Column<bool>(type: "bit", nullable: true),
                    DateOfCompleteService = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsReady = table.Column<bool>(type: "bit", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailingOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetailingOrders_AspNetUsers_AspNetUserId",
                        column: x => x.AspNetUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DetailingOrders_AspNetUsers_EndOfOrderAspNetUserId",
                        column: x => x.EndOfOrderAspNetUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DetailingOrders_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DetailingOrders_ModelCars_ModelCarId",
                        column: x => x.ModelCarId,
                        principalTable: "ModelCars",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DetailingOrders_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    OrganizationId = table.Column<int>(type: "int", nullable: true),
                    AspNetUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Services_AspNetUsers_AspNetUserId",
                        column: x => x.AspNetUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Services_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WashOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AspNetUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    OrganizationId = table.Column<int>(type: "int", nullable: true),
                    EndOfOrderAspNetUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DateOfCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CarId = table.Column<int>(type: "int", nullable: true),
                    ModelCarId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    IsReturn = table.Column<bool>(type: "bit", nullable: true),
                    IsOvered = table.Column<bool>(type: "bit", nullable: true),
                    DateOfCompleteService = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsReady = table.Column<bool>(type: "bit", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WashOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WashOrders_AspNetUsers_AspNetUserId",
                        column: x => x.AspNetUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WashOrders_AspNetUsers_EndOfOrderAspNetUserId",
                        column: x => x.EndOfOrderAspNetUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WashOrders_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WashOrders_ModelCars_ModelCarId",
                        column: x => x.ModelCarId,
                        principalTable: "ModelCars",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WashOrders_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DetailingOrderTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentMethodId = table.Column<int>(type: "int", nullable: true),
                    AspNetUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DateOfCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Summ = table.Column<double>(type: "float", nullable: true),
                    ToPay = table.Column<double>(type: "float", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    OrganizationId = table.Column<int>(type: "int", nullable: true),
                    DetailingOrderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailingOrderTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetailingOrderTransactions_AspNetUsers_AspNetUserId",
                        column: x => x.AspNetUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DetailingOrderTransactions_DetailingOrders_DetailingOrderId",
                        column: x => x.DetailingOrderId,
                        principalTable: "DetailingOrders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DetailingOrderTransactions_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DetailingOrderTransactions_PaymentMethods_PaymentMethodId",
                        column: x => x.PaymentMethodId,
                        principalTable: "PaymentMethods",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DetailingPriceLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: true),
                    ModelCarId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    AspNetUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    OrganizationId = table.Column<int>(type: "int", nullable: true),
                    ServiceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailingPriceLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetailingPriceLists_AspNetUsers_AspNetUserId",
                        column: x => x.AspNetUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DetailingPriceLists_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DetailingPriceLists_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DetailingServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<double>(type: "float", nullable: true),
                    ServiceId = table.Column<int>(type: "int", nullable: true),
                    AspNetUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DateOfCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    IsOvered = table.Column<bool>(type: "bit", nullable: true),
                    DetailingOrderId = table.Column<int>(type: "int", nullable: true),
                    OrganizationId = table.Column<int>(type: "int", nullable: true),
                    WhomAspNetUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<double>(type: "float", nullable: true),
                    DateOfCompleteService = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailingServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetailingServices_AspNetUsers_AspNetUserId",
                        column: x => x.AspNetUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DetailingServices_DetailingOrders_DetailingOrderId",
                        column: x => x.DetailingOrderId,
                        principalTable: "DetailingOrders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DetailingServices_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DetailingServices_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SalarySettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceId = table.Column<int>(type: "int", nullable: true),
                    Salary = table.Column<double>(type: "float", nullable: true),
                    AspNetUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DateOfCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OrganizationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalarySettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalarySettings_AspNetUsers_AspNetUserId",
                        column: x => x.AspNetUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SalarySettings_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SalarySettings_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WashOrderTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentMethodId = table.Column<int>(type: "int", nullable: true),
                    AspNetUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DateOfCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Summ = table.Column<double>(type: "float", nullable: true),
                    ToPay = table.Column<double>(type: "float", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    OrganizationId = table.Column<int>(type: "int", nullable: true),
                    WashOrderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WashOrderTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WashOrderTransactions_AspNetUsers_AspNetUserId",
                        column: x => x.AspNetUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WashOrderTransactions_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WashOrderTransactions_PaymentMethods_PaymentMethodId",
                        column: x => x.PaymentMethodId,
                        principalTable: "PaymentMethods",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WashOrderTransactions_WashOrders_WashOrderId",
                        column: x => x.WashOrderId,
                        principalTable: "WashOrders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WashServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<double>(type: "float", nullable: true),
                    ServiceId = table.Column<int>(type: "int", nullable: true),
                    AspNetUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAspNetUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    WhomAspNetUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DateOfCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    IsOvered = table.Column<bool>(type: "bit", nullable: true),
                    WashOrderId = table.Column<int>(type: "int", nullable: true),
                    OrganizationId = table.Column<int>(type: "int", nullable: true),
                    Salary = table.Column<double>(type: "float", nullable: true),
                    DateOfCompleteService = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WashServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WashServices_AspNetUsers_AspNetUserId",
                        column: x => x.AspNetUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WashServices_AspNetUsers_CreatedAspNetUserId",
                        column: x => x.CreatedAspNetUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WashServices_AspNetUsers_WhomAspNetUserId",
                        column: x => x.WhomAspNetUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WashServices_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WashServices_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WashServices_WashOrders_WashOrderId",
                        column: x => x.WashOrderId,
                        principalTable: "WashOrders",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5ca727a1-be5c-48bf-84b9-3a7c8e9b02ca", "52f92fcd-1e1f-4f15-916f-707ab0c26f94", "Менеджер", "МЕНЕДЖЕР" },
                    { "7fde158f-22b2-4831-8f5e-05d8a9f4c5c8", "2fadea65-5249-4695-8c0d-c18df2e80300", "Мастер", "МАСТЕР" },
                    { "bf1bde28-1261-44dc-b067-e3d521c8f4aa", "ce454d31-7462-4416-b1c2-fa3f90c4a1f2", "Директор", "Директор" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, false, "Acura" },
                    { 2, false, "AITO" },
                    { 3, false, "Alfa Romeo" },
                    { 4, false, "Alga" },
                    { 5, false, "Alpina" },
                    { 6, false, "Arcfox" },
                    { 7, false, "Aro" },
                    { 8, false, "Aston Martin" },
                    { 9, false, "Audi" },
                    { 10, false, "Aurus" },
                    { 11, false, "Avatr" },
                    { 12, false, "BAIC" },
                    { 13, false, "Bajaj" },
                    { 14, false, "Baojun" },
                    { 15, false, "BAW" },
                    { 16, false, "Bentley" },
                    { 17, false, "Blaval" },
                    { 18, false, "BMW" },
                    { 19, false, "Borgward" },
                    { 20, false, "Brilliance" },
                    { 21, false, "Bugatii" },
                    { 22, false, "Buick" },
                    { 23, false, "BYD" },
                    { 24, false, "Cadillac" },
                    { 25, false, "Changan" },
                    { 26, false, "ChangFeng" },
                    { 27, false, "Changhe" },
                    { 28, false, "Chery" },
                    { 29, false, "Chevrolet" },
                    { 30, false, "Chrysler" },
                    { 31, false, "Citroen" },
                    { 32, false, "Core Power" },
                    { 33, false, "Cupra" },
                    { 34, false, "Dacia" },
                    { 35, false, "Dadi" },
                    { 36, false, "Daewoo" },
                    { 37, false, "Daihatsu" },
                    { 38, false, "Datsun" },
                    { 39, false, "Dayun" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 40, false, "Deepal" },
                    { 41, false, "Denza" },
                    { 42, false, "Derways" }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, false, "Наличный" },
                    { 2, false, "Безналичный" },
                    { 3, false, "Смешанная оплата" }
                });

            migrationBuilder.InsertData(
                table: "TypeOfOrganizations",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, false, "Detailing" },
                    { 2, false, "Car wash" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, 1, false, "CL" },
                    { 2, 1, false, "CSX" },
                    { 3, 1, false, "EL" },
                    { 4, 1, false, "ILX" },
                    { 5, 1, false, "Integra" },
                    { 6, 1, false, "Legend" },
                    { 7, 1, false, "MDX" },
                    { 8, 1, false, "NSX" },
                    { 9, 1, false, "RDX" },
                    { 10, 1, false, "RL" },
                    { 11, 1, false, "RLX" },
                    { 12, 1, false, "RSX" },
                    { 13, 1, false, "SLX" },
                    { 14, 1, false, "TL" },
                    { 15, 1, false, "TLX" },
                    { 16, 1, false, "TSX" },
                    { 17, 1, false, "ZDX" },
                    { 18, 2, false, "M5" },
                    { 19, 2, false, "M5 EV" },
                    { 20, 2, false, "M7" },
                    { 21, 2, false, "M9" },
                    { 22, 3, false, "145" },
                    { 23, 3, false, "146" },
                    { 24, 3, false, "147" },
                    { 25, 3, false, "155" },
                    { 26, 3, false, "156" },
                    { 27, 3, false, "159" },
                    { 28, 3, false, "164" },
                    { 29, 3, false, "166" },
                    { 30, 3, false, "33" },
                    { 31, 3, false, "4C" },
                    { 32, 3, false, "75" },
                    { 33, 3, false, "8C Competizione" },
                    { 34, 3, false, "Brera" },
                    { 35, 3, false, "Guilia" },
                    { 36, 3, false, "Guilietta" },
                    { 37, 3, false, "GT" },
                    { 38, 3, false, "GTV" },
                    { 39, 3, false, "MiTo" },
                    { 40, 3, false, "Spider" },
                    { 41, 3, false, "Stelvio" },
                    { 42, 4, false, "SM41" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 43, 4, false, "SM42" },
                    { 44, 4, false, "SM43" },
                    { 45, 5, false, "B10" },
                    { 46, 5, false, "B11" },
                    { 47, 5, false, "B12" },
                    { 48, 5, false, "B3" },
                    { 49, 5, false, "B4" },
                    { 50, 5, false, "B5" },
                    { 51, 5, false, "B6" },
                    { 52, 5, false, "B7" },
                    { 53, 5, false, "B8" },
                    { 54, 5, false, "D10" },
                    { 55, 5, false, "D3" },
                    { 56, 5, false, "D5" },
                    { 57, 5, false, "Roadster S" },
                    { 58, 5, false, "Roadster V8" },
                    { 59, 5, false, "XD3" },
                    { 60, 6, false, "Alpha S" },
                    { 61, 6, false, "Alpha TL" },
                    { 62, 7, false, "24" },
                    { 63, 8, false, "Cygnet" },
                    { 64, 8, false, "DB11" },
                    { 65, 8, false, "DB12" },
                    { 66, 8, false, "DB7" },
                    { 67, 8, false, "DB9" },
                    { 68, 8, false, "DBS" },
                    { 69, 8, false, "DBX" },
                    { 70, 8, false, "Lagonda" },
                    { 71, 8, false, "One-77" },
                    { 72, 8, false, "Rapide" },
                    { 73, 8, false, "V12 Speedster" },
                    { 74, 8, false, "V12 Zagato" },
                    { 75, 8, false, "Vanquish" },
                    { 76, 8, false, "Vantage" },
                    { 77, 8, false, "Virage" },
                    { 78, 9, false, "100" },
                    { 79, 9, false, "200" },
                    { 80, 9, false, "80" },
                    { 81, 9, false, "90" },
                    { 82, 9, false, "A1" },
                    { 83, 9, false, "A2" },
                    { 84, 9, false, "A3" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 85, 9, false, "A4" },
                    { 86, 9, false, "A4 allroad" },
                    { 87, 9, false, "A5" },
                    { 88, 9, false, "A6" },
                    { 89, 9, false, "A6 allroad" },
                    { 90, 9, false, "A7" },
                    { 91, 9, false, "A8" },
                    { 92, 9, false, "Cabriolet" },
                    { 93, 9, false, "Coupe" },
                    { 94, 9, false, "e-tron" },
                    { 95, 9, false, "e-tron GT" },
                    { 96, 9, false, "e-tron Sportback" },
                    { 97, 9, false, "Q2 e-tron" },
                    { 98, 9, false, "Q3" },
                    { 99, 9, false, "Q4 e-tron" },
                    { 100, 9, false, "Q5" },
                    { 101, 9, false, "Q5 e-tron" },
                    { 102, 9, false, "Q5 Sportback" },
                    { 103, 9, false, "Q6" },
                    { 104, 9, false, "Q7" },
                    { 105, 9, false, "Q8" },
                    { 106, 9, false, "Q8 e-tron" },
                    { 107, 9, false, "Quattro" },
                    { 108, 9, false, "R8" },
                    { 109, 9, false, "RS" },
                    { 110, 9, false, "RS 2" },
                    { 111, 9, false, "RS 3" },
                    { 112, 9, false, "RS 4" },
                    { 113, 9, false, "RS 5" },
                    { 114, 9, false, "RS 6" },
                    { 115, 9, false, "RS 7" },
                    { 116, 9, false, "RS Q3" },
                    { 117, 9, false, "RS Q3 Sportback" },
                    { 118, 9, false, "RS Q8" },
                    { 119, 9, false, "S1" },
                    { 120, 9, false, "S2" },
                    { 121, 9, false, "S3" },
                    { 122, 9, false, "S4" },
                    { 123, 9, false, "S5" },
                    { 124, 9, false, "S6" },
                    { 125, 9, false, "S7" },
                    { 126, 9, false, "S8" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 127, 9, false, "SQ2" },
                    { 128, 9, false, "SQ5" },
                    { 129, 9, false, "SQ7" },
                    { 130, 9, false, "SQ8" },
                    { 131, 9, false, "TT" },
                    { 132, 9, false, "V8" },
                    { 133, 10, false, "Senat" },
                    { 134, 11, false, "06" },
                    { 135, 11, false, "07" },
                    { 136, 11, false, "11" },
                    { 137, 11, false, "12" },
                    { 138, 12, false, "Beijing X7" },
                    { 139, 12, false, "BJ2022 Brave" },
                    { 140, 12, false, "Warrior" },
                    { 141, 12, false, "BJ30" },
                    { 142, 12, false, "BJ40" },
                    { 143, 12, false, "BJ60" },
                    { 144, 12, false, "BJ80" },
                    { 145, 12, false, "BJ90" },
                    { 146, 12, false, "D50" },
                    { 147, 12, false, "D70" },
                    { 148, 12, false, "EC3" },
                    { 149, 12, false, "EU5" },
                    { 150, 12, false, "Huansu H2" },
                    { 151, 12, false, "Huansu S3L" },
                    { 152, 12, false, "Q7" },
                    { 153, 12, false, "Rubics Cube" },
                    { 154, 12, false, "Senova D20" },
                    { 155, 12, false, "U5 Plus" },
                    { 156, 12, false, "X55" },
                    { 157, 13, false, "Qute" },
                    { 158, 14, false, "Kiwi EV" },
                    { 159, 14, false, "Yep" },
                    { 160, 14, false, "Yunduo Cloud" },
                    { 161, 15, false, "212 T01" },
                    { 162, 15, false, "F7" },
                    { 163, 15, false, "Luba" },
                    { 164, 15, false, "M7" },
                    { 165, 15, false, "Yueling" },
                    { 166, 15, false, "Yusheng" },
                    { 167, 16, false, "Arnage" },
                    { 168, 16, false, "Azure" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 169, 16, false, "Bentayga" },
                    { 170, 16, false, "Brooklands" },
                    { 171, 16, false, "Continental" },
                    { 172, 16, false, "Continental Flying" },
                    { 173, 16, false, "Spur" },
                    { 174, 16, false, "Continental GT" },
                    { 175, 16, false, "Eight" },
                    { 176, 16, false, "Flying Spur" },
                    { 177, 16, false, "Mulsanne" },
                    { 178, 16, false, "T-series" },
                    { 179, 16, false, "Turbo R" },
                    { 180, 17, false, "FH-M8" },
                    { 181, 18, false, "114" },
                    { 182, 18, false, "116" },
                    { 183, 18, false, "118" },
                    { 184, 18, false, "120" },
                    { 185, 18, false, "125" },
                    { 186, 18, false, "128" },
                    { 187, 18, false, "130" },
                    { 188, 18, false, "135" },
                    { 189, 18, false, "140" },
                    { 190, 18, false, "2-Series Active Tourer" },
                    { 191, 18, false, "218" },
                    { 192, 18, false, "220" },
                    { 193, 18, false, "225" },
                    { 194, 18, false, "228" },
                    { 195, 18, false, "230" },
                    { 196, 18, false, "M235" },
                    { 197, 18, false, "M240" },
                    { 198, 18, false, "315" },
                    { 199, 18, false, "316" },
                    { 200, 18, false, "318" },
                    { 201, 18, false, "320" },
                    { 202, 18, false, "323" },
                    { 203, 18, false, "324d" },
                    { 204, 18, false, "325" },
                    { 205, 18, false, "328" },
                    { 206, 18, false, "330" },
                    { 207, 18, false, "335" },
                    { 208, 18, false, "340" },
                    { 209, 18, false, "3 Gran Turismo" },
                    { 210, 18, false, "418" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 211, 18, false, "420" },
                    { 212, 18, false, "425" },
                    { 213, 18, false, "428" },
                    { 214, 18, false, "430" },
                    { 215, 18, false, "435" },
                    { 216, 18, false, "440" },
                    { 217, 18, false, "518" },
                    { 218, 18, false, "520" },
                    { 219, 18, false, "523" },
                    { 220, 18, false, "524" },
                    { 221, 18, false, "525" },
                    { 222, 18, false, "528" },
                    { 223, 18, false, "530" },
                    { 224, 18, false, "535" },
                    { 225, 18, false, "540" },
                    { 226, 18, false, "545" },
                    { 227, 18, false, "550" },
                    { 228, 18, false, "5 Grand Turismo" },
                    { 229, 18, false, "628" },
                    { 230, 18, false, "630" },
                    { 231, 18, false, "633" },
                    { 232, 18, false, "635" },
                    { 233, 18, false, "640" },
                    { 234, 18, false, "645" },
                    { 235, 18, false, "650" },
                    { 236, 18, false, "725" },
                    { 237, 18, false, "728" },
                    { 238, 18, false, "730" },
                    { 239, 18, false, "732" },
                    { 240, 18, false, "735" },
                    { 241, 18, false, "740" },
                    { 242, 18, false, "745" },
                    { 243, 18, false, "750" },
                    { 244, 18, false, "760" },
                    { 245, 18, false, "M760" },
                    { 246, 18, false, "840" },
                    { 247, 18, false, "850" },
                    { 248, 18, false, "i3" },
                    { 249, 18, false, "i4" },
                    { 250, 18, false, "i5" },
                    { 251, 18, false, "i7" },
                    { 252, 18, false, "i8" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 253, 18, false, "iX" },
                    { 254, 18, false, "iX1" },
                    { 255, 18, false, "iX3" },
                    { 256, 18, false, "M2" },
                    { 257, 18, false, "M3" },
                    { 258, 18, false, "M4" },
                    { 259, 18, false, "M5" },
                    { 260, 18, false, "M6" },
                    { 261, 18, false, "M8" },
                    { 262, 18, false, "X1" },
                    { 263, 18, false, "X2" },
                    { 264, 18, false, "X3" },
                    { 265, 18, false, "X3 M" },
                    { 266, 18, false, "X4" },
                    { 267, 18, false, "X4 M" },
                    { 268, 18, false, "X5" },
                    { 269, 18, false, "X5 M" },
                    { 270, 18, false, "X6" },
                    { 271, 18, false, "X6 M" },
                    { 272, 18, false, "X7" },
                    { 273, 18, false, "X7" },
                    { 274, 18, false, "XM" },
                    { 275, 18, false, "Z1" },
                    { 276, 18, false, "Z3" },
                    { 277, 18, false, "Z3 M" },
                    { 278, 18, false, "Z4" },
                    { 279, 18, false, "Z4 M" },
                    { 280, 18, false, "Z8" },
                    { 281, 19, false, "BX5" },
                    { 282, 19, false, "BX7" },
                    { 283, 20, false, "BS2" },
                    { 284, 20, false, "BS4" },
                    { 285, 20, false, "BS6" },
                    { 286, 20, false, "FRV (BS2)" },
                    { 287, 20, false, "H230" },
                    { 288, 20, false, "H530" },
                    { 289, 20, false, "M1" },
                    { 290, 20, false, "M2" },
                    { 291, 20, false, "M3" },
                    { 292, 20, false, "V3" },
                    { 293, 20, false, "V5" },
                    { 294, 21, false, "Chiron" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 295, 21, false, "EB 110" },
                    { 296, 21, false, "EB 112" },
                    { 297, 21, false, "Veyron" },
                    { 298, 22, false, "Century" },
                    { 299, 22, false, "Electra" },
                    { 300, 22, false, "Enclave" },
                    { 301, 22, false, "Encore" },
                    { 302, 22, false, "Excelle" },
                    { 303, 22, false, "GL8" },
                    { 304, 22, false, "LaCrosse" },
                    { 305, 22, false, "LE Sabre" },
                    { 306, 22, false, "Lucerne" },
                    { 307, 22, false, "Park Avenue" },
                    { 308, 22, false, "Rainier" },
                    { 309, 22, false, "Reatta" },
                    { 310, 22, false, "Regal" },
                    { 311, 22, false, "Rendezvous" },
                    { 312, 22, false, "Riviera" },
                    { 313, 22, false, "Roadmaster" },
                    { 314, 22, false, "Skylark" },
                    { 315, 22, false, "Terraza" },
                    { 316, 22, false, "Velite 7" },
                    { 317, 22, false, "Verano" },
                    { 318, 23, false, "D1" },
                    { 319, 23, false, "Destroyer 05" },
                    { 320, 23, false, "Dolphin" },
                    { 321, 23, false, "E1" },
                    { 322, 23, false, "E2" },
                    { 323, 23, false, "E5" },
                    { 324, 23, false, "E6" },
                    { 325, 23, false, "F0" },
                    { 326, 23, false, "F3" },
                    { 327, 23, false, "F3-R" },
                    { 328, 23, false, "F5" },
                    { 329, 23, false, "F6" },
                    { 330, 23, false, "F7" },
                    { 331, 23, false, "F8" },
                    { 332, 23, false, "FangChengBao" },
                    { 333, 23, false, "Leopard 8" },
                    { 334, 23, false, "Flyer" },
                    { 335, 23, false, "G3" },
                    { 336, 23, false, "G6" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 337, 23, false, "Han" },
                    { 338, 23, false, "L3" },
                    { 339, 23, false, "Leopard 5" },
                    { 340, 23, false, "M6" },
                    { 341, 23, false, "Qin" },
                    { 342, 23, false, "Qin L DM-i" },
                    { 343, 23, false, "Qin Plus" },
                    { 344, 23, false, "S6" },
                    { 345, 23, false, "Sea Lion 05" },
                    { 346, 23, false, "Sea Lion 07" },
                    { 347, 23, false, "Seagull" },
                    { 348, 23, false, "Seal" },
                    { 349, 23, false, "Seal 06" },
                    { 350, 23, false, "Song" },
                    { 351, 23, false, "Song L" },
                    { 352, 23, false, "Song L DM-i" },
                    { 353, 23, false, "Song Plus" },
                    { 354, 23, false, "Song Plus Champion" },
                    { 355, 23, false, "Song Plus Honor" },
                    { 356, 23, false, "Song Pro" },
                    { 357, 23, false, "Tang" },
                    { 358, 23, false, "Yangwang U7" },
                    { 359, 23, false, "Yangwang U8" },
                    { 360, 23, false, "Yangwang U9" },
                    { 361, 23, false, "Yuan" },
                    { 362, 23, false, "Yuan Plus" },
                    { 363, 23, false, "Yuan Up" },
                    { 364, 24, false, "Allante" },
                    { 365, 24, false, "ATS" },
                    { 366, 24, false, "BLS" },
                    { 367, 24, false, "Brougham" },
                    { 368, 24, false, "Catera" },
                    { 369, 24, false, "CT4" },
                    { 370, 24, false, "CT5" },
                    { 371, 24, false, "CT6" },
                    { 372, 24, false, "CTS" },
                    { 373, 24, false, "De Ville" },
                    { 374, 24, false, "DTS" },
                    { 375, 24, false, "Eldorado" },
                    { 376, 24, false, "ELR" },
                    { 377, 24, false, "Escalade" },
                    { 378, 24, false, "Escalade IQ" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 379, 24, false, "Fleetwood" },
                    { 380, 24, false, "Lyriq" },
                    { 381, 24, false, "Optiq" },
                    { 382, 24, false, "Seville" },
                    { 383, 24, false, "SRX" },
                    { 384, 24, false, "STS" },
                    { 385, 24, false, "XLR" },
                    { 386, 24, false, "XT4" },
                    { 387, 24, false, "XT5" },
                    { 388, 24, false, "XT6" },
                    { 389, 24, false, "XTS" },
                    { 390, 25, false, "Alsvin" },
                    { 391, 25, false, "Auchan A600 EV" },
                    { 392, 25, false, "Benben E-Star" },
                    { 393, 25, false, "Benben EV" },
                    { 394, 25, false, "BenBen Mini" },
                    { 395, 25, false, "Benni" },
                    { 396, 25, false, "Chana SC6350C" },
                    { 397, 25, false, "CM8" },
                    { 398, 25, false, "Cross Star" },
                    { 399, 25, false, "CS15 EV" },
                    { 400, 25, false, "CS35" },
                    { 401, 25, false, "CS35 Plus" },
                    { 402, 25, false, "CS55" },
                    { 403, 25, false, "CS55 Plus" },
                    { 404, 25, false, "CS75" },
                    { 405, 25, false, "CS75 Plus" },
                    { 406, 25, false, "CS85" },
                    { 407, 25, false, "CS95" },
                    { 408, 25, false, "CS95 Plus" },
                    { 409, 25, false, "CX20" },
                    { 410, 25, false, "Eado" },
                    { 411, 25, false, "Eado Plus" },
                    { 412, 25, false, "Explorer" },
                    { 413, 25, false, "Hunter" },
                    { 414, 25, false, "Hunter Plus" },
                    { 415, 25, false, "Kaicence F70" },
                    { 416, 25, false, "Kaicence Ruixing M60" },
                    { 417, 25, false, "Kaicheng Uno S" },
                    { 418, 25, false, "Lamore" },
                    { 419, 25, false, "Lantop" },
                    { 420, 25, false, "Lumin" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 421, 25, false, "Oshan X5" },
                    { 422, 25, false, "Oshan Z6" },
                    { 423, 25, false, "Qiyuan A05" },
                    { 424, 25, false, "Qiyuan A06" },
                    { 425, 25, false, "Qiyuan A07" },
                    { 426, 25, false, "Qiyuan Q05" },
                    { 427, 25, false, "Raeton" },
                    { 428, 25, false, "UNI-K" },
                    { 429, 25, false, "UNI-T" },
                    { 430, 25, false, "UNI-V" },
                    { 431, 25, false, "UNI-Z" },
                    { 432, 25, false, "X5 Plus" },
                    { 433, 25, false, "X7 Plus" },
                    { 434, 25, false, "Yida" },
                    { 435, 26, false, "Flying" },
                    { 436, 26, false, "SUV" },
                    { 437, 27, false, "Q7" },
                    { 438, 28, false, "A3" },
                    { 439, 28, false, "Amulet" },
                    { 440, 28, false, "Amulet (A15)" },
                    { 441, 28, false, "Arrizo 5" },
                    { 442, 28, false, "Arrizo 7" },
                    { 443, 28, false, "Arrizo 8" },
                    { 444, 28, false, "Bonus" },
                    { 445, 28, false, "CheryExeed TXL" },
                    { 446, 28, false, "Cowin" },
                    { 447, 28, false, "CrossEastar" },
                    { 448, 28, false, "Eastar" },
                    { 449, 28, false, "eQ5" },
                    { 450, 28, false, "Explore 06" },
                    { 451, 28, false, "Fora" },
                    { 452, 28, false, "Fulwin T9" },
                    { 453, 28, false, "IndiS" },
                    { 454, 28, false, "J11" },
                    { 455, 28, false, "Karry" },
                    { 456, 28, false, "Kimo (A1)" },
                    { 457, 28, false, "M11" },
                    { 458, 28, false, "Omoda 5" },
                    { 459, 28, false, "Oriental Son" },
                    { 460, 28, false, "QQ" },
                    { 461, 28, false, "QQ6 (S21)" },
                    { 462, 28, false, "Sweet (QQ)" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 463, 28, false, "Tiggo" },
                    { 464, 28, false, "Tiggo 2" },
                    { 465, 28, false, "Tiggo 2 Pro" },
                    { 466, 28, false, "Tiggo 3" },
                    { 467, 28, false, "Tiggo 3x" },
                    { 468, 28, false, "Tiggo 4" },
                    { 469, 28, false, "Tiggo 4 Pro" },
                    { 470, 28, false, "Tiggo 5" },
                    { 471, 28, false, "Tiggo 7" },
                    { 472, 28, false, "Tiggo 7 Pro" },
                    { 473, 28, false, "Tiggo 7 Pro Max" },
                    { 474, 28, false, "Tiggo 8" },
                    { 475, 28, false, "Tiggo 8 Pro" },
                    { 476, 28, false, "Tiggo Pro Max" },
                    { 477, 28, false, "Tiggo 9" },
                    { 478, 28, false, "TJ-1" },
                    { 479, 28, false, "Very" },
                    { 480, 29, false, "Alero" },
                    { 481, 29, false, "Astro" },
                    { 482, 29, false, "Avalanche" },
                    { 483, 29, false, "Aveo" },
                    { 484, 29, false, "Beretta" },
                    { 485, 29, false, "Blazer" },
                    { 486, 29, false, "Bolt" },
                    { 487, 29, false, "Camaro" },
                    { 488, 29, false, "Caprice" },
                    { 489, 29, false, "Captiva" },
                    { 490, 29, false, "Cavalier" },
                    { 491, 29, false, "Celta" },
                    { 492, 29, false, "Chevy Van" },
                    { 493, 29, false, "Classic" },
                    { 494, 29, false, "Cobalt" },
                    { 495, 29, false, "Colorado" },
                    { 496, 29, false, "Corsica" },
                    { 497, 29, false, "Corvette" },
                    { 498, 29, false, "Cruze" },
                    { 499, 29, false, "Damas" },
                    { 500, 29, false, "Epica" },
                    { 501, 29, false, "Equinox" },
                    { 502, 29, false, "Evanda" },
                    { 503, 29, false, "Express" },
                    { 504, 29, false, "Groove" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 505, 29, false, "HHR" },
                    { 506, 29, false, "Impala" },
                    { 507, 29, false, "K30" },
                    { 508, 29, false, "Kalos" },
                    { 509, 29, false, "Lacetti" },
                    { 510, 29, false, "Lanos" },
                    { 511, 29, false, "Lumina" },
                    { 512, 29, false, "Lumina APV" },
                    { 513, 29, false, "Lumina SS" },
                    { 514, 29, false, "LUV D-MAX" },
                    { 515, 29, false, "Malibu" },
                    { 516, 29, false, "Matiz" },
                    { 517, 29, false, "Menlo" },
                    { 518, 29, false, "Metro" },
                    { 519, 29, false, "Monte Carlo" },
                    { 520, 29, false, "Monza" },
                    { 521, 29, false, "MW" },
                    { 522, 29, false, "Nexia" },
                    { 523, 29, false, "Niva" },
                    { 524, 29, false, "Nubira" },
                    { 525, 29, false, "Onix" },
                    { 526, 29, false, "Orlando" },
                    { 527, 29, false, "Prizm" },
                    { 528, 29, false, "Rezzo" },
                    { 529, 29, false, "S-10" },
                    { 530, 29, false, "Sail" },
                    { 531, 29, false, "Seeker" },
                    { 532, 29, false, "Silverado" },
                    { 533, 29, false, "Sonic" },
                    { 534, 29, false, "Spark" },
                    { 535, 29, false, "Spin" },
                    { 536, 29, false, "SS" },
                    { 537, 29, false, "SSR" },
                    { 538, 29, false, "Suburban" },
                    { 539, 29, false, "Tacuma" },
                    { 540, 29, false, "Tahoe" },
                    { 541, 29, false, "Tavera" },
                    { 542, 29, false, "Tracker" },
                    { 543, 29, false, "TrailBlazer" },
                    { 544, 29, false, "Trans Sport" },
                    { 545, 29, false, "Traverse" },
                    { 546, 29, false, "Trax" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 547, 29, false, "Uplander" },
                    { 548, 29, false, "Van" },
                    { 549, 29, false, "Venture" },
                    { 550, 29, false, "Viva" },
                    { 551, 29, false, "Volt" },
                    { 552, 30, false, "200" },
                    { 553, 30, false, "300C" },
                    { 554, 30, false, "300M" },
                    { 555, 30, false, "Aspen" },
                    { 556, 30, false, "Cirrus" },
                    { 557, 30, false, "Concorde" },
                    { 558, 30, false, "Crossfire" },
                    { 559, 30, false, "Daytona" },
                    { 560, 30, false, "Fifth Avenue" },
                    { 561, 30, false, "Intrepid" },
                    { 562, 30, false, "LeBaron" },
                    { 563, 30, false, "LHS" },
                    { 564, 30, false, "Neon" },
                    { 565, 30, false, "New Yorker" },
                    { 566, 30, false, "Pacifica" },
                    { 567, 30, false, "Prowler" },
                    { 568, 30, false, "PT Cruiser" },
                    { 569, 30, false, "Saratoga" },
                    { 570, 30, false, "Sebring" },
                    { 571, 30, false, "Stratus" },
                    { 572, 30, false, "Town and Country" },
                    { 573, 30, false, "Viper" },
                    { 574, 30, false, "Vision" },
                    { 575, 30, false, "Voyager" },
                    { 576, 31, false, "2 CV" },
                    { 577, 31, false, "AMI" },
                    { 578, 31, false, "AX" },
                    { 579, 31, false, "Berlingo" },
                    { 580, 31, false, "BX" },
                    { 581, 31, false, "C-Crosser" },
                    { 582, 31, false, "C-Elysee" },
                    { 583, 31, false, "C1" },
                    { 584, 31, false, "C15" },
                    { 585, 31, false, "C2" },
                    { 586, 31, false, "C3" },
                    { 587, 31, false, "C3 Aircross" },
                    { 588, 31, false, "C3 Picasso" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 589, 31, false, "C4" },
                    { 590, 31, false, "C4 Aircross" },
                    { 591, 31, false, "C6" },
                    { 592, 31, false, "C8" },
                    { 593, 31, false, "CX" },
                    { 594, 31, false, "DS3" },
                    { 595, 31, false, "DS4" },
                    { 596, 31, false, "DS5" },
                    { 597, 31, false, "Evasion" },
                    { 598, 31, false, "Jumper" },
                    { 599, 31, false, "Jumpy" },
                    { 600, 31, false, "Nemo" },
                    { 601, 31, false, "Saxo" },
                    { 602, 31, false, "SpaceTourer" },
                    { 603, 31, false, "Xantia" },
                    { 604, 31, false, "XM" },
                    { 605, 31, false, "Xsara" },
                    { 606, 31, false, "Xsara Picasso" },
                    { 607, 31, false, "ZX" },
                    { 608, 32, false, "C5" },
                    { 609, 32, false, "C1" },
                    { 610, 33, false, "Formentor" },
                    { 611, 33, false, "Leon" },
                    { 612, 33, false, "Tavascan" },
                    { 613, 34, false, "1325 Liberta" },
                    { 614, 34, false, "Duster" },
                    { 615, 34, false, "Logdy" },
                    { 616, 34, false, "Logan" },
                    { 617, 34, false, "Sandero" },
                    { 618, 34, false, "Solenza" },
                    { 619, 34, false, "Spring" },
                    { 620, 35, false, "Shuttle" },
                    { 621, 36, false, "Alpheon" },
                    { 622, 36, false, "Arcadia" },
                    { 623, 36, false, "Chairman" },
                    { 624, 36, false, "Cielo" },
                    { 625, 36, false, "Damas" },
                    { 626, 36, false, "Espero" },
                    { 627, 36, false, "Evanda" },
                    { 628, 36, false, "G2X" },
                    { 629, 36, false, "Gentra" },
                    { 630, 36, false, "Kalos" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 631, 36, false, "Korando" },
                    { 632, 36, false, "Lacetti" },
                    { 633, 36, false, "Lanos" },
                    { 634, 36, false, "Leganza" },
                    { 635, 36, false, "LeMans" },
                    { 636, 36, false, "Lublin" },
                    { 637, 36, false, "Magnus" },
                    { 638, 36, false, "Matiz" },
                    { 639, 36, false, "Matiz Creative" },
                    { 640, 36, false, "Musso" },
                    { 641, 36, false, "Nexia" },
                    { 642, 36, false, "Nubira" },
                    { 643, 36, false, "Prince" },
                    { 644, 36, false, "Racer" },
                    { 645, 36, false, "Rezzo" },
                    { 646, 36, false, "Royale" },
                    { 647, 36, false, "Sens" },
                    { 648, 36, false, "Statesman" },
                    { 649, 36, false, "Tacuma" },
                    { 650, 36, false, "Tico" },
                    { 651, 36, false, "Tosca" },
                    { 652, 36, false, "Veritas Winstorm" },
                    { 653, 37, false, "Altis" },
                    { 654, 37, false, "Applause" },
                    { 655, 37, false, "Atrai" },
                    { 656, 37, false, "Be-go" },
                    { 657, 37, false, "Boon" },
                    { 658, 37, false, "Charade" },
                    { 659, 37, false, "Coo" },
                    { 660, 37, false, "Copen" },
                    { 661, 37, false, "Cuore" },
                    { 662, 37, false, "Esse" },
                    { 663, 37, false, "Feroza" },
                    { 664, 37, false, "Gran Move" },
                    { 665, 37, false, "Leeza" },
                    { 666, 37, false, "Materia" },
                    { 667, 37, false, "MAX" },
                    { 668, 37, false, "Mira" },
                    { 669, 37, false, "Move" },
                    { 670, 37, false, "Naked" },
                    { 671, 37, false, "Pyzar" },
                    { 672, 37, false, "Rocky" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 673, 37, false, "Sirion" },
                    { 674, 37, false, "Sonica" },
                    { 675, 37, false, "Storia" },
                    { 676, 37, false, "Tanto" },
                    { 677, 37, false, "Terios" },
                    { 678, 37, false, "Trevis" },
                    { 679, 37, false, "Wildcat" },
                    { 680, 37, false, "Xenia" },
                    { 681, 37, false, "YRV" },
                    { 682, 38, false, "mi-Do" },
                    { 683, 38, false, "on-DO" },
                    { 684, 39, false, "ES3" },
                    { 685, 39, false, "V5 Pickup" },
                    { 686, 40, false, "G318" },
                    { 687, 40, false, "S05" },
                    { 688, 40, false, "S07" },
                    { 689, 40, false, "SL03" },
                    { 690, 41, false, "D9" },
                    { 691, 41, false, "N7" },
                    { 692, 41, false, "N9" },
                    { 693, 41, false, "X" },
                    { 694, 41, false, "Z9 GT" },
                    { 695, 42, false, "Aurora" },
                    { 696, 42, false, "Land Crown" }
                });

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
                name: "IX_AspNetUsers_OrganizationId",
                table: "AspNetUsers",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DetailingOrders_AspNetUserId",
                table: "DetailingOrders",
                column: "AspNetUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailingOrders_CarId",
                table: "DetailingOrders",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailingOrders_EndOfOrderAspNetUserId",
                table: "DetailingOrders",
                column: "EndOfOrderAspNetUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailingOrders_ModelCarId",
                table: "DetailingOrders",
                column: "ModelCarId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailingOrders_OrganizationId",
                table: "DetailingOrders",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailingOrderTransactions_AspNetUserId",
                table: "DetailingOrderTransactions",
                column: "AspNetUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailingOrderTransactions_DetailingOrderId",
                table: "DetailingOrderTransactions",
                column: "DetailingOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailingOrderTransactions_OrganizationId",
                table: "DetailingOrderTransactions",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailingOrderTransactions_PaymentMethodId",
                table: "DetailingOrderTransactions",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailingPriceLists_AspNetUserId",
                table: "DetailingPriceLists",
                column: "AspNetUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailingPriceLists_OrganizationId",
                table: "DetailingPriceLists",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailingPriceLists_ServiceId",
                table: "DetailingPriceLists",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailingServices_AspNetUserId",
                table: "DetailingServices",
                column: "AspNetUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailingServices_DetailingOrderId",
                table: "DetailingServices",
                column: "DetailingOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailingServices_OrganizationId",
                table: "DetailingServices",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailingServices_ServiceId",
                table: "DetailingServices",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ModelCars_CarId",
                table: "ModelCars",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_TypeOfOrganizationId",
                table: "Organizations",
                column: "TypeOfOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_SalarySettings_AspNetUserId",
                table: "SalarySettings",
                column: "AspNetUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SalarySettings_OrganizationId",
                table: "SalarySettings",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_SalarySettings_ServiceId",
                table: "SalarySettings",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_AspNetUserId",
                table: "Services",
                column: "AspNetUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_OrganizationId",
                table: "Services",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_OrganizationId",
                table: "Subscriptions",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_WashOrders_AspNetUserId",
                table: "WashOrders",
                column: "AspNetUserId");

            migrationBuilder.CreateIndex(
                name: "IX_WashOrders_CarId",
                table: "WashOrders",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_WashOrders_EndOfOrderAspNetUserId",
                table: "WashOrders",
                column: "EndOfOrderAspNetUserId");

            migrationBuilder.CreateIndex(
                name: "IX_WashOrders_ModelCarId",
                table: "WashOrders",
                column: "ModelCarId");

            migrationBuilder.CreateIndex(
                name: "IX_WashOrders_OrganizationId",
                table: "WashOrders",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_WashOrderTransactions_AspNetUserId",
                table: "WashOrderTransactions",
                column: "AspNetUserId");

            migrationBuilder.CreateIndex(
                name: "IX_WashOrderTransactions_OrganizationId",
                table: "WashOrderTransactions",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_WashOrderTransactions_PaymentMethodId",
                table: "WashOrderTransactions",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_WashOrderTransactions_WashOrderId",
                table: "WashOrderTransactions",
                column: "WashOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_WashServices_AspNetUserId",
                table: "WashServices",
                column: "AspNetUserId");

            migrationBuilder.CreateIndex(
                name: "IX_WashServices_CreatedAspNetUserId",
                table: "WashServices",
                column: "CreatedAspNetUserId");

            migrationBuilder.CreateIndex(
                name: "IX_WashServices_OrganizationId",
                table: "WashServices",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_WashServices_ServiceId",
                table: "WashServices",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_WashServices_WashOrderId",
                table: "WashServices",
                column: "WashOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_WashServices_WhomAspNetUserId",
                table: "WashServices",
                column: "WhomAspNetUserId");
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
                name: "ClientOrganizations");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "DetailingOrderTransactions");

            migrationBuilder.DropTable(
                name: "DetailingPriceLists");

            migrationBuilder.DropTable(
                name: "DetailingServices");

            migrationBuilder.DropTable(
                name: "ForgotPasswordCodes");

            migrationBuilder.DropTable(
                name: "NotifiactionTokens");

            migrationBuilder.DropTable(
                name: "NotificationCenters");

            migrationBuilder.DropTable(
                name: "SalarySettings");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "WashOrderTransactions");

            migrationBuilder.DropTable(
                name: "WashServices");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "DetailingOrders");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "WashOrders");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ModelCars");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "TypeOfOrganizations");
        }
    }
}
