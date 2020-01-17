using Microsoft.EntityFrameworkCore.Migrations;

namespace ViperMedix.WebAPI.Migrations
{
    public partial class RelationshipTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_AddressSATId",
                table: "Suppliers",
                column: "AddressSATId");

            migrationBuilder.CreateIndex(
                name: "IX_StateProvinces_CountryRegionId",
                table: "StateProvinces",
                column: "CountryRegionId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrders_PharmacyBranchId",
                table: "SalesOrders",
                column: "PharmacyBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrders_UserId",
                table: "SalesOrders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderDetails_ProductId",
                table: "SalesOrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderDetails_SalesOrderId",
                table: "SalesOrderDetails",
                column: "SalesOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSubCategories_ProductCategoryId",
                table: "ProductSubCategories",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ActiveSubstanceId",
                table: "Products",
                column: "ActiveSubstanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductSubCategoryId",
                table: "Products",
                column: "ProductSubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductLocations_PharmacyBranchId",
                table: "ProductLocations",
                column: "PharmacyBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductLocations_ProductId",
                table: "ProductLocations",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductListPriceHistories_PharmacyBranchId",
                table: "ProductListPriceHistories",
                column: "PharmacyBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductListPriceHistories_ProductId",
                table: "ProductListPriceHistories",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInventories_PharmacyBranchId",
                table: "ProductInventories",
                column: "PharmacyBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInventories_ProductId",
                table: "ProductInventories",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductExpiries_PharmacyBranchId",
                table: "ProductExpiries",
                column: "PharmacyBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductExpiries_ProductId",
                table: "ProductExpiries",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCostHistories_ProductId",
                table: "ProductCostHistories",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PharmacyMasters_AddressSATId",
                table: "PharmacyMasters",
                column: "AddressSATId");

            migrationBuilder.CreateIndex(
                name: "IX_PharmacyMasters_UserId",
                table: "PharmacyMasters",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PharmacyBranches_AddressId",
                table: "PharmacyBranches",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_PharmacyBranches_PharmacyMasterId",
                table: "PharmacyBranches",
                column: "PharmacyMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_ModuleId",
                table: "Permissions",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_RoleId",
                table: "Permissions",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_JobTitles_DepartmentId",
                table: "JobTitles",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_AddressId",
                table: "Employees",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_GenderId",
                table: "Employees",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_JobTitleId",
                table: "Employees",
                column: "JobTitleId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_MaritalStatusId",
                table: "Employees",
                column: "MaritalStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PharmacyBranchId",
                table: "Employees",
                column: "PharmacyBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ShiftId",
                table: "Employees",
                column: "ShiftId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_UserId",
                table: "Employees",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_StateProvinceId",
                table: "Cities",
                column: "StateProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_AddressesSAT_AddressTypeId",
                table: "AddressesSAT",
                column: "AddressTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AddressesSAT_CityId",
                table: "AddressesSAT",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_AddressesSAT_RoadTypeId",
                table: "AddressesSAT",
                column: "RoadTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AddressesSAT_StateProvinceId",
                table: "AddressesSAT",
                column: "StateProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_AddressTypeId",
                table: "Addresses",
                column: "AddressTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CityId",
                table: "Addresses",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_RoadTypeId",
                table: "Addresses",
                column: "RoadTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_StateProvinceId",
                table: "Addresses",
                column: "StateProvinceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_AddressTypes_AddressTypeId",
                table: "Addresses",
                column: "AddressTypeId",
                principalTable: "AddressTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Cities_CityId",
                table: "Addresses",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_RoadTypes_RoadTypeId",
                table: "Addresses",
                column: "RoadTypeId",
                principalTable: "RoadTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_StateProvinces_StateProvinceId",
                table: "Addresses",
                column: "StateProvinceId",
                principalTable: "StateProvinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AddressesSAT_AddressTypes_AddressTypeId",
                table: "AddressesSAT",
                column: "AddressTypeId",
                principalTable: "AddressTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AddressesSAT_Cities_CityId",
                table: "AddressesSAT",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AddressesSAT_RoadTypes_RoadTypeId",
                table: "AddressesSAT",
                column: "RoadTypeId",
                principalTable: "RoadTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AddressesSAT_StateProvinces_StateProvinceId",
                table: "AddressesSAT",
                column: "StateProvinceId",
                principalTable: "StateProvinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_StateProvinces_StateProvinceId",
                table: "Cities",
                column: "StateProvinceId",
                principalTable: "StateProvinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Addresses_AddressId",
                table: "Employees",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Genders_GenderId",
                table: "Employees",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_JobTitles_JobTitleId",
                table: "Employees",
                column: "JobTitleId",
                principalTable: "JobTitles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_MaritalStatuses_MaritalStatusId",
                table: "Employees",
                column: "MaritalStatusId",
                principalTable: "MaritalStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_PharmacyBranches_PharmacyBranchId",
                table: "Employees",
                column: "PharmacyBranchId",
                principalTable: "PharmacyBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Shifts_ShiftId",
                table: "Employees",
                column: "ShiftId",
                principalTable: "Shifts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Users_UserId",
                table: "Employees",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobTitles_Departments_DepartmentId",
                table: "JobTitles",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_Modules_ModuleId",
                table: "Permissions",
                column: "ModuleId",
                principalTable: "Modules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_Roles_RoleId",
                table: "Permissions",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PharmacyBranches_Addresses_AddressId",
                table: "PharmacyBranches",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PharmacyBranches_PharmacyMasters_PharmacyMasterId",
                table: "PharmacyBranches",
                column: "PharmacyMasterId",
                principalTable: "PharmacyMasters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PharmacyMasters_AddressesSAT_AddressSATId",
                table: "PharmacyMasters",
                column: "AddressSATId",
                principalTable: "AddressesSAT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PharmacyMasters_Users_UserId",
                table: "PharmacyMasters",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCostHistories_Products_ProductId",
                table: "ProductCostHistories",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductExpiries_PharmacyBranches_PharmacyBranchId",
                table: "ProductExpiries",
                column: "PharmacyBranchId",
                principalTable: "PharmacyBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductExpiries_Products_ProductId",
                table: "ProductExpiries",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInventories_PharmacyBranches_PharmacyBranchId",
                table: "ProductInventories",
                column: "PharmacyBranchId",
                principalTable: "PharmacyBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInventories_Products_ProductId",
                table: "ProductInventories",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductListPriceHistories_PharmacyBranches_PharmacyBranchId",
                table: "ProductListPriceHistories",
                column: "PharmacyBranchId",
                principalTable: "PharmacyBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductListPriceHistories_Products_ProductId",
                table: "ProductListPriceHistories",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductLocations_PharmacyBranches_PharmacyBranchId",
                table: "ProductLocations",
                column: "PharmacyBranchId",
                principalTable: "PharmacyBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductLocations_Products_ProductId",
                table: "ProductLocations",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ActiveSubstances_ActiveSubstanceId",
                table: "Products",
                column: "ActiveSubstanceId",
                principalTable: "ActiveSubstances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductSubCategories_ProductSubCategoryId",
                table: "Products",
                column: "ProductSubCategoryId",
                principalTable: "ProductSubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSubCategories_ProductCategories_ProductCategoryId",
                table: "ProductSubCategories",
                column: "ProductCategoryId",
                principalTable: "ProductCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesOrderDetails_Products_ProductId",
                table: "SalesOrderDetails",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesOrderDetails_SalesOrders_SalesOrderId",
                table: "SalesOrderDetails",
                column: "SalesOrderId",
                principalTable: "SalesOrders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesOrders_PharmacyBranches_PharmacyBranchId",
                table: "SalesOrders",
                column: "PharmacyBranchId",
                principalTable: "PharmacyBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesOrders_Users_UserId",
                table: "SalesOrders",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StateProvinces_Countries_CountryRegionId",
                table: "StateProvinces",
                column: "CountryRegionId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Suppliers_AddressesSAT_AddressSATId",
                table: "Suppliers",
                column: "AddressSATId",
                principalTable: "AddressesSAT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_AddressTypes_AddressTypeId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Cities_CityId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_RoadTypes_RoadTypeId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_StateProvinces_StateProvinceId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_AddressesSAT_AddressTypes_AddressTypeId",
                table: "AddressesSAT");

            migrationBuilder.DropForeignKey(
                name: "FK_AddressesSAT_Cities_CityId",
                table: "AddressesSAT");

            migrationBuilder.DropForeignKey(
                name: "FK_AddressesSAT_RoadTypes_RoadTypeId",
                table: "AddressesSAT");

            migrationBuilder.DropForeignKey(
                name: "FK_AddressesSAT_StateProvinces_StateProvinceId",
                table: "AddressesSAT");

            migrationBuilder.DropForeignKey(
                name: "FK_Cities_StateProvinces_StateProvinceId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Addresses_AddressId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Genders_GenderId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_JobTitles_JobTitleId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_MaritalStatuses_MaritalStatusId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_PharmacyBranches_PharmacyBranchId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Shifts_ShiftId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Users_UserId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_JobTitles_Departments_DepartmentId",
                table: "JobTitles");

            migrationBuilder.DropForeignKey(
                name: "FK_Permissions_Modules_ModuleId",
                table: "Permissions");

            migrationBuilder.DropForeignKey(
                name: "FK_Permissions_Roles_RoleId",
                table: "Permissions");

            migrationBuilder.DropForeignKey(
                name: "FK_PharmacyBranches_Addresses_AddressId",
                table: "PharmacyBranches");

            migrationBuilder.DropForeignKey(
                name: "FK_PharmacyBranches_PharmacyMasters_PharmacyMasterId",
                table: "PharmacyBranches");

            migrationBuilder.DropForeignKey(
                name: "FK_PharmacyMasters_AddressesSAT_AddressSATId",
                table: "PharmacyMasters");

            migrationBuilder.DropForeignKey(
                name: "FK_PharmacyMasters_Users_UserId",
                table: "PharmacyMasters");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCostHistories_Products_ProductId",
                table: "ProductCostHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductExpiries_PharmacyBranches_PharmacyBranchId",
                table: "ProductExpiries");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductExpiries_Products_ProductId",
                table: "ProductExpiries");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInventories_PharmacyBranches_PharmacyBranchId",
                table: "ProductInventories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInventories_Products_ProductId",
                table: "ProductInventories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductListPriceHistories_PharmacyBranches_PharmacyBranchId",
                table: "ProductListPriceHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductListPriceHistories_Products_ProductId",
                table: "ProductListPriceHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductLocations_PharmacyBranches_PharmacyBranchId",
                table: "ProductLocations");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductLocations_Products_ProductId",
                table: "ProductLocations");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ActiveSubstances_ActiveSubstanceId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductSubCategories_ProductSubCategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSubCategories_ProductCategories_ProductCategoryId",
                table: "ProductSubCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesOrderDetails_Products_ProductId",
                table: "SalesOrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesOrderDetails_SalesOrders_SalesOrderId",
                table: "SalesOrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesOrders_PharmacyBranches_PharmacyBranchId",
                table: "SalesOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesOrders_Users_UserId",
                table: "SalesOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_StateProvinces_Countries_CountryRegionId",
                table: "StateProvinces");

            migrationBuilder.DropForeignKey(
                name: "FK_Suppliers_AddressesSAT_AddressSATId",
                table: "Suppliers");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_RoleId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Suppliers_AddressSATId",
                table: "Suppliers");

            migrationBuilder.DropIndex(
                name: "IX_StateProvinces_CountryRegionId",
                table: "StateProvinces");

            migrationBuilder.DropIndex(
                name: "IX_SalesOrders_PharmacyBranchId",
                table: "SalesOrders");

            migrationBuilder.DropIndex(
                name: "IX_SalesOrders_UserId",
                table: "SalesOrders");

            migrationBuilder.DropIndex(
                name: "IX_SalesOrderDetails_ProductId",
                table: "SalesOrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_SalesOrderDetails_SalesOrderId",
                table: "SalesOrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_ProductSubCategories_ProductCategoryId",
                table: "ProductSubCategories");

            migrationBuilder.DropIndex(
                name: "IX_Products_ActiveSubstanceId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductSubCategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_ProductLocations_PharmacyBranchId",
                table: "ProductLocations");

            migrationBuilder.DropIndex(
                name: "IX_ProductLocations_ProductId",
                table: "ProductLocations");

            migrationBuilder.DropIndex(
                name: "IX_ProductListPriceHistories_PharmacyBranchId",
                table: "ProductListPriceHistories");

            migrationBuilder.DropIndex(
                name: "IX_ProductListPriceHistories_ProductId",
                table: "ProductListPriceHistories");

            migrationBuilder.DropIndex(
                name: "IX_ProductInventories_PharmacyBranchId",
                table: "ProductInventories");

            migrationBuilder.DropIndex(
                name: "IX_ProductInventories_ProductId",
                table: "ProductInventories");

            migrationBuilder.DropIndex(
                name: "IX_ProductExpiries_PharmacyBranchId",
                table: "ProductExpiries");

            migrationBuilder.DropIndex(
                name: "IX_ProductExpiries_ProductId",
                table: "ProductExpiries");

            migrationBuilder.DropIndex(
                name: "IX_ProductCostHistories_ProductId",
                table: "ProductCostHistories");

            migrationBuilder.DropIndex(
                name: "IX_PharmacyMasters_AddressSATId",
                table: "PharmacyMasters");

            migrationBuilder.DropIndex(
                name: "IX_PharmacyMasters_UserId",
                table: "PharmacyMasters");

            migrationBuilder.DropIndex(
                name: "IX_PharmacyBranches_AddressId",
                table: "PharmacyBranches");

            migrationBuilder.DropIndex(
                name: "IX_PharmacyBranches_PharmacyMasterId",
                table: "PharmacyBranches");

            migrationBuilder.DropIndex(
                name: "IX_Permissions_ModuleId",
                table: "Permissions");

            migrationBuilder.DropIndex(
                name: "IX_Permissions_RoleId",
                table: "Permissions");

            migrationBuilder.DropIndex(
                name: "IX_JobTitles_DepartmentId",
                table: "JobTitles");

            migrationBuilder.DropIndex(
                name: "IX_Employees_AddressId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_GenderId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_JobTitleId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_MaritalStatusId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_PharmacyBranchId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_ShiftId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_UserId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Cities_StateProvinceId",
                table: "Cities");

            migrationBuilder.DropIndex(
                name: "IX_AddressesSAT_AddressTypeId",
                table: "AddressesSAT");

            migrationBuilder.DropIndex(
                name: "IX_AddressesSAT_CityId",
                table: "AddressesSAT");

            migrationBuilder.DropIndex(
                name: "IX_AddressesSAT_RoadTypeId",
                table: "AddressesSAT");

            migrationBuilder.DropIndex(
                name: "IX_AddressesSAT_StateProvinceId",
                table: "AddressesSAT");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_AddressTypeId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_CityId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_RoadTypeId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_StateProvinceId",
                table: "Addresses");
        }
    }
}
