using System;
using System.Collections.Generic;

namespace MaximumProductofAdjacentdigits
{



    /// <summary>
    /// class Find the four adjacent digits in any given number that have the greatest product. What is the value of this product
    /// </summary>
     class ToFindMaximumProduct
    {
        /// <summary>
        /// Method to find the four adjacent digits in any given number that have the greatest product. What is the value of this product
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {
            string givenInput = (Console.ReadLine());
            ValidationsForMaxProduct o = new ValidationsForMaxProduct();
            bool isValid = o.TestcasesValidations((givenInput));
            if (isValid == false) return;
            FunctionToFindMaxProduct object1 = new FunctionToFindMaxProduct();

            List<int> List1 = (object1.MaxProductOfAdjacentDigits((givenInput)));
            Displayoflist object2 = new Displayoflist();
            object2.DisplayMethod(List1);
        }
    }
}
