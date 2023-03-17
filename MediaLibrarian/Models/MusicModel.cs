using MediaLibrarian.Enums;
using System.ComponentModel.DataAnnotations;

namespace MediaLibrarian.Models
{
    public class MusicModel
    {
        public Guid Id { get; set; }
        [Required]
        public string Artist { get; set; }
        [Required]
        public string AlbumName { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public string Label { get; set; }

        [Required]
        [Range(0, 100)]
        public int UserRating { get; set; }


        [Required]
        public MusicGenreCategory Genre { get; set; }
        public string? GenreTwo { get; set; }
        public string? GenreThree { get; set; }
        [Required]
        public string Image { get; set; }
    }
}
