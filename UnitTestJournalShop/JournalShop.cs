﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestJournalShop;
using UnitTestJournalShop.Models;


namespace UnitTestJournalShop
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void JournalShopTest()
        {
            DateTime date = DateTime.Now;
            // Instance of the movie model to be tested
            Journal journal = new Journal();

        }
    }
}


//// Instance of the DateTime class
//DateTime date = DateTime.Now;

//// Instance of the movie model to be tested
//Movie movie = new Movie();

//// Assigning values to various fields of the model
//movie.Id = 1;
//            movie.Genre = "Romance";
//            movie.Price = 20;
//            movie.ReleaseDate = date;
//            movie.Title = "The Photograph";

//            // Assert to check for equality between assigned values and those store in the database
//            Assert.Equal(1, movie.Id);
//            Assert.Equal("Romance", movie.Genre);
//            Assert.Equal(20, movie.Price);
//            Assert.Equal(date, movie.ReleaseDate);
//            Assert.Equal("The Photograph", movie.Title);