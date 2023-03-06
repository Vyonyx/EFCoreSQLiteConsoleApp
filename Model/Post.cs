using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFGettingStartedConsole.Model;

public class Post
{
    [Key]
    public int PostId { get; set; }

    [Column("nvarchar(250)")]
    public string? Title { get; set; }

    [Column("nvarchar(250)")]
    public string? Content { get; set; }

    public int BlogId { get; set; }
    public Blog? Blog { get; set; }
}
