using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestDemo.Model
{
        [Table("student")]
    public class Student
    {
        [Key]
        public int Stuid { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Branch {  get; set; }
        [Required]
        [Column(TypeName = "decimal(5, 2)")]
        public decimal Marks {  get; set; }

    }
}
