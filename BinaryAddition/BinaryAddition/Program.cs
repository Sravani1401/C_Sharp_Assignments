using System;
using System.Collections.Generic;


namespace BinaryAddition
{
   
    class Program
    {
        static void Main(string[] args)
        {
            double givenInput1 = Convert.ToDouble(Console.ReadLine());
            double givenInput2 = Convert.ToDouble(Console.ReadLine());
            SeperateIntegerAndDecimal object1= new SeperateIntegerAndDecimal();
            List<double> List1 = object1.MethodForSeperatingIntegerAndDecimal(givenInput1);
            List<double> List2 = object1.MethodForSeperatingIntegerAndDecimal(givenInput2);
            DisplayOfList object2= new DisplayOfList();
            
            object2.DisplayList(List1);
            object2.DisplayList(List2);

            FractionalPart object3 = new FractionalPart();
            string a=object3.FractionalTobinary(List1[1]);
            Console.WriteLine(a);
            string b= object3.FractionalTobinary(List2[1]);
            Console.WriteLine(b);
            IntegerPart object4 = new IntegerPart();
            string c = object4.Binary(Convert.ToInt32(List1[0]));
            Console.WriteLine(c);
            string d = object4.Binary(Convert.ToInt32(List2[0]));
            Console.WriteLine(d);
            BinaryAdditionForBinary object5 = new BinaryAdditionForBinary();
            string f=object5.BinaryAdditionForBoth(a, b, 0);
            Console.WriteLine(f);
            string result;
            if(f.Length==25)
            {
                result=object5.BinaryAdditionForBoth(c, d, 1);
                f = f.Substring(1);
            }
            else
            {
                result=object5.BinaryAdditionForBoth(c, d, 0);
            }
            Console.WriteLine(result+'.'+f);
            Numerical object6= new Numerical();
            int integer=object6.BinaryToDecimal(result);
            double fraction=(object6.BinaryToFraction(f));
            fraction = fraction +  integer;
            Console.WriteLine(fraction);
            

        }
    }
}
