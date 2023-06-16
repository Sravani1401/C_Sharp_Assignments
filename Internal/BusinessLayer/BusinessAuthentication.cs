using DataTlayer;
using BusinessModel;
namespace BusinessLayer
{
    /// <summary>
    /// Business Authentication for Validation of login and register
    /// </summary>
    public class BusinessAuthentication
    {
        /// <summary>
        /// Method for Login validaton
        /// </summary>
        /// <returns></returns>

        User obj = new User();
        public bool login(User user)
        {

            DataFactory ds = new DataFactory();
            if (ds.DataAuthenticationmethod().IsLogIn(user))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Method for Register
        /// </summary>
        /// <returns></returns>
        public bool Register(User user)
        {
            DataFactory ds = new DataFactory();

            if (ds.DataAuthenticationmethod().IsRegistred(user))
            {
                return true;
            }
            return false;
        }
    }
}