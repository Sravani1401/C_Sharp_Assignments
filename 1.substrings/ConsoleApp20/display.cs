using System;
using System.Collections.Generic;
namespace ConsoleApp
{
    /// <summary>
    /// Class to display the Index Positions and Number of Strings
    /// </summary>
     class Display
    {
        /// <summary>
        /// Method to list the values of indexpositons and Number of Strings
        /// </summary>
        /// <param name="List1"></param>
        public  void DisplayResult(List<int> List1)
        {
            Console.WriteLine("IndexPositions: ");
            for (int i = 0; i < (List1.Count) - 1; i++)
            {
                Console.WriteLine(List1[i]);
            }
            Console.WriteLine("NoOfSubStrings: ");
            Console.WriteLine(List1[(List1.Count) - 1]);
        }
    }
}
