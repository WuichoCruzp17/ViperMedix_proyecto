using Microsoft.EntityFrameworkCore.Migrations;

namespace ViperMedix.WebAPI.Migrations
{
    public partial class RemovePluralizingTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Thermohygrometers",
                table: "Thermohygrometers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Suppliers",
                table: "Suppliers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StateProvinces",
                table: "StateProvinces");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shifts",
                table: "Shifts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesOrders",
                table: "SalesOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoadTypes",
                table: "RoadTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSubCategories",
                table: "ProductSubCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductLocations",
                table: "ProductLocations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductListPriceHistories",
                table: "ProductListPriceHistories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductInventories",
                table: "ProductInventories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductExpiries",
                table: "ProductExpiries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductCostHistories",
                table: "ProductCostHistories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductCategories",
                table: "ProductCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PharmacyMasters",
                table: "PharmacyMasters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PharmacyBranches",
                table: "PharmacyBranches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Permissions",
                table: "Permissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Modules",
                table: "Modules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaritalStatuses",
                table: "MaritalStatuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobTitles",
                table: "JobTitles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genders",
                table: "Genders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cities",
                table: "Cities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AddressTypes",
                table: "AddressTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AddressesSAT",
                table: "AddressesSAT");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ActiveSubstances",
                table: "ActiveSubstances");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "Thermohygrometers",
                newName: "Thermohygrometer");

            migrationBuilder.RenameTable(
                name: "Suppliers",
                newName: "Supplier");

            migrationBuilder.RenameTable(
                name: "StateProvinces",
                newName: "StateProvince");

            migrationBuilder.RenameTable(
                name: "Shifts",
                newName: "Shift");

            migrationBuilder.RenameTable(
                name: "SalesOrders",
                newName: "SalesOrder");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "Role");

            migrationBuilder.RenameTable(
                name: "RoadTypes",
                newName: "RoadType");

            migrationBuilder.RenameTable(
                name: "ProductSubCategories",
                newName: "ProductSubCategory");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "ProductLocations",
                newName: "ProductLocation");

            migrationBuilder.RenameTable(
                name: "ProductListPriceHistories",
                newName: "ProductListPriceHistory");

            migrationBuilder.RenameTable(
                name: "ProductInventories",
                newName: "ProductInventory");

            migrationBuilder.RenameTable(
                name: "ProductExpiries",
                newName: "ProductExpiry");

            migrationBuilder.RenameTable(
                name: "ProductCostHistories",
                newName: "ProductCostHistory");

            migrationBuilder.RenameTable(
                name: "ProductCategories",
                newName: "ProductCategory");

            migrationBuilder.RenameTable(
                name: "PharmacyMasters",
                newName: "PharmacyMaster");

            migrationBuilder.RenameTable(
                name: "PharmacyBranches",
                newName: "PharmacyBranch");

            migrationBuilder.RenameTable(
                name: "Permissions",
                newName: "Permission");

            migrationBuilder.RenameTable(
                name: "Modules",
                newName: "Module");

            migrationBuilder.RenameTable(
                name: "MaritalStatuses",
                newName: "MaritalStatus");

            migrationBuilder.RenameTable(
                name: "JobTitles",
                newName: "JobTitle");

            migrationBuilder.RenameTable(
                name: "Genders",
                newName: "Gender");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employee");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "Department");

            migrationBuilder.RenameTable(
                name: "Countries",
                newName: "CountryRegion");

            migrationBuilder.RenameTable(
                name: "Cities",
                newName: "City");

            migrationBuilder.RenameTable(
                name: "AddressTypes",
                newName: "AddressType");

            migrationBuilder.RenameTable(
                name: "AddressesSAT",
                newName: "AddressSat");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "Address");

            migrationBuilder.RenameTable(
                name: "ActiveSubstances",
                newName: "ActiveSubstance");

            migrationBuilder.RenameIndex(
                name: "IX_Users_RoleId",
                table: "User",
                newName: "IX_User_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Suppliers_AddressSATId",
                table: "Supplier",
                newName: "IX_Supplier_AddressSATId");

            migrationBuilder.RenameIndex(
                name: "IX_StateProvinces_CountryRegionId",
                table: "StateProvince",
                newName: "IX_StateProvince_CountryRegionId");

            migrationBuilder.RenameIndex(
                name: "IX_SalesOrders_UserId",
                table: "SalesOrder",
                newName: "IX_SalesOrder_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_SalesOrders_PharmacyBranchId",
                table: "SalesOrder",
                newName: "IX_SalesOrder_PharmacyBranchId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSubCategories_ProductCategoryId",
                table: "ProductSubCategory",
                newName: "IX_ProductSubCategory_ProductCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ProductSubCategoryId",
                table: "Product",
                newName: "IX_Product_ProductSubCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ActiveSubstanceId",
                table: "Product",
                newName: "IX_Product_ActiveSubstanceId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductLocations_ProductId",
                table: "ProductLocation",
                newName: "IX_ProductLocation_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductLocations_PharmacyBranchId",
                table: "ProductLocation",
                newName: "IX_ProductLocation_PharmacyBranchId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductListPriceHistories_ProductId",
                table: "ProductListPriceHistory",
                newName: "IX_ProductListPriceHistory_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductListPriceHistories_PharmacyBranchId",
                table: "ProductListPriceHistory",
                newName: "IX_ProductListPriceHistory_PharmacyBranchId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductInventories_ProductId",
                table: "ProductInventory",
                newName: "IX_ProductInventory_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductInventories_PharmacyBranchId",
                table: "ProductInventory",
                newName: "IX_ProductInventory_PharmacyBranchId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductExpiries_ProductId",
                table: "ProductExpiry",
                newName: "IX_ProductExpiry_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductExpiries_PharmacyBranchId",
                table: "ProductExpiry",
                newName: "IX_ProductExpiry_PharmacyBranchId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductCostHistories_ProductId",
                table: "ProductCostHistory",
                newName: "IX_ProductCostHistory_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_PharmacyMasters_UserId",
                table: "PharmacyMaster",
                newName: "IX_PharmacyMaster_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_PharmacyMasters_AddressSATId",
                table: "PharmacyMaster",
                newName: "IX_PharmacyMaster_AddressSATId");

            migrationBuilder.RenameIndex(
                name: "IX_PharmacyBranches_PharmacyMasterId",
                table: "PharmacyBranch",
                newName: "IX_PharmacyBranch_PharmacyMasterId");

            migrationBuilder.RenameIndex(
                name: "IX_PharmacyBranches_AddressId",
                table: "PharmacyBranch",
                newName: "IX_PharmacyBranch_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Permissions_RoleId",
                table: "Permission",
                newName: "IX_Permission_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Permissions_ModuleId",
                table: "Permission",
                newName: "IX_Permission_ModuleId");

            migrationBuilder.RenameIndex(
                name: "IX_JobTitles_DepartmentId",
                table: "JobTitle",
                newName: "IX_JobTitle_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_UserId",
                table: "Employee",
                newName: "IX_Employee_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_ShiftId",
                table: "Employee",
                newName: "IX_Employee_ShiftId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_PharmacyBranchId",
                table: "Employee",
                newName: "IX_Employee_PharmacyBranchId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_MaritalStatusId",
                table: "Employee",
                newName: "IX_Employee_MaritalStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_JobTitleId",
                table: "Employee",
                newName: "IX_Employee_JobTitleId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_GenderId",
                table: "Employee",
                newName: "IX_Employee_GenderId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_AddressId",
                table: "Employee",
                newName: "IX_Employee_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Cities_StateProvinceId",
                table: "City",
                newName: "IX_City_StateProvinceId");

            migrationBuilder.RenameIndex(
                name: "IX_AddressesSAT_StateProvinceId",
                table: "AddressSat",
                newName: "IX_AddressSat_StateProvinceId");

            migrationBuilder.RenameIndex(
                name: "IX_AddressesSAT_RoadTypeId",
                table: "AddressSat",
                newName: "IX_AddressSat_RoadTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_AddressesSAT_CityId",
                table: "AddressSat",
                newName: "IX_AddressSat_CityId");

            migrationBuilder.RenameIndex(
                name: "IX_AddressesSAT_AddressTypeId",
                table: "AddressSat",
                newName: "IX_AddressSat_AddressTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_StateProvinceId",
                table: "Address",
                newName: "IX_Address_StateProvinceId");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_RoadTypeId",
                table: "Address",
                newName: "IX_Address_RoadTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_CityId",
                table: "Address",
                newName: "IX_Address_CityId");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_AddressTypeId",
                table: "Address",
                newName: "IX_Address_AddressTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Thermohygrometer",
                table: "Thermohygrometer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Supplier",
                table: "Supplier",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StateProvince",
                table: "StateProvince",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shift",
                table: "Shift",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesOrder",
                table: "SalesOrder",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Role",
                table: "Role",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoadType",
                table: "RoadType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSubCategory",
                table: "ProductSubCategory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductLocation",
                table: "ProductLocation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductListPriceHistory",
                table: "ProductListPriceHistory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductInventory",
                table: "ProductInventory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductExpiry",
                table: "ProductExpiry",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductCostHistory",
                table: "ProductCostHistory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductCategory",
                table: "ProductCategory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PharmacyMaster",
                table: "PharmacyMaster",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PharmacyBranch",
                table: "PharmacyBranch",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Permission",
                table: "Permission",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Module",
                table: "Module",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaritalStatus",
                table: "MaritalStatus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobTitle",
                table: "JobTitle",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gender",
                table: "Gender",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                table: "Department",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CountryRegion",
                table: "CountryRegion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_City",
                table: "City",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AddressType",
                table: "AddressType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AddressSat",
                table: "AddressSat",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ActiveSubstance",
                table: "ActiveSubstance",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_AddressType_AddressTypeId",
                table: "Address",
                column: "AddressTypeId",
                principalTable: "AddressType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Address_City_CityId",
                table: "Address",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Address_RoadType_RoadTypeId",
                table: "Address",
                column: "RoadTypeId",
                principalTable: "RoadType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Address_StateProvince_StateProvinceId",
                table: "Address",
                column: "StateProvinceId",
                principalTable: "StateProvince",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AddressSat_AddressType_AddressTypeId",
                table: "AddressSat",
                column: "AddressTypeId",
                principalTable: "AddressType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AddressSat_City_CityId",
                table: "AddressSat",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AddressSat_RoadType_RoadTypeId",
                table: "AddressSat",
                column: "RoadTypeId",
                principalTable: "RoadType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AddressSat_StateProvince_StateProvinceId",
                table: "AddressSat",
                column: "StateProvinceId",
                principalTable: "StateProvince",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_City_StateProvince_StateProvinceId",
                table: "City",
                column: "StateProvinceId",
                principalTable: "StateProvince",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Address_AddressId",
                table: "Employee",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Gender_GenderId",
                table: "Employee",
                column: "GenderId",
                principalTable: "Gender",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_JobTitle_JobTitleId",
                table: "Employee",
                column: "JobTitleId",
                principalTable: "JobTitle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_MaritalStatus_MaritalStatusId",
                table: "Employee",
                column: "MaritalStatusId",
                principalTable: "MaritalStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_PharmacyBranch_PharmacyBranchId",
                table: "Employee",
                column: "PharmacyBranchId",
                principalTable: "PharmacyBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Shift_ShiftId",
                table: "Employee",
                column: "ShiftId",
                principalTable: "Shift",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_User_UserId",
                table: "Employee",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobTitle_Department_DepartmentId",
                table: "JobTitle",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Permission_Module_ModuleId",
                table: "Permission",
                column: "ModuleId",
                principalTable: "Module",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Permission_Role_RoleId",
                table: "Permission",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PharmacyBranch_Address_AddressId",
                table: "PharmacyBranch",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PharmacyBranch_PharmacyMaster_PharmacyMasterId",
                table: "PharmacyBranch",
                column: "PharmacyMasterId",
                principalTable: "PharmacyMaster",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PharmacyMaster_AddressSat_AddressSATId",
                table: "PharmacyMaster",
                column: "AddressSATId",
                principalTable: "AddressSat",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PharmacyMaster_User_UserId",
                table: "PharmacyMaster",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ActiveSubstance_ActiveSubstanceId",
                table: "Product",
                column: "ActiveSubstanceId",
                principalTable: "ActiveSubstance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ProductSubCategory_ProductSubCategoryId",
                table: "Product",
                column: "ProductSubCategoryId",
                principalTable: "ProductSubCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCostHistory_Product_ProductId",
                table: "ProductCostHistory",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductExpiry_PharmacyBranch_PharmacyBranchId",
                table: "ProductExpiry",
                column: "PharmacyBranchId",
                principalTable: "PharmacyBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductExpiry_Product_ProductId",
                table: "ProductExpiry",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInventory_PharmacyBranch_PharmacyBranchId",
                table: "ProductInventory",
                column: "PharmacyBranchId",
                principalTable: "PharmacyBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInventory_Product_ProductId",
                table: "ProductInventory",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductListPriceHistory_PharmacyBranch_PharmacyBranchId",
                table: "ProductListPriceHistory",
                column: "PharmacyBranchId",
                principalTable: "PharmacyBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductListPriceHistory_Product_ProductId",
                table: "ProductListPriceHistory",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductLocation_PharmacyBranch_PharmacyBranchId",
                table: "ProductLocation",
                column: "PharmacyBranchId",
                principalTable: "PharmacyBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductLocation_Product_ProductId",
                table: "ProductLocation",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSubCategory_ProductCategory_ProductCategoryId",
                table: "ProductSubCategory",
                column: "ProductCategoryId",
                principalTable: "ProductCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesOrder_PharmacyBranch_PharmacyBranchId",
                table: "SalesOrder",
                column: "PharmacyBranchId",
                principalTable: "PharmacyBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesOrder_User_UserId",
                table: "SalesOrder",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesOrderDetails_Product_ProductId",
                table: "SalesOrderDetails",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesOrderDetails_SalesOrder_SalesOrderId",
                table: "SalesOrderDetails",
                column: "SalesOrderId",
                principalTable: "SalesOrder",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StateProvince_CountryRegion_CountryRegionId",
                table: "StateProvince",
                column: "CountryRegionId",
                principalTable: "CountryRegion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Supplier_AddressSat_AddressSATId",
                table: "Supplier",
                column: "AddressSATId",
                principalTable: "AddressSat",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Role_RoleId",
                table: "User",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_AddressType_AddressTypeId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Address_City_CityId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Address_RoadType_RoadTypeId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Address_StateProvince_StateProvinceId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_AddressSat_AddressType_AddressTypeId",
                table: "AddressSat");

            migrationBuilder.DropForeignKey(
                name: "FK_AddressSat_City_CityId",
                table: "AddressSat");

            migrationBuilder.DropForeignKey(
                name: "FK_AddressSat_RoadType_RoadTypeId",
                table: "AddressSat");

            migrationBuilder.DropForeignKey(
                name: "FK_AddressSat_StateProvince_StateProvinceId",
                table: "AddressSat");

            migrationBuilder.DropForeignKey(
                name: "FK_City_StateProvince_StateProvinceId",
                table: "City");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Address_AddressId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Gender_GenderId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_JobTitle_JobTitleId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_MaritalStatus_MaritalStatusId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_PharmacyBranch_PharmacyBranchId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Shift_ShiftId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_User_UserId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_JobTitle_Department_DepartmentId",
                table: "JobTitle");

            migrationBuilder.DropForeignKey(
                name: "FK_Permission_Module_ModuleId",
                table: "Permission");

            migrationBuilder.DropForeignKey(
                name: "FK_Permission_Role_RoleId",
                table: "Permission");

            migrationBuilder.DropForeignKey(
                name: "FK_PharmacyBranch_Address_AddressId",
                table: "PharmacyBranch");

            migrationBuilder.DropForeignKey(
                name: "FK_PharmacyBranch_PharmacyMaster_PharmacyMasterId",
                table: "PharmacyBranch");

            migrationBuilder.DropForeignKey(
                name: "FK_PharmacyMaster_AddressSat_AddressSATId",
                table: "PharmacyMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_PharmacyMaster_User_UserId",
                table: "PharmacyMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_ActiveSubstance_ActiveSubstanceId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_ProductSubCategory_ProductSubCategoryId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCostHistory_Product_ProductId",
                table: "ProductCostHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductExpiry_PharmacyBranch_PharmacyBranchId",
                table: "ProductExpiry");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductExpiry_Product_ProductId",
                table: "ProductExpiry");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInventory_PharmacyBranch_PharmacyBranchId",
                table: "ProductInventory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInventory_Product_ProductId",
                table: "ProductInventory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductListPriceHistory_PharmacyBranch_PharmacyBranchId",
                table: "ProductListPriceHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductListPriceHistory_Product_ProductId",
                table: "ProductListPriceHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductLocation_PharmacyBranch_PharmacyBranchId",
                table: "ProductLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductLocation_Product_ProductId",
                table: "ProductLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSubCategory_ProductCategory_ProductCategoryId",
                table: "ProductSubCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesOrder_PharmacyBranch_PharmacyBranchId",
                table: "SalesOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesOrder_User_UserId",
                table: "SalesOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesOrderDetails_Product_ProductId",
                table: "SalesOrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesOrderDetails_SalesOrder_SalesOrderId",
                table: "SalesOrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_StateProvince_CountryRegion_CountryRegionId",
                table: "StateProvince");

            migrationBuilder.DropForeignKey(
                name: "FK_Supplier_AddressSat_AddressSATId",
                table: "Supplier");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Role_RoleId",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Thermohygrometer",
                table: "Thermohygrometer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Supplier",
                table: "Supplier");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StateProvince",
                table: "StateProvince");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shift",
                table: "Shift");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesOrder",
                table: "SalesOrder");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Role",
                table: "Role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoadType",
                table: "RoadType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSubCategory",
                table: "ProductSubCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductLocation",
                table: "ProductLocation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductListPriceHistory",
                table: "ProductListPriceHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductInventory",
                table: "ProductInventory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductExpiry",
                table: "ProductExpiry");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductCostHistory",
                table: "ProductCostHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductCategory",
                table: "ProductCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PharmacyMaster",
                table: "PharmacyMaster");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PharmacyBranch",
                table: "PharmacyBranch");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Permission",
                table: "Permission");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Module",
                table: "Module");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaritalStatus",
                table: "MaritalStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobTitle",
                table: "JobTitle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gender",
                table: "Gender");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                table: "Department");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CountryRegion",
                table: "CountryRegion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_City",
                table: "City");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AddressType",
                table: "AddressType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AddressSat",
                table: "AddressSat");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ActiveSubstance",
                table: "ActiveSubstance");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "Thermohygrometer",
                newName: "Thermohygrometers");

            migrationBuilder.RenameTable(
                name: "Supplier",
                newName: "Suppliers");

            migrationBuilder.RenameTable(
                name: "StateProvince",
                newName: "StateProvinces");

            migrationBuilder.RenameTable(
                name: "Shift",
                newName: "Shifts");

            migrationBuilder.RenameTable(
                name: "SalesOrder",
                newName: "SalesOrders");

            migrationBuilder.RenameTable(
                name: "Role",
                newName: "Roles");

            migrationBuilder.RenameTable(
                name: "RoadType",
                newName: "RoadTypes");

            migrationBuilder.RenameTable(
                name: "ProductSubCategory",
                newName: "ProductSubCategories");

            migrationBuilder.RenameTable(
                name: "ProductLocation",
                newName: "ProductLocations");

            migrationBuilder.RenameTable(
                name: "ProductListPriceHistory",
                newName: "ProductListPriceHistories");

            migrationBuilder.RenameTable(
                name: "ProductInventory",
                newName: "ProductInventories");

            migrationBuilder.RenameTable(
                name: "ProductExpiry",
                newName: "ProductExpiries");

            migrationBuilder.RenameTable(
                name: "ProductCostHistory",
                newName: "ProductCostHistories");

            migrationBuilder.RenameTable(
                name: "ProductCategory",
                newName: "ProductCategories");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "PharmacyMaster",
                newName: "PharmacyMasters");

            migrationBuilder.RenameTable(
                name: "PharmacyBranch",
                newName: "PharmacyBranches");

            migrationBuilder.RenameTable(
                name: "Permission",
                newName: "Permissions");

            migrationBuilder.RenameTable(
                name: "Module",
                newName: "Modules");

            migrationBuilder.RenameTable(
                name: "MaritalStatus",
                newName: "MaritalStatuses");

            migrationBuilder.RenameTable(
                name: "JobTitle",
                newName: "JobTitles");

            migrationBuilder.RenameTable(
                name: "Gender",
                newName: "Genders");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Employees");

            migrationBuilder.RenameTable(
                name: "Department",
                newName: "Departments");

            migrationBuilder.RenameTable(
                name: "CountryRegion",
                newName: "Countries");

            migrationBuilder.RenameTable(
                name: "City",
                newName: "Cities");

            migrationBuilder.RenameTable(
                name: "AddressType",
                newName: "AddressTypes");

            migrationBuilder.RenameTable(
                name: "AddressSat",
                newName: "AddressesSAT");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "Addresses");

            migrationBuilder.RenameTable(
                name: "ActiveSubstance",
                newName: "ActiveSubstances");

            migrationBuilder.RenameIndex(
                name: "IX_User_RoleId",
                table: "Users",
                newName: "IX_Users_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Supplier_AddressSATId",
                table: "Suppliers",
                newName: "IX_Suppliers_AddressSATId");

            migrationBuilder.RenameIndex(
                name: "IX_StateProvince_CountryRegionId",
                table: "StateProvinces",
                newName: "IX_StateProvinces_CountryRegionId");

            migrationBuilder.RenameIndex(
                name: "IX_SalesOrder_UserId",
                table: "SalesOrders",
                newName: "IX_SalesOrders_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_SalesOrder_PharmacyBranchId",
                table: "SalesOrders",
                newName: "IX_SalesOrders_PharmacyBranchId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSubCategory_ProductCategoryId",
                table: "ProductSubCategories",
                newName: "IX_ProductSubCategories_ProductCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductLocation_ProductId",
                table: "ProductLocations",
                newName: "IX_ProductLocations_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductLocation_PharmacyBranchId",
                table: "ProductLocations",
                newName: "IX_ProductLocations_PharmacyBranchId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductListPriceHistory_ProductId",
                table: "ProductListPriceHistories",
                newName: "IX_ProductListPriceHistories_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductListPriceHistory_PharmacyBranchId",
                table: "ProductListPriceHistories",
                newName: "IX_ProductListPriceHistories_PharmacyBranchId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductInventory_ProductId",
                table: "ProductInventories",
                newName: "IX_ProductInventories_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductInventory_PharmacyBranchId",
                table: "ProductInventories",
                newName: "IX_ProductInventories_PharmacyBranchId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductExpiry_ProductId",
                table: "ProductExpiries",
                newName: "IX_ProductExpiries_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductExpiry_PharmacyBranchId",
                table: "ProductExpiries",
                newName: "IX_ProductExpiries_PharmacyBranchId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductCostHistory_ProductId",
                table: "ProductCostHistories",
                newName: "IX_ProductCostHistories_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_ProductSubCategoryId",
                table: "Products",
                newName: "IX_Products_ProductSubCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_ActiveSubstanceId",
                table: "Products",
                newName: "IX_Products_ActiveSubstanceId");

            migrationBuilder.RenameIndex(
                name: "IX_PharmacyMaster_UserId",
                table: "PharmacyMasters",
                newName: "IX_PharmacyMasters_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_PharmacyMaster_AddressSATId",
                table: "PharmacyMasters",
                newName: "IX_PharmacyMasters_AddressSATId");

            migrationBuilder.RenameIndex(
                name: "IX_PharmacyBranch_PharmacyMasterId",
                table: "PharmacyBranches",
                newName: "IX_PharmacyBranches_PharmacyMasterId");

            migrationBuilder.RenameIndex(
                name: "IX_PharmacyBranch_AddressId",
                table: "PharmacyBranches",
                newName: "IX_PharmacyBranches_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Permission_RoleId",
                table: "Permissions",
                newName: "IX_Permissions_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Permission_ModuleId",
                table: "Permissions",
                newName: "IX_Permissions_ModuleId");

            migrationBuilder.RenameIndex(
                name: "IX_JobTitle_DepartmentId",
                table: "JobTitles",
                newName: "IX_JobTitles_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_UserId",
                table: "Employees",
                newName: "IX_Employees_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_ShiftId",
                table: "Employees",
                newName: "IX_Employees_ShiftId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_PharmacyBranchId",
                table: "Employees",
                newName: "IX_Employees_PharmacyBranchId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_MaritalStatusId",
                table: "Employees",
                newName: "IX_Employees_MaritalStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_JobTitleId",
                table: "Employees",
                newName: "IX_Employees_JobTitleId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_GenderId",
                table: "Employees",
                newName: "IX_Employees_GenderId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_AddressId",
                table: "Employees",
                newName: "IX_Employees_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_City_StateProvinceId",
                table: "Cities",
                newName: "IX_Cities_StateProvinceId");

            migrationBuilder.RenameIndex(
                name: "IX_AddressSat_StateProvinceId",
                table: "AddressesSAT",
                newName: "IX_AddressesSAT_StateProvinceId");

            migrationBuilder.RenameIndex(
                name: "IX_AddressSat_RoadTypeId",
                table: "AddressesSAT",
                newName: "IX_AddressesSAT_RoadTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_AddressSat_CityId",
                table: "AddressesSAT",
                newName: "IX_AddressesSAT_CityId");

            migrationBuilder.RenameIndex(
                name: "IX_AddressSat_AddressTypeId",
                table: "AddressesSAT",
                newName: "IX_AddressesSAT_AddressTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Address_StateProvinceId",
                table: "Addresses",
                newName: "IX_Addresses_StateProvinceId");

            migrationBuilder.RenameIndex(
                name: "IX_Address_RoadTypeId",
                table: "Addresses",
                newName: "IX_Addresses_RoadTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Address_CityId",
                table: "Addresses",
                newName: "IX_Addresses_CityId");

            migrationBuilder.RenameIndex(
                name: "IX_Address_AddressTypeId",
                table: "Addresses",
                newName: "IX_Addresses_AddressTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Thermohygrometers",
                table: "Thermohygrometers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Suppliers",
                table: "Suppliers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StateProvinces",
                table: "StateProvinces",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shifts",
                table: "Shifts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesOrders",
                table: "SalesOrders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoadTypes",
                table: "RoadTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSubCategories",
                table: "ProductSubCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductLocations",
                table: "ProductLocations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductListPriceHistories",
                table: "ProductListPriceHistories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductInventories",
                table: "ProductInventories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductExpiries",
                table: "ProductExpiries",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductCostHistories",
                table: "ProductCostHistories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductCategories",
                table: "ProductCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PharmacyMasters",
                table: "PharmacyMasters",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PharmacyBranches",
                table: "PharmacyBranches",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Permissions",
                table: "Permissions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Modules",
                table: "Modules",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaritalStatuses",
                table: "MaritalStatuses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobTitles",
                table: "JobTitles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genders",
                table: "Genders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cities",
                table: "Cities",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AddressTypes",
                table: "AddressTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AddressesSAT",
                table: "AddressesSAT",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ActiveSubstances",
                table: "ActiveSubstances",
                column: "Id");

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
    }
}
