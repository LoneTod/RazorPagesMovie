using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovies.Modelos;

namespace RazorPagesMovies.Data
{
    public class RazorPagesMoviesContext : DbContext
    {
        public RazorPagesMoviesContext (DbContextOptions<RazorPagesMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovies.Modelos.Movie> Movie { get; set; }
    }
}
