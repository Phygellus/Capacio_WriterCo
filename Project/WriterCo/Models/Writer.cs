using Supabase.Postgrest.Attributes;

[Table("users")] // Points to the same table
public class Writer : User
{
    [Column("is_writer")] // Add this column in your SQL schema
    public bool IsWriter { get; set; } = true;

    // Note: We do NOT store Document[] directly inside the User row.
    // Instead, we query the Documents table looking for OwnerId == this.Id.
}