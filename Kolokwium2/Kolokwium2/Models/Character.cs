using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium2.Models;

[Table("charachters")]
public class Character
{

    [Key]
    public int Id { get; set; }
    
    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; } = string.Empty;
    
    [Required]
    [MaxLength(120)]
    public string LastName { get; set; } = string.Empty;
    public int CurrentWeight { get; set; }
    public int MaxWeight { get; set; }

    public ICollection<CharacterTitle> CharacterTitles { get; set; } = new List<CharacterTitle>();
    public ICollection<Backpack> Backpacks { get; set; } = new List<Backpack>();
}