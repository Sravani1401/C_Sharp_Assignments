using System;
using System.Collections.Generic;

namespace MaximumProductofAdjacentdigits
{
    /// <summary>
    /// Class Function to find maximum product for the Adjacent digits
    /// </summary>
     class FunctionToFindMaxProduct
    {
        /// <summary>
        /// Function to find maximum product for the adjacent digits
        /// </summary>
        /// <param name="givenValue"></param>
        /// <returns></returns>
        public List<int> MaxProductOfAdjacentDigits(string givenInput)
        {
            List<int> List1 = new List<int>();

            int product, maxProduct = 1;
            string findResult = "";

            for (int i = 0; i <= givenInput.Length - 4; i++)
            {

                char a = givenInput[i];
                char b = givenInput[i + 1];
                char c = givenInput[i + 2];
                char d = givenInput[i + 3];
                string result = a.ToString() + b.ToString() + c.ToString() + d.ToString();
                product = (a - '0') * (b - '0') * (c - '0') * (d - '0');
                /*Console.WriteLine(Product);*/
                if (maxProduct < product)
                {
                    maxProduct = product;
                    findResult = (result);
                }

            }
            List1.Add(Convert.ToInt32(findResult));
            List1.Add(maxProduct);
            return List1;
        }
       
    }
}
