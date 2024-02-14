using GameCatalog.client.Models;
namespace GameCatalog.client;

public static class GameClient // Static insures that when this is using in our components, only one instance is ever made.
{
    private static readonly List<Game> games = new()
    {
        new Game()
        {
            Id = 1,
            Name = "Minecraft",
            Genre = "Sandbox",
            Price = 29.99M,
            ReleaseDate = new DateTime(2009, 5, 17)
        },
        new Game()
        {
            Id = 2,
            Name = "Final Fantasy XVI",
            Genre = "Action-RPG",
            Price = 69.99M,
            ReleaseDate = new DateTime(2023, 6, 22)
        },
        new Game()
        {
            Id = 3,
            Name = "Spore",
            Genre = "Sandbox",
            Price = 59.99M,
            ReleaseDate = new DateTime(2008, 9, 04)
        },
    };
}