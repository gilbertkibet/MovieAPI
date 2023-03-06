using CleanMovie.Application;
using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Infrastructure
{
    public class MovieRepository : IMovieRepository
    {
        public static List<Movie> movies = new List<Movie>()
        {
            
            new Movie{
                Id= 1,
                Name="Passion of Christ",
                Cost=4,
            },


            new Movie{
                Id= 1,
                Name="Unleash the man",
                Cost=4,
            },




        };

        public List<Movie> GetAllMovies()
        {
            try
            {
                return
                    movies;
            }
            catch(Exception ex)
            {
                throw new Exception();
            }
        }
    }
}
