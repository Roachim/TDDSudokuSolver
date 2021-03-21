using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SudokuSolverTests
{
    [TestClass]
    public class CheckerTests
    {
        [TestMethod]
        public void IsArrayValid_PartialFilled_True()
        {
            //Arrange
            //Need 2 dimensional array
            //fill with number a few places
            int[] Array = new int[9];
            bool ExpectedResult = true;

            //Act
            //Run method that chekcs
            bool ActualResult = CheckerTests.IsArrayValid(Array);


            //assert
            //is true returned??
            Assert.AreEqual(ExpectedResult, ActualResult);
        }

    }
}
