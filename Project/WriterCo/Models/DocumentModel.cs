using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System.Text.Json;

[Table("documents")]
public class DocumentModel : BaseModel
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

    [Column("content_json")]
    public string ContentJson { get; set; } = "{\"pages\":[], \"headings\":[]}";

    // --- These are now methods, so Supabase completely ignores them ---

    public List<string> GetHeadings()
    {
        var doc = JsonSerializer.Deserialize<DocumentContent>(ContentJson);
        return doc?.Headings ?? new List<string>();
    }

    public List<Page> GetPages()
    {
        var doc = JsonSerializer.Deserialize<DocumentContent>(ContentJson);
        return doc?.Pages ?? new List<Page>();
    }
    
    public void SetPages(List<Page> pages)
    {
        var doc = JsonSerializer.Deserialize<DocumentContent>(ContentJson) ?? new DocumentContent();
        doc.Pages = pages;
        ContentJson = JsonSerializer.Serialize(doc);
    }

    public void SetHeadings(List<string> headings)
    {
        var doc = JsonSerializer.Deserialize<DocumentContent>(ContentJson) ?? new DocumentContent();
        doc.Headings = headings;
        ContentJson = JsonSerializer.Serialize(doc);
    }
}

// Helper class for JSON
public class DocumentContent
{
    public List<Page> Pages { get; set; } = new();
    public List<string> Headings { get; set; } = new();
}