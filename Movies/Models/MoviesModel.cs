using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.Models
{
    public class MoviesModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? MovieId { get; set; }
        public required string MovieName { get; set; }
        public required string CoverImage { get; set; }
        public required string Genre { get; set; }
        public required string Director { get; set; }
        public required string ReleaseDate { get; set; }
        public required int Rating { get; set; }

    }
}
