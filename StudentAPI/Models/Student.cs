using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentAPI.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string Name { get; set; } = "";

        public string ContactNumber { get; set; }

        public string Age { get; set; }
    }
}
