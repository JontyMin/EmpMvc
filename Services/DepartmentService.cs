using EmpMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmpMvc.Data;
using Microsoft.EntityFrameworkCore;

namespace EmpMvc.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly EmpMvcContext _context;

        public DepartmentService(EmpMvcContext context)
        {
            _context = context;
        }
        public Task Add(Department department)
        {
            _context.Departments.Add(department);
            return Task.CompletedTask;
        }

        public Task<IEnumerable<Department>> GetAll()
        {
            return Task.Run(
                () => _context.Departments.AsEnumerable()
            );
        }

        public Task<Department> GetById(int id)
        {
            return Task.Run(
                () => _context.Departments.FirstOrDefault(x => x.ID == id)
                );
        }

        public Task<CompanySummary> GetCompanySummary()
        {
            return Task.Run(
                () =>
                {
                    return new CompanySummary
                    {
                        EmployeeCount = _context.Departments.Sum(c=>c.EmployeeCount),
                        AverageDepartmentEmployeeCount = (int)_context.Departments.Average(c=>c.EmployeeCount)
                    };
                }
                );
        }
    }
}
