﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium2.Models;

[Table("titles")]
public class Title
{
    [Key]
    public int Id { get; set; }
    
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    public ICollection<CharacterTitle> CharacterTitles { get; set; } = new List<CharacterTitle>();
}