using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Domain.Models
{
    [Table("User")]
    public class User : BaseModel
    {
        [PrimaryKey("userid")]
        public int Id { get; set; }

        [Column("username")]
        public string ? Name { get; set; }

        [Column("email")]
        public string ? Email { get; set; }

        [Column("password")]
        public string? Password { get; set; }
    }
}
