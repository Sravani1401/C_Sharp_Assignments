using System;
using System.Collections.Generic;


namespace BinaryAddition
{
     class DisplayOfList
    {
        public void DisplayList(List<double> list1)
        {
            for (int i = 0; i < list1.Count; i++)
            {
                Console.WriteLine(list1[i]);
            }
        }
    }
}
