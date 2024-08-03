using System.ComponentModel.DataAnnotations;

namespace Practice.Models
{
    public class Emp
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string DepartmentName { get; set; }


    }
}
