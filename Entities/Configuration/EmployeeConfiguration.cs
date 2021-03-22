using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Entities.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {

            builder.HasOne("Entities.Models.Company", "Company").WithMany("Employees").HasForeignKey("CompanyId").OnDelete(DeleteBehavior.Cascade).IsRequired();

            builder.HasData
            (
            new Employee
            {
                Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                Name = "Masoud Keshavarz",
                Age = 30,
                Position = "Full Stack Engineer",
                CompanyId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")
            }
            );
        }
    }
}
