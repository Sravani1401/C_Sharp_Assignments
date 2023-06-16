using BusinessModel;
namespace BusinessLayer
{ 
    /// <summary>
    /// Business Validations for Validation of Username,password,Email,Mobile 
    /// </summary>
    public class BusinessValidations
    {
        /// <summary>
        /// Method for username validaton
        /// </summary>
        /// <returns></returns>
        User obj = new User();
        public bool isValidName(string Input)
        {
            //bool isAlpha = Input.All(Char.IsLetter);
            //return (isAlpha);
            for (int i = 0; i < Input.Length; i++)
            {
                if (!Char.IsLetter(Input[i]))
                {
                    return false;
                }

            }
            return true;
        }
        ///// <summary>
        ///// Method for Email Validation
        ///// </summary>
        ///// <returns></returns>
        //public bool isValidEmail(string Email)
        //{
        //     Email = obj.Email;
        //    int count = 0;
        //    for(int i=0;i<Email.Length;i++) {
        //        if (Email[i]=='@')
        //        {
        //            count = 1;
        //        }
        //    }
        //    return false;
        //}
        /// <summary>
        /// Method for Mobile Validation
        /// </summary>
        /// <returns></returns>

        public bool isValidMobile(string phonenumber)
        {

            if (phonenumber.Length == 10)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Method for password Validation
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool isValidPassword(string password)
        {

            if (password.Length == 6)
            {
                return true;
            }
            return false;
        }
    }
}
