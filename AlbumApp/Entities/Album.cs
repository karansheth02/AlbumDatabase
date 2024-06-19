using System.ComponentModel.DataAnnotations;

namespace AlbumApp.Entities
{
    public class Album
    {
        [Key]
        public int? Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Song { get; set; }
        [Required]
        [Range(0.0, 10.0)]
        public decimal Rating { get; set; }
    }
}
