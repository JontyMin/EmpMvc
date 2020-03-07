using System.Collections;

namespace EmpMvc.Models
{
    public class Department : IEnumerable
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int EmployeeCount { get; set; }
        public IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}
