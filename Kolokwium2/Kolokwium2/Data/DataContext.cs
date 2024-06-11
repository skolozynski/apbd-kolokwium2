using Kolokwium2.Models;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2.Data;

public class DataContext : DbContext
{
    protected DataContext()
    {
    }

    public DataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Item> Items { get; set; }
    public DbSet<Backpack> Backpacks { get; set; }
    public DbSet<Character> Characters { get; set; }
    public DbSet<CharacterTitle> CharacterTitles { get; set; }
    public DbSet<Title> Titles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Character>().HasData(new List<Character>
        {
            new Character() {Id = 1, FirstName = "John", LastName = "Yakuza", CurrentWeight = 43, MaxWeight = 200},
            new Character() {Id = 2, FirstName = "Ann", LastName = "Smith", CurrentWeight = 50, MaxWeight = 320},
            new Character() {Id = 3, FirstName = "Maks", LastName = "Nowak", CurrentWeight = 32, MaxWeight = 180}
        });

        modelBuilder.Entity<Item>().HasData(new List<Item>()
        {
            new Item() {Id = 1, Name = "Item1", Weight = 10},
            new Item() {Id = 2, Name = "Item2", Weight = 11},
            new Item() {Id = 3, Name = "Item3", Weight = 12}
        });

        modelBuilder.Entity<Title>().HasData(new List<Title>
        {
            new Title() {Id = 1, Name = "Title1"},
            new Title() { Id = 2, Name = "Title2"},
            new Title() { Id = 3, Name = "Title3"}
        });

        modelBuilder.Entity<Backpack>().HasData(new List<Backpack>
        {
            new Backpack() {CharacterId = 1, ItemId = 1, Amount = 2},
            new Backpack() {CharacterId = 1, ItemId = 2, Amount = 3},
            new Backpack() {CharacterId = 2, ItemId = 2, Amount = 2},
            new Backpack() {CharacterId = 3, ItemId = 3, Amount = 1}
        });

        modelBuilder.Entity<CharacterTitle>().HasData(new List<CharacterTitle>
        {
            new CharacterTitle() {CharacterId = 1, TitleId = 1, AcquiredAt = DateTime.Now},
            new CharacterTitle() {CharacterId = 1, TitleId = 2, AcquiredAt = DateTime.Now},
            new CharacterTitle() {CharacterId = 1, TitleId = 3, AcquiredAt = DateTime.Now},
            new CharacterTitle() {CharacterId = 2, TitleId = 1, AcquiredAt = DateTime.Now},
            new CharacterTitle() {CharacterId = 3, TitleId = 2, AcquiredAt = DateTime.Now}
        });
    }
}