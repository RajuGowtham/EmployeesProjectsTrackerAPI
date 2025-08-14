using Microsoft.EntityFrameworkCore;

namespace EmployeeProjectTrackerAPI.Models
{
    public class DbContextSetup : DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public DbContextSetup(DbContextOptions<DbContextSetup> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed sample Projects
            modelBuilder.Entity<Project>().HasData(
               new Project
               {
                   ProjectId = 1,
                   ProjectCode = "PRJ001",
                   ProjectName = "Employee Tracker System",
                   StartDate = new DateTime(2025, 1, 1),
                   EndDate = null,
                   Budget = 150000
               },
               new Project
               {
                   ProjectId = 2,
                   ProjectCode = "PRJ002",
                   ProjectName = "E-Commerce Platform",
                   StartDate = new DateTime(2025, 2, 15),
                   EndDate = null,
                   Budget = 300000
               }
           );

            // Seed sample Employees
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 1,
                    EmployeeCode = "EMP001",
                    FullName = "Alice Johnson",
                    Email = "alice@example.com",
                    Designation = "Software Engineer",
                    Salary = 60000,
                    ProjectId = 1
                },
                new Employee
                {
                    EmployeeId = 2,
                    EmployeeCode = "EMP002",
                    FullName = "Bob Smith",
                    Email = "bob@example.com",
                    Designation = "Project Manager",
                    Salary = 90000,
                    ProjectId = 1
                },
                new Employee
                {
                    EmployeeId = 3,
                    EmployeeCode = "EMP003",
                    FullName = "Charlie Brown",
                    Email = "charlie@example.com",
                    Designation = "UI/UX Designer",
                    Salary = 55000,
                    ProjectId = 2
                }
            );
        }


            
           

    }
}
