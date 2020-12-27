using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Acme.CommomTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertspceTest()
        {
            //Arrange
            var source = "SonicScredriver";
            var expected ="Sonic Scredriver";
            //Act
            var actual = source.InsertSpaces();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void InsertspceWithExitingTest()
        {
            //Arrange
            var source = "Sonic Scredriver";
            var expected = "Sonic Scredriver";
            //Act
            var actual = source.InsertSpaces();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
