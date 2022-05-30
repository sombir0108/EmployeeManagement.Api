using Microsoft.EntityFrameworkCore;
using System;

namespace EmployeeManagement.Api
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Employee Table
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                ID = 21,
                FirstName = "John",
                LastName = "Hastings",
                Gender = "Male",
                Salary = 60000
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                ID = 22,
                FirstName = "Sam",
                LastName = "Galloway",
                Gender = "Male",
                Salary = 60000
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                ID = 23,
                FirstName = "Mary",
                LastName = "Smith",
                Gender = "Male",
                Salary = 60000
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                ID = 24,
                FirstName = "Sara",
                LastName = "Longway",
                Gender = "Male",
                Salary = 60000
            });
        }
    }
}