using BusinessLayer;
using BusinessModel;
using DataLayer;

namespace ConsoleAppplication
{
    /// <summary>
    /// Class  Authentication for Login and regsiter from BusinessAuthentication
    /// </summary>
    public class ConsoleAuthentication
    {
        /// <summary>
        /// Method for Login  Authentication from BusinessAuthentication
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool loginAuthentication(Users user)
        {
            BALfactory BalFactoryObj = new BALfactory();

            IBAL bsValid = BalFactoryObj.BusinessAuthenticationMethod();

            //BusinessAuthentication object2 = new BusinessAuthentication();
            if (bsValid.login(user))
            {
                return true;
            }
            return false;

        }
        /// <summary>
        /// Method for Register  Authentication from BusinessAuthentication
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool RegisterAuthentication(Users user)
        {
            BALfactory BalFactoryObj = new BALfactory();
            IBAL bs = BalFactoryObj.BusinessAuthenticationMethod();
            if (bs.Register(user))
            {
                return true;
            }
            return false;
        }

    }
}

