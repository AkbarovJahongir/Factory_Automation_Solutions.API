using Factory_Automation_Solutions.Domain.Models;
using Factory_Automation_Solutions.Models;
using Microsoft.EntityFrameworkCore;

namespace Factory_Automation_Solutions.Application
{
    public class DataContext : DbContext
	{
		public DbSet<User>? Users { get; set; }
        public DbSet<Country>? Country { get; set; }
        public DbSet<Manafacture>? Manafactures { get; set; }
		public DbSet<Role>? Roles { get; set; }
        public DbSet<Supplier>? Suppliers { get; set; }
        public DbSet<WareHouse> WareHouses { get; set; }
        public DbSet<Product>? Products { get; set; }
        public DbSet<InComeProducts>? InComeProducts { get; set; }
        public DbSet<Order>? Orders { get; set; }
        public DbSet<Material>? Materials { get; set; }
        public List<Employee>? Employees { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
		{
			//Database.EnsureDeleted();
			Database.EnsureCreated();
		}
		protected override void OnModelCreating(ModelBuilder modelbuilder)
		{
			ManafactureMapping(modelbuilder);
            InComeProductsMapping(modelbuilder);
			CountriesMapping(modelbuilder);
			SuppliersMapping(modelbuilder);
			WareHousesMapping(modelbuilder);
			RolesMapping(modelbuilder);
			UsersMapping(modelbuilder);
			ProductMapping(modelbuilder);
			OrderMapping(modelbuilder);
			MaterialMapping(modelbuilder);
			EmployeeMapping(modelbuilder);
            base.OnModelCreating(modelbuilder);
		}
		private void ManafactureMapping(ModelBuilder modelBuilder)
		{
			var manafacturMapping = modelBuilder.Entity<Manafacture>();
			manafacturMapping.HasKey(m => m.Id);
		}
		private void InComeProductsMapping(ModelBuilder modelBuilder)
		{
			var incomeProductsMapping = modelBuilder.Entity<InComeProducts>();
            incomeProductsMapping.HasKey(i => i.Id);
            incomeProductsMapping.HasOne(i => i.Products).WithMany(m => m.InComeProducts).HasForeignKey(f => f.ProductId);
		}
		private void CountriesMapping(ModelBuilder modelBuilder)
		{
			var countriesMapping = modelBuilder.Entity<Country>();
			countriesMapping.HasKey(c => c.Id);
		}
		private void SuppliersMapping(ModelBuilder modelBuilder)
		{
			var suppliersMapping = modelBuilder.Entity<Supplier>();
			suppliersMapping.HasKey(s => s.Id);
		}
		private void WareHousesMapping(ModelBuilder modelBuilder)
		{
			var warehousesMapping = modelBuilder.Entity<WareHouse>();
			warehousesMapping.HasKey(w => w.Id);
		}
		private void RolesMapping(ModelBuilder modelBuilder)
		{
			var rolesMapping = modelBuilder.Entity<Role>();
			rolesMapping.HasData(
				new Role
				{
					Id = 1,
					Name = "Admin"
				});
		}
		private void UsersMapping(ModelBuilder modelBuilder)
		{
			var usersMapping = modelBuilder.Entity<User>();
			usersMapping.HasKey(u => u.Id);
			usersMapping.HasOne(u => u.Role).WithMany(m => m.Users).HasForeignKey(f => f.RoleID);
			usersMapping.HasData(
				new User
				{
					Id = 1,
					Login = "admin",
					Password = "admin",
					Name = "Admin",
					RoleID = 1
				});
		}
		private void ProductMapping(ModelBuilder modelBuilder) {
			var productMapping = modelBuilder.Entity<Product>();
			productMapping.HasKey(p => p.Id);
			productMapping.HasOne(p => p.Matelials).WithMany(p => p.Productst).HasForeignKey(f => f.MaterialId);
        }
		private void OrderMapping(ModelBuilder modelBuilder) {
			var orderMapping = modelBuilder.Entity<Order>();
			orderMapping.HasKey(x => x.Id);
			orderMapping.HasOne(x => x.Employees).WithMany(m => m.Orders).HasForeignKey(f => f.EmployeeId);
			orderMapping.HasOne(x => x.Products).WithMany(m => m.Orders).HasForeignKey(f => f.ProductId);
		}
		private void MaterialMapping(ModelBuilder modelBuilder) {
			var materialMapping = modelBuilder.Entity<Material>();
			materialMapping.HasKey(x => x.Id);
			materialMapping.HasOne(x => x.Suppliers).WithMany(m => m.Materials).HasForeignKey(f => f.SupplierId);
		}
		private void EmployeeMapping(ModelBuilder modelBuilder) {
			var employeeMapping = modelBuilder.Entity<Employee>();
			employeeMapping.HasKey(x => x.Id);
		}
    }
}
