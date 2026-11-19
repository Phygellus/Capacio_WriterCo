public class Page
{
    public string Body { get; set; } = string.Empty;
    public string Heading { get; set; } = string.Empty;

    public Page() { } // Required for JSON deserialization

    public Page(string body, string heading)
    {
        Body = body;
        Heading = heading;
    }
    
    public Page(string body)
    {
        Body = body;
        Heading = "";
    }
}