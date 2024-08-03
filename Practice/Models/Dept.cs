using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Practice.Models
{
    public class Dept
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Department Name")]
        public string Deptname { get; set; }
    }
}
