using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc.Html;
using AdaMovieStoreSample.Interfaces;
using AdaMovieStoreSample.Models;
using Dapper;

namespace AdaMovieStoreSample.DataLayer
{
    public class MovieRepository: IMovieRepository
    {
        private IDbConnection db = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFileName=C:\Users\x1e5.NORD\Source\Repos\AdaMovieStoreSample\AdaMovieStoreSample\AdaMovieStoreSample\AdaMovieStoreSample\App_Data\movieStore.mdf;Integrated Security=True");
        public Movie Find(int id)
        {
            throw new NotImplementedException();
        }

        public List<Movie> GetAll()
        {
            return this.db.Query<Movie>("select * from movie").ToList();
        }

        public Movie Add(Movie movie)
        {
            throw new NotImplementedException();
        }

        public Movie Update(Movie movie)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Movie GetFullMovie(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}
