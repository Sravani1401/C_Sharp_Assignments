using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumProductofAdjacentdigits
{
    /// <summary>
    /// Displaying message for incorrect inputs 
    /// </summary>
     class Displayoflist
    {   
        
            public void DisplayMethod(List<int> List1)
            {
                Console.WriteLine("Adjacent Digits:");
                Console.WriteLine(List1[0]);
                Console.WriteLine("MaxProduct:");
                Console.WriteLine(List1[1]);
            }
        
    }
}
