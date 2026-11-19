using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

[Table("document_links")]
public class DocumentLink : BaseModel
{
    [PrimaryKey("id", false)]
    public long Id { get; set; }

    // The document the user is currently viewing
    [Column("source_document_id")]
    public long SourceDocumentId { get; set; }

    // The document being linked to
    [Column("target_document_id")]
    public long TargetDocumentId { get; set; }

    // Your requirement: "make private connections"
    [Column("is_private")]
    public bool IsPrivate { get; set; } = true;

    [Column("deleted_at")]
    public DateTime? DeletedAt { get; set; }
}