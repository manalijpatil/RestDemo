using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestDemo.Model
{
    [Table("book")]
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Author { get; set; }
        [Required]

        [Column(TypeName = "decimal(5, 2)")]
        public decimal Price {  get; set; }
    }
}
