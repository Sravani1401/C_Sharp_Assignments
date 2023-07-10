using BusinessModel;
using DataLayer;
namespace BusinessLayer
{
    /// <summary>
    /// Business Authentication for Validation of login and register
    /// </summary>
    internal class BusinessAuthentication : IBAL
    {
        /// <summary>
        /// Method for Login validaton
        /// </summary>
        /// <returns></returns>
        public bool login(Users user)
        {

            DataFactory dataFactoryObj = new DataFactory();
            IInterfacemethods ds = dataFactoryObj.DataAuthenticationmethod();
           
            if (ds.CheckLogin(user))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Method for Register
        /// </summary>
        /// <returns></returns>
        public bool Register(Users user)
        {
            DataFactory dataFactoryObj = new DataFactory();
            IInterfacemethods ds = dataFactoryObj.DataAuthenticationmethod();

            if (ds.CheckRegistration(user))
            {
                return true;
            }
            return false;
        }
    }
}