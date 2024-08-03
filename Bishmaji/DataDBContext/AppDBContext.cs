using Bishmaji.Models;
using Microsoft.EntityFrameworkCore;

namespace Bishmaji.DataDBContext
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            List<Department> departments = new List<Department>() {
                new Department { DepartmentId=Guid.Parse("58834185-e5c7-422c-b55e-241210eba621"),DepartmentName="IT"},
                new Department { DepartmentId=Guid.Parse("5cb3dc03-6785-437a-b2a4-32e0db51c5dd"),DepartmentName="Engineering"}
            };

            modelBuilder.Entity<Department>().HasData(departments);
        }
    }
}
