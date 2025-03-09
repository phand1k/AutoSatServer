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
                    { "2279899f-f874-4a40-9dd5-97a0fd24e9db", "498d102b-26a3-4834-8dab-05381ba20868", "Директор", "Директор" },
                    { "4b25ca3b-b1be-4aed-9bf4-8618db17e244", "09a301b6-27f0-47ee-8622-313226fc7bc9", "Менеджер", "МЕНЕДЖЕР" },
                    { "be05d8eb-3c8a-4d17-a5e0-8cb3a8b9ac2b", "f5f80337-e3e7-48b3-80c5-7e668a9d03d0", "Мастер", "МАСТЕР" }
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
                    { 42, false, "Derways" },
                    { 43, false, "DFSK" },
                    { 44, false, "Dodge" },
                    { 45, false, "DongFeng" },
                    { 46, false, "DS" },
                    { 47, false, "Eagle" },
                    { 48, false, "Enovate" },
                    { 49, false, "Evergrande" },
                    { 50, false, "EXEED" },
                    { 51, false, "Fang Chang Bao" },
                    { 52, false, "Farizon" },
                    { 53, false, "FAW" },
                    { 54, false, "Ferrari" },
                    { 55, false, "Fiat" },
                    { 56, false, "Fisker" },
                    { 57, false, "Ford" },
                    { 58, false, "Forthing" },
                    { 59, false, "Foton" },
                    { 60, false, "GAC" },
                    { 61, false, "Geely" },
                    { 62, false, "Genesis" },
                    { 63, false, "GMC" },
                    { 64, false, "Gonow" },
                    { 65, false, "Great Wall" },
                    { 66, false, "Guojin" },
                    { 67, false, "Hafei" },
                    { 68, false, "Haima" },
                    { 69, false, "Hanteng" },
                    { 70, false, "Haval" },
                    { 71, false, "Hawtai" },
                    { 72, false, "HiPhi" },
                    { 73, false, "Honda" },
                    { 74, false, "Hongqi" },
                    { 75, false, "Hozon" },
                    { 76, false, "HuangHai" },
                    { 77, false, "Huansu" },
                    { 78, false, "Huawei" },
                    { 79, false, "Hummer" },
                    { 80, false, "Hyundai" },
                    { 81, false, "iCar" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 82, false, "IM" },
                    { 83, false, "Ineos" },
                    { 84, false, "Infiniti" },
                    { 85, false, "Iran Khodro" },
                    { 86, false, "Isuzu" },
                    { 87, false, "JAC" },
                    { 88, false, "Jaecooo" },
                    { 89, false, "Jaguar" },
                    { 90, false, "Jeep" },
                    { 91, false, "Jetour" },
                    { 92, false, "Jetta" },
                    { 93, false, "JinBei" },
                    { 94, false, "JINPENG" },
                    { 95, false, "Jiyue" },
                    { 96, false, "JMC" },
                    { 97, false, "Kaiyi" },
                    { 98, false, "Karry" },
                    { 99, false, "Kia" },
                    { 100, false, "KYC" },
                    { 101, false, "Lamborghini" },
                    { 102, false, "Lancia" },
                    { 103, false, "Land Rover" },
                    { 104, false, "Landwind" },
                    { 105, false, "Leapmotor" },
                    { 106, false, "Leopaard" },
                    { 107, false, "Lexus" },
                    { 108, false, "LI" },
                    { 109, false, "Lifan" },
                    { 110, false, "Lincoln" },
                    { 111, false, "Livan" },
                    { 112, false, "Lotus" },
                    { 113, false, "Lucid" },
                    { 114, false, "Luxeed" },
                    { 115, false, "Luxgen" },
                    { 116, false, "Lynk & Co" },
                    { 117, false, "Mahindra" },
                    { 118, false, "Maple" },
                    { 119, false, "Maserati" },
                    { 120, false, "Maxus" },
                    { 121, false, "Maybach" },
                    { 122, false, "Mazda" },
                    { 123, false, "McLaren" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 124, false, "Mercedes-Benz" },
                    { 125, false, "Mercedes-Maybach" },
                    { 126, false, "Mercury" },
                    { 127, false, "Metrocab" },
                    { 128, false, "MG" },
                    { 129, false, "Mini" },
                    { 130, false, "Mitsubishi" },
                    { 131, false, "Nio" },
                    { 132, false, "Nissan" },
                    { 133, false, "Niutrion" },
                    { 134, false, "NL" },
                    { 135, false, "Oldsmobile" },
                    { 136, false, "OMODA" },
                    { 137, false, "Opel" },
                    { 138, false, "Ora" },
                    { 139, false, "Peugeot" },
                    { 140, false, "Plymouth" },
                    { 141, false, "Polar Stone" },
                    { 142, false, "Polestar" },
                    { 143, false, "Pontiac" },
                    { 144, false, "Porsche" },
                    { 145, false, "Proton" },
                    { 146, false, "Puch" },
                    { 147, false, "Radar" },
                    { 148, false, "RAM" },
                    { 149, false, "Ravon" },
                    { 150, false, "Renault" },
                    { 151, false, "Renault Samsung" },
                    { 152, false, "Rivian" },
                    { 153, false, "Roewe" },
                    { 154, false, "Rolls-Royce" },
                    { 155, false, "Rover" },
                    { 156, false, "Rox" },
                    { 157, false, "Saab" },
                    { 158, false, "SIAC" },
                    { 159, false, "Santana" },
                    { 160, false, "Saturn" },
                    { 161, false, "Skoda" },
                    { 162, false, "Smart" },
                    { 163, false, "Soueast" },
                    { 164, false, "Spartan" },
                    { 165, false, "SsangYong" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 166, false, "Subaru" },
                    { 167, false, "Suzuki" },
                    { 168, false, "SWM" },
                    { 169, false, "Tank" },
                    { 170, false, "Tesla" },
                    { 171, false, "Toyota" },
                    { 172, false, "Vokswagen" },
                    { 173, false, "Volvo" },
                    { 174, false, "Voyah" },
                    { 175, false, "Xiamo" },
                    { 176, false, "Zeekr" },
                    { 177, false, "ВАЗ (Lada)" }
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
                    { 696, 42, false, "Land Crown" },
                    { 697, 43, false, "C31" },
                    { 698, 43, false, "C32" },
                    { 699, 43, false, "C35" },
                    { 700, 43, false, "C36" },
                    { 701, 43, false, "C37" },
                    { 702, 43, false, "C56" },
                    { 703, 43, false, "C71" },
                    { 704, 44, false, "Avenger" },
                    { 705, 44, false, "Caliber" },
                    { 706, 44, false, "Caravan" },
                    { 707, 44, false, "Challenger" },
                    { 708, 44, false, "Charger" },
                    { 709, 44, false, "Dakota" },
                    { 710, 44, false, "Dart" },
                    { 711, 44, false, "Daytona" },
                    { 712, 44, false, "Durango" },
                    { 713, 44, false, "Interepid" },
                    { 714, 44, false, "Journey" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 715, 44, false, "Magnum" },
                    { 716, 44, false, "Monaco" },
                    { 717, 44, false, "Neon" },
                    { 718, 44, false, "Nitro" },
                    { 719, 44, false, "Ram" },
                    { 720, 44, false, "Shadow" },
                    { 721, 44, false, "Spirit" },
                    { 722, 44, false, "Stealth" },
                    { 723, 44, false, "Stratus" },
                    { 724, 44, false, "Viper" },
                    { 725, 45, false, "Nano EX1" },
                    { 726, 45, false, "580" },
                    { 727, 45, false, "A30" },
                    { 728, 45, false, "A60" },
                    { 729, 45, false, "Aeolus Haohan" },
                    { 730, 45, false, "Aeolus Haoji" },
                    { 731, 45, false, "Aeolus L7" },
                    { 732, 45, false, "Aeolus Yixuan" },
                    { 733, 45, false, "AX4" },
                    { 734, 45, false, "AX7" },
                    { 735, 45, false, "E70" },
                    { 736, 45, false, "EC36" },
                    { 737, 45, false, "EM26" },
                    { 738, 45, false, "EQ5032" },
                    { 739, 45, false, "EQ6380" },
                    { 740, 45, false, "EX1" },
                    { 741, 45, false, "Fengon 500" },
                    { 742, 45, false, "Fengon E5" },
                    { 743, 45, false, "Forthing T5 EVO" },
                    { 744, 45, false, "Forthing T5L" },
                    { 745, 45, false, "H30 Cross" },
                    { 746, 45, false, "Joyear S50" },
                    { 747, 45, false, "M5EV" },
                    { 748, 45, false, "Mengshi M-Hero 917" },
                    { 749, 45, false, "MPV" },
                    { 750, 45, false, "Nano (Nammi)" },
                    { 751, 45, false, "Oting" },
                    { 752, 45, false, "P16" },
                    { 753, 45, false, "Paladin" },
                    { 754, 45, false, "Rich" },
                    { 755, 45, false, "S30" },
                    { 756, 45, false, "Shine" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 757, 45, false, "Shine Max" },
                    { 758, 45, false, "Yipai 007" },
                    { 759, 45, false, "Yipai 008" },
                    { 760, 46, false, "7 Crossback" },
                    { 761, 47, false, "Summit" },
                    { 762, 47, false, "Premier" },
                    { 763, 47, false, "Talon" },
                    { 764, 47, false, "Vision" },
                    { 765, 48, false, "ME7" },
                    { 766, 49, false, "Hengchi 5" },
                    { 767, 50, false, "LX" },
                    { 768, 50, false, "RX" },
                    { 769, 50, false, "TXL" },
                    { 770, 50, false, "VX" },
                    { 771, 51, false, "Leopard 5" },
                    { 772, 52, false, "Xingxiang V6" },
                    { 773, 53, false, "1010" },
                    { 774, 53, false, "1021" },
                    { 775, 53, false, "1024" },
                    { 776, 53, false, "6350" },
                    { 777, 53, false, "6371" },
                    { 778, 53, false, "6390" },
                    { 779, 53, false, "Bestune B70" },
                    { 780, 53, false, "Bestune M9" },
                    { 781, 53, false, "Bestune T55" },
                    { 782, 53, false, "Bestune T77" },
                    { 783, 53, false, "Bestune T99" },
                    { 784, 53, false, "Besturn B50" },
                    { 785, 53, false, "Besturn B70" },
                    { 786, 53, false, "Besturn NAT" },
                    { 787, 53, false, "Besturn X40" },
                    { 788, 53, false, "Besturn X80" },
                    { 789, 53, false, "D60" },
                    { 790, 53, false, "Jinn" },
                    { 791, 53, false, "Landmark" },
                    { 792, 53, false, "N5" },
                    { 793, 53, false, "Oley" },
                    { 794, 53, false, "S80" },
                    { 795, 53, false, "T80" },
                    { 796, 53, false, "V2" },
                    { 797, 53, false, "V5" },
                    { 798, 53, false, "V80" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 799, 53, false, "Vita" },
                    { 800, 53, false, "Xenia R7" },
                    { 801, 54, false, "296 GTB" },
                    { 802, 54, false, "348" },
                    { 803, 54, false, "360" },
                    { 804, 54, false, "456" },
                    { 805, 54, false, "458" },
                    { 806, 54, false, "488" },
                    { 807, 54, false, "550" },
                    { 808, 54, false, "575" },
                    { 809, 54, false, "599" },
                    { 810, 54, false, "612" },
                    { 811, 54, false, "812" },
                    { 812, 54, false, "California" },
                    { 813, 54, false, "Enzo" },
                    { 814, 54, false, "F12 berlinetta" },
                    { 815, 54, false, "F355" },
                    { 816, 54, false, "F40" },
                    { 817, 54, false, "F430" },
                    { 818, 54, false, "F8" },
                    { 819, 54, false, "FF" },
                    { 820, 54, false, "GTC4Lusso" },
                    { 821, 54, false, "Mondial" },
                    { 822, 54, false, "Portofino" },
                    { 823, 54, false, "Purosangue" },
                    { 824, 54, false, "Roma" },
                    { 825, 54, false, "SF90 Stradale" },
                    { 826, 54, false, "Testarossa" },
                    { 827, 55, false, "500" },
                    { 828, 55, false, "500e" },
                    { 829, 55, false, "500L" },
                    { 830, 55, false, "500X" },
                    { 831, 55, false, "600" },
                    { 832, 55, false, "Albea" },
                    { 833, 55, false, "Barchetta" },
                    { 834, 55, false, "Brava" },
                    { 835, 55, false, "Bravo" },
                    { 836, 55, false, "Cinquecento" },
                    { 837, 55, false, "Coupe" },
                    { 838, 55, false, "Croma" },
                    { 839, 55, false, "Doblo" },
                    { 840, 55, false, "Ducato" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 841, 55, false, "Fiorino" },
                    { 842, 55, false, "Freemont" },
                    { 843, 55, false, "Idea" },
                    { 844, 55, false, "Linea" },
                    { 845, 55, false, "Marea" },
                    { 846, 55, false, "Multipla" },
                    { 847, 55, false, "Palio" },
                    { 848, 55, false, "Panda" },
                    { 849, 55, false, "Punto" },
                    { 850, 55, false, "Qubo" },
                    { 851, 55, false, "Scudo" },
                    { 852, 55, false, "Sedici" },
                    { 853, 55, false, "Seicento" },
                    { 854, 55, false, "Siena" },
                    { 855, 55, false, "Stilo" },
                    { 856, 55, false, "Strada" },
                    { 857, 55, false, "Tempra" },
                    { 858, 55, false, "Tipo" },
                    { 859, 55, false, "Ulysse" },
                    { 860, 55, false, "Uno" },
                    { 861, 56, false, "Ocean" },
                    { 862, 57, false, "Aerostar" },
                    { 863, 57, false, "Aspire" },
                    { 864, 57, false, "B-Max" },
                    { 865, 57, false, "Bronco" },
                    { 866, 57, false, "Bronco Sport" },
                    { 867, 57, false, "Bronco-II" },
                    { 868, 57, false, "C-Max" },
                    { 869, 57, false, "Capri" },
                    { 870, 57, false, "Contour" },
                    { 871, 57, false, "Cougar" },
                    { 872, 57, false, "Courier Van" },
                    { 873, 57, false, "Crown Victoria" },
                    { 874, 57, false, "E-series" },
                    { 875, 57, false, "Econonline" },
                    { 876, 57, false, "Econovan" },
                    { 877, 57, false, "EcoSport" },
                    { 878, 57, false, "Edge" },
                    { 879, 57, false, "Equator" },
                    { 880, 57, false, "Escape" },
                    { 881, 57, false, "Escort" },
                    { 882, 57, false, "Escort (North America)" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 883, 57, false, "Everest" },
                    { 884, 57, false, "Evos" },
                    { 885, 57, false, "Excursion" },
                    { 886, 57, false, "Expedition" },
                    { 887, 57, false, "Explorer" },
                    { 888, 57, false, "Explorer Sport Trac" },
                    { 889, 57, false, "F-Series" },
                    { 890, 57, false, "Festiva" },
                    { 891, 57, false, "Fiesta" },
                    { 892, 57, false, "Five Hundred" },
                    { 893, 57, false, "Flex" },
                    { 894, 57, false, "Focus" },
                    { 895, 57, false, "Freda" },
                    { 896, 57, false, "Freestyle" },
                    { 897, 57, false, "Fusion" },
                    { 898, 57, false, "Fusion (North America)" },
                    { 899, 57, false, "Galaxy" },
                    { 900, 57, false, "Granada" },
                    { 901, 57, false, "GT" },
                    { 902, 57, false, "Ixion" },
                    { 903, 57, false, "KA" },
                    { 904, 57, false, "Kuga" },
                    { 905, 57, false, "Laser" },
                    { 906, 57, false, "Maverick" },
                    { 907, 57, false, "Mondeo" },
                    { 908, 57, false, "Mustang" },
                    { 909, 57, false, "Mustang Mach-E" },
                    { 910, 57, false, "Orion" },
                    { 911, 57, false, "Otosan P100" },
                    { 912, 57, false, "Probe" },
                    { 913, 57, false, "Puma" },
                    { 914, 57, false, "Ranger" },
                    { 915, 57, false, "Ranger (North America)" },
                    { 916, 57, false, "S-Max" },
                    { 917, 57, false, "Scorpio" },
                    { 918, 57, false, "Sierra" },
                    { 919, 57, false, "Taunus" },
                    { 920, 57, false, "Taurus" },
                    { 921, 57, false, "Telstar" },
                    { 922, 57, false, "Tempo" },
                    { 923, 57, false, "Territory" },
                    { 924, 57, false, "Thunderbird" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 925, 57, false, "Torino" },
                    { 926, 57, false, "Tourneo Connect" },
                    { 927, 57, false, "Tourneo Custom" },
                    { 928, 57, false, "Transit" },
                    { 929, 57, false, "Transict Connect" },
                    { 930, 57, false, "Windstar" },
                    { 931, 58, false, "Lingzhi M5" },
                    { 932, 58, false, "T5 EVO" },
                    { 933, 59, false, "Alpha" },
                    { 934, 59, false, "Gratour" },
                    { 935, 59, false, "Saga" },
                    { 936, 59, false, "Sauvana" },
                    { 937, 59, false, "Sup" },
                    { 938, 59, false, "Tunland" },
                    { 939, 59, false, "View" },
                    { 940, 60, false, "Aion Hyper GT" },
                    { 941, 60, false, "Aion LX" },
                    { 942, 60, false, "Aion S" },
                    { 943, 60, false, "Aion V" },
                    { 944, 60, false, "Aion Y" },
                    { 945, 60, false, "E9" },
                    { 946, 60, false, "Emkoo" },
                    { 947, 60, false, "Empow" },
                    { 948, 60, false, "GN8" },
                    { 949, 60, false, "GS3" },
                    { 950, 60, false, "GS4" },
                    { 951, 60, false, "GS5" },
                    { 952, 60, false, "GS7" },
                    { 953, 60, false, "GS8" },
                    { 954, 60, false, "M6" },
                    { 955, 60, false, "M8" },
                    { 956, 61, false, "Atlas" },
                    { 957, 61, false, "Azkarra" },
                    { 958, 61, false, "Beauty Leopard" },
                    { 959, 61, false, "Binrui Cool" },
                    { 960, 61, false, "Binyue" },
                    { 961, 61, false, "CK" },
                    { 962, 61, false, "Coolray" },
                    { 963, 61, false, "Emgrand" },
                    { 964, 61, false, "Emgrand 7" },
                    { 965, 61, false, "Emgrand EC7" },
                    { 966, 61, false, "Emgrand EC8" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 967, 61, false, "Emgrand GSe" },
                    { 968, 61, false, "Emgrand GT" },
                    { 969, 61, false, "Emgrand L" },
                    { 970, 61, false, "Emgrand X7" },
                    { 971, 61, false, "Farizon FX" },
                    { 972, 61, false, "FC" },
                    { 973, 61, false, "Galaxy E5" },
                    { 974, 61, false, "Galaxy E8" },
                    { 975, 61, false, "Galaxy L6" },
                    { 976, 61, false, "Galaxy L7" },
                    { 977, 61, false, "Galaxy Starship 7" },
                    { 978, 61, false, "GC6" },
                    { 979, 61, false, "GC9" },
                    { 980, 61, false, "Geome Xingyuan" },
                    { 981, 61, false, "Geometry A GE11" },
                    { 982, 61, false, "Geometry E" },
                    { 983, 61, false, "Icon" },
                    { 984, 61, false, "Jiajii" },
                    { 985, 61, false, "MK" },
                    { 986, 61, false, "Monjaro" },
                    { 987, 61, false, "Okavango" },
                    { 988, 61, false, "Preface" },
                    { 989, 61, false, "SC7" },
                    { 990, 61, false, "Tugella" },
                    { 991, 61, false, "Vision X3" },
                    { 992, 61, false, "Vision X3 Pro" },
                    { 993, 61, false, "Vision X6 Pro" },
                    { 994, 62, false, "G70" },
                    { 995, 62, false, "G80" },
                    { 996, 62, false, "G90" },
                    { 997, 62, false, "GV60" },
                    { 998, 62, false, "GV70" },
                    { 999, 62, false, "GV80" },
                    { 1000, 62, false, "GV80 Coupe" },
                    { 1001, 63, false, "Acadia" },
                    { 1002, 63, false, "Canyon" },
                    { 1003, 63, false, "Envoy" },
                    { 1004, 63, false, "Hummer EV" },
                    { 1005, 63, false, "Jimmy" },
                    { 1006, 63, false, "Safari" },
                    { 1007, 63, false, "Savana" },
                    { 1008, 63, false, "Sierra" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1009, 63, false, "Sonoma" },
                    { 1010, 63, false, "Terrain" },
                    { 1011, 63, false, "Vandura" },
                    { 1012, 63, false, "Yukon" },
                    { 1013, 64, false, "Aoxuan" },
                    { 1014, 64, false, "GX6" },
                    { 1015, 64, false, "Victor" },
                    { 1016, 65, false, "Coolbear" },
                    { 1017, 65, false, "Cowry" },
                    { 1018, 65, false, "Deer" },
                    { 1019, 65, false, "Florid" },
                    { 1020, 65, false, "Hover" },
                    { 1021, 65, false, "Hover H3" },
                    { 1022, 65, false, "Hover H5" },
                    { 1023, 65, false, "Hover H6" },
                    { 1024, 65, false, "Hover M2" },
                    { 1025, 65, false, "Hover M4" },
                    { 1026, 65, false, "Pegasus" },
                    { 1027, 65, false, "Peri" },
                    { 1028, 65, false, "Poer" },
                    { 1029, 65, false, "Poer KingKong" },
                    { 1030, 65, false, "Safe" },
                    { 1031, 65, false, "Sailor" },
                    { 1032, 65, false, "Sing RUV" },
                    { 1033, 65, false, "Voleex C30" },
                    { 1034, 65, false, "Voleex C50" },
                    { 1035, 65, false, "Voleex C70" },
                    { 1036, 65, false, "Wingle 3" },
                    { 1037, 65, false, "Wingle 5" },
                    { 1038, 65, false, "Wingle 6" },
                    { 1039, 65, false, "Wingle 7" },
                    { 1040, 66, false, "Jun Xing" },
                    { 1041, 67, false, "Brio" },
                    { 1042, 67, false, "Princip" },
                    { 1043, 67, false, "Saibao" },
                    { 1044, 67, false, "Simbo" },
                    { 1045, 68, false, "2" },
                    { 1046, 68, false, "3" },
                    { 1047, 68, false, "7" },
                    { 1048, 68, false, "M3" },
                    { 1049, 68, false, "S5" },
                    { 1050, 69, false, "V7" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1051, 69, false, "X5 EV" },
                    { 1052, 69, false, "X7" },
                    { 1053, 70, false, "Chitu" },
                    { 1054, 70, false, "Dargo" },
                    { 1055, 70, false, "Dargo X" },
                    { 1056, 70, false, "F7" },
                    { 1057, 70, false, "F7x" },
                    { 1058, 70, false, "H2" },
                    { 1059, 70, false, "H5" },
                    { 1060, 70, false, "H6" },
                    { 1061, 70, false, "H6 GT" },
                    { 1062, 70, false, "H7" },
                    { 1063, 70, false, "H8" },
                    { 1064, 70, false, "H9" },
                    { 1065, 70, false, "Jolion" },
                    { 1066, 70, false, "M6" },
                    { 1067, 70, false, "Raptor" },
                    { 1068, 70, false, "Shenshou" },
                    { 1069, 70, false, "Xiaolong" },
                    { 1070, 71, false, "Boliger" },
                    { 1071, 72, false, "X" },
                    { 1072, 72, false, "Y" },
                    { 1073, 72, false, "Z" },
                    { 1074, 73, false, "Accord" },
                    { 1075, 73, false, "Acty" },
                    { 1076, 73, false, "Airwave" },
                    { 1077, 73, false, "Amaze" },
                    { 1078, 73, false, "Ascot" },
                    { 1079, 73, false, "Avancier" },
                    { 1080, 73, false, "Ballade" },
                    { 1081, 73, false, "Beat" },
                    { 1082, 73, false, "Brio" },
                    { 1083, 73, false, "Capa" },
                    { 1084, 73, false, "City" },
                    { 1085, 73, false, "Civic" },
                    { 1086, 73, false, "Clarity" },
                    { 1087, 73, false, "Concerto" },
                    { 1088, 73, false, "CR-V" },
                    { 1089, 73, false, "CR-Z" },
                    { 1090, 73, false, "CRX" },
                    { 1091, 73, false, "Crossroad" },
                    { 1092, 73, false, "Crosstour" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1093, 73, false, "CRX" },
                    { 1094, 73, false, "Domani" },
                    { 1095, 73, false, "Element" },
                    { 1096, 73, false, "Elysion" },
                    { 1097, 73, false, "EV Plus" },
                    { 1098, 73, false, "Fit" },
                    { 1099, 73, false, "Fit Aria" },
                    { 1100, 73, false, "FR-V" },
                    { 1101, 73, false, "Freed" },
                    { 1102, 73, false, "HR-V" },
                    { 1103, 73, false, "Insight" },
                    { 1104, 73, false, "Inspire" },
                    { 1105, 73, false, "Integra" },
                    { 1106, 73, false, "Jade" },
                    { 1107, 73, false, "Jazz" },
                    { 1108, 73, false, "Lagreat" },
                    { 1109, 73, false, "Legend" },
                    { 1110, 73, false, "Life" },
                    { 1111, 73, false, "Logo" },
                    { 1112, 73, false, "Mobilio" },
                    { 1113, 73, false, "N-Box" },
                    { 1114, 73, false, "N-One" },
                    { 1115, 73, false, "N-Van" },
                    { 1116, 73, false, "N-WGN" },
                    { 1117, 73, false, "NSX" },
                    { 1118, 73, false, "Odyssey" },
                    { 1119, 73, false, "Orthia" },
                    { 1120, 73, false, "Partner" },
                    { 1121, 73, false, "Passport" },
                    { 1122, 73, false, "Pilot" },
                    { 1123, 73, false, "Prelude" },
                    { 1124, 73, false, "Quintet" },
                    { 1125, 73, false, "Ridgeline" },
                    { 1126, 73, false, "S2000" },
                    { 1127, 73, false, "S660" },
                    { 1128, 73, false, "Shuttle" },
                    { 1129, 73, false, "SM-X" },
                    { 1130, 73, false, "Stepwgn" },
                    { 1131, 73, false, "Stream" },
                    { 1132, 73, false, "Thats" },
                    { 1133, 73, false, "Today" },
                    { 1134, 73, false, "Torneo" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1135, 73, false, "Vamos" },
                    { 1136, 73, false, "Vezel" },
                    { 1137, 73, false, "Zest" },
                    { 1138, 74, false, "E-HS3" },
                    { 1139, 74, false, "E-HS9" },
                    { 1140, 74, false, "E-QM5" },
                    { 1141, 74, false, "H5" },
                    { 1142, 74, false, "H7" },
                    { 1143, 74, false, "H9" },
                    { 1144, 74, false, "HS5" },
                    { 1145, 74, false, "HS7" },
                    { 1146, 74, false, "HS9" },
                    { 1147, 74, false, "L5" },
                    { 1148, 74, false, "S9" },
                    { 1149, 75, false, "Neta Aya" },
                    { 1150, 75, false, "Neta GT" },
                    { 1151, 75, false, "Neta L" },
                    { 1152, 75, false, "Neta S" },
                    { 1153, 75, false, "Neta U" },
                    { 1154, 75, false, "Neta U-II" },
                    { 1155, 75, false, "Neta V" },
                    { 1156, 75, false, "Neta X" },
                    { 1157, 76, false, "Antelope" },
                    { 1158, 76, false, "Aurora" },
                    { 1159, 76, false, "Landscape" },
                    { 1160, 76, false, "Landscape F1" },
                    { 1161, 76, false, "Landscape V3" },
                    { 1162, 76, false, "Major" },
                    { 1163, 76, false, "N7" },
                    { 1164, 76, false, "Navigator" },
                    { 1165, 76, false, "Plutus" },
                    { 1166, 77, false, "H5" },
                    { 1167, 78, false, "Stelato S9" },
                    { 1168, 79, false, "H1" },
                    { 1169, 79, false, "H2" },
                    { 1170, 79, false, "H3" },
                    { 1171, 80, false, "Accent" },
                    { 1172, 80, false, "Atos" },
                    { 1173, 80, false, "Avante" },
                    { 1174, 80, false, "Azera" },
                    { 1175, 80, false, "Centennial" },
                    { 1176, 80, false, "Click" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1177, 80, false, "Creta" },
                    { 1178, 80, false, "Dynasty" },
                    { 1179, 80, false, "Elantra" },
                    { 1180, 80, false, "Entourage" },
                    { 1181, 80, false, "Eon" },
                    { 1182, 80, false, "Equus" },
                    { 1183, 80, false, "Excel" },
                    { 1184, 80, false, "Genesis" },
                    { 1185, 80, false, "Getz" },
                    { 1186, 80, false, "Grandeur" },
                    { 1187, 80, false, "H-1" },
                    { 1188, 80, false, "H-100" },
                    { 1189, 80, false, "HB20" },
                    { 1190, 80, false, "i10" },
                    { 1191, 80, false, "i20" },
                    { 1192, 80, false, "i30" },
                    { 1193, 80, false, "i40" },
                    { 1194, 80, false, "Ioniq" },
                    { 1195, 80, false, "ix20" },
                    { 1196, 80, false, "ix35" },
                    { 1197, 80, false, "ix55" },
                    { 1198, 80, false, "Kona" },
                    { 1199, 80, false, "Lavita" },
                    { 1200, 80, false, "Marcia" },
                    { 1201, 80, false, "Matrix" },
                    { 1202, 80, false, "Maxcruz" },
                    { 1203, 80, false, "Nexo" },
                    { 1204, 80, false, "Palisade" },
                    { 1205, 80, false, "Pony" },
                    { 1206, 80, false, "Porter" },
                    { 1207, 80, false, "Santa Fe" },
                    { 1208, 80, false, "Santamo" },
                    { 1209, 80, false, "S-Coupe" },
                    { 1210, 80, false, "Solaris" },
                    { 1211, 80, false, "Sonata" },
                    { 1212, 80, false, "Starex" },
                    { 1213, 80, false, "Stellar" },
                    { 1214, 80, false, "Terracan" },
                    { 1215, 80, false, "Tiburon" },
                    { 1216, 80, false, "Trajet" },
                    { 1217, 80, false, "Tucson" },
                    { 1218, 80, false, "Veloster" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1219, 80, false, "Venue" },
                    { 1220, 80, false, "Veracruz" },
                    { 1221, 80, false, "Verna" },
                    { 1222, 80, false, "Visto" },
                    { 1223, 80, false, "Xcent" },
                    { 1224, 81, false, "03" },
                    { 1225, 82, false, "LS6" },
                    { 1226, 82, false, "LS7" },
                    { 1227, 83, false, "Grenadier" },
                    { 1228, 84, false, "EX25" },
                    { 1229, 84, false, "EX35" },
                    { 1230, 84, false, "EX37" },
                    { 1231, 84, false, "FX35" },
                    { 1232, 84, false, "FX37" },
                    { 1233, 84, false, "FX45" },
                    { 1234, 84, false, "FX50" },
                    { 1235, 84, false, "G20" },
                    { 1236, 84, false, "G25" },
                    { 1237, 84, false, "G35" },
                    { 1238, 84, false, "G37" },
                    { 1239, 84, false, "I30" },
                    { 1240, 84, false, "I35" },
                    { 1241, 84, false, "J30" },
                    { 1242, 84, false, "JX35" },
                    { 1243, 84, false, "M25" },
                    { 1244, 84, false, "M30" },
                    { 1245, 84, false, "M35" },
                    { 1246, 84, false, "M37" },
                    { 1247, 84, false, "M45" },
                    { 1248, 84, false, "M56" },
                    { 1249, 84, false, "Q30" },
                    { 1250, 84, false, "Q40" },
                    { 1251, 84, false, "Q45" },
                    { 1252, 84, false, "Q50" },
                    { 1253, 84, false, "Q60" },
                    { 1254, 84, false, "Q70" },
                    { 1255, 84, false, "QX30" },
                    { 1256, 84, false, "QX4" },
                    { 1257, 84, false, "QX50" },
                    { 1258, 84, false, "QX56" },
                    { 1259, 84, false, "QX60" },
                    { 1260, 84, false, "QX70" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1261, 84, false, "QX80" },
                    { 1262, 85, false, "Peugeot Pars" },
                    { 1263, 85, false, "Runna" },
                    { 1264, 85, false, "Samand" },
                    { 1265, 85, false, "Sarir" },
                    { 1266, 86, false, "Amigo" },
                    { 1267, 86, false, "Ascender" },
                    { 1268, 86, false, "Axiom" },
                    { 1269, 86, false, "Bighorn" },
                    { 1270, 86, false, "D-Max" },
                    { 1271, 86, false, "Fargo" },
                    { 1272, 86, false, "Faster" },
                    { 1273, 86, false, "Filly" },
                    { 1274, 86, false, "Florian" },
                    { 1275, 86, false, "Gemini" },
                    { 1276, 86, false, "Hombre" },
                    { 1277, 86, false, "Impulse" },
                    { 1278, 86, false, "KB" },
                    { 1279, 86, false, "MU" },
                    { 1280, 86, false, "MU-X" },
                    { 1281, 86, false, "Piazza" },
                    { 1282, 86, false, "Rodeo" },
                    { 1283, 86, false, "Trooper" },
                    { 1284, 86, false, "VehiCROSS" },
                    { 1285, 86, false, "Wizard" },
                    { 1286, 87, false, "E-J7" },
                    { 1287, 87, false, "e-JS4" },
                    { 1288, 87, false, "HFC 1027 PickUp" },
                    { 1289, 87, false, "iEV7S" },
                    { 1290, 87, false, "iEVS4" },
                    { 1291, 87, false, "J2" },
                    { 1292, 87, false, "J3" },
                    { 1293, 87, false, "J5" },
                    { 1294, 87, false, "J6" },
                    { 1295, 87, false, "J7" },
                    { 1296, 87, false, "J7 Plus" },
                    { 1297, 87, false, "JS4" },
                    { 1298, 87, false, "JS5" },
                    { 1299, 87, false, "JS6" },
                    { 1300, 87, false, "JS8" },
                    { 1301, 87, false, "M1" },
                    { 1302, 87, false, "M4 (Refine)" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1303, 87, false, "M5" },
                    { 1304, 87, false, "N35" },
                    { 1305, 87, false, "S1" },
                    { 1306, 87, false, "S2" },
                    { 1307, 87, false, "S3" },
                    { 1308, 87, false, "S3 Pro" },
                    { 1309, 87, false, "S5" },
                    { 1310, 87, false, "S7" },
                    { 1311, 87, false, "Sehol A5 Plus" },
                    { 1312, 87, false, "Sehol X8 Plus" },
                    { 1313, 87, false, "Sunray" },
                    { 1314, 87, false, "T6" },
                    { 1315, 87, false, "T8 Pro" },
                    { 1316, 87, false, "T9 Hunter" },
                    { 1317, 87, false, "Yttrium 3" },
                    { 1318, 88, false, "J7" },
                    { 1319, 88, false, "J8" },
                    { 1320, 89, false, "E-Pace" },
                    { 1321, 89, false, "F-Pace" },
                    { 1322, 89, false, "F-Type" },
                    { 1323, 89, false, "I-Pace" },
                    { 1324, 89, false, "S-Type" },
                    { 1325, 89, false, "X-Type" },
                    { 1326, 89, false, "XE" },
                    { 1327, 89, false, "XF" },
                    { 1328, 89, false, "XJ" },
                    { 1329, 89, false, "XK" },
                    { 1330, 89, false, "XKR" },
                    { 1331, 90, false, "Cherokee" },
                    { 1332, 90, false, "CJ" },
                    { 1333, 90, false, "Commander" },
                    { 1334, 90, false, "Compass" },
                    { 1335, 90, false, "Gladiator" },
                    { 1336, 90, false, "Grand Cherokee" },
                    { 1337, 90, false, "Grand Wagoneer" },
                    { 1338, 90, false, "Liberty" },
                    { 1339, 90, false, "Patriot" },
                    { 1340, 90, false, "Renegade" },
                    { 1341, 90, false, "Wagoneer" },
                    { 1342, 90, false, "Wrangler" },
                    { 1343, 91, false, "Dashing" },
                    { 1344, 91, false, "Shanghai L7" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1345, 91, false, "Shanghai L9" },
                    { 1346, 91, false, "T2" },
                    { 1347, 91, false, "Traveller" },
                    { 1348, 91, false, "X50" },
                    { 1349, 91, false, "X70" },
                    { 1350, 91, false, "X70 Plus" },
                    { 1351, 91, false, "X70 PRO" },
                    { 1352, 91, false, "X70S" },
                    { 1353, 91, false, "X90" },
                    { 1354, 91, false, "X90 Plus" },
                    { 1355, 91, false, "X95" },
                    { 1356, 92, false, "VA3" },
                    { 1357, 92, false, "VS5" },
                    { 1358, 92, false, "VS7" },
                    { 1359, 93, false, "Haise" },
                    { 1360, 93, false, "Hiace" },
                    { 1361, 93, false, "X30" },
                    { 1362, 94, false, "G6S" },
                    { 1363, 95, false, "Robo 01" },
                    { 1364, 96, false, "Baodian" },
                    { 1365, 96, false, "Dadao" },
                    { 1366, 96, false, "Vigus" },
                    { 1367, 96, false, "YunBa JX6504D" },
                    { 1368, 96, false, "Yusheng" },
                    { 1369, 97, false, "E5" },
                    { 1370, 97, false, "X3" },
                    { 1371, 97, false, "X3 Pro" },
                    { 1372, 97, false, "X7 Kunlun" },
                    { 1373, 97, false, "Xuanjie Pro EV" },
                    { 1374, 98, false, "K60" },
                    { 1375, 98, false, "K60 EV" },
                    { 1376, 99, false, "Avella" },
                    { 1377, 99, false, "Besta" },
                    { 1378, 99, false, "Bongo" },
                    { 1379, 99, false, "Cadenza" },
                    { 1380, 99, false, "Capital" },
                    { 1381, 99, false, "Carens" },
                    { 1382, 99, false, "Carnival" },
                    { 1383, 99, false, "Carstar" },
                    { 1384, 99, false, "Cee'd" },
                    { 1385, 99, false, "Cerato" },
                    { 1386, 99, false, "Clarus" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1387, 99, false, "Concord" },
                    { 1388, 99, false, "Credos" },
                    { 1389, 99, false, "Elan" },
                    { 1390, 99, false, "Enterprise" },
                    { 1391, 99, false, "EV5" },
                    { 1392, 99, false, "EV6" },
                    { 1393, 99, false, "EV9" },
                    { 1394, 99, false, "Forte" },
                    { 1395, 99, false, "Joice" },
                    { 1396, 99, false, "K3" },
                    { 1397, 99, false, "K4" },
                    { 1398, 99, false, "K5" },
                    { 1399, 99, false, "K7" },
                    { 1400, 99, false, "K8" },
                    { 1401, 99, false, "K9" },
                    { 1402, 99, false, "K900" },
                    { 1403, 99, false, "KX 1" },
                    { 1404, 99, false, "Magentis" },
                    { 1405, 99, false, "Mohave" },
                    { 1406, 99, false, "Morning" },
                    { 1407, 99, false, "Niro" },
                    { 1408, 99, false, "Opirus" },
                    { 1409, 99, false, "Optima" },
                    { 1410, 99, false, "Pegas" },
                    { 1411, 99, false, "Picanto" },
                    { 1412, 99, false, "Potentia" },
                    { 1413, 99, false, "Pregio" },
                    { 1414, 99, false, "Pride" },
                    { 1415, 99, false, "ProCeed" },
                    { 1416, 99, false, "Quoris" },
                    { 1417, 99, false, "Ray" },
                    { 1418, 99, false, "Retona" },
                    { 1419, 99, false, "Rio" },
                    { 1420, 99, false, "Rio X-Line" },
                    { 1421, 99, false, "Rocsta" },
                    { 1422, 99, false, "Sedona" },
                    { 1423, 99, false, "Seltos" },
                    { 1424, 99, false, "Sephia" },
                    { 1425, 99, false, "Shuma" },
                    { 1426, 99, false, "Sonet" },
                    { 1427, 99, false, "Sorento" },
                    { 1428, 99, false, "Soul" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1429, 99, false, "Spectra" },
                    { 1430, 99, false, "Sportage" },
                    { 1431, 99, false, "Stinger" },
                    { 1432, 99, false, "Stonic" },
                    { 1433, 99, false, "Telluride" },
                    { 1434, 99, false, "Topic" },
                    { 1435, 99, false, "Venga" },
                    { 1436, 99, false, "Visto" },
                    { 1437, 99, false, "X-Trek" },
                    { 1438, 99, false, "XCeed" },
                    { 1439, 100, false, "V7" },
                    { 1440, 101, false, "Aventador" },
                    { 1441, 101, false, "Centenario" },
                    { 1442, 101, false, "Countach" },
                    { 1443, 101, false, "Diablo" },
                    { 1444, 101, false, "Gallardo" },
                    { 1445, 101, false, "Huracan" },
                    { 1446, 101, false, "LM002" },
                    { 1447, 101, false, "Murcielago" },
                    { 1448, 101, false, "Reventon" },
                    { 1449, 101, false, "Revuelto" },
                    { 1450, 101, false, "Temerario" },
                    { 1451, 101, false, "Urus" },
                    { 1452, 102, false, "Beta" },
                    { 1453, 102, false, "Dedra" },
                    { 1454, 102, false, "Delta" },
                    { 1455, 102, false, "Kappa" },
                    { 1456, 102, false, "Lybra" },
                    { 1457, 102, false, "Musa" },
                    { 1458, 102, false, "Phedra" },
                    { 1459, 102, false, "Prisma" },
                    { 1460, 102, false, "Thema" },
                    { 1461, 102, false, "Thesis" },
                    { 1462, 102, false, "Ypsilon" },
                    { 1463, 102, false, "Zeta" },
                    { 1464, 103, false, "Defender" },
                    { 1465, 103, false, "Discovery" },
                    { 1466, 103, false, "Discovery Sport" },
                    { 1467, 103, false, "Freelander" },
                    { 1468, 103, false, "LR2" },
                    { 1469, 103, false, "LR3" },
                    { 1470, 103, false, "LR4" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1471, 103, false, "Range Rover" },
                    { 1472, 103, false, "Range Rover Evoque" },
                    { 1473, 103, false, "Range Rover Sport" },
                    { 1474, 103, false, "Range Rover Velar" },
                    { 1475, 104, false, "E3" },
                    { 1476, 105, false, "C01" },
                    { 1477, 105, false, "C11" },
                    { 1478, 105, false, "C16" },
                    { 1479, 105, false, "T03" },
                    { 1480, 105, false, "C10" },
                    { 1481, 106, false, "Coupe" },
                    { 1482, 107, false, "CT200h" },
                    { 1483, 107, false, "ES 200" },
                    { 1484, 107, false, "ES 250" },
                    { 1485, 107, false, "ES 300" },
                    { 1486, 107, false, "ES 300h" },
                    { 1487, 107, false, "ES 330" },
                    { 1488, 107, false, "ES 350" },
                    { 1489, 107, false, "GS 200t" },
                    { 1490, 107, false, "GS 250" },
                    { 1491, 107, false, "GS 300h" },
                    { 1492, 107, false, "GS 350" },
                    { 1493, 107, false, "GS 400" },
                    { 1494, 107, false, "GS 430" },
                    { 1495, 107, false, "GS 450h" },
                    { 1496, 107, false, "GS 460" },
                    { 1497, 107, false, "GS-F" },
                    { 1498, 107, false, "GX 400" },
                    { 1499, 107, false, "GX 470" },
                    { 1500, 107, false, "GX 550" },
                    { 1501, 107, false, "HS" },
                    { 1502, 107, false, "IS 200" },
                    { 1503, 107, false, "IS 200t" },
                    { 1504, 107, false, "IS 220" },
                    { 1505, 107, false, "IS 250" },
                    { 1506, 107, false, "IS 300" },
                    { 1507, 107, false, "IS 350" },
                    { 1508, 107, false, "IS 500" },
                    { 1509, 107, false, "IS-F" },
                    { 1510, 107, false, "LS 350" },
                    { 1511, 107, false, "LS 400" },
                    { 1512, 107, false, "LS 430" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1513, 107, false, "LS 460" },
                    { 1514, 107, false, "LS 500" },
                    { 1515, 107, false, "LS 500h" },
                    { 1516, 107, false, "LS 600h" },
                    { 1517, 107, false, "700" },
                    { 1518, 107, false, "LX 450" },
                    { 1519, 107, false, "LX 450d" },
                    { 1520, 107, false, "LX 470" },
                    { 1521, 107, false, "LX 570" },
                    { 1522, 107, false, "LX 600" },
                    { 1523, 107, false, "LX 700h" },
                    { 1524, 107, false, "NX 200" },
                    { 1525, 107, false, "NX 200t" },
                    { 1526, 107, false, "NX 250" },
                    { 1527, 107, false, "NX 300" },
                    { 1528, 107, false, "NX 300h" },
                    { 1529, 107, false, "NX 350" },
                    { 1530, 107, false, "NX 350h" },
                    { 1531, 107, false, "NX 450h+" },
                    { 1532, 107, false, "RC 200t" },
                    { 1533, 107, false, "RC 300" },
                    { 1534, 107, false, "RC 300h" },
                    { 1535, 107, false, "RC 350" },
                    { 1536, 107, false, "RC-F" },
                    { 1537, 107, false, "RX 200t" },
                    { 1538, 107, false, "RX 270" },
                    { 1539, 107, false, "RX 300" },
                    { 1540, 107, false, "RX 330" },
                    { 1541, 107, false, "RX350" },
                    { 1542, 107, false, "RX 350h" },
                    { 1543, 107, false, "RX 400h" },
                    { 1544, 107, false, "RX 350h" },
                    { 1545, 107, false, "RX 400h" },
                    { 1546, 107, false, "RX 450h" },
                    { 1547, 107, false, "RX 500h" },
                    { 1548, 107, false, "SC 300" },
                    { 1549, 107, false, "SC 400" },
                    { 1550, 107, false, "SC 430" },
                    { 1551, 107, false, "UX 200" },
                    { 1552, 107, false, "UX 250h" },
                    { 1553, 107, false, "UX300e" },
                    { 1554, 108, false, "L6" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1555, 108, false, "L7" },
                    { 1556, 108, false, "L8" },
                    { 1557, 108, false, "L9" },
                    { 1558, 108, false, "Mega" },
                    { 1559, 108, false, "One" },
                    { 1560, 109, false, "Breez" },
                    { 1561, 109, false, "Cebrium" },
                    { 1562, 109, false, "Celliya" },
                    { 1563, 109, false, "Murman" },
                    { 1564, 109, false, "MyWay" },
                    { 1565, 109, false, "Smily" },
                    { 1566, 109, false, "Solano" },
                    { 1567, 109, false, "X50" },
                    { 1568, 109, false, "X60" },
                    { 1569, 109, false, "X70" },
                    { 1570, 109, false, "X80" },
                    { 1571, 110, false, "Aviator" },
                    { 1572, 110, false, "Continental" },
                    { 1573, 110, false, "Corsair" },
                    { 1574, 110, false, "LS" },
                    { 1575, 110, false, "Mark LT" },
                    { 1576, 110, false, "Mark VII" },
                    { 1577, 110, false, "MKC" },
                    { 1578, 110, false, "MKS" },
                    { 1579, 110, false, "MKX" },
                    { 1580, 110, false, "MKZ" },
                    { 1581, 110, false, "Nautilus" },
                    { 1582, 110, false, "Navigator" },
                    { 1583, 110, false, "Town Car" },
                    { 1584, 110, false, "Zephyr" },
                    { 1585, 111, false, "7" },
                    { 1586, 111, false, "S6 Pro" },
                    { 1587, 111, false, "X3 Pro" },
                    { 1588, 111, false, "X6 Pro" },
                    { 1589, 112, false, "Elan" },
                    { 1590, 112, false, "Eletre" },
                    { 1591, 112, false, "Elise" },
                    { 1592, 112, false, "Emeya" },
                    { 1593, 112, false, "Esprit" },
                    { 1594, 112, false, "Europa S" },
                    { 1595, 112, false, "Evora" },
                    { 1596, 112, false, "Excel" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1597, 112, false, "Exige" },
                    { 1598, 113, false, "Air" },
                    { 1599, 113, false, "Gravity" },
                    { 1600, 114, false, "R7" },
                    { 1601, 114, false, "S7" },
                    { 1602, 115, false, "5" },
                    { 1603, 115, false, "7" },
                    { 1604, 115, false, "U6 Turbo" },
                    { 1605, 115, false, "U7 Turbo" },
                    { 1606, 116, false, "01" },
                    { 1607, 116, false, "03" },
                    { 1608, 116, false, "05" },
                    { 1609, 116, false, "06" },
                    { 1610, 116, false, "07" },
                    { 1611, 116, false, "08 EM-P" },
                    { 1612, 116, false, "09" },
                    { 1613, 117, false, "Scorpio" },
                    { 1614, 118, false, "Leaf 80V" },
                    { 1615, 119, false, "228" },
                    { 1616, 119, false, "3200 GT" },
                    { 1617, 119, false, "4200 GT" },
                    { 1618, 119, false, "Coupe" },
                    { 1619, 119, false, "Ghibli" },
                    { 1620, 119, false, "GranCabrio" },
                    { 1621, 119, false, "GranSport" },
                    { 1622, 119, false, "GranTurismo" },
                    { 1623, 119, false, "Grecale" },
                    { 1624, 119, false, "Levante" },
                    { 1625, 119, false, "MC20" },
                    { 1626, 119, false, "Quattroporte" },
                    { 1627, 119, false, "Shamal" },
                    { 1628, 119, false, "Spyder" },
                    { 1629, 120, false, "EV30" },
                    { 1630, 120, false, "G10" },
                    { 1631, 120, false, "G50" },
                    { 1632, 120, false, "G90" },
                    { 1633, 121, false, "57" },
                    { 1634, 121, false, "62" },
                    { 1635, 121, false, "Exelero" },
                    { 1636, 121, false, "Landaulet" },
                    { 1637, 121, false, "Zeppelin" },
                    { 1638, 122, false, "121" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1639, 122, false, "2" },
                    { 1640, 122, false, "3" },
                    { 1641, 122, false, "323" },
                    { 1642, 122, false, "5" },
                    { 1643, 122, false, "6" },
                    { 1644, 122, false, "626" },
                    { 1645, 122, false, "929" },
                    { 1646, 122, false, "Atenza" },
                    { 1647, 122, false, "Axela" },
                    { 1648, 122, false, "AZ-1" },
                    { 1649, 122, false, "B-series" },
                    { 1650, 122, false, "Biante" },
                    { 1651, 122, false, "Bongo" },
                    { 1652, 122, false, "Bongo-Friendee" },
                    { 1653, 122, false, "BT-50" },
                    { 1654, 122, false, "Capella" },
                    { 1655, 122, false, "Carol" },
                    { 1656, 122, false, "Cosmo" },
                    { 1657, 122, false, "Cronos" },
                    { 1658, 122, false, "CX-3" },
                    { 1659, 122, false, "CX-30" },
                    { 1660, 122, false, "CX-4" },
                    { 1661, 122, false, "CX-5" },
                    { 1662, 122, false, "CX-7" },
                    { 1663, 122, false, "CX-9" },
                    { 1664, 122, false, "CX-90" },
                    { 1665, 122, false, "Demio" },
                    { 1666, 122, false, "Efini MS-6" },
                    { 1667, 122, false, "Efini MS-8" },
                    { 1668, 122, false, "Efini MS-9" },
                    { 1669, 122, false, "Eunos 500" },
                    { 1670, 122, false, "Eunos 800" },
                    { 1671, 122, false, "EZ-6" },
                    { 1672, 122, false, "Familia" },
                    { 1673, 122, false, "Lantis" },
                    { 1674, 122, false, "Laputa" },
                    { 1675, 122, false, "Luce" },
                    { 1676, 122, false, "Millenia" },
                    { 1677, 122, false, "MPV" },
                    { 1678, 122, false, "MX-3" },
                    { 1679, 122, false, "MX-5" },
                    { 1680, 122, false, "MX-6" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1681, 122, false, "MX30" },
                    { 1682, 122, false, "Navajo" },
                    { 1683, 122, false, "Premacy" },
                    { 1684, 122, false, "Proceed" },
                    { 1685, 122, false, "Proceed Levante" },
                    { 1686, 122, false, "Proceed Marvie" },
                    { 1687, 122, false, "Protege" },
                    { 1688, 122, false, "Roadster" },
                    { 1689, 122, false, "RX-7" },
                    { 1690, 122, false, "RX-8" },
                    { 1691, 122, false, "Sentia" },
                    { 1692, 122, false, "Tribute" },
                    { 1693, 122, false, "Verisa" },
                    { 1694, 122, false, "Xedos 6" },
                    { 1695, 122, false, "Xedos 9" },
                    { 1696, 123, false, "570S" },
                    { 1697, 123, false, "720S" },
                    { 1698, 123, false, "Senna" },
                    { 1699, 124, false, "A140" },
                    { 1700, 124, false, "A150" },
                    { 1701, 124, false, "A 160" },
                    { 1702, 124, false, "A 170" },
                    { 1703, 124, false, "A 180" },
                    { 1704, 124, false, "A 190" },
                    { 1705, 124, false, "A 200" },
                    { 1706, 124, false, "A 210" },
                    { 1707, 124, false, "A 220" },
                    { 1708, 124, false, "A 250" },
                    { 1709, 124, false, "A 35 AMG" },
                    { 1710, 124, false, "A 45 AMG" },
                    { 1711, 124, false, "B 150" },
                    { 1712, 124, false, "B 160" },
                    { 1713, 124, false, "B 170" },
                    { 1714, 124, false, "B 180" },
                    { 1715, 124, false, "B 200" },
                    { 1716, 124, false, "B 220" },
                    { 1717, 124, false, "B 250" },
                    { 1718, 124, false, "C 160" },
                    { 1719, 124, false, "C 180" },
                    { 1720, 124, false, "C 200" },
                    { 1721, 124, false, "C 220" },
                    { 1722, 124, false, "C 230" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1723, 124, false, "C 240" },
                    { 1724, 124, false, "C 250" },
                    { 1725, 124, false, "C 270" },
                    { 1726, 124, false, "C 280" },
                    { 1727, 124, false, "C 30 AMG" },
                    { 1728, 124, false, "C 300" },
                    { 1729, 124, false, "C 32 AMG" },
                    { 1730, 124, false, "C 320" },
                    { 1731, 124, false, "C 350" },
                    { 1732, 124, false, "C 36 AMG" },
                    { 1733, 124, false, "C 400" },
                    { 1734, 124, false, "C 43 AMG" },
                    { 1735, 124, false, "C 450 AMG" },
                    { 1736, 124, false, "C 55 AMG" },
                    { 1737, 124, false, "C 63 AMG" },
                    { 1738, 124, false, "CL 180" },
                    { 1739, 124, false, "CL 200" },
                    { 1740, 124, false, "CL 220" },
                    { 1741, 124, false, "CL 230" },
                    { 1742, 124, false, "CL 420" },
                    { 1743, 124, false, "CL 45 AMG" },
                    { 1744, 124, false, "CL 500" },
                    { 1745, 124, false, "CL 55 AMG" },
                    { 1746, 124, false, "CL 550" },
                    { 1747, 124, false, "CL 600" },
                    { 1748, 124, false, "CL 63 AMG" },
                    { 1749, 124, false, "CL 65 AMG" },
                    { 1750, 124, false, "CLA 180" },
                    { 1751, 124, false, "CLA 200" },
                    { 1752, 124, false, "CLA 220" },
                    { 1753, 124, false, "CLA 250" },
                    { 1754, 124, false, "CLA 35 AMG" },
                    { 1755, 124, false, "CLA 45 AMG" },
                    { 1756, 124, false, "CLC 160" },
                    { 1757, 124, false, "CLC 180" },
                    { 1758, 124, false, "CLC 200" },
                    { 1759, 124, false, "CLC 220" },
                    { 1760, 124, false, "CLC 230" },
                    { 1761, 124, false, "CLC 350" },
                    { 1762, 124, false, "CLK 200" },
                    { 1763, 124, false, "CLK 220" },
                    { 1764, 124, false, "CLK 230" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1765, 124, false, "CLK 240" },
                    { 1766, 124, false, "CLK 270" },
                    { 1767, 124, false, "CLK 280" },
                    { 1768, 124, false, "CLK 320" },
                    { 1769, 124, false, "CLK 350" },
                    { 1770, 124, false, "CLK 430" },
                    { 1771, 124, false, "CLK 500" },
                    { 1772, 124, false, "CLK 55 AMG" },
                    { 1773, 124, false, "CLK 63 AMG" },
                    { 1774, 124, false, "CLS 250" },
                    { 1775, 124, false, "CLS 280" },
                    { 1776, 124, false, "CLS 320" },
                    { 1777, 124, false, "CLS 350" },
                    { 1778, 124, false, "CLS 400" },
                    { 1779, 124, false, "CLS 450" },
                    { 1780, 124, false, "CLS 500" },
                    { 1781, 124, false, "CLS 53 AMG" },
                    { 1782, 124, false, "CLS 55 AMG" },
                    { 1783, 124, false, "CLS 550" },
                    { 1784, 124, false, "CLS 63 AMG" },
                    { 1785, 124, false, "E 200" },
                    { 1786, 124, false, "E 220" },
                    { 1787, 124, false, "E 230" },
                    { 1788, 124, false, "E 240" },
                    { 1789, 124, false, "E 250" },
                    { 1790, 124, false, "E 260" },
                    { 1791, 124, false, "E 270" },
                    { 1792, 124, false, "E 280" },
                    { 1793, 124, false, "E 290" },
                    { 1794, 124, false, "E 300" },
                    { 1795, 124, false, "E 320" },
                    { 1796, 124, false, "E 350" },
                    { 1797, 124, false, "E 36 AMG" },
                    { 1798, 124, false, "E 400" },
                    { 1799, 124, false, "E 420" },
                    { 1800, 124, false, "E 43 AMG" },
                    { 1801, 124, false, "E 430" },
                    { 1802, 124, false, "E 450" },
                    { 1803, 124, false, "E 50" },
                    { 1804, 124, false, "E 500" },
                    { 1805, 124, false, "E 53 AMG" },
                    { 1806, 124, false, "E 55 AMG" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1807, 124, false, "E 550" },
                    { 1808, 124, false, "E 60 AMG" },
                    { 1809, 124, false, "E 63 AMG" },
                    { 1810, 124, false, "EQA" },
                    { 1811, 124, false, "EQB" },
                    { 1812, 124, false, "EQC" },
                    { 1813, 124, false, "EQE" },
                    { 1814, 124, false, "EQE SUV" },
                    { 1815, 124, false, "EQS" },
                    { 1816, 124, false, "EQV" },
                    { 1817, 124, false, "G 230" },
                    { 1818, 124, false, "G 240" },
                    { 1819, 124, false, "G 250" },
                    { 1820, 124, false, "G 270" },
                    { 1821, 124, false, "G 280" },
                    { 1822, 124, false, "G 290" },
                    { 1823, 124, false, "G 300" },
                    { 1824, 124, false, "G 320" },
                    { 1825, 124, false, "G 350" },
                    { 1826, 124, false, "G 400" },
                    { 1827, 124, false, "G 500" },
                    { 1828, 124, false, "G 55 AMG" },
                    { 1829, 124, false, "G 550" },
                    { 1830, 124, false, "G 580 EQ" },
                    { 1831, 124, false, "G 63 AMG" },
                    { 1832, 124, false, "G 65A AMG" },
                    { 1833, 124, false, "GL 320" },
                    { 1834, 124, false, "GL 350" },
                    { 1835, 124, false, "GL 400" },
                    { 1836, 124, false, "GL 420" },
                    { 1837, 124, false, "GL 450" },
                    { 1838, 124, false, "GL 500" },
                    { 1839, 124, false, "GL 55 AMG" },
                    { 1840, 124, false, "GL 550" },
                    { 1841, 124, false, "GL 63 AMG" },
                    { 1842, 124, false, "GLA 180" },
                    { 1843, 124, false, "GLA 200" },
                    { 1844, 124, false, "GLA 220" },
                    { 1845, 124, false, "GLA 250" },
                    { 1846, 124, false, "GLA 35 AMG" },
                    { 1847, 124, false, "GLA 45 AMG" },
                    { 1848, 124, false, "GLB 200" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1849, 124, false, "GLB 220" },
                    { 1850, 124, false, "GLB 250" },
                    { 1851, 124, false, "GLB 35 AMG" },
                    { 1852, 124, false, "GLC Coupe 220" },
                    { 1853, 124, false, "GLC Coupe 250" },
                    { 1854, 124, false, "GLC Coupe 300" },
                    { 1855, 124, false, "GLC Coupe 43 AMG" },
                    { 1856, 124, false, "GLC Coupe 63 AMG" },
                    { 1857, 124, false, "GLC 200" },
                    { 1858, 124, false, "GLC 220" },
                    { 1859, 124, false, "GLC 250" },
                    { 1860, 124, false, "GLC 300" },
                    { 1861, 124, false, "GLC 350" },
                    { 1862, 124, false, "GLC 43 AMG" },
                    { 1863, 124, false, "GLC 63 AMG" },
                    { 1864, 124, false, "GLE Coupe 350d" },
                    { 1865, 124, false, "GLE Coupe 400" },
                    { 1866, 124, false, "GLE Coupe 43 AMG" },
                    { 1867, 124, false, "GLE Coupe 450 AMG" },
                    { 1868, 124, false, "GLE Coupe 53 AMG" },
                    { 1869, 124, false, "GLE Coupe 63 AMG" },
                    { 1870, 124, false, "GLE 250d" },
                    { 1871, 124, false, "GLE 300" },
                    { 1872, 124, false, "GLE 350" },
                    { 1873, 124, false, "GLE 350d" },
                    { 1874, 124, false, "GLE 400" },
                    { 1875, 124, false, "GLE 43 AMG" },
                    { 1876, 124, false, "GLE 450" },
                    { 1877, 124, false, "GLE 500" },
                    { 1878, 124, false, "GLE 53 AMG" },
                    { 1879, 124, false, "GLE 580" },
                    { 1880, 124, false, "GLE 63 AMG" },
                    { 1881, 124, false, "GLK 200" },
                    { 1882, 124, false, "GLK 220" },
                    { 1883, 124, false, "GLK 250" },
                    { 1884, 124, false, "GLK 280" },
                    { 1885, 124, false, "GLK 300" },
                    { 1886, 124, false, "GLK 320" },
                    { 1887, 124, false, "GLK 350" },
                    { 1888, 124, false, "GLS 350d" },
                    { 1889, 124, false, "GLS 400" },
                    { 1890, 124, false, "GLS 450" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1891, 124, false, "GLS 500" },
                    { 1892, 124, false, "GLS 580" },
                    { 1893, 124, false, "GLS 63 AMG" },
                    { 1894, 124, false, "MB 100" },
                    { 1895, 124, false, "ML 230" },
                    { 1896, 124, false, "ML 250" },
                    { 1897, 124, false, "ML 270" },
                    { 1898, 124, false, "ML 280" },
                    { 1899, 124, false, "ML 300" },
                    { 1900, 124, false, "ML 320" },
                    { 1901, 124, false, "ML 350" },
                    { 1902, 124, false, "ML 400" },
                    { 1903, 124, false, "ML 420" },
                    { 1904, 124, false, "ML 430" },
                    { 1905, 124, false, "ML 450" },
                    { 1906, 124, false, "ML 500" },
                    { 1907, 124, false, "ML 55 AMG" },
                    { 1908, 124, false, "ML 550" },
                    { 1909, 124, false, "ML 63 AMG" },
                    { 1910, 124, false, "R 280" },
                    { 1911, 124, false, "R 300" },
                    { 1912, 124, false, "R 320" },
                    { 1913, 124, false, "R 350" },
                    { 1914, 124, false, "R 500" },
                    { 1915, 124, false, "R 63 AMG" },
                    { 1916, 124, false, "S 220" },
                    { 1917, 124, false, "S 250" },
                    { 1918, 124, false, "S 260" },
                    { 1919, 124, false, "S 280" },
                    { 1920, 124, false, "S 300" },
                    { 1921, 124, false, "S 320" },
                    { 1922, 124, false, "S 350" },
                    { 1923, 124, false, "S 380" },
                    { 1924, 124, false, "S 400" },
                    { 1925, 124, false, "S 420" },
                    { 1926, 124, false, "S 430" },
                    { 1927, 124, false, "S 450" },
                    { 1928, 124, false, "S 500" },
                    { 1929, 124, false, "S 55" },
                    { 1930, 124, false, "S 550" },
                    { 1931, 124, false, "S 560" },
                    { 1932, 124, false, "S 580" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1933, 124, false, "S 600" },
                    { 1934, 124, false, "S 63 AMG" },
                    { 1935, 124, false, "S 65 AMG" },
                    { 1936, 124, false, "SEC 500 AMG" },
                    { 1937, 124, false, "450 SLC" },
                    { 1938, 124, false, "SL 280" },
                    { 1939, 124, false, "SL 300" },
                    { 1940, 124, false, "SL 320" },
                    { 1941, 124, false, "SL 350" },
                    { 1942, 124, false, "SL 380" },
                    { 1943, 124, false, "SL 400" },
                    { 1944, 124, false, "SL 450" },
                    { 1945, 124, false, "SL 500" },
                    { 1946, 124, false, "SL 55 AMG" },
                    { 1947, 124, false, "SL 560" },
                    { 1948, 124, false, "SL 60 AMG" },
                    { 1949, 124, false, "SL 600" },
                    { 1950, 124, false, "SL 63 AMG" },
                    { 1951, 124, false, "SL 65 AMG" },
                    { 1952, 124, false, "SL 70 AMG" },
                    { 1953, 124, false, "SL 73 AMG" },
                    { 1954, 124, false, "SLC 180" },
                    { 1955, 124, false, "SLC 200" },
                    { 1956, 124, false, "SLC 250" },
                    { 1957, 124, false, "SLC 300" },
                    { 1958, 124, false, "SLC 43 AMG" },
                    { 1959, 124, false, "SLK 200" },
                    { 1960, 124, false, "SLK 230" },
                    { 1961, 124, false, "SLK 250" },
                    { 1962, 124, false, "SLK 280" },
                    { 1963, 124, false, "SLK 300" },
                    { 1964, 124, false, "SLK 32 AMG" },
                    { 1965, 124, false, "SLK 320" },
                    { 1966, 124, false, "SLK 350" },
                    { 1967, 124, false, "SLK 55 AMG" },
                    { 1968, 124, false, "SLR McLaren" },
                    { 1969, 124, false, "SLS AMG" },
                    { 1970, 124, false, "Sprinter" },
                    { 1971, 124, false, "V 200" },
                    { 1972, 124, false, "V 220" },
                    { 1973, 124, false, "V 230" },
                    { 1974, 124, false, "V250" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1975, 124, false, "V 280" },
                    { 1976, 124, false, "V 300" },
                    { 1977, 124, false, "Vaneo" },
                    { 1978, 124, false, "Viano" },
                    { 1979, 124, false, "Vito" },
                    { 1980, 124, false, "X 200" },
                    { 1981, 124, false, "X 220" },
                    { 1982, 124, false, "X 250" },
                    { 1983, 124, false, "X 350" },
                    { 1984, 125, false, "G650 Landaulet Maybach" },
                    { 1985, 125, false, "GLS 600" },
                    { 1986, 125, false, "GLS 680" },
                    { 1987, 125, false, "S 400" },
                    { 1988, 125, false, "S 450" },
                    { 1989, 125, false, "S 500" },
                    { 1990, 125, false, "S 560" },
                    { 1991, 125, false, "S 580" },
                    { 1992, 125, false, "S 600" },
                    { 1993, 125, false, "S 650" },
                    { 1994, 125, false, "S 680" },
                    { 1995, 125, false, "VS 680" },
                    { 1996, 126, false, "Cougar" },
                    { 1997, 126, false, "Grand Marquis" },
                    { 1998, 126, false, "Marauder" },
                    { 1999, 126, false, "Mariner" },
                    { 2000, 126, false, "Milan" },
                    { 2001, 126, false, "Montego" },
                    { 2002, 126, false, "Monterey" },
                    { 2003, 126, false, "Mounterey" },
                    { 2004, 126, false, "Mountaineer" },
                    { 2005, 126, false, "Mystique" },
                    { 2006, 126, false, "Sable" },
                    { 2007, 126, false, "Topaz" },
                    { 2008, 126, false, "Tracer" },
                    { 2009, 126, false, "Villager" },
                    { 2010, 127, false, "Metrocab I" },
                    { 2011, 127, false, "Metrocab II" },
                    { 2012, 128, false, "3" },
                    { 2013, 128, false, "350" },
                    { 2014, 128, false, "4 EV" },
                    { 2015, 128, false, "5" },
                    { 2016, 128, false, "550" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 2017, 128, false, "6" },
                    { 2018, 128, false, "6 Pro" },
                    { 2019, 128, false, "7" },
                    { 2020, 128, false, "750" },
                    { 2021, 128, false, "Cyberster" },
                    { 2022, 128, false, "F" },
                    { 2023, 128, false, "HS" },
                    { 2024, 128, false, "One" },
                    { 2025, 128, false, "RV8" },
                    { 2026, 128, false, "RX5" },
                    { 2027, 128, false, "T60" },
                    { 2028, 128, false, "TF" },
                    { 2029, 128, false, "Xpower SV" },
                    { 2030, 128, false, "ZR" },
                    { 2031, 128, false, "ZS" },
                    { 2032, 128, false, "ZT" },
                    { 2033, 129, false, "Cabrio" },
                    { 2034, 129, false, "Clubman" },
                    { 2035, 129, false, "Countryman" },
                    { 2036, 129, false, "Coupe" },
                    { 2037, 129, false, "Hatch" },
                    { 2038, 129, false, "Paceman" },
                    { 2039, 129, false, "Roadster" },
                    { 2040, 130, false, "3000 GT" },
                    { 2041, 130, false, "Airtrek" },
                    { 2042, 130, false, "Aspire" },
                    { 2043, 130, false, "ASX" },
                    { 2044, 130, false, "Attrage" },
                    { 2045, 130, false, "Carisma" },
                    { 2046, 130, false, "Challenger" },
                    { 2047, 130, false, "Chariot" },
                    { 2048, 130, false, "Colt" },
                    { 2049, 130, false, "Cordia" },
                    { 2050, 130, false, "Debonair" },
                    { 2051, 130, false, "Delica" },
                    { 2052, 130, false, "Delica D:5" },
                    { 2053, 130, false, "Diamante" },
                    { 2054, 130, false, "Dingo" },
                    { 2055, 130, false, "Dion" },
                    { 2056, 130, false, "Eclipse" },
                    { 2057, 130, false, "Eclipse Cross" },
                    { 2058, 130, false, "eK Wagon" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 2059, 130, false, "Emeraude" },
                    { 2060, 130, false, "Endeavor" },
                    { 2061, 130, false, "Eterna" },
                    { 2062, 130, false, "FTO" },
                    { 2063, 130, false, "Galant" },
                    { 2064, 130, false, "Grandis" },
                    { 2065, 130, false, "GTO" },
                    { 2066, 130, false, "i" },
                    { 2067, 130, false, "i-MiEV" },
                    { 2068, 130, false, "Jeep" },
                    { 2069, 130, false, "L200" },
                    { 2070, 130, false, "L300" },
                    { 2071, 130, false, "L400" },
                    { 2072, 130, false, "Lancer" },
                    { 2073, 130, false, "Lancer Evolution" },
                    { 2074, 130, false, "Legnum" },
                    { 2075, 130, false, "Libero" },
                    { 2076, 130, false, "Minica" },
                    { 2077, 130, false, "Minicab MiEV" },
                    { 2078, 130, false, "Mirage" },
                    { 2079, 130, false, "Montero" },
                    { 2080, 130, false, "Montero Sport" },
                    { 2081, 130, false, "Nativa" },
                    { 2082, 130, false, "Outlander" },
                    { 2083, 130, false, "Outlander Sport" },
                    { 2084, 130, false, "Pajero" },
                    { 2085, 130, false, "Pajero Evolution" },
                    { 2086, 130, false, "Pajerop iO" },
                    { 2087, 130, false, "Pajero Junior" },
                    { 2088, 130, false, "Pajero Mini" },
                    { 2089, 130, false, "Pajero Pinin" },
                    { 2090, 130, false, "Pajero Sport" },
                    { 2091, 130, false, "Proudia" },
                    { 2092, 130, false, "RVR" },
                    { 2093, 130, false, "Sapporo" },
                    { 2094, 130, false, "Sigma/Magna" },
                    { 2095, 130, false, "Space Gear" },
                    { 2096, 130, false, "Space Runner" },
                    { 2097, 130, false, "Space Star" },
                    { 2098, 130, false, "Space Wagon" },
                    { 2099, 130, false, "Starion" },
                    { 2100, 130, false, "Toppo" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 2101, 130, false, "Tredia" },
                    { 2102, 130, false, "Xpander" },
                    { 2103, 130, false, "Xpander Cross" },
                    { 2104, 130, false, "Zinger" },
                    { 2105, 131, false, "ES6" },
                    { 2106, 131, false, "ES7" },
                    { 2107, 131, false, "ES8" },
                    { 2108, 131, false, "ET7" },
                    { 2109, 132, false, "100NX" },
                    { 2110, 132, false, "180SX" },
                    { 2111, 132, false, "200SX" },
                    { 2112, 132, false, "240SX" },
                    { 2113, 132, false, "300ZX" },
                    { 2114, 132, false, "350ZX" },
                    { 2115, 132, false, "350Z" },
                    { 2116, 132, false, "370Z" },
                    { 2117, 132, false, "AD" },
                    { 2118, 132, false, "Almera" },
                    { 2119, 132, false, "Almera Classic" },
                    { 2120, 132, false, "Almera Tino" },
                    { 2121, 132, false, "Altima" },
                    { 2122, 132, false, "Ariya" },
                    { 2123, 132, false, "Armada" },
                    { 2124, 132, false, "Avenir" },
                    { 2125, 132, false, "Bassara" },
                    { 2126, 132, false, "Bluebird" },
                    { 2127, 132, false, "Caravan" },
                    { 2128, 132, false, "Cedric" },
                    { 2129, 132, false, "Cefiro" },
                    { 2130, 132, false, "Cherry" },
                    { 2131, 132, false, "Cima" },
                    { 2132, 132, false, "Crew" },
                    { 2133, 132, false, "Cube" },
                    { 2134, 132, false, "Datsun" },
                    { 2135, 132, false, "Dayz" },
                    { 2136, 132, false, "Elgrand" },
                    { 2137, 132, false, "Expert" },
                    { 2138, 132, false, "Fairlady Z" },
                    { 2139, 132, false, "Frontier" },
                    { 2140, 132, false, "Fuga" },
                    { 2141, 132, false, "Gloria" },
                    { 2142, 132, false, "GT-R" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 2143, 132, false, "Homy" },
                    { 2144, 132, false, "Juke" },
                    { 2145, 132, false, "Kicks" },
                    { 2146, 132, false, "Kubistar" },
                    { 2147, 132, false, "Lafesta" },
                    { 2148, 132, false, "Largo" },
                    { 2149, 132, false, "Latio" },
                    { 2150, 132, false, "Laurel" },
                    { 2151, 132, false, "Leaf" },
                    { 2152, 132, false, "Leopard" },
                    { 2153, 132, false, "Liberty" },
                    { 2154, 132, false, "Lucino" },
                    { 2155, 132, false, "March" },
                    { 2156, 132, false, "Maxima" },
                    { 2157, 132, false, "Micra" },
                    { 2158, 132, false, "Mistral" },
                    { 2159, 132, false, "Moco" },
                    { 2160, 132, false, "Murano" },
                    { 2161, 132, false, "Navara" },
                    { 2162, 132, false, "Note" },
                    { 2163, 132, false, "NP300" },
                    { 2164, 132, false, "NV100 Clipper" },
                    { 2165, 132, false, "NV200" },
                    { 2166, 132, false, "NV350" },
                    { 2167, 132, false, "Otti" },
                    { 2168, 132, false, "Pathfinder" },
                    { 2169, 132, false, "Patrol" },
                    { 2170, 132, false, "Pixo" },
                    { 2171, 132, false, "Prairie" },
                    { 2172, 132, false, "Prairie Joy" },
                    { 2173, 132, false, "Preage" },
                    { 2174, 132, false, "Presea" },
                    { 2175, 132, false, "President" },
                    { 2176, 132, false, "Primastar" },
                    { 2177, 132, false, "Primera" },
                    { 2178, 132, false, "Primera Camino" },
                    { 2179, 132, false, "Pulsar" },
                    { 2180, 132, false, "Qashqai" },
                    { 2181, 132, false, "Quest" },
                    { 2182, 132, false, "R'nessa" },
                    { 2183, 132, false, "Rasheen" },
                    { 2184, 132, false, "Rogue" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 2185, 132, false, "Roox" },
                    { 2186, 132, false, "Safari" },
                    { 2187, 132, false, "Sentra" },
                    { 2188, 132, false, "Serena" },
                    { 2189, 132, false, "Silvia" },
                    { 2190, 132, false, "Skyline" },
                    { 2191, 132, false, "Skyline Crossover" },
                    { 2192, 132, false, "Stagea" },
                    { 2193, 132, false, "Sunny" },
                    { 2194, 132, false, "Sylphy" },
                    { 2195, 132, false, "Teana" },
                    { 2196, 132, false, "Terra" },
                    { 2197, 132, false, "Terrano" },
                    { 2198, 132, false, "Tiida" },
                    { 2199, 132, false, "Tino" },
                    { 2200, 132, false, "Titan" },
                    { 2201, 132, false, "Urvan" },
                    { 2202, 132, false, "Vanette" },
                    { 2203, 132, false, "Versa" },
                    { 2204, 132, false, "Wingroad" },
                    { 2205, 132, false, "X-Terra" },
                    { 2206, 132, false, "X-Trail" },
                    { 2207, 132, false, "Xterra" },
                    { 2208, 133, false, "NV" },
                    { 2209, 134, false, "F200" },
                    { 2210, 135, false, "88" },
                    { 2211, 135, false, "Achieva" },
                    { 2212, 135, false, "Alero" },
                    { 2213, 135, false, "Aurora" },
                    { 2214, 135, false, "Bravada" },
                    { 2215, 135, false, "Custom Cruiser" },
                    { 2216, 135, false, "Cutlass" },
                    { 2217, 135, false, "Intrigue" },
                    { 2218, 135, false, "Silhouette" },
                    { 2219, 136, false, "C5" },
                    { 2220, 136, false, "S5" },
                    { 2221, 137, false, "Adam" },
                    { 2222, 137, false, "Agila" },
                    { 2223, 137, false, "Ampera" },
                    { 2224, 137, false, "Antara" },
                    { 2225, 137, false, "Arena" },
                    { 2226, 137, false, "Ascona" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 2227, 137, false, "Astra" },
                    { 2228, 137, false, "Cabrio" },
                    { 2229, 137, false, "Calibra" },
                    { 2230, 137, false, "Campo" },
                    { 2231, 137, false, "Cascada" },
                    { 2232, 137, false, "Combo" },
                    { 2233, 137, false, "Corsa" },
                    { 2234, 137, false, "Crossland" },
                    { 2235, 137, false, "Frontera" },
                    { 2236, 137, false, "Grandland X" },
                    { 2237, 137, false, "GT" },
                    { 2238, 137, false, "Insignia" },
                    { 2239, 137, false, "Kadett" },
                    { 2240, 137, false, "Karl" },
                    { 2241, 137, false, "Manta" },
                    { 2242, 137, false, "Meriva" },
                    { 2243, 137, false, "Mokka" },
                    { 2244, 137, false, "Monterey" },
                    { 2245, 137, false, "Movano" },
                    { 2246, 137, false, "Omega" },
                    { 2247, 137, false, "Rekord" },
                    { 2248, 137, false, "Senator" },
                    { 2249, 137, false, "Signum" },
                    { 2250, 137, false, "Sintra" },
                    { 2251, 137, false, "Speedster" },
                    { 2252, 137, false, "Tigra" },
                    { 2253, 137, false, "Vectra" },
                    { 2254, 137, false, "Vita" },
                    { 2255, 137, false, "Vivaro" },
                    { 2256, 137, false, "Zafira" },
                    { 2257, 137, false, "Zafira Life" },
                    { 2258, 138, false, "03" },
                    { 2259, 138, false, "Black Cat" },
                    { 2260, 138, false, "Good Cat" },
                    { 2261, 138, false, "Lightning Cat" },
                    { 2262, 138, false, "White Cat" },
                    { 2263, 139, false, "1007" },
                    { 2264, 139, false, "106" },
                    { 2265, 139, false, "107" },
                    { 2266, 139, false, "108" },
                    { 2267, 139, false, "2008" },
                    { 2268, 139, false, "205" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 2269, 139, false, "206" },
                    { 2270, 139, false, "207" },
                    { 2271, 139, false, "208" },
                    { 2272, 139, false, "3008" },
                    { 2273, 139, false, "301" },
                    { 2274, 139, false, "305" },
                    { 2275, 139, false, "306" },
                    { 2276, 139, false, "307" },
                    { 2277, 139, false, "308" },
                    { 2278, 139, false, "309" },
                    { 2279, 139, false, "4007" },
                    { 2280, 139, false, "4008" },
                    { 2281, 139, false, "405" },
                    { 2282, 139, false, "406" },
                    { 2283, 139, false, "407" },
                    { 2284, 139, false, "408" },
                    { 2285, 139, false, "5008" },
                    { 2286, 139, false, "505" },
                    { 2287, 139, false, "508" },
                    { 2288, 139, false, "605" },
                    { 2289, 139, false, "607" },
                    { 2290, 139, false, "806" },
                    { 2291, 139, false, "807" },
                    { 2292, 139, false, "Bipper" },
                    { 2293, 139, false, "Boxer" },
                    { 2294, 139, false, "e-2008" },
                    { 2295, 139, false, "Expert" },
                    { 2296, 139, false, "iOn" },
                    { 2297, 139, false, "Partner" },
                    { 2298, 139, false, "RCZ" },
                    { 2299, 139, false, "Rifter" },
                    { 2300, 139, false, "Traveller" },
                    { 2301, 140, false, "Acclaim" },
                    { 2302, 140, false, "Breeze" },
                    { 2303, 140, false, "Fury" },
                    { 2304, 140, false, "Laser" },
                    { 2305, 140, false, "Neon" },
                    { 2306, 140, false, "Prowler" },
                    { 2307, 140, false, "Sundance" },
                    { 2308, 140, false, "Voyager" },
                    { 2309, 141, false, "Jishi 01" },
                    { 2310, 142, false, "2" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 2311, 142, false, "3" },
                    { 2312, 142, false, "4" },
                    { 2313, 143, false, "6000" },
                    { 2314, 143, false, "Aztek" },
                    { 2315, 143, false, "Bonneville" },
                    { 2316, 143, false, "Catalina" },
                    { 2317, 143, false, "Fiero" },
                    { 2318, 143, false, "Firebird" },
                    { 2319, 143, false, "G3" },
                    { 2320, 143, false, "G4" },
                    { 2321, 143, false, "G5" },
                    { 2322, 143, false, "G6" },
                    { 2323, 143, false, "G8" },
                    { 2324, 143, false, "Grand Am" },
                    { 2325, 143, false, "Grand Prix" },
                    { 2326, 143, false, "GTO" },
                    { 2327, 143, false, "LeMans" },
                    { 2328, 143, false, "Montana" },
                    { 2329, 143, false, "Parisienne" },
                    { 2330, 143, false, "Phoenix" },
                    { 2331, 143, false, "Pursuit" },
                    { 2332, 143, false, "Solstice" },
                    { 2333, 143, false, "Sunbird" },
                    { 2334, 143, false, "Sunfire" },
                    { 2335, 143, false, "Torrent" },
                    { 2336, 143, false, "Trans Sport" },
                    { 2337, 143, false, "Vibe" },
                    { 2338, 144, false, "911" },
                    { 2339, 144, false, "918" },
                    { 2340, 144, false, "924" },
                    { 2341, 144, false, "928" },
                    { 2342, 144, false, "944" },
                    { 2343, 144, false, "968" },
                    { 2344, 144, false, "Boxster" },
                    { 2345, 144, false, "Carrera GT" },
                    { 2346, 144, false, "Cayenne" },
                    { 2347, 144, false, "Cayenne Coupe" },
                    { 2348, 144, false, "Cayman" },
                    { 2349, 144, false, "Macan" },
                    { 2350, 144, false, "Panamera" },
                    { 2351, 144, false, "Taycan" },
                    { 2352, 145, false, "Persona" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 2353, 146, false, "G" },
                    { 2354, 146, false, "Pinzgauer" },
                    { 2355, 147, false, "RD6" },
                    { 2356, 148, false, "1500" },
                    { 2357, 149, false, "Gentra" },
                    { 2358, 149, false, "Matiz" },
                    { 2359, 149, false, "Nexia R3" },
                    { 2360, 149, false, "R2" },
                    { 2361, 149, false, "R4" },
                    { 2362, 150, false, "11" },
                    { 2363, 150, false, "12" },
                    { 2364, 150, false, "14" },
                    { 2365, 150, false, "16" },
                    { 2366, 150, false, "18" },
                    { 2367, 150, false, "19" },
                    { 2368, 150, false, "20" },
                    { 2369, 150, false, "21" },
                    { 2370, 150, false, "25" },
                    { 2371, 150, false, "30" },
                    { 2372, 150, false, "5" },
                    { 2373, 150, false, "9" },
                    { 2374, 150, false, "Alaskan" },
                    { 2375, 150, false, "Arkana" },
                    { 2376, 150, false, "Avantime" },
                    { 2377, 150, false, "Captur" },
                    { 2378, 150, false, "City K-ZE" },
                    { 2379, 150, false, "Clio" },
                    { 2380, 150, false, "Dokker" },
                    { 2381, 150, false, "Duster" },
                    { 2382, 150, false, "Espace" },
                    { 2383, 150, false, "Express" },
                    { 2384, 150, false, "Fluence" },
                    { 2385, 150, false, "Fuego" },
                    { 2386, 150, false, "Grand Scenic" },
                    { 2387, 150, false, "Kadjar" },
                    { 2388, 150, false, "Kangoo" },
                    { 2389, 150, false, "Kaptur" },
                    { 2390, 150, false, "Koleos" },
                    { 2391, 150, false, "Kwid" },
                    { 2392, 150, false, "Laguna" },
                    { 2393, 150, false, "Latitude" },
                    { 2394, 150, false, "Lodgy" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 2395, 150, false, "Logan" },
                    { 2396, 150, false, "Logan Stepway" },
                    { 2397, 150, false, "Mascott" },
                    { 2398, 150, false, "Master" },
                    { 2399, 150, false, "Megane" },
                    { 2400, 150, false, "Modus" },
                    { 2401, 150, false, "Rapid" },
                    { 2402, 150, false, "Safrane" },
                    { 2403, 150, false, "Sandero" },
                    { 2404, 150, false, "Sandero Stepway" },
                    { 2405, 150, false, "Scenic" },
                    { 2406, 150, false, "Symbol" },
                    { 2407, 150, false, "Talisman" },
                    { 2408, 150, false, "Trafic" },
                    { 2409, 150, false, "Twingo" },
                    { 2410, 150, false, "Twizy" },
                    { 2411, 150, false, "Vel Satis" },
                    { 2412, 150, false, "Wind" },
                    { 2413, 150, false, "Zoe" },
                    { 2414, 151, false, "QM3" },
                    { 2415, 151, false, "QM5" },
                    { 2416, 151, false, "QM6" },
                    { 2417, 151, false, "SM3" },
                    { 2418, 151, false, "SM5" },
                    { 2419, 151, false, "SM6" },
                    { 2420, 151, false, "SM7" },
                    { 2421, 151, false, "XM3" },
                    { 2422, 152, false, "R1S" },
                    { 2423, 152, false, "R1T" },
                    { 2424, 153, false, "i5" },
                    { 2425, 153, false, "Marvel X" },
                    { 2426, 153, false, "RX5" },
                    { 2427, 154, false, "Corniche" },
                    { 2428, 154, false, "Cullinan" },
                    { 2429, 154, false, "Dawn" },
                    { 2430, 154, false, "Ghost" },
                    { 2431, 154, false, "Park Ward" },
                    { 2432, 154, false, "Phantom" },
                    { 2433, 154, false, "Silver Cloud" },
                    { 2434, 154, false, "Silver Seraph" },
                    { 2435, 154, false, "Silver Shadow" },
                    { 2436, 154, false, "Silver Spirit" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 2437, 154, false, "Silver Spur" },
                    { 2438, 154, false, "Spectre" },
                    { 2439, 154, false, "Wraith" },
                    { 2440, 155, false, "200 Series" },
                    { 2441, 155, false, "25" },
                    { 2442, 155, false, "400 Series" },
                    { 2443, 155, false, "45" },
                    { 2444, 155, false, "600 Series" },
                    { 2445, 155, false, "75" },
                    { 2446, 155, false, "800 Series" },
                    { 2447, 155, false, "CityRover" },
                    { 2448, 155, false, "Maestro" },
                    { 2449, 155, false, "Metro" },
                    { 2450, 155, false, "Mini" },
                    { 2451, 155, false, "Montego" },
                    { 2452, 155, false, "Streetwise" },
                    { 2453, 156, false, "01" },
                    { 2454, 157, false, "9-2X" },
                    { 2455, 157, false, "9-3" },
                    { 2456, 157, false, "9-5" },
                    { 2457, 157, false, "9-7X" },
                    { 2458, 157, false, "90" },
                    { 2459, 157, false, "900" },
                    { 2460, 157, false, "9000" },
                    { 2461, 157, false, "99" },
                    { 2462, 158, false, "Maxus Dana V1" },
                    { 2463, 158, false, "Maxus EUNIQ 5" },
                    { 2464, 158, false, "Maxus V80" },
                    { 2465, 159, false, "PS-10" },
                    { 2466, 160, false, "Astra" },
                    { 2467, 160, false, "Aura" },
                    { 2468, 160, false, "Ion" },
                    { 2469, 160, false, "L-Series" },
                    { 2470, 160, false, "Outlook" },
                    { 2471, 160, false, "Relay" },
                    { 2472, 160, false, "S-Series" },
                    { 2473, 160, false, "Sky" },
                    { 2474, 160, false, "Vue" },
                    { 2475, 161, false, "Citigo" },
                    { 2476, 161, false, "Enyaq" },
                    { 2477, 161, false, "Fabia" },
                    { 2478, 161, false, "Favorit" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 2479, 161, false, "Felicia" },
                    { 2480, 161, false, "Forman" },
                    { 2481, 161, false, "Kamiq" },
                    { 2482, 161, false, "Karoq" },
                    { 2483, 161, false, "Kodiaq" },
                    { 2484, 161, false, "Octavia" },
                    { 2485, 161, false, "Rapid" },
                    { 2486, 161, false, "Roomster" },
                    { 2487, 161, false, "Scala" },
                    { 2488, 161, false, "Superb" },
                    { 2489, 161, false, "Yeti" },
                    { 2490, 162, false, "EQ" },
                    { 2491, 162, false, "Forfour" },
                    { 2492, 162, false, "Fortwo" },
                    { 2493, 163, false, "DX3" },
                    { 2494, 163, false, "DX5" },
                    { 2495, 163, false, "DX7" },
                    { 2496, 163, false, "DX9" },
                    { 2497, 163, false, "V3 Lingyue" },
                    { 2498, 163, false, "V5 Lingzhi" },
                    { 2499, 163, false, "V6 Lingshi" },
                    { 2500, 163, false, "V7 Lingzhi" },
                    { 2501, 163, false, "V9 Lingzhi" },
                    { 2502, 164, false, "2" },
                    { 2503, 165, false, "Actyon" },
                    { 2504, 165, false, "Chairman" },
                    { 2505, 165, false, "Istana" },
                    { 2506, 165, false, "Korando" },
                    { 2507, 165, false, "Kyron" },
                    { 2508, 165, false, "Musso" },
                    { 2509, 165, false, "Rexton" },
                    { 2510, 165, false, "Rodius" },
                    { 2511, 165, false, "Stavic" },
                    { 2512, 165, false, "Tivoli" },
                    { 2513, 165, false, "XLV" },
                    { 2514, 166, false, "1000" },
                    { 2515, 166, false, "1400" },
                    { 2516, 166, false, "1600" },
                    { 2517, 166, false, "1800" },
                    { 2518, 166, false, "360" },
                    { 2519, 166, false, "600" },
                    { 2520, 166, false, "Alcyone" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 2521, 166, false, "Ascent" },
                    { 2522, 166, false, "Baja" },
                    { 2523, 166, false, "BRZ" },
                    { 2524, 166, false, "BRZ tS" },
                    { 2525, 166, false, "Crosstrek" },
                    { 2526, 166, false, "Dex" },
                    { 2527, 166, false, "Dias Wagon" },
                    { 2528, 166, false, "Domingo" },
                    { 2529, 166, false, "Exiga" },
                    { 2530, 166, false, "Forester" },
                    { 2531, 166, false, "Impreza" },
                    { 2532, 166, false, "Impreza WRX" },
                    { 2533, 166, false, "Impreza WRX STI" },
                    { 2534, 166, false, "Justy" },
                    { 2535, 166, false, "Legacy" },
                    { 2536, 166, false, "Leone" },
                    { 2537, 166, false, "Levorg" },
                    { 2538, 166, false, "Libero" },
                    { 2539, 166, false, "Outback" },
                    { 2540, 166, false, "Pleo" },
                    { 2541, 166, false, "R1" },
                    { 2542, 166, false, "R2" },
                    { 2543, 166, false, "Rex" },
                    { 2544, 166, false, "Sambar" },
                    { 2545, 166, false, "Stella" },
                    { 2546, 166, false, "SVX" },
                    { 2547, 166, false, "Traviq" },
                    { 2548, 166, false, "Tribeca" },
                    { 2549, 166, false, "Viziv" },
                    { 2550, 166, false, "WRX" },
                    { 2551, 166, false, "WRX STI" },
                    { 2552, 166, false, "XV" },
                    { 2553, 167, false, "Alto" },
                    { 2554, 167, false, "APV" },
                    { 2555, 167, false, "Baleno" },
                    { 2556, 167, false, "Cappuccino" },
                    { 2557, 167, false, "Carry" },
                    { 2558, 167, false, "Celerio" },
                    { 2559, 167, false, "Cervo" },
                    { 2560, 167, false, "Cultus" },
                    { 2561, 167, false, "Ertiga" },
                    { 2562, 167, false, "Escudo" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 2563, 167, false, "Every" },
                    { 2564, 167, false, "Forenza" },
                    { 2565, 167, false, "Fronte" },
                    { 2566, 167, false, "Grand Vitara" },
                    { 2567, 167, false, "Ignis" },
                    { 2568, 167, false, "Jimny" },
                    { 2569, 167, false, "Kizashi" },
                    { 2570, 167, false, "Lapin" },
                    { 2571, 167, false, "Liana" },
                    { 2572, 167, false, "MR Wagon" },
                    { 2573, 167, false, "Reno" },
                    { 2574, 167, false, "Samurai" },
                    { 2575, 167, false, "Sidekick" },
                    { 2576, 167, false, "Solio" },
                    { 2577, 167, false, "Splash" },
                    { 2578, 167, false, "Swift" },
                    { 2579, 167, false, "SX4" },
                    { 2580, 167, false, "Twin" },
                    { 2581, 167, false, "Vitara" },
                    { 2582, 167, false, "Wagon R" },
                    { 2583, 167, false, "X-90" },
                    { 2584, 167, false, "XL7" },
                    { 2585, 168, false, "Tiger" },
                    { 2586, 169, false, "300" },
                    { 2587, 169, false, "400" },
                    { 2588, 169, false, "500" },
                    { 2589, 169, false, "700" },
                    { 2590, 170, false, "Cybertruck" },
                    { 2591, 170, false, "Model 3" },
                    { 2592, 170, false, "Model S" },
                    { 2593, 170, false, "Model X" },
                    { 2594, 170, false, "Model Y" },
                    { 2595, 170, false, "Roadster" },
                    { 2596, 171, false, "4Runner" },
                    { 2597, 171, false, "86" },
                    { 2598, 171, false, "Allion" },
                    { 2599, 171, false, "Alphard" },
                    { 2600, 171, false, "Altezza" },
                    { 2601, 171, false, "Aristo" },
                    { 2602, 171, false, "Aurion" },
                    { 2603, 171, false, "Auris" },
                    { 2604, 171, false, "Avalon" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 2605, 171, false, "Avanza" },
                    { 2606, 171, false, "Avensis" },
                    { 2607, 171, false, "Aygo" },
                    { 2608, 171, false, "bB" },
                    { 2609, 171, false, "Belta" },
                    { 2610, 171, false, "Blade" },
                    { 2611, 171, false, "Brevis" },
                    { 2612, 171, false, "C-HR" },
                    { 2613, 171, false, "Caldina" },
                    { 2614, 171, false, "Camry" },
                    { 2615, 171, false, "Carina" },
                    { 2616, 171, false, "Carina E" },
                    { 2617, 171, false, "Cavalier" },
                    { 2618, 171, false, "Celica" },
                    { 2619, 171, false, "Celsior" },
                    { 2620, 171, false, "Century" },
                    { 2621, 171, false, "Chaser" },
                    { 2622, 171, false, "Coaster" },
                    { 2623, 171, false, "Comfort" },
                    { 2624, 171, false, "Corolla" },
                    { 2625, 171, false, "Corona" },
                    { 2626, 171, false, "Corsa" },
                    { 2627, 171, false, "Cressida" },
                    { 2628, 171, false, "Cresta" },
                    { 2629, 171, false, "Crown" },
                    { 2630, 171, false, "Curren" },
                    { 2631, 171, false, "Cynos" },
                    { 2632, 171, false, "Duet" },
                    { 2633, 171, false, "Dyna" },
                    { 2634, 171, false, "Echo" },
                    { 2635, 171, false, "Estima" },
                    { 2636, 171, false, "FJ Cruiser" },
                    { 2637, 171, false, "Fortuner" },
                    { 2638, 171, false, "Fun Cargo" },
                    { 2639, 171, false, "Gaia" },
                    { 2640, 171, false, "Granvia" },
                    { 2641, 171, false, "Harrier" },
                    { 2642, 171, false, "Hiace" },
                    { 2643, 171, false, "Highlander" },
                    { 2644, 171, false, "Hilux" },
                    { 2645, 171, false, "Innova" },
                    { 2646, 171, false, "Ipsum" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 2647, 171, false, "iQ" },
                    { 2648, 171, false, "Isis" },
                    { 2649, 171, false, "Ist" },
                    { 2650, 171, false, "Kluger" },
                    { 2651, 171, false, "Land Cruiser" },
                    { 2652, 171, false, "LiteAce" },
                    { 2653, 171, false, "Mark II" },
                    { 2654, 171, false, "Mark X" },
                    { 2655, 171, false, "MasterAce" },
                    { 2656, 171, false, "Matrix" },
                    { 2657, 171, false, "Mirai" },
                    { 2658, 171, false, "MR2" },
                    { 2659, 171, false, "Nadia" },
                    { 2660, 171, false, "Noah" },
                    { 2661, 171, false, "Opa" },
                    { 2662, 171, false, "Paseo" },
                    { 2663, 171, false, "Passo" },
                    { 2664, 171, false, "Picnic" },
                    { 2665, 171, false, "Platz" },
                    { 2666, 171, false, "Porte" },
                    { 2667, 171, false, "Premio" },
                    { 2668, 171, false, "Previa" },
                    { 2669, 171, false, "Prius" },
                    { 2670, 171, false, "ProAce" },
                    { 2671, 171, false, "Probox" },
                    { 2672, 171, false, "Progres" },
                    { 2673, 171, false, "Pronard" },
                    { 2674, 171, false, "Publica" },
                    { 2675, 171, false, "Quantum" },
                    { 2676, 171, false, "Ractis" },
                    { 2677, 171, false, "Raum" },
                    { 2678, 171, false, "RAV4" },
                    { 2679, 171, false, "RegiusAce" },
                    { 2680, 171, false, "Reiz" },
                    { 2681, 171, false, "Rukus" },
                    { 2682, 171, false, "Rush" },
                    { 2683, 171, false, "SAI" },
                    { 2684, 171, false, "Sequoia" },
                    { 2685, 171, false, "Sera" },
                    { 2686, 171, false, "Sienna" },
                    { 2687, 171, false, "Sienta" },
                    { 2688, 171, false, "Soarer" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 2689, 171, false, "Solara" },
                    { 2690, 171, false, "Soluna" },
                    { 2691, 171, false, "Space Cruiser" },
                    { 2692, 171, false, "Sparky" },
                    { 2693, 171, false, "Sprinter" },
                    { 2694, 171, false, "Stallion" },
                    { 2695, 171, false, "Starlet" },
                    { 2696, 171, false, "Succeed" },
                    { 2697, 171, false, "Supra" },
                    { 2698, 171, false, "T100" },
                    { 2699, 171, false, "Tacoma" },
                    { 2700, 171, false, "Tamaraw" },
                    { 2701, 171, false, "Tarago" },
                    { 2702, 171, false, "Tercel" },
                    { 2703, 171, false, "TownAce" },
                    { 2704, 171, false, "Tundra" },
                    { 2705, 171, false, "Urban Cruiser" },
                    { 2706, 171, false, "Vanguard" },
                    { 2707, 171, false, "Vellfire" },
                    { 2708, 171, false, "Venza" },
                    { 2709, 171, false, "Verossa" },
                    { 2710, 171, false, "Verso" },
                    { 2711, 171, false, "Vios" },
                    { 2712, 171, false, "Vista" },
                    { 2713, 171, false, "Vitz" },
                    { 2714, 171, false, "Voltz" },
                    { 2715, 171, false, "Voxy" },
                    { 2716, 171, false, "Will" },
                    { 2717, 171, false, "Windom" },
                    { 2718, 171, false, "Wish" },
                    { 2719, 171, false, "Yaris" },
                    { 2720, 171, false, "Yaris Cross" },
                    { 2721, 172, false, "Amarok" },
                    { 2722, 172, false, "Arteon" },
                    { 2723, 172, false, "Atlas" },
                    { 2724, 172, false, "Beetle" },
                    { 2725, 172, false, "Bora" },
                    { 2726, 172, false, "Caddy" },
                    { 2727, 172, false, "Caravelle" },
                    { 2728, 172, false, "CC" },
                    { 2729, 172, false, "Corrado" },
                    { 2730, 172, false, "Crafter" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 2731, 172, false, "CrossFox" },
                    { 2732, 172, false, "Eos" },
                    { 2733, 172, false, "Fox" },
                    { 2734, 172, false, "Gol" },
                    { 2735, 172, false, "Golf" },
                    { 2736, 172, false, "ID.3" },
                    { 2737, 172, false, "ID.4" },
                    { 2738, 172, false, "ID.5" },
                    { 2739, 172, false, "ID.6" },
                    { 2740, 172, false, "Jetta" },
                    { 2741, 172, false, "Karmann Ghia" },
                    { 2742, 172, false, "Lavida" },
                    { 2743, 172, false, "LT" },
                    { 2744, 172, false, "Lupo" },
                    { 2745, 172, false, "Multivan" },
                    { 2746, 172, false, "Passat" },
                    { 2747, 172, false, "Phaeton" },
                    { 2748, 172, false, "Pointer" },
                    { 2749, 172, false, "Polo" },
                    { 2750, 172, false, "Quantum" },
                    { 2751, 172, false, "Routan" },
                    { 2752, 172, false, "Santana" },
                    { 2753, 172, false, "Scirocco" },
                    { 2754, 172, false, "Sharan" },
                    { 2755, 172, false, "T-Cross" },
                    { 2756, 172, false, "T-Roc" },
                    { 2757, 172, false, "Taigun" },
                    { 2758, 172, false, "Taro" },
                    { 2759, 172, false, "Teramont" },
                    { 2760, 172, false, "Tiguan" },
                    { 2761, 172, false, "Touareg" },
                    { 2762, 172, false, "Touran" },
                    { 2763, 172, false, "Transporter" },
                    { 2764, 172, false, "Up" },
                    { 2765, 172, false, "Vento" },
                    { 2766, 173, false, "140" },
                    { 2767, 173, false, "164" },
                    { 2768, 173, false, "240" },
                    { 2769, 173, false, "260" },
                    { 2770, 173, false, "340" },
                    { 2771, 173, false, "360" },
                    { 2772, 173, false, "440" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 2773, 173, false, "460" },
                    { 2774, 173, false, "480" },
                    { 2775, 173, false, "66" },
                    { 2776, 173, false, "740" },
                    { 2777, 173, false, "760" },
                    { 2778, 173, false, "780" },
                    { 2779, 173, false, "850" },
                    { 2780, 173, false, "940" },
                    { 2781, 173, false, "960" },
                    { 2782, 173, false, "C30" },
                    { 2783, 173, false, "C70" },
                    { 2784, 173, false, "C90" },
                    { 2785, 173, false, "P1800" },
                    { 2786, 173, false, "P1900" },
                    { 2787, 173, false, "PV" },
                    { 2788, 173, false, "S40" },
                    { 2789, 173, false, "S60" },
                    { 2790, 173, false, "S70" },
                    { 2791, 173, false, "S80" },
                    { 2792, 173, false, "S90" },
                    { 2793, 173, false, "V40" },
                    { 2794, 173, false, "V50" },
                    { 2795, 173, false, "V60" },
                    { 2796, 173, false, "V70" },
                    { 2797, 173, false, "V90" },
                    { 2798, 173, false, "XC40" },
                    { 2799, 173, false, "XC60" },
                    { 2800, 173, false, "XC70" },
                    { 2801, 173, false, "XC90" },
                    { 2802, 174, false, "Chasing Light" },
                    { 2803, 174, false, "Dream" },
                    { 2804, 174, false, "Free" },
                    { 2805, 174, false, "i-Free" },
                    { 2806, 174, false, "i-Land" },
                    { 2807, 174, false, "i-SPACE" },
                    { 2808, 174, false, "i-V6" },
                    { 2809, 174, false, "i-V7" },
                    { 2810, 174, false, "i-V9" },
                    { 2811, 174, false, "i-Venture" },
                    { 2812, 174, false, "i-Wild" },
                    { 2813, 175, false, "SU7" },
                    { 2814, 176, false, "001" }
                });

            migrationBuilder.InsertData(
                table: "ModelCars",
                columns: new[] { "Id", "CarId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 2815, 176, false, "007" },
                    { 2816, 176, false, "009" },
                    { 2817, 176, false, "7X" },
                    { 2818, 176, false, "X" },
                    { 2819, 177, false, "1111 Ока" },
                    { 2820, 177, false, "2101" },
                    { 2821, 177, false, "2102" },
                    { 2822, 177, false, "2103" },
                    { 2823, 177, false, "2104" },
                    { 2824, 177, false, "2105" },
                    { 2825, 177, false, "2106" },
                    { 2826, 177, false, "2107" },
                    { 2827, 177, false, "2108" },
                    { 2828, 177, false, "2109" },
                    { 2829, 177, false, "21099" },
                    { 2830, 177, false, "2110" },
                    { 2831, 177, false, "2111" },
                    { 2832, 177, false, "2112" },
                    { 2833, 177, false, "2113" },
                    { 2834, 177, false, "2114" },
                    { 2835, 177, false, "2115" },
                    { 2836, 177, false, "2120 Надежда" },
                    { 2837, 177, false, "2121 (4x4)" },
                    { 2838, 177, false, "Lada 2121" },
                    { 2839, 177, false, "Lada 2131 (5-ти дверный)" },
                    { 2840, 177, false, "2123" },
                    { 2841, 177, false, "" }
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
