using EmpMvc.Data;
using EmpMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpMvc.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly EmpMvcContext _context;

        public EmployeeService(EmpMvcContext context)
        {
            _context = context;
        }
        public Task Add(Employee employee)
        {
            _context.Employees.Add(employee);
            return Task.CompletedTask;
        }

        public Task<Employee> Fire(int id)
        {
            return Task.Run(() =>
            {
                var employee = _context.Employees.FirstOrDefault(c => c.Id == id);
                if (employee != null)
                {
                    employee.Fired = true;
                    return employee;
                }

                return null;
            });
        }

        public Task<IEnumerable<Employee>> GetByDepartmentId(int departmentId)
        {
            return Task.Run(()=>_context.Employees.AsEnumerable());
        }
    }
}
