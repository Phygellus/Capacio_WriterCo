using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

[Table("users")]
public class User : BaseModel
{
    [PrimaryKey("id", false)] // false = database auto-generates this ID
    public long Id { get; set; }

    [Column("username")]
    public string Username { get; set; } = string.Empty;

    [Column("email")]
    public string Email { get; set; } = string.Empty;

    [Column("password")] // We are storing it plainly for the project
    public string Password { get; set; } = string.Empty;
}