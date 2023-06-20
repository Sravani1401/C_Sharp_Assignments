using BusinessModel;
namespace DataLayer
{
    public class DataAuthentication : IInterfacemethods
    {
        public void AddUser(Users user)
        {
            DataSource.datatable.Add(user);
        }
        /// <summary>
        /// Method for User login  
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool IsLogin(Users user)
        {
            Users findUserLogin = DataSource.datatable.Find(findUserLogin => findUserLogin.UserName == user.UserName);
            if (findUserLogin != null)
            {
                if (findUserLogin.Password == user.Password)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Method for User Registration
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool IsRegistered(Users user)
        {
            Users findUserRegistration = DataSource.datatable.Find(findUserRegistration => findUserRegistration.UserName == user.UserName);
            if (findUserRegistration != null)
            {
                return false;
            }
            DataSource.datatable.Add(user);
            return true;
        }
    }
}



