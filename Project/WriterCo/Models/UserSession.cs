public class UserSession
{
    public User? CurrentUser { get; private set; }

    public void LogIn(User user)
    {
        CurrentUser = user;
    }

    public void LogOut()
    {
        CurrentUser = null;
    }
}