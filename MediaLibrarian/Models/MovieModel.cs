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
        [Required]
        [Range(0, 100)]
        [Display(Name = "User Rating")]
        public int UserRating { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public MPAARatingCategory MPAA { get; set; }       
        public int RunTimeHours { get; set; } 
        public int RunTimeMinutes { get; set; }
        [Required]
        public string ReleaseDate { get; set; }


        [Required]
        public MovieGenreCategory Genre { get; set; }
        public string? GenreTwo { get; set; }
        public string? GenreThree { get; set; }
        [Required]
        public string Image { get; set; }
    }
}
