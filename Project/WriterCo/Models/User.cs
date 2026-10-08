public class User
{
    private String username;
    private String email;
    private String password;

    public User(String username, String email, String password)
    {
        this.username=username;
        this.email=email;
        this.password=password;
    }

    public String getUsername()
    {
        return username;
    }
    public String getEmail()
    {
        return email;
    }
    public String getPassword()
    {
        return password;
    }
    protected void setUsername(String username)
    {
        this.username=username;
    }
    protected void setPassword(String password)
    {
        this.password=password;
    }
    protected void setEmail(String email)
    {
        this.email=email;
    }
}