using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDSudokuSolver;
namespace SudokuSolverTests
{
    [TestClass]
    public class ArrayConverterTests
    {
        /// <summary>
        /// Checks if a new array can be made from one of the 3-by-3 boxes in a 2 dimensional array.
        /// </summary>
        /// <example>
        /// The first 3 numbers from the first 3 rows, shown as x's in the code example. Example shows an invalid case.
        /// <code>
        /// { X, X, X, 1, 2, 3, 1, 2, 3 }
        /// { X, X, X, 1, 2, 3, 1, 2, 3 }
        /// { X, X, X, 1, 2, 3, 1, 2, 3 }
        /// { 1, 2, 3, 1, 2, 3, 1, 2, 3 }
        /// { 1, 2, 3, 1, 2, 3, 1, 2, 3 }
        /// { 1, 2, 3, 1, 2, 3, 1, 2, 3 }
        /// { 1, 2, 3, 1, 2, 3, 1, 2, 3 }
        /// { 1, 2, 3, 1, 2, 3, 1, 2, 3 }
        /// { 1, 2, 3, 1, 2, 3, 1, 2, 3 }
        /// </code>
        /// </example>
        /// <param name="BoxNumber"></param>
        /// <param name="ExpectedArray"></param>
        [DataRow(1, new int[9] { 1, 2, 3, 1, 2, 3, 1, 2, 3 })]
        [DataRow(2, new int[9] { 4, 5, 6, 4, 5, 6, 4, 5, 6 })]
        [DataRow(3, new int[9] { 7, 8, 9, 7, 8, 9, 7, 8, 9 })]
        [DataRow(4, new int[9] { 1, 2, 3, 1, 2, 3, 1, 2, 3 })]
        [DataRow(5, new int[9] { 4, 5, 6, 4, 5, 6, 4, 5, 6 })]
        [DataRow(6, new int[9] { 7, 8, 9, 7, 8, 9, 7, 8, 9 })]
        [DataRow(7, new int[9] { 1, 2, 3, 1, 2, 3, 1, 2, 3 })]
        [DataRow(8, new int[9] { 4, 5, 6, 4, 5, 6, 4, 5, 6 })]
        [DataRow(9, new int[9] { 7, 8, 9, 7, 8, 9, 7, 8, 9 })]
        [TestMethod]
        public void ConvertBox_AllBoxes_ReturnsCorrectArray(int BoxNumber, int[] ExpectedArray)
        {
            //arrange
            int[,] Array2D = new int[9, 9]
                {
                    { 1,2,3,4,5,6,7,8,9 },
                    { 1,2,3,4,5,6,7,8,9 },
                    { 1,2,3,4,5,6,7,8,9 },
                    { 1,2,3,4,5,6,7,8,9 },
                    { 1,2,3,4,5,6,7,8,9 },
                    { 1,2,3,4,5,6,7,8,9 },
                    { 1,2,3,4,5,6,7,8,9 },
                    { 1,2,3,4,5,6,7,8,9 },
                    { 1,2,3,4,5,6,7,8,9 }
                };

            //act
           int[] array = ArrayConverter.ConvertBox(Array2D, BoxNumber);


            //assert
            Assert.AreEqual(ExpectedArray, array);
        }
    }
}
