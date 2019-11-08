using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
               new Employee
               {
                   Id = 1,
                   Name = "Mark",
                   Department = Dept.IT,
                   Email = "email@email.com"
               },
               new Employee
               {
                   Id = 2,
                   Name = "Mark2",
                   Department = Dept.Payroll,
                   Email = "email@email.com"
               },
               new Employee
               {
                   Id = 3,
                   Name = "Mark3",
                   Department = Dept.IT,
                   Email = "email@email.com"
               }

               );
        }


    }
}
