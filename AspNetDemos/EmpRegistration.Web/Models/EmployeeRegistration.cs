using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpRegistration.Web.Models
{
    [Table(name:"EmployiesRegistration")]
    public class EmployeeRegistration
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Column(TypeName="varchar(50)")]
        public string Email { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Password { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]

        public string Address { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Country { get; set; }

        [Required]
        [Column(TypeName = "char(10)")]
        public string Gender { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "char(10)")]
        public string Phone { get; set; }
    }
}
