using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace BinaryAddition
{
    class Numerical
    {
        public int BinaryToDecimal(string IntegerBinary)
        {
            int number;
            int binaryNumber = Convert.ToInt32(IntegerBinary);
                int count = 0;
                int temp, var = 1;
                while (binaryNumber != 0)
                {
                    temp = binaryNumber % 10;
                    count = count + temp * var;
                    binaryNumber = binaryNumber / 10;
                    var = var * 2;
                }
                number = count;
            /*
            else
            {
                int count = 0;
                int temp, var = 1;
                while (binaryNumber != 0)
                {
                    temp = binaryNumber % 10;
                    count = count + temp * var;
                    binaryNumber = binaryNumber / 10;
                    var = var *(1/2);
                }
                number = count;
            }
            */
            return count;

        }
        public double BinaryToFraction(string IntegerBinary)
        {
            int a;
            double var = 1;
            double temp;
            double addvariable=0;
           for(int i=0; i<IntegerBinary.Length;i++)
            {
                a = IntegerBinary[i]-'0';
                var = var * (0.5);
                temp = var * a;
                addvariable = addvariable + temp;
            }
            return addvariable;
           
        }
    }
}
