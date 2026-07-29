using SchoolLibraryAPI.Enums;
using System.ComponentModel.DataAnnotations;

namespace SchoolLibraryAPI.Model
{
    public class Books
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        [StringLength(100)]
        public string Autor {  get; set; }

        [Required]
        public Genres Genre { get; set; }

        [Required]
        [Range(1000, 2030)]
        public int years {  get; set; }
    }
}