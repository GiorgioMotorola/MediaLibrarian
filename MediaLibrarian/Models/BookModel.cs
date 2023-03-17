using MediaLibrarian.Enums;
using System.ComponentModel.DataAnnotations;

namespace MediaLibrarian.Models
{
    public class BookModel
    {
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Writer { get; set; }
        [Required]
        public BookGenreCategory Genre { get; set; }
        public string? GenreTwo { get; set; }
        public string? GenreThree { get; set; }
        [Range(1.0, 10.0)]
        public float UserRating { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public string Image { get; set; }
    }
}
