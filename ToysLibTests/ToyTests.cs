using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToysLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToysLib.Tests
{
    [TestClass()]
    public class ToyTests
    {
        [TestMethod()]
        public void ToStringTest()
        {
            // Arrange
            Toy toy = new Toy();
            
            toy.Id = 1;
            toy.Brand = "Lego";
            toy.Model = "Star Wars";
            toy.Price = 19;
            
            // Act
            string result = toy.ToString();
            // Assert
            Assert.AreEqual("Id: 1, Brand: Lego, Model: Star Wars, Price: 19", result);
        }

        [TestMethod()]
        public void ValidateBrandTest()
        {
            // Arrange
            Toy toy = new Toy();
            toy.Brand = "Lego";
            // Act
            toy.ValidateBrand();
            // Assert
            Assert.IsTrue(true);
        }
        [TestMethod()]
        public void ValidateBrandTestException()
        {
            // Arrange
            Toy toy = new Toy();
            toy.Brand = "";
            // Act
            // Assert
            Assert.ThrowsException<ArgumentException>(() => toy.ValidateBrand());
        }
        [TestMethod()]
        public void ValidateModelTest()
        {
            // Arrange
            Toy toy = new Toy();
            toy.Model = "Star Wars";
            // Act
            toy.ValidateModel();
            // Assert
            Assert.IsTrue(true);
        
        }
        [TestMethod()]
        public void ValidateModelTestException()
        {
            // Arrange
            Toy toy = new Toy();
            toy.Model = "";
            // Act
            // Assert
            Assert.ThrowsException<ArgumentException>(() => toy.ValidateModel());
        }
    }
}