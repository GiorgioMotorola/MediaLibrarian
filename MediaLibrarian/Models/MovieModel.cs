using MediaLibrarian.Enums;
using System.ComponentModel.DataAnnotations;

namespace MediaLibrarian.Models
{
    public class MovieModel
    {
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Stars { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Writer { get; set; }
        
        [Range(1.0, 10.0)]
        public float UserRating { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public MPAARatingCategory MPAA { get; set; }
        [MaxLength(2)]
        public string RunTimeHours { get; set; }
        [MaxLength(2)]
        public string RunTimeMinutes { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }


        [Required]
        public MovieGenreCategory Genre { get; set; }
        public string? GenreTwo { get; set; }
        public string? GenreThree { get; set; }
        [Required]
        public string Image { get; set; }
    }
}
