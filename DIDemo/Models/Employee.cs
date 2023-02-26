
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DIDemo.Models
{
    [Table("tblEmp")]
    public class Employee
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [Display(Name ="Mobile No")]
        [MaxLength(10)]
        public string Mobile { get; set; }
        [Required]
        public int Age { get; set; }
    }
}
