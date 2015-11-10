using System;
using System.Diagnostics;
using AdaMovieStoreSample.DataLayer;
using AdaMovieStoreSample.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;



namespace AdaMovieStoreSample.Tests
{
    [TestClass]
    public class MovieRepositoryTests
    {
        [TestMethod]
        public void Get_all_should_return_3_results()
        {
            IMovieRepository repository = CreateRepository();

            var movies = repository.GetAll();
            Assert.IsTrue(movies.Count == 3);
        }

        private IMovieRepository CreateRepository()
        {
            return new MovieRepository();
        }
    }
}
