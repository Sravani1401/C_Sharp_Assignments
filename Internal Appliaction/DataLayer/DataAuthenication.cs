
using AutoMapper;
using BusinessModel;
using Microsoft.VisualBasic;

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
        /// Method for User login  
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool CheckLogin(BusinessModel.Users user)
        {
            //    ConversionMethod obj = new ConversionMethod();
            //    DataModels.Users UsersinDataobj = obj.ConverttoModel<BusinessModel.Users, DataModels.Users>(user);
            //var obj = new DataModels.Users();
            //user.MatchPropertiesFrom(obj);

            DataModels.Users findUserLogin = DataSource.datatable.Find(findUserLogin => findUserLogin.UserName == user.UserName);
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
        public bool CheckRegistration(BusinessModel.Users user)
        {
           // ConversionMethod obj = new ConversionMethod();
            //DataModels.Users UsersinDataobj = obj.ConverttoModel<BusinessModel.Users, DataModels.Users>(user);
            //DataModels.Users UsersinDataObj = obj.ConvertIntoBusinessModel(user);
          //  DataModels.Users users = new DataModels.Users();
            //var obj=new DataModels.Users();
            //user.MatchPropertiesFrom(obj);
            DataModels.Users findUserRegistration = DataSource.datatable.Find(findUserRegistration => findUserRegistration.UserName == user.UserName);
            if (findUserRegistration != null)
            {
                return false;
            }
            DataModels.Users obj=new DataModels.Users();
            obj.CopyPropertiesFrom(user);
            DataSource.datatable.Add(obj);
            return true;
        }
    }
}



