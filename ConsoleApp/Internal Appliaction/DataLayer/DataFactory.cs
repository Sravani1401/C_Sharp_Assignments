namespace DataLayer
{
    /// <summary>
    /// Create a Factory to generate an object using new keyword.
    /// </summary>
    public class DataFactory
    {
        //use  DataAuthenticationmethod()  method to get object of type Imethods
        public IInterfacemethods DataAuthenticationmethod()
        {
            return new DataAuthentication();
        }
    }
}
