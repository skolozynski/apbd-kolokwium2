using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Kolokwium2.Models;

[Table("items")]
public class Item
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;
    
    [Required]
    public int Weight { get; set; }

    public ICollection<Backpack> Backpacks { get; set; } = new List<Backpack>();

}