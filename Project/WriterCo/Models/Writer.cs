using System.ComponentModel.DataAnnotations;

public class Writer : User
{
    private Document[] documents;

    public Writer(String username, String email, String password) : base(username, email, password)
    {
        this.documents=[];
    }

    public Document[] Published()
    {
        Document[] published = [];
        foreach(Document doc in documents)
        {
            if (doc.getIsPublished())
            {
                published.Append(doc);
            }
        }
        return published;
    }

    public Document[] AllDocuments()
    {
        return documents;
    }
}