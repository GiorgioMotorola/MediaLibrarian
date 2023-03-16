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
        public string Genre { get; set; }
        [Required]
        public string StyleOne { get; set; }
        public string? StyleTwo { get; set; }
        public string? StyleThree { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public string Label { get; set; }
        [Required]
        [Range(1.0, 10.0)]
        public float UserRating { get; set; }
        [Required]
        public string Image { get; set; }
    }
}
