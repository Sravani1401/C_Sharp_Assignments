using BusinessModel;
namespace DataTlayer;
/// <summary>
/// class of DataAuthentication
/// </summary>
public class DataAuthentication
{

    /// <summary>
    /// method for registration in DataAuthentication
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>

    internal DataAuthentication() { }
    public bool IsRegistred(User user)
    {
        DataSource dataObject = new DataSource();
        if (dataObject.Register(user) == true) { return true; }

        return false;

    }
    /// <summary>
    ///  method for login in DataAuthentication
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public bool IsLogIn(User user)
    {
        DataSource dataObject = new DataSource();
        if (dataObject.Login(user) == true)
        {
            return true;
        }
        return false;
    }
}
