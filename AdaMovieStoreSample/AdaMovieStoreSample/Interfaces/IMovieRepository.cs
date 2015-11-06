using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdaMovieStoreSample.Models;

namespace AdaMovieStoreSample.Interfaces
{
    public interface IMovieRepository
    {
        Movie Find(int id);
        List<Movie> GetAll();
        Movie Add(Movie movie);
        Movie Update(Movie movie);
        void Remove(int id);

        Movie GetFullMovie(int id);
        void Save(Movie movie);
    }
}
