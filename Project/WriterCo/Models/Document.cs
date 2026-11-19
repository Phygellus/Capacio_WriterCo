using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System.Text.Json;

[Table("documents")]
public class Document : BaseModel
{
    [PrimaryKey("id", false)]
    public long Id { get; set; }

    [Column("title")]
    public string Title { get; set; } = "Untitled";

    [Column("owner_id")]
    public long OwnerId { get; set; }

    [Column("is_published")]
    public bool IsPublished { get; set; } = false;

    [Column("deleted_at")]
    public DateTime? DeletedAt { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // This IS a database column
    [Column("content_json")]
    public string ContentJson { get; set; } = "{\"pages\":[], \"headings\":[]}";

    // NOT a database column (no [Column] attribute, no [Ignore] attribute)
    public List<Page> Pages 
    {
        get 
        {
            var doc = JsonSerializer.Deserialize<DocumentContent>(ContentJson);
            return doc?.Pages ?? new List<Page>();
        }
        set 
        {
            var doc = JsonSerializer.Deserialize<DocumentContent>(ContentJson) ?? new DocumentContent();
            doc.Pages = value;
            ContentJson = JsonSerializer.Serialize(doc);
        }
    }

    // NOT a database column
    public List<string> Headings
    {
        get 
        {
            var doc = JsonSerializer.Deserialize<DocumentContent>(ContentJson);
            return doc?.Headings ?? new List<string>();
        }
        set 
        {
            var doc = JsonSerializer.Deserialize<DocumentContent>(ContentJson) ?? new DocumentContent();
            doc.Headings = value;
            ContentJson = JsonSerializer.Serialize(doc);
        }
    }

    public void Published()
    {
        IsPublished = true;
    }
}

public class DocumentContent
{
    public List<Page> Pages { get; set; } = new();
    public List<string> Headings { get; set; } = new();
}