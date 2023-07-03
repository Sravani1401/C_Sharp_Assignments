using System.Text.RegularExpressions;
namespace BusinessLayer
{
    /// <summary>
    ///  Business Validations for Validation of Username,password,Email,Mobile 
    /// </summary>
    internal class BusinessValidations : IBALValidations
    {
        /// <summary>
        /// Method for username validaton
        /// </summary>
        /// <returns></returns>
        public bool isValidName(string Input)
        {
            Regex regex = new Regex("^[a-zA-Z]*$");
            if (regex.IsMatch(Input))
            {
                return true;
            }
            return false;


        }
        /// <summary>
        /// Method for Email Validation
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool IsValidEmail(string email)
        {
            if (email.EndsWith("@gmail.com") == false)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Method for MobileNumber Validation
        /// </summary>
        /// <returns></returns>

        public bool isValidMobile(string phonenumber)
        {

            if (Regex.IsMatch(phonenumber, "[0-9]{10}"))
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

            if (Regex.IsMatch(password, @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,16}"))
            {
                return true;
            }
            return false;
        }
    }
}
