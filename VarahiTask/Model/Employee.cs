using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VarahiTask.Model
{
    [Table("Employee")]
    public class Employee

    {
        [Key]
        public int Id { get; set; }
        public string? EmpName { get; set; }
        public decimal Salary { get; set; }
        public string? Department { get; set; }
        public int WorkingDay { get; set; }
        public int IsActive { get; set; }
    }
}
