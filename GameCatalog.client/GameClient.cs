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

    public static Game[] GetGames()
    {
        return games.ToArray();
    }

    public static void AddGame(Game game)
    {
        game.Id = games.Max(game => game.Id) + 1;
        games.Add(game);
    }

    public static Game GetGameWithId(int gameId)
    {
        return games.Find(game => game.Id == gameId) ?? throw new Exception($"Couldn't find game with the supplied Id: {gameId}");
    }

    public static void UpdateGame(Game editedGame)
    {
        Game fetchedGame = GetGameWithId(editedGame.Id);

        fetchedGame.Name = editedGame.Name;
        fetchedGame.Genre = editedGame.Genre;
        fetchedGame.Price = editedGame.Price;
        fetchedGame.ReleaseDate = editedGame.ReleaseDate;
    }
}