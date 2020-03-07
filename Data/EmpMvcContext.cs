using EmpMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace EmpMvc.Data
{
    public class EmpMvcContext:DbContext
    {
        public EmpMvcContext(DbContextOptions<EmpMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }


    }
}
