using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChildrenCare.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppParameters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppParameters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    IsPotentialCustomer = table.Column<bool>(type: "bit", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BriefInfo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Price = table.Column<long>(type: "bigint", nullable: false),
                    SalePrice = table.Column<long>(type: "bigint", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ThumbnailUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    BackLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThumbnailUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
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
                    UserId = table.Column<int>(type: "int", nullable: false),
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
                    UserId = table.Column<int>(type: "int", nullable: false)
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
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
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
                    UserId = table.Column<int>(type: "int", nullable: false),
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
                name: "Prescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerAccountId = table.Column<int>(type: "int", nullable: false),
                    AuthorAccountId = table.Column<int>(type: "int", nullable: false),
                    PrescriptionContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prescriptions_AspNetUsers_AuthorAccountId",
                        column: x => x.AuthorAccountId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prescriptions_AspNetUsers_CustomerAccountId",
                        column: x => x.CustomerAccountId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorUserId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Tittle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    BriefInfo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Status = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    BlogBody = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThumbnailUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blogs_AspNetUsers_AuthorUserId",
                        column: x => x.AuthorUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Blogs_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StaffSpecializations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffId = table.Column<int>(type: "int", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffSpecializations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StaffSpecializations_AspNetUsers_StaffId",
                        column: x => x.StaffId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StaffSpecializations_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerAccountId = table.Column<int>(type: "int", nullable: false),
                    PrescriptionId = table.Column<int>(type: "int", nullable: true),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CustomerGender = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TotalBasePrice = table.Column<long>(type: "bigint", nullable: false),
                    ActualTotalPrice = table.Column<long>(type: "bigint", nullable: false),
                    PreservedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_AspNetUsers_CustomerAccountId",
                        column: x => x.CustomerAccountId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservations_Prescriptions_PrescriptionId",
                        column: x => x.PrescriptionId,
                        principalTable: "Prescriptions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ReservationDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationId = table.Column<int>(type: "int", nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: true),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    NumberOfPeople = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    BasePrice = table.Column<long>(type: "bigint", nullable: false),
                    SalePrice = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReservationDetails_AspNetUsers_StaffId",
                        column: x => x.StaffId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReservationDetails_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationDetails_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FeedBacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationServiceId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Star = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedBacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeedBacks_ReservationDetails_ReservationServiceId",
                        column: x => x.ReservationServiceId,
                        principalTable: "ReservationDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AppParameters",
                columns: new[] { "Id", "Description", "DisplayName", "Name", "Type", "Value" },
                values: new object[,]
                {
                    { 1, "Status that a user account has when it's active", "Active", "Active User Status Id", 1, "" },
                    { 2, "Status that a user account has when it's not active", "Inactive", "Inactive User Status Id", 1, "" },
                    { 3, "Status that a service has when it's active", "Active", "Active Service Status Id", 2, "" },
                    { 4, "Status that a service has when it's not active", "Inactive", "Inactive Service Status Id", 2, "" },
                    { 5, "Status that a service will have when it's created", "New Service Status Id", "New Service Status Id", 2, "3" },
                    { 6, "Status that a blog has when it's active", "Active", "Active Blog Status Id", 3, "" },
                    { 7, "Status that a blog has when it's not active", "Inactive", "Inactive Blog Status Id", 3, "" },
                    { 8, "Status that a blog will have when it's created", "New Blog Status Id", "New Blog Status Id", 3, "6" },
                    { 9, "Status that a reservation will have when it's created by customer", "Submitted", "Submitted Reservation Status Id", 4, "" },
                    { 10, "Status that a reservation will have when it's approved by manager", "Approved", "Approved Reservation Status Id", 4, "" },
                    { 11, "Status that a reservation will have when it's marked success by manager", "Success", "Success Reservation Status Id", 4, "" },
                    { 12, "Status that a reservation will have when it's cancelled by customer or manager", "Cancelled", "Cancelled Reservation Status Id", 4, "" },
                    { 13, "Status that a Slider has when it's active", "Active", "Active Slider Status Id", 5, "" },
                    { 14, "Status that a Slider has when it's not active", "Inactive", "Inactive Slider Status Id", 5, "" },
                    { 15, "Status that a Slider will have when it's created", "New Slider Status Id", "New Slider Status Id", 5, "13" },
                    { 16, "Status that a Reservation will have when it's created but not submitted by customer", "Draft", "Draft Reservation Status Id", 4, "" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "17cf3f18-16f3-4940-ab5b-c19827383cef", "admin", "ADMIN" },
                    { 2, "db3eb56e-5f1b-4337-99a7-a979c14b20a3", "manager", "MANAGER" },
                    { 3, "eb93c415-1601-411b-a9bd-cf1729822eb9", "doctor", "DOCTOR" },
                    { 4, "e800b099-6500-4357-b8c5-7a3cac71106f", "nurse", "NURSE" },
                    { 5, "66c142b1-48a8-4630-baf9-753c50de9758", "customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "Gender", "IsPotentialCustomer", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "1980e87d-2598-4548-b9a8-f78818d687d7", "doctor1@gmail.com", true, "Doctor 1", true, false, false, null, "DOCTOR1@GMAIL.COM", "DOCTOR1@GMAIL.COM", "AQAAAAEAACcQAAAAEGd0+eWoiCIzUIjCGM6x0nuxNzgcfiRNj6zfyYnSfim2h3tuzvYAjo9gymyJD7uCgg==", "1234567890", true, null, false, "doctor1@gmail.com" },
                    { 2, 0, "cdc87c67-985c-4d72-a14f-4f7599401d65", "doctor2@gmail.com", true, "Doctor 2", true, false, false, null, "DOCTOR2@GMAIL.COM", "DOCTOR2@GMAIL.COM", "AQAAAAEAACcQAAAAEGd0+eWoiCIzUIjCGM6x0nuxNzgcfiRNj6zfyYnSfim2h3tuzvYAjo9gymyJD7uCgg==", "1234567890", true, null, false, "doctor2@gmail.com" },
                    { 3, 0, "dbeca50f-90f7-4312-a3b4-671f6dbef976", "doctor3@gmail.com", true, "Doctor 3", true, false, false, null, "DOCTOR3@GMAIL.COM", "DOCTOR3@GMAIL.COM", "AQAAAAEAACcQAAAAEGd0+eWoiCIzUIjCGM6x0nuxNzgcfiRNj6zfyYnSfim2h3tuzvYAjo9gymyJD7uCgg==", "1234567890", true, null, false, "doctor3@gmail.com" },
                    { 4, 0, "b9a201ef-a5da-4d05-81b0-53fbd7f0ca99", "nurse1@gmail.com", true, "Nurse 1", true, false, false, null, "NURSE1@GMAIL.COM", "NURSE1@GMAIL.COM", "AQAAAAEAACcQAAAAEGd0+eWoiCIzUIjCGM6x0nuxNzgcfiRNj6zfyYnSfim2h3tuzvYAjo9gymyJD7uCgg==", "1234567890", true, null, false, "nurse1@gmail.com" },
                    { 5, 0, "166648c7-ae8d-4b58-b252-81a3593ee66d", "nurse2@gmail.com", true, "Nurse 2", true, false, false, null, "NURSE2@GMAIL.COM", "NURSE2@GMAIL.COM", "AQAAAAEAACcQAAAAEGd0+eWoiCIzUIjCGM6x0nuxNzgcfiRNj6zfyYnSfim2h3tuzvYAjo9gymyJD7uCgg==", "1234567890", true, null, false, "nurse2@gmail.com" },
                    { 6, 0, "346f2653-0005-48ca-8f68-2581fd64f815", "nurse3@gmail.com", true, "Nurse 3", true, false, false, null, "NURSE3@GMAIL.COM", "NURSE3@GMAIL.COM", "AQAAAAEAACcQAAAAEGd0+eWoiCIzUIjCGM6x0nuxNzgcfiRNj6zfyYnSfim2h3tuzvYAjo9gymyJD7uCgg==", "1234567890", true, null, false, "nurse3@gmail.com" },
                    { 7, 0, "36457045-c08b-4be8-8c5e-0510b972e26f", "admin1@gmail.com", true, "Admin 1", true, false, false, null, "ADMIN1@GMAIL.COM", "ADMIN1@GMAIL.COM", "AQAAAAEAACcQAAAAEGd0+eWoiCIzUIjCGM6x0nuxNzgcfiRNj6zfyYnSfim2h3tuzvYAjo9gymyJD7uCgg==", "1234567890", true, null, false, "admin1@gmail.com" },
                    { 8, 0, "d8735d32-7c47-4a93-be5b-22321ff741f0", "manager1@gmail.com", true, "Manager 1", true, false, false, null, "MANAGER1@GMAIL.COM", "MANAGER1@GMAIL.COM", "AQAAAAEAACcQAAAAEGd0+eWoiCIzUIjCGM6x0nuxNzgcfiRNj6zfyYnSfim2h3tuzvYAjo9gymyJD7uCgg==", "1234567890", true, null, false, "manager1@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Cardiology" },
                    { 2, "Neurology" },
                    { 3, "News" },
                    { 4, "Opinion" },
                    { 5, "Scientific Paper" },
                    { 6, "Advertisement" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "BriefInfo", "CreatedDate", "Description", "IsFeatured", "LastUpdated", "Name", "Price", "SalePrice", "Status", "ThumbnailUrl" },
                values: new object[,]
                {
                    { 1, "Treatment of disorders of the heart and the blood vessels", new DateTime(2022, 7, 7, 21, 51, 16, 804, DateTimeKind.Local).AddTicks(8651), "Cardiology is a branch of internal medicine. A cardiologist is not the same as a cardiac surgeon. \r\n                A cardiac surgeon opens the chest and performs heart surgery.\r\n                A cardiologist specializes in diagnosing and treating diseases of the cardiovascular system.The cardiologist will carry out tests,\r\n                and they may perform some procedures,\r\n                such as heart catheterizations,\r\n                angioplasty,\r\n                or inserting a pacemaker.\r\n                Heart disease relates specifically to the heart, while cardiovascular disease affects the heart, the blood vessels, or both.\r\n                To become a cardiologist in the United States, it is necessary to complete 4 years of medical school, 3 years of training in internal medicine, and at least 3 years specializing in cardiology.", false, new DateTime(2022, 7, 7, 21, 51, 16, 804, DateTimeKind.Local).AddTicks(8659), "Cardiology", 250000L, 200000L, 1, "https://placeimg.com/500/500/tech" },
                    { 2, "BriefInfo of Surgery", new DateTime(2022, 7, 7, 21, 51, 16, 804, DateTimeKind.Local).AddTicks(8660), "Long Description of Surgery", false, new DateTime(2022, 7, 7, 21, 51, 16, 804, DateTimeKind.Local).AddTicks(8661), "Surgery", 300000L, 250000L, 1, "https://placeimg.com/500/500/tech" },
                    { 3, "BriefInfo of General Examination", new DateTime(2022, 7, 7, 21, 51, 16, 804, DateTimeKind.Local).AddTicks(8662), "Long Description of General Examination", false, new DateTime(2022, 7, 7, 21, 51, 16, 804, DateTimeKind.Local).AddTicks(8663), "General Examination", 500000L, 400000L, 1, "https://placeimg.com/500/500/tech" },
                    { 4, "BriefInfo of Diagnosis", new DateTime(2022, 7, 7, 21, 51, 16, 804, DateTimeKind.Local).AddTicks(8664), "Long Description of Diagnosis", false, new DateTime(2022, 7, 7, 21, 51, 16, 804, DateTimeKind.Local).AddTicks(8664), "Diagnosis", 100000L, 80000L, 1, "https://placeimg.com/500/500/tech" },
                    { 5, "BriefInfo of Digital Testing", new DateTime(2022, 7, 7, 21, 51, 16, 804, DateTimeKind.Local).AddTicks(8666), "Long Description of Digital Testing", false, new DateTime(2022, 7, 7, 21, 51, 16, 804, DateTimeKind.Local).AddTicks(8667), "Digital Testing", 100000L, 80000L, 1, "https://placeimg.com/500/500/tech" },
                    { 6, "BriefInfo of Fake Service", new DateTime(2022, 7, 7, 21, 51, 16, 804, DateTimeKind.Local).AddTicks(8668), "Long Description of Fake Service", false, new DateTime(2022, 7, 7, 21, 51, 16, 804, DateTimeKind.Local).AddTicks(8668), "Fake Service", 999999999L, 999999L, 2, "https://placeimg.com/500/500/tech" }
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
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_AuthorUserId",
                table: "Blogs",
                column: "AuthorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_CategoryId",
                table: "Blogs",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FeedBacks_ReservationServiceId",
                table: "FeedBacks",
                column: "ReservationServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_AuthorAccountId",
                table: "Prescriptions",
                column: "AuthorAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_CustomerAccountId",
                table: "Prescriptions",
                column: "CustomerAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationDetails_ReservationId",
                table: "ReservationDetails",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationDetails_ServiceId",
                table: "ReservationDetails",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationDetails_StaffId",
                table: "ReservationDetails",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_CustomerAccountId",
                table: "Reservations",
                column: "CustomerAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_PrescriptionId",
                table: "Reservations",
                column: "PrescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffSpecializations_ServiceId",
                table: "StaffSpecializations",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffSpecializations_StaffId",
                table: "StaffSpecializations",
                column: "StaffId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppParameters");

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
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "FeedBacks");

            migrationBuilder.DropTable(
                name: "Sliders");

            migrationBuilder.DropTable(
                name: "StaffSpecializations");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "ReservationDetails");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Prescriptions");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
