using System;
using System.Collections.Generic;
using System.Text;

namespace TDDSudokuSolver
{
    public static class Checker
    {
        /// <summary>
        /// Checks whether a given array contains any duplicates.
        /// 0  counts as an empty space and will not be counted as a duplicate.
        /// </summary>
        /// <param name="array">The array which will be evaluated</param>
        /// <returns>RETURNS bool</returns>
        public static bool IsArrayValid(int[] array)
        {
            List<int> CheckList = new List<int>();
            foreach(int X in array)
            {
                if(X != 0)
                {
                    bool contains = CheckList.Contains(X);
                    
                    switch (contains)
                    {
                        case true:
                            return false;
                        case false:
                            CheckList.Add(X);
                            break;
                    }
                        
                    
                }

            }
            return true;
        }
    }
}
