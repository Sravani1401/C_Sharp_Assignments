using BusinessModel;
using BusinessLayer;

namespace ConsoleApp
{
    /// <summary>
    /// class for taking inputs from user
    /// </summary>
    public class RegisterandLogin
    {
        /// <summary>
        /// Method for taking inputs from users
        /// </summary>

        public void RegisterInput()
        {
            User obj = new User();
            ConsoleAuthentication obj2 = new ConsoleAuthentication();
            BusinessValidations valid = new BusinessValidations();
            Console.WriteLine(Literals._DisplayUserName);
            obj.UserName = Console.ReadLine();
            Console.WriteLine(Literals._DisplayEmail);
            obj.Email = Console.ReadLine();
            Console.WriteLine(Literals._Displayphonenumber);
            obj.phonenumber = Console.ReadLine();

            Console.WriteLine(Literals._DisplayPassword);
            obj.password = Console.ReadLine();
            int flag = 1;
            if (valid.isValidName(obj.UserName) == false)
            {
                flag = 0;
                Console.WriteLine(Literals._inavalidUsername);
            }
           
            if (valid.isValidMobile(obj.phonenumber) == false)
            {
                flag = 0;
                Console.WriteLine(Literals._inavalidPhoneNumber);
            }
            if (valid.isValidPassword(obj.password) == false)
            {
                flag = 0;
                Console.WriteLine(Literals._invalidPassword);
            }
            if (flag == 1)
            {
                if (obj2.RegisterAuthentication(obj))
                {
                    Console.WriteLine(Literals._ValidRegistration);
                }
                else
                {
                    Console.WriteLine(Literals._inValidRegistration);
                }
            }
        }
        public void LoginInput()
        {
            User obj = new User();
            ConsoleAuthentication obj2 = new ConsoleAuthentication();

            Console.WriteLine(Literals._DisplayUserName);
            obj.UserName = Console.ReadLine();
            Console.WriteLine(Literals._DisplayPassword);
            obj.password = Console.ReadLine();
            int flag = 1;
            BusinessValidations valid = new BusinessValidations();
            if (valid.isValidName(obj.UserName) == false)
            {
                flag = 0;
                Console.WriteLine(Literals._inavalidUsername);
            }
            if (valid.isValidPassword(obj.password) == false)
            {
                flag = 0;
                Console.WriteLine(Literals._invalidPassword);
            }
            if (flag == 1)
            {
                if (obj2.loginAuthentication(obj))
                {
                    Console.WriteLine(Literals._ValidLogin);
                }
                else
                {
                    Console.WriteLine(Literals._inValidLogin);
                }
            }
        }
    }
}
