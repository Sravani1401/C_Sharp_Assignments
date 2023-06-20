using BusinessModel;
namespace BusinessLayer
{
    /// <summary>
    /// interface for BusinessAuthentication
    /// </summary>
    public interface IBAL
    {
        public bool login(Users user);
        public bool Register(Users user);
    }
}
