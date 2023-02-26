
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DIDemo.Models
{
    [Table("tblstudent")]
    public class Student
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
        [MaxLength(100)]
        public string Phone { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public int Marks { get; set; }
    }
}
