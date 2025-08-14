using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeProjectTrackerAPI.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required, StringLength(8)]
        public string EmployeeCode { get; set; }

        [Required, StringLength(150)]
        public string FullName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, StringLength(50)]
        public string Designation { get; set; }

        [Required]
        public decimal Salary { get; set; }

        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
