using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDSudokuSolver;

namespace SudokuSolverTests
{
    [TestClass]
    public class CheckerTests
    {
        [TestMethod]
        public void IsArrayValid_PartialFilled_True()
        {
            //A 0 in the array counts as an empty space, therefore it is called "partialFilled."
            //Arrange
            int[] Array = new int[9] {1,0,4,8,2,0,9,0,0 };
            bool ExpectedResult = true;

            //Act
            bool ActualResult = Checker.IsArrayValid(Array);


            //assert
            Assert.AreEqual(ExpectedResult, ActualResult);
        }


        [TestMethod]
        public void IsArrayValid_PartialFilled_False()
        {
            //A 0 in the array counts as an empty space, therefore it is called "partialFilled."
            //Arrange
            int[] Array = new int[9] { 1, 0, 4, 8, 2, 0, 9, 1, 1 };
            bool ExpectedResult = false;

            //Act
            bool ActualResult = Checker.IsArrayValid(Array);


            //assert
            Assert.AreEqual(ExpectedResult, ActualResult);
        }


        [TestMethod]
        public void IsArrayValid_Filled_True()
        {
            //A 0 in the array counts as an empty space, therefore it is called "partialFilled."
            //Arrange
            int[] Array = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            bool ExpectedResult = true;

            //Act
            bool ActualResult = Checker.IsArrayValid(Array);


            //assert
            Assert.AreEqual(ExpectedResult, ActualResult);
        }


        [TestMethod]
        public void IsArrayValid_Filled_false()
        {
            //A 0 in the array counts as an empty space, therefore it is called "partialFilled."
            //Arrange
            int[] Array = new int[9] { 1, 1, 3, 4, 5, 6, 7, 8, 9 };
            bool ExpectedResult = false;

            //Act
            bool ActualResult = Checker.IsArrayValid(Array);


            //assert
            Assert.AreEqual(ExpectedResult, ActualResult);
        }


        [TestMethod]
        public void IsArrayValid_Empty_True()
        {
            //A 0 in the array counts as an empty space, therefore it is called "partialFilled."
            //Arrange
            int[] Array = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            bool ExpectedResult = true;

            //Act
            bool ActualResult = Checker.IsArrayValid(Array);


            //assert
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
    }
}
