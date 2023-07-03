namespace BusinessLayer
{
    /// <summary>
    /// create a class Balfactory to create instance for  BusinessAuthentication and BusinessValidations
    /// </summary>
    public class BALfactory
    {
        public IBAL BusinessAuthenticationMethod()
        {
            return new BusinessAuthentication();
        }
        public IBALValidations BusinessValidationsMethod()
        {
            return new BusinessValidations();
        }
    }
}
