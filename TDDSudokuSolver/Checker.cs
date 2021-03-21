using System;
using System.Collections.Generic;
using System.Text;

namespace TDDSudokuSolver
{
    public static class Checker
    {
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
