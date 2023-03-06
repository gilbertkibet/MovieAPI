using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Application
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public IMovieRepository MovieRepository { get; }

        public List<Movie> GetAllMovies()
        {
            try
            {
                var movies= _movieRepository.GetAllMovies();

                return movies;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
