using System.ComponentModel.DataAnnotations;

namespace GameCatalog.client.Models;

// With C#, validation to ensure against empty objects can be added right onto the class.
// While this is great and should always be used when dealing with user data, also add validation on the form as well.

public class Game
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public required string Name { get; set; }

    [Required]
    [StringLength(50)]
    public required string Genre { get; set; }

    [Range(0, 120)]
    public decimal Price { get; set; }

    public DateTime ReleaseDate { get; set; }
}