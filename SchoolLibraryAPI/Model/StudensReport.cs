using SchoolLibraryAPI.Enums;
using System.ComponentModel.DataAnnotations;

namespace SchoolLibraryAPI.Model
{
    public class Studens
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        [Range(10, 13)]
        public int Grade { get; set; }

        [Required]
        public int BookId { get; set; }

        [Required]
        public DateTime BorrowDate {  get; set; } = DateTime.Now;
    }
}