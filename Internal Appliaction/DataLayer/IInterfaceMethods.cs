using BusinessModel;
namespace DataLayer
{
    /// <summary>
    /// Create interface for DataAuthentication
    /// </summary>
    public interface IInterfacemethods
    {
        public bool IsRegistered(Users user);
        public bool IsLogin(Users user);
    }
}
