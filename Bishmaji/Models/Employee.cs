using System.ComponentModel.DataAnnotations;

namespace Bishmaji.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public double Salary { get; set; }
        //public Guid DepartmentId { get; set; }
        public string Department { get; set; }
    }
}
