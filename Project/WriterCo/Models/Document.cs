public class Document
{
    private String title;
    private String[] headings;
    private Page[] pages;
    private bool isPublished;

    public Document(string title)
    {
        this.title=title;
        this.headings = [];
        this.pages = [];
        this.isPublished = false;
    }

    public void addPages(Page page)
    {
        pages.Append(page);
    }

    public void addHeading(String heading)
    {
        headings.Append(heading);
    }

    public void Published()
    {
        this.isPublished = true;
    }
}