public class program
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
