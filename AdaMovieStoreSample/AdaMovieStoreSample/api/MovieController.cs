using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AdaMovieStoreSample.DataLayer;
using AdaMovieStoreSample.Models;

namespace AdaMovieStoreSample.api
{
    public class MovieController : ApiController
    {
        // GET: api/Movie
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Movie/5
        public Movie Get(int id)
        {
            var movieRepo = new MovieRepository();
            return movieRepo.Find(id);
        }

        // POST: api/Movie
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Movie/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Movie/5
        public void Delete(int id)
        {
        }
    }
}
