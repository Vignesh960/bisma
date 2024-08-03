using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bishmaji.Models
{
    public class Department
    {
        [Key]
        public Guid DepartmentId { get; set; }
        [Required]
        [DisplayName("Department Name")]
        public string DepartmentName { get; set; }
        //public ICollection<Employee> Employees { get; set; }
    }
}
