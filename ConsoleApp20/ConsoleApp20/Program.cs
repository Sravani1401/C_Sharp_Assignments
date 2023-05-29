﻿using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    /// <summary>
    /// Class of main method Take two strings as input and check whether the second string is a sub-string of the first or not. If yes, 
    /// print the number of times occurredured in S1 and print the index positions 
    /// </summary>
    class CountSubstring
    {
        /// <summary>
        /// Take two strings as input and check whether the second string is a sub-string of the first or not. If yes, print the number of timesoccurredured in S1 and print the index positions
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            CountSubstrings object1 = new CountSubstrings();
            Console.WriteLine("Enter String Input");
            string givenstring = Console.ReadLine();
            Console.WriteLine("Enter Substring Input");
            string givenSubstring = Console.ReadLine();
            InputValidations object2= new InputValidations();
            bool checkvalidations=object2.TestcasesValidations(givenstring,givenSubstring);
            if(checkvalidations==false)
            {
                return;
            }
            Display object3 = new Display();
            List<int> List1 = (object1.CountSubstringsAndIndexPositions(givenstring, givenSubstring));
            object3.DisplayResult(List1);
               

        }
    }
}