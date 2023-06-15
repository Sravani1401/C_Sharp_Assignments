using BusinessModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class register
    {
        User obj = new User();
        

        public string RegisterInput()
        {
            obj.UserName = Console.ReadLine();
            obj.Email = Console.ReadLine();
            obj.phonenumber = Console.ReadLine();
            obj.password = Console.ReadLine();
            return null;
        }
    }

}
