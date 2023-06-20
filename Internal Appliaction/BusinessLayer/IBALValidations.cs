namespace BusinessLayer
{
    /// <summary>
    /// interface for BusinessValidations
    /// </summary>
    public interface IBALValidations
    {
        public bool isValidName(string Input);
        public bool IsValidEmail(string email);
        public bool isValidMobile(string phonenumber);
        public bool isValidPassword(string password);
    }
}
