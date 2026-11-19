using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

[Table("reviews")]
public class Review : BaseModel
{
    [PrimaryKey("id", false)]
    public long Id { get; set; }

    [Column("user_id")]
    public long UserId { get; set; }

    [Column("rating")]
    public int Rating { get; set; }

    [Column("comment")]
    public string Comment { get; set; } = string.Empty;

    [Column("deleted_at")] 
    public DateTime? DeletedAt { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}