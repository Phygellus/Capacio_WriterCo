using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

[Table("users")]
public class User : BaseModel
{
    [PrimaryKey("id", false)]
    public long Id { get; set; }

    [Column("username")]
    public string Username { get; set; } = string.Empty;

    [Column("email")]
    public string Email { get; set; } = string.Empty;

    // Note: Never store plain text passwords. Supabase Auth handles this securely in the background.
    // We keep this property here just so the model matches your original design.
    [Column("password_hash")] 
    public string PasswordHash { get; set; } = string.Empty;

    [Column("deleted_at")] 
    public DateTime? DeletedAt { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}