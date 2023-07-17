using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleWebApplication.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string Publisher { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string Author { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string Category { get; set; }

    }
}
