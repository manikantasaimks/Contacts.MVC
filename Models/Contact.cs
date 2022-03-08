using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Contact
    {
        [Key]
        public int EmployeeID { get; set; }
        [Required]
        public string EmployeeName { get; set; }
        [Required]
        public int EmployeeAge { get; set; }
        public string EmployeeType { get; set; }
        public string EmployeeAddress { get; set; }
    }
}