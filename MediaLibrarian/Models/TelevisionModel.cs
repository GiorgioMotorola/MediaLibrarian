using MediaLibrarian.Enums;
using System.ComponentModel.DataAnnotations;

namespace MediaLibrarian.Models
{
    public class TelevisionModel
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
        public int YearStart { get; set; }
        public int? YearEnd { get; set; }
        [Required]
        public string Seasons { get; set; }


        [Required]
        public TelevisionGenreCategory Genre { get; set; }
        public string? GenreTwo { get; set; }
        public string? GenreThree { get; set; }
        [Required]
        public string Image { get; set; }
    }
}
