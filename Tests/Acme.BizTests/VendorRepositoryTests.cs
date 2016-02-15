using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class VendorRepositoryTests
    {
        [TestMethod()]
        public void RetrieveValueTestWithInt()
        {
            //Arrange
            var repo = new VendorRepository();
            var expected = 32;

            //Act
            var actual = repo.RetrieveValue<int>("Select  ...", 32);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RetrieveValueTestWithString()
        {
            //Arrange
            var repo = new VendorRepository();
            var expected = "* From People Where Name == 'Ronald'";

            //Act
            var actual = repo.RetrieveValue<string>("Select  ...", "* From People Where Name == 'Ronald'");

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}