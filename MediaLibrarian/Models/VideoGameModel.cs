using MediaLibrarian.Enums;
using System.ComponentModel.DataAnnotations;

namespace MediaLibrarian.Models
{
    public class VideoGameModel
    {
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Company { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Release Date")]
        public string ReleaseDate { get; set; }
        [Required]
        public string Platform { get; set; }
        [Required]
        [Range(0, 100)]
        [Display(Name = "User Rating")]
        public int UserRating { get; set; }
        [Required]
        public ESRBRatingCategory ESRB { get; set; }


        [Required]
        public VideoGameGenreCategory Genre { get; set; }
        [Display(Name = "Sub Genre")]
        public string? GenreTwo { get; set; }
        [Display(Name = "Sub Genre")]
        public string? GenreThree { get; set; }
        [Required]
        public string Image { get; set; }
    }
}
