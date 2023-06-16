using BusinessLayer;
using BusinessModel;

namespace ConsoleApp
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
        public bool loginAuthentication(User user)
        {

            BusinessAuthentication obj2 = new BusinessAuthentication();
            if (obj2.login(user))
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
        public bool RegisterAuthentication(User user)
        {
            BusinessAuthentication obj2 = new BusinessAuthentication();
            if (obj2.Register(user))
            {
                return true;
            }
            return false;
        }

    }
}
