using DotNetCoreConsole;

public class Program
{
   public static List<List<string>>list1 = new List<List<string>>();
    public static void Main()
    {
        while (true)
        {

            //List<string> List2 = clientlayer.inputs();
            //list1.Add(List2);

            //for (int i = 0; i < list1.Count; i++)
            //{
            //    //for (int j = 0; j < list1[i].Count; j++)
            //    //{
            //    //    Console.WriteLine(list1[i][j]);
            //    //}
            //    //Console.WriteLine("\n");

            //}
            Console.WriteLine("Please enter\n1 for login\n2 for registration");
            var choice = Console.ReadLine();
            int choice1 = int.Parse(choice);
            switch (choice)
            {
                case "1":
                    break;
                case "2":
                    ////clientlayer obj = new clientlayer();
                    clientlayer.inputs();

                    break;
                default:
                    break;


            }
            //display obj2 = new display();
            //obj2.displayLists(List1);
        }
    }
}