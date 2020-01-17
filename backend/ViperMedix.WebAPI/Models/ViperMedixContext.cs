using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ViperMedix.WebAPI.Models
{
    public class ViperMedixContext : DbContext
    {
        public ViperMedixContext(DbContextOptions<ViperMedixContext> options) : base(options)
        {
        }

        public DbSet<ActiveSubstance> ActiveSubstances { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<AddressSat> AddressesSAT { get; set; }
        public DbSet<AddressType> AddressTypes { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<CountryRegion> Countries { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<JobTitle> JobTitles { get; set; }
        public DbSet<MaritalStatus> MaritalStatuses { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<PharmacyBranch> PharmacyBranches { get; set; }
        public DbSet<PharmacyMaster> PharmacyMasters { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductCostHistory> ProductCostHistories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductExpiry> ProductExpiries { get; set; }
        public DbSet<ProductInventory> ProductInventories { get; set; }
        public DbSet<ProductListPriceHistory> ProductListPriceHistories { get; set; }
        public DbSet<ProductLocation> ProductLocations { get; set; }
        public DbSet<ProductSubCategory> ProductSubCategories { get; set; }
        public DbSet<RoadType> RoadTypes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<SalesOrderDetails> SalesOrderDetails { get; set; }
        public DbSet<SalesOrder> SalesOrders { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<StateProvince> StateProvinces { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Thermohygrometer> Thermohygrometers { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            foreach (IMutableEntityType entity in modelBuilder.Model.GetEntityTypes())
            {
                entity.SetTableName(entity.DisplayName());
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}