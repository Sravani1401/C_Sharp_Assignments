<<<<<<< HEAD
﻿using ConsoleApp;
public class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Please enter\n1 for registration\n2 for login");
            var choice = Console.ReadLine();
            RegisterandLogin obj1 = new RegisterandLogin();
            switch (choice)
            {
                case "1":
                    obj1.RegisterInput();
                    break;
                case "2":
                    ////clientlayer obj = new clientlayer();
                    obj1.LoginInput();
                    break;
                default:
                    break;
            }
            //display obj2 = new display();
            //obj2.displayLists(List1);
        }
    }
}
=======
﻿public class program
{
    public static void Main()
    {
        while (true)
        {

        
            Console.WriteLine("Please enter\n1 for login\n2 for registration");
            var choice = Console.ReadLine();
            int choice1 = int.Parse(choice);
            switch (choice)
            {
                case "1":
                    login();
                    break;
                case "2":
                    ////clientlayer obj = new clientlayer();
                    registerinputs();

                    break;
                default:
                    break;
            }
            //display obj2 = new display();
            //obj2.displayLists(List1);
        }
    }
}
>>>>>>> d094bc957d6bdcd590f18d6f9ba3ea5eb290ab28
