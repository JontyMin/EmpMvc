namespace EmpMvc.Models
{
    public class Employee
    {
        public int Id { get; set; }
        
        public int DepartmentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Gender { get; set; }
        public bool Fired { get; set; }
    }
}
