using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ViperMedix.WebAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActiveSubstances",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Substance = table.Column<string>(maxLength: 512, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActiveSubstances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ObjectKey = table.Column<string>(maxLength: 25, nullable: false),
                    RoadTypeId = table.Column<int>(nullable: false),
                    AddressTypeId = table.Column<int>(nullable: false),
                    Street = table.Column<string>(maxLength: 20, nullable: false),
                    No_Int = table.Column<string>(nullable: true),
                    No_Ext = table.Column<string>(nullable: true),
                    Colony = table.Column<string>(maxLength: 40, nullable: false),
                    StateProvinceId = table.Column<int>(nullable: false),
                    CityId = table.Column<int>(nullable: false),
                    PostalCode = table.Column<string>(maxLength: 5, nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 256, nullable: true),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AddressesSAT",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ObjectKey = table.Column<string>(maxLength: 17, nullable: false),
                    RoadTypeId = table.Column<int>(nullable: false),
                    AddressTypeId = table.Column<int>(nullable: false),
                    Street = table.Column<string>(maxLength: 20, nullable: false),
                    No_Int = table.Column<string>(nullable: true),
                    No_Ext = table.Column<string>(nullable: true),
                    Colony = table.Column<string>(maxLength: 40, nullable: false),
                    StateProvinceId = table.Column<int>(nullable: false),
                    CityId = table.Column<int>(nullable: false),
                    PostalCode = table.Column<string>(maxLength: 5, nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 256, nullable: true),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressesSAT", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AddressTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressTypeName = table.Column<string>(maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateProvinceId = table.Column<int>(nullable: false),
                    CveEnt = table.Column<string>(maxLength: 2, nullable: false),
                    CveCity = table.Column<string>(maxLength: 3, nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false),
                    CveCab = table.Column<string>(maxLength: 7, nullable: true),
                    NameCab = table.Column<string>(maxLength: 100, nullable: true),
                    PTOT = table.Column<string>(maxLength: 10, nullable: true),
                    PMAS = table.Column<string>(maxLength: 10, nullable: true),
                    PFEM = table.Column<string>(maxLength: 10, nullable: true),
                    VTOT = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(maxLength: 100, nullable: false),
                    FIPS104 = table.Column<string>(maxLength: 2, nullable: false),
                    ISO2 = table.Column<string>(maxLength: 2, nullable: false),
                    ISO3 = table.Column<string>(maxLength: 3, nullable: false),
                    ISON = table.Column<string>(maxLength: 30, nullable: false),
                    Internet = table.Column<string>(maxLength: 2, nullable: true),
                    Capital = table.Column<string>(maxLength: 25, nullable: true),
                    MapReference = table.Column<string>(maxLength: 50, nullable: true),
                    NationalitySingular = table.Column<string>(maxLength: 35, nullable: true),
                    NationalityPlural = table.Column<string>(maxLength: 35, nullable: true),
                    Currency = table.Column<string>(maxLength: 30, nullable: true),
                    CurrencyCode = table.Column<string>(maxLength: 3, nullable: true),
                    Population = table.Column<long>(type: "bigint", nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: true),
                    Comment = table.Column<string>(maxLength: 2048, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(maxLength: 40, nullable: false),
                    Hierarchy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeNumber = table.Column<string>(maxLength: 100, nullable: false),
                    IS = table.Column<string>(maxLength: 6, nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    MiddleName = table.Column<string>(maxLength: 50, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 10, nullable: true),
                    WhatsApp = table.Column<string>(maxLength: 13, nullable: true),
                    BirthDate = table.Column<string>(maxLength: 8, nullable: true),
                    MaritalStatusId = table.Column<int>(nullable: false),
                    GenderId = table.Column<int>(nullable: false),
                    AddressId = table.Column<int>(nullable: false),
                    RFC = table.Column<string>(maxLength: 13, nullable: true),
                    CURP = table.Column<string>(maxLength: 18, nullable: false),
                    NSS = table.Column<string>(maxLength: 16, nullable: true),
                    ShiftId = table.Column<int>(nullable: false),
                    JobTitleId = table.Column<int>(nullable: false),
                    PharmacyBranchId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Photo = table.Column<byte[]>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 256, nullable: true),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderName = table.Column<string>(maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobTitles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobTitleName = table.Column<string>(maxLength: 40, nullable: false),
                    DepartmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaritalStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaritalStatusName = table.Column<string>(maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaritalStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Menu = table.Column<string>(maxLength: 50, nullable: false),
                    Submenu = table.Column<string>(maxLength: 50, nullable: true),
                    ControlName = table.Column<string>(maxLength: 50, nullable: false),
                    ControlImage = table.Column<string>(maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(nullable: false),
                    ModuleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PharmacyBranches",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PharmacyMasterId = table.Column<int>(nullable: false),
                    PharmacyBranchName = table.Column<string>(maxLength: 256, nullable: false),
                    UniquePhysicalID = table.Column<string>(maxLength: 100, nullable: false),
                    AddressId = table.Column<int>(nullable: false),
                    ResponsibleName = table.Column<string>(maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 20, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 256, nullable: true),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PharmacyBranches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PharmacyMasters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    MiddleName = table.Column<string>(maxLength: 50, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    WhatsApp = table.Column<string>(maxLength: 13, nullable: true),
                    EmailAddress = table.Column<string>(maxLength: 50, nullable: false),
                    Birthday = table.Column<string>(maxLength: 10, nullable: true),
                    RFC = table.Column<string>(maxLength: 13, nullable: false),
                    FiscalName = table.Column<string>(maxLength: 256, nullable: false),
                    PharmacyMasterName = table.Column<string>(maxLength: 256, nullable: false),
                    BusinessPhoneNumber = table.Column<string>(maxLength: 20, nullable: true),
                    BusinessEmailAddress = table.Column<string>(maxLength: 50, nullable: true),
                    PharmacyMasterKey = table.Column<string>(maxLength: 30, nullable: false),
                    AddressSATId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Logo = table.Column<byte[]>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 256, nullable: true),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PharmacyMasters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCategoryName = table.Column<string>(maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCostHistories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    StantardCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCostHistories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductExpiries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LotNumber = table.Column<string>(maxLength: 100, nullable: true),
                    DiscontinuedDate = table.Column<string>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    PharmacyBranchId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductExpiries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductInventories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    PharmacyBranchId = table.Column<int>(nullable: false),
                    UnitsInStock = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInventories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductListPriceHistories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    PharmacyBranchId = table.Column<int>(nullable: false),
                    ListPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductListPriceHistories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductLocations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    PharmacyBranchId = table.Column<int>(nullable: false),
                    Location = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductLocations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BarCode = table.Column<string>(maxLength: 21, nullable: true),
                    AlternativeCode = table.Column<string>(maxLength: 21, nullable: true),
                    ActiveSubstanceId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 512, nullable: true),
                    Laboratory = table.Column<string>(maxLength: 100, nullable: true),
                    LotNumber = table.Column<string>(maxLength: 100, nullable: true),
                    ProductSubCategoryId = table.Column<int>(nullable: false),
                    StandardCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsDiscontinued = table.Column<bool>(nullable: false),
                    IsRecipe = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    InvMin = table.Column<int>(nullable: false),
                    InvMax = table.Column<int>(nullable: false),
                    LastSupplierRefill = table.Column<string>(maxLength: 256, nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 256, nullable: true),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductSubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCategoryId = table.Column<int>(nullable: false),
                    ProductSubCategoryName = table.Column<string>(maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSubCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoadTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoadTypeName = table.Column<string>(maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoadTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(maxLength: 40, nullable: false),
                    Description = table.Column<string>(maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalesOrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    PurchaseAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IVA = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrderDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    PharmacyBranchId = table.Column<int>(nullable: false),
                    EmployeeName = table.Column<string>(maxLength: 256, nullable: true),
                    CustomerName = table.Column<string>(maxLength: 256, nullable: true),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    OrderState = table.Column<bool>(nullable: false),
                    ReturnOrderDate = table.Column<DateTime>(nullable: true),
                    ItemsQuantity = table.Column<int>(nullable: false),
                    PurchaseTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IVA = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shifts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShiftName = table.Column<string>(maxLength: 40, nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shifts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StateProvinces",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryRegionId = table.Column<int>(nullable: false),
                    CveEnt = table.Column<string>(maxLength: 2, nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false),
                    Abrev = table.Column<string>(maxLength: 10, nullable: false),
                    CveCab = table.Column<string>(maxLength: 7, nullable: true),
                    NameCab = table.Column<string>(maxLength: 100, nullable: true),
                    PTOT = table.Column<string>(maxLength: 10, nullable: true),
                    PMAS = table.Column<string>(maxLength: 10, nullable: true),
                    PFEM = table.Column<string>(maxLength: 10, nullable: true),
                    VTOT = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateProvinces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierName = table.Column<string>(maxLength: 256, nullable: false),
                    RFC = table.Column<string>(maxLength: 13, nullable: false),
                    SupplierKey = table.Column<string>(maxLength: 30, nullable: false),
                    AddressSATId = table.Column<int>(nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 20, nullable: true),
                    CellphoneNumber = table.Column<string>(maxLength: 13, nullable: true),
                    EmailAddress = table.Column<string>(maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Logo = table.Column<byte[]>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 256, nullable: true),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Thermohygrometers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<DateTime>(nullable: false),
                    Temperature = table.Column<decimal>(type: "decimal(2,2)", nullable: false),
                    Humidity = table.Column<decimal>(type: "decimal(2,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thermohygrometers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoginID = table.Column<string>(maxLength: 20, nullable: false),
                    PasswordEncrypted = table.Column<string>(maxLength: 256, nullable: false),
                    PasswordQuestion = table.Column<string>(maxLength: 100, nullable: true),
                    PasswordAnswer = table.Column<string>(maxLength: 100, nullable: true),
                    RoleId = table.Column<int>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    IsWelcome = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 256, nullable: true),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActiveSubstances");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "AddressesSAT");

            migrationBuilder.DropTable(
                name: "AddressTypes");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "JobTitles");

            migrationBuilder.DropTable(
                name: "MaritalStatuses");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "PharmacyBranches");

            migrationBuilder.DropTable(
                name: "PharmacyMasters");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "ProductCostHistories");

            migrationBuilder.DropTable(
                name: "ProductExpiries");

            migrationBuilder.DropTable(
                name: "ProductInventories");

            migrationBuilder.DropTable(
                name: "ProductListPriceHistories");

            migrationBuilder.DropTable(
                name: "ProductLocations");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ProductSubCategories");

            migrationBuilder.DropTable(
                name: "RoadTypes");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "SalesOrderDetails");

            migrationBuilder.DropTable(
                name: "SalesOrders");

            migrationBuilder.DropTable(
                name: "Shifts");

            migrationBuilder.DropTable(
                name: "StateProvinces");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Thermohygrometers");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
