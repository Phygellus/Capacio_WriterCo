public class Page
{
    private String body;
    private String heading;

    public Page(String body, String heading)
    {
        this.body=body;
        this.heading=heading;
    }
    public Page(String body)
    {
        this.body=body;
        this.heading="";
    }
    public String getBody()
    {
        return body;
    }
    public String getHeading()
    {
        return heading;
    }
    public void setBody(String body)
    {
        this.body=body;
    }
    public void setHeading(String heading)
    {
        this.heading=heading;
    }
}