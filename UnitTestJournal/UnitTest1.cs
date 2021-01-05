using Microsoft.VisualStudio.TestTools.UnitTesting;
using JournalShop;
using System;
using JournalShop.Models;


namespace UnitTestJournal
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void JournalTest()
        {
            // Act
            // Instance of the DateTime class
            DateTime date = DateTime.Now;

            // Instance of the movie model to be tested
            Journal journal = new Journal();

            // Arrange
            journal.Id = 1;
            journal.Material = "Wooden";
            journal.PageNumber = 300;
            journal.Price = 76.9M;
            journal.Size = "Extra Large";
            journal.Color = "Burgandy";
            journal.StockDate = date;

            // Assert
            Assert.AreEqual(1, journal.Id);
            Assert.AreEqual("Wooden", journal.Material);
            Assert.AreEqual(300,journal.PageNumber);
            Assert.AreEqual(76.9M, journal.Price);
            Assert.AreEqual("Extra Large", journal.Size);
            Assert.AreEqual("Burgandy", journal.Color);
            Assert.AreEqual(date, journal.StockDate);



        }
    }
}




