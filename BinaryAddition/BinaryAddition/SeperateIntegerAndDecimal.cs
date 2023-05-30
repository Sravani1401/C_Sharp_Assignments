using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryAddition
{
     class SeperateIntegerAndDecimal
    {
        public List<double> MethodForSeperatingIntegerAndDecimal(double givenInput)
        {
            List<double> List1 = new List<double>();
            string b = Convert.ToString(givenInput);
            string v = "";
            int k = 0;
            while (k < b.Length)
            {

                if (b[k] == '.')
                {
                    break;
                }
                v = v + b[k];
                k++;
            }
            double first_digits = Convert.ToDouble(v);
            List1.Add(first_digits);
            double decimalFraction = givenInput - first_digits;

            List1.Add(decimalFraction);
            return List1;

        }

    }
}
