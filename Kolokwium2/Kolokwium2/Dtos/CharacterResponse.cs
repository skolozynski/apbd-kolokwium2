﻿namespace Kolokwium2.Dtos;

public class CharacterResponse
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int CurrentWeight { get; set; }
    public int MaxWeight { get; set; }
    public List<BackpackItemDto> BackpackItems { get; set; }
    public List<TitleDto> Titles { get; set; }
}