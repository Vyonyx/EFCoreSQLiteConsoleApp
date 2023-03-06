using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFGettingStartedConsole.Model;

public class Blog
{
    [Key]
    public int BlogId { get; set; }

    [Column("nvarchar(250)")]
    public string? Url { get; set; }

    public List<Post> Posts { get; } = new();
}
