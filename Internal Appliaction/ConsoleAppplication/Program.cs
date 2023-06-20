using ConsoleAppplication;
using BusinessModel;
using System.Text.RegularExpressions;
public class Program
{
    public enum Choice 
    {
        Register = 1,
        Login = 2
    }
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Please enter\n1 for registration\n2 for login");
            UserInputs object1 = new UserInputs();
            string choice = Console.ReadLine();
            if (!Regex.IsMatch(choice, "[1-2]"))
            {
                Console.WriteLine(Literals._inValidChoice);
            }
            else
            {
                int ch = Convert.ToInt32(choice);
                switch (ch)
                {
                    case (int)Choice.Register:
                        object1.RegisterInput();
                        break;
                    case (int)Choice.Login:
                        object1.LoginInput();
                        break;
                    default:
                        Console.WriteLine(Literals._inValidChoice);
                        break;
                }
            }
        }
    }
}
