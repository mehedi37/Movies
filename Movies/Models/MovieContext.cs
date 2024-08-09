using Microsoft.EntityFrameworkCore;

namespace Movies.Models
{
    public class MovieContext(DbContextOptions<MovieContext> options) : DbContext(options)
    {
        public DbSet<MoviesModel> Movies { get; set; }
    }
}
