using System.ComponentModel.DataAnnotations;

namespace Kolokwium2.Dtos; 

public class ItemDto
{
    [Required]
    public int ItemId { get; set; }
}