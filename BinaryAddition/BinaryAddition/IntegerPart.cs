using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryAddition
{
     class IntegerPart
    {
        public string Binary(int value)
        {

            string binary = "";
            int count = 0;
            while (count <= 32)
            {
                // storing remainder in binary array
                binary = binary + (value % 2);
                value = value / 2;
                count++;
            }
            int len;
            len = binary.Length - 1;
            string rev = "";
            while (len >= 0)
            {
                rev = rev + binary[len];
                len--;
            }
            return rev;

        }
    }
}
