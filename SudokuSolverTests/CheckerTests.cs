using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDSudokuSolver;

namespace SudokuSolverTests
{
    /// <summary>
    /// 
    /// </summary>
    [TestClass]
    public class CheckerTests
    {
        /// <summary>
        /// This test asserts whether or not an array, that does not contain a full set of numbers, is valid by not having dupicates.
        /// </summary>
        [TestMethod]
        public void IsArrayValid_PartialFilled_True()
        {
            //Arrange
            int[] Array = new int[9] {1,0,4,8,2,0,9,0,0 };
            bool ExpectedResult = true;

            //Act
            bool ActualResult = Checker.IsArrayValid(Array);


            //assert
            Assert.AreEqual(ExpectedResult, ActualResult);
        }

        /// <summary>
        /// Checks whether or not false is returned should the partially filled array contain a duplicate
        /// </summary>
        [TestMethod]
        public void IsArrayValid_PartialFilled_False()
        {
            //Arrange
            int[] Array = new int[9] { 1, 0, 4, 8, 2, 0, 9, 1, 1 };
            bool ExpectedResult = false;

            //Act
            bool ActualResult = Checker.IsArrayValid(Array);


            //assert
            Assert.AreEqual(ExpectedResult, ActualResult);
        }

        /// <summary>
        /// Checks if the method returns true when the array is filled and contains no duplicates
        /// </summary>
        [TestMethod]
        public void IsArrayValid_Filled_True()
        {
            //Arrange
            int[] Array = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            bool ExpectedResult = true;

            //Act
            bool ActualResult = Checker.IsArrayValid(Array);


            //assert
            Assert.AreEqual(ExpectedResult, ActualResult);
        }

        /// <summary>
        /// checks if false is returned, when the filled array contains duplicates.
        /// </summary>
        [TestMethod]
        public void IsArrayValid_Filled_false()
        {
            //Arrange
            int[] Array = new int[9] { 1, 1, 3, 4, 5, 6, 7, 8, 9 };
            bool ExpectedResult = false;

            //Act
            bool ActualResult = Checker.IsArrayValid(Array);


            //assert
            Assert.AreEqual(ExpectedResult, ActualResult);
        }

        /// <summary>
        /// Checks if true is returned, when the array is "empty".
        /// </summary>
        [TestMethod]
        public void IsArrayValid_Empty_True()
        {
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
