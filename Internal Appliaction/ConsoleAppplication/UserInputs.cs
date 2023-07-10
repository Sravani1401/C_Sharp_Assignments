using BusinessLayer;
using BusinessModel;
namespace ConsoleAppplication
{
    /// <summary>
    /// class for taking inputs from user
    /// </summary>
    public class UserInputs
    {
        /// <summary>
        /// Method for taking inputs from users for registration
        /// </summary>

        public void RegisterInput()
        {

            Users userObj = new Users();
            ConsoleAuthentication Consoleobj2 = new ConsoleAuthentication();

            BALfactory BalFactoryObj = new BALfactory();
            IBALValidations bsValid = BalFactoryObj.BusinessValidationsMethod();

            Console.WriteLine(Literals._displayUserName);
            userObj.UserName = Console.ReadLine();
            Console.WriteLine(Literals._displayEmail);
            userObj.Email = Console.ReadLine();
            Console.WriteLine(Literals._displayPhoneNumber);
            userObj.PhoneNumber = Console.ReadLine();

            Console.WriteLine(Literals._displayPassword);
            userObj.Password = Console.ReadLine();
            int flag = 1;
            if (bsValid.isValidName(userObj.UserName) == false)
            {
                flag = 0;
                Console.WriteLine(Literals._inValidUserName);
            }
            if (bsValid.IsValidEmail(userObj.Email) == false)
            {
                flag = 0;
                Console.WriteLine(Literals._inValidEmail);
            }

            if (bsValid.isValidMobile(userObj.PhoneNumber) == false)
            {
                flag = 0;
                Console.WriteLine(Literals._inValidPhoneNumber);
            }
            if (bsValid.isValidPassword(userObj.Password) == false)
            {
                flag = 0;
                Console.WriteLine(Literals._inValidPassword);
            }
            if (flag == 1)
            {
                if (Consoleobj2.RegisterAuthentication(userObj))
                {
                    Console.WriteLine(Literals._validRegistration);
                }
                else
                {
                    Console.WriteLine(Literals._inValidRegistration);
                }
            }
        }
        /// <summary>
        /// Method for taking inputs from users for login
        /// </summary>
        public void LoginInput()
        {
            Users userObj = new Users();
            ConsoleAuthentication Consoleobj2 = new ConsoleAuthentication();

            Console.WriteLine(Literals._displayUserName);
            userObj.UserName = Console.ReadLine();
            Console.WriteLine(Literals._displayPassword);
            userObj.Password = Console.ReadLine();
            int flag = 1;
            BALfactory BalFactoryObj = new BALfactory();
            IBALValidations bsValid = BalFactoryObj.BusinessValidationsMethod();
            if (bsValid.isValidName(userObj.UserName) == false)
            {
                flag = 0;
                Console.WriteLine(Literals._inValidUserName);
            }
            if (bsValid.isValidPassword(userObj.Password) == false)
            {
                flag = 0;
                Console.WriteLine(Literals._inValidPassword);
            }
            if (flag == 1)
            {
                if (Consoleobj2.loginAuthentication(userObj))
                {
                    Console.WriteLine(Literals._validLogin);
                }
                else
                {
                    Console.WriteLine(Literals._inValidLogin);
                }
            }
        }
    }
}
