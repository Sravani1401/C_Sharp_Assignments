namespace DataLayer
{
    public class DataAuthentication : IInterfacemethods
    {
        /// <summary>
        /// Method for adding User to Datatable
        /// </summary>
        /// <param name="user"></param>
        public void AddUser(DataModels.Users user)
        {
            DataSource.datatable.Add(user);
        }
        /// <summary>
        /// Method for Conversion of userInData to user 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        DataModels.Users ConvertToDataModel(BusinessModel.Users user)
        {
            DataModels.Users UsersInDataObj = new DataModels.Users();
            UsersInDataObj.UserName = user.UserName;
            UsersInDataObj.Password = user.Password;
            return UsersInDataObj;
        }
        /// <summary>
        /// Method for User login  
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool IsLogin(BusinessModel.Users user)
        {
            //user = new Users();
            DataModels.Users UsersInDataObj = ConvertToDataModel(user);

            DataModels.Users findUserLogin = DataSource.datatable.Find(findUserLogin => findUserLogin.UserName == UsersInDataObj.UserName);
            if (findUserLogin != null)
            {
                if (findUserLogin.Password == UsersInDataObj.Password)
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
        public bool IsRegistered(BusinessModel.Users user)
        {
            DataModels.Users findUserRegistration = DataSource.datatable.Find(findUserRegistration => findUserRegistration.UserName == user.UserName);
            if (findUserRegistration != null)
            {
                return false;
            }
            DataSource.datatable.Add(ConvertToDataModel(user));
            return true;
        }
    }
}



