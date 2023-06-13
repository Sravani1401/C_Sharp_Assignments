using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCoreConsole
{
    public class clientlayer
    {
        public static List<string>inputs()
        {
          
            string Name = Console.ReadLine();
           
            string email= Console.ReadLine();
            string phonenumber= Console.ReadLine();
            string password= Console.ReadLine();
            List<string>List2= new List<string>();
            List2.Add(Name);
            List2.Add(email);
            List2.Add(phonenumber);
            List2.Add(password);
            //List1.Add(List2);
            return List2;
        }

    }
}
